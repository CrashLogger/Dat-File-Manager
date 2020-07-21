using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Dat_File_Thing
{
    public partial class MainForm : Form
    {
        static string config_path;
        static string log_path;                     //ID LOG
        static string utd_path;
        static string masterBundle = "";
        static string pathToManifest = "";
        static string fullPathFromManifest = "";
        public static string editingPath = "";
        public static bool colorPrefix = false;
        public static bool colorSuffix = false;

        public static int minItemID, maxItemID, currentItemID, minVehicleID, maxVehicleID, currentVehicleID, minObjectID, maxObjectID, currentObjectID, minEffectID, maxEffectID, currentEffectID = 0;
        
        static string[] manifestLines;

        static bool parentDir = false;
        public static bool advancedMode = false;
        public static bool demoMode = false;

        static List<string> dirsOfInterest = new List<string>();
        static List<string> dirsUnchecked = new List<string>();
        static List<string> configSettings = new List<string>();
        static List<string> logLines = new List<string>();
        static List<string> logged_IDs = new List<string>();
        static List<string> already_checked = new List<string>();
        //These are full lines with their respective ID, Type, Names and so on
        static List<string> Item_Logged_IDs = new List<string>();
        static List<string> Vehicle_Logged_IDs = new List<string>();
        static List<string> Object_Logged_IDs = new List<string>();
        static List<string> Misc_Cosmetics_Logged_IDs = new List<string>();

        public static List<string> cleanManifestLines = new List<string>();
        public static List<string> debuggingLines = new List<string>();
        public static string debugLogPath;

        public static List<string> debugLog = new List<string>();
        static List<string> configChanges = new List<string>();

        //These are just IDs, to check which one is the latest one used
        public static int[] vehicleIDsLogged;
        public static int[] itemIDsLogged;
        public static int[] objectIDsLogged;
        public static int[] miscIDsLogged;

        //Types of items
        static string[] TypesItems = {"Arrest_End", "Arrest_Start", "Compass", "Detonator", "Filter", "Grower", "Food", "Water", "Medical", "Barricade", "Beacon", "Charge", "Farm", "Generator", "Gun", "Melee", "Backpack", "Glasses", "Shirt", "Pants", "Hat", "Mask", "Oil pump", "Optic", "Refill", "Resource", "Sentry", "Sight", "Storage", "Structure", "Library", "Supply", "Tank", "Tactical", "Throwable", "Tire", "Trap", "Vehicle_Repair_Tool", "Vest", "Fisher"};

        //Types of Objects
        static string[] TypesObjects = {"Large", "Medium", "Small", "Decal" };

        //Types of Vehicles (I know, it's useless but this method works and I can't be arsed to figure out why)
        static string[] TypesVehicles = { "Vehicle" };

        private void useIndividualBundles_Click(object sender, EventArgs e)
        {
            IDRanges idranges = new IDRanges();
            idranges.Show();
        }

        public MainForm()
        {

            logged_IDs.Add("ID,Bundle Name,Type,In-Game Name,Path,Cosmetic");
            Item_Logged_IDs.Add("ID, Bundle_Name, Type, Game_Name, Path, Cosmetic");
            Object_Logged_IDs.Add("ID, Bundle_Name, Type, Game_Name, Path, Cosmetic");
            Vehicle_Logged_IDs.Add("ID, Bundle_Name, Type, Game_Name, Path, Cosmetic");
            Misc_Cosmetics_Logged_IDs.Add("ID, Bundle_Name, Type, Game_Name, Path, Cosmetic");
            config_path = AppDomain.CurrentDomain.BaseDirectory;
            log_path = config_path + "IDLog.csv";
            debugLogPath = config_path + "Log.dat";

            //creates log files
            if (!File.Exists(log_path)) 
            {
                FileStream logStream = File.Create(log_path);
                logStream.Close();
                //Set-up for the logs to be exported onto spreadsheet programs
                File.WriteAllText(log_path, "ID, Type, Bundle_Name, Game_Name, Path, Cosmetic");
                logLines.Add("ID, Type, Bundle_Name, Game_Name, Path, Cosmetic");
                logLines.Add("-, -, -, -, -");
            }
            if (!File.Exists(debugLogPath))
            {
                FileStream debugLogStream = File.Create(debugLogPath);
                debugLogStream.Close();
            }
            //checks the config for paths and whatnot
            config_path = config_path + "Config.dat";

            configSettings = File.ReadAllLines(config_path).ToList();

            if(!configSettings.Contains("Basic") && !configSettings.Contains("Advanced"))
            {
                demoMode = true;
            }

            bool readingVID = false;
            bool readingIID = false;
            bool readingOID = false;

            foreach (string configLine in configSettings)
            {
                //MessageBox.Show(configLine);
                if (configLine.Contains("Utd"))
                {
                    utd_path = configLine.Remove(0, 16);
                }

                if (!configLine.Contains($@"//"))
                {
                    if (!readingOID && !readingIID && !readingVID)
                    {
                        if (configLine.Equals("Advanced"))
                        {
                            advancedMode = true;
                            demoMode = false;
                        }
                        else if (configLine.Equals("Basic"))
                        {
                            advancedMode = false;
                            demoMode = false;
                        }

                        if (configLine.Contains("Object"))
                        {
                            readingOID = true;
                        }
                        if (configLine.Contains("Vehicle"))
                        {
                            readingVID = true;
                        }
                    }

                    else if (readingOID)
                    {
                        minObjectID = Convert.ToInt32(configLine.Split(',').First());
                        maxObjectID = Convert.ToInt32(configLine.Split(',').Last());

                        if (minObjectID == maxObjectID)
                        {
                            maxObjectID = 65535;
                        }

                        readingIID = false;
                    }
                    else if (readingVID)
                    {
                        minVehicleID = Convert.ToInt32(configLine.Split(',').First());
                        maxVehicleID = Convert.ToInt32(configLine.Split(',').Last());

                        if (minVehicleID == maxVehicleID)
                        {
                            maxVehicleID = 65535;
                        }

                        readingVID = false;
                    }
                }
                else
                {
                    //MessageBox.Show("Comment:" + configLine);
                }
            }
            //Loads the form once all the settings and stuff are ready
            InitializeComponent();
            if (advancedMode)
            {
                AdvancedPanel.BackgroundImage = Properties.Resources.AdvancedMode64;
                KnownBugsButton.Enabled = true;
            }
            else if (demoMode)
            {
                AdvancedPanel.BackgroundImage = Properties.Resources.DemoMode64;

            }
            else if (!advancedMode && !demoMode)
            {
                AdvancedPanel.BackgroundImage = Properties.Resources.BasicMode64;
            }
            ChooseBundleType.SelectedItem = "All";
            if (!advancedMode)
            {
                ChooseBundleType.Enabled = false;
                FilePerTypeBox.Enabled = false;
                setIDRanges.Enabled = false;
            }
            Utd_Path_Box.Text = $@"{utd_path}";

            //TEMPORARY DEBUG MEASURE
            currentVehicleID = minVehicleID;
            currentItemID = minItemID;
            currentObjectID = minObjectID;
            currentEffectID = minEffectID;
        }

        private void ID_Find_Button_Click(object sender, EventArgs e)
        {
            logged_IDs.Clear();
            logged_IDs.Add($@"ID,Bundle Name,Type,In-Game Name,Path,Cosmetic");
            logLines.Clear();

            //Looks in the pre-established interesting directories, where it should expect bundles to be

            if (LookForVanilla.Checked)
            {
                dirsOfInterest.Clear();
                dirsOfInterest.Add("Bundles");
                dirsOfInterest.Add("Maps");
            }
            else
            {
                dirsOfInterest.Clear();
                dirsOfInterest.Add("Maps");
            }
            foreach (string directoryOfInterest in dirsOfInterest)
            {
                try
                {
                    //Looks for all directories within those directories of interest, then in those (recursive). Only if the word "Bundles" is included in the path
                    string[] dirsInUnturned = Directory.GetDirectories($@"{utd_path}\{directoryOfInterest}");
                    foreach (string dir in dirsInUnturned)
                    {
                        LoadSubDirs(dir);
                        File.WriteAllLines(debugLogPath, debugLog);
                    }
                }
                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show($"The {directoryOfInterest} folder is missing from your Unturned folder! (Pretty important!) Check the path to your unturned folder is correct, or the integrity of your Unturned files on Steam", $@"{directoryOfInterest} folder missing!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }

            }

            bool isACosmetic = false;
            bool hasNotBeenUsed = false;
            string ID = "";
            string bundleName = "";
            string bundleType = "";
            string EnglishDatFile = "";
            string Game_Name = "";

            List<String> CheckedBundles = new List<string>();
            List<String> CheckedPaths = new List<string>();

            foreach (string checkable_filePath in logLines)
            {
                isACosmetic = false;
                hasNotBeenUsed = false;
                Game_Name = "#NAME";
                parentDir = false;

                if (!checkable_filePath.Contains(",") && !checkable_filePath.Contains("Skin") && !checkable_filePath.Contains("Mythic") && !already_checked.Contains(checkable_filePath))
                {
                    EnglishDatFile = ($@"{checkable_filePath}\English.dat");
                    bundleName = ($@"{checkable_filePath.Split(Path.DirectorySeparatorChar).Last()}");

                    if (CheckedBundles.Contains(bundleName) && (CheckedPaths.Contains(checkable_filePath)))
                    {
                        continue;
                    }
                    else
                    {
                        CheckedBundles.Add(bundleName); CheckedPaths.Add(checkable_filePath);
                        hasNotBeenUsed = true;
                    }
                    try
                    {
                        var fileChecking = File.ReadAllLines($@"{checkable_filePath}\{bundleName}.dat");
                        foreach (string line in fileChecking)
                        {
                            if (line.Contains("ID") && !line.Contains("GUID") && !line.Contains("print") && !line.Contains("table") && !line.Contains("Asset") && !line.Contains("Reward") && !line.Contains("Spawn") && !line.Contains("Skin") && !line.Contains("Replacement") && !line.Contains("Item") && !line.Contains("Limit") && !line.Contains("Blade") && !line.Contains("Condition"))
                            {
                                ID = line.Substring(3, line.Length - 3);
                            }
                            else if (line.Contains("Type") && !line.Contains("Blueprint") && !line.Contains("Kills") && !line.Contains("Reward") && !line.Contains("Condition") && !line.Contains("Flag"))
                            {
                                bundleType = line.Substring(5, line.Length - 5);
                            }
                            else if (line.Equals("Pro"))
                            {
                                isACosmetic = true;
                            }
                        }
                    }
                    catch (System.UnauthorizedAccessException)
                    {
                        debugLog.Add($@"Unauthorized Access to: {checkable_filePath}");
                        File.WriteAllLines(debugLogPath, debugLog);

                        MessageBox.Show($"There was an error accessing {checkable_filePath}: Unauthorized Access \n Close any program that might be using it and try again.", "Unauthorized Access", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (FileNotFoundException)
                    {
                        debugLog.Add($@"Failed to find a {bundleName}.dat file in {checkable_filePath}. Ignore if this is a parent directory.");
                        File.WriteAllLines(debugLogPath, debugLog);
                        parentDir = true;
                    }
                    try
                    {
                        var gameNameChecking = File.ReadAllLines(EnglishDatFile);
                        foreach (string line in gameNameChecking)
                        {
                            if (line.Contains("Name"))
                            {
                                Game_Name = line.Substring(5, line.Length - 5);
                            }
                        }
                    }
                    catch (System.IO.FileNotFoundException)
                    {
                        Game_Name = "#NAME";
                    }
                }
                if (hasNotBeenUsed && !checkable_filePath.Contains("Asset") && !FilePerTypeBox.Checked)
                {
                    if (!SkipCosmetics.Checked && !parentDir)
                    {
                        logged_IDs.Add($@"{ID},{bundleName},{bundleType},{Game_Name},{checkable_filePath},{isACosmetic}");
                    }
                    else
                    {
                        if (!isACosmetic && !parentDir)
                        {
                            logged_IDs.Add($@"{ID},{bundleName},{bundleType},{Game_Name},{checkable_filePath},{isACosmetic}");
                        }
                    }
                }

                //God this is such a fucking pain in the ass
                //It has yet to be dealt with, it barely works now and to be honest, even when it does work it skips/doubles some things
                //VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV

                else if (hasNotBeenUsed && !checkable_filePath.Contains("Asset") && FilePerTypeBox.Checked)
                {
                    foreach (string subType in TypesItems)
                    {
                        if (subType.Equals(bundleType) && !isACosmetic && hasNotBeenUsed && $@"{checkable_filePath}\{bundleName}".Contains($@"{bundleName}\{bundleName}"))
                        {
                            Item_Logged_IDs.Add($@"{ID},{bundleName},{bundleType},{Game_Name},{checkable_filePath},{isACosmetic}");
                            continue;
                        }
                    }
                    foreach (string subType in TypesObjects)
                    {
                        if (subType.Equals(bundleType) && !isACosmetic && hasNotBeenUsed && $@"{checkable_filePath}\{bundleName}".Contains($@"{bundleName}\{bundleName}"))
                        {
                            Object_Logged_IDs.Add($@"{ID},{bundleName},{bundleType},{Game_Name},{checkable_filePath},{isACosmetic}");
                            continue;
                        }
                    }
                    foreach (string subType in TypesObjects)
                    {
                        if (subType.Equals(bundleType) && !isACosmetic && hasNotBeenUsed && $@"{checkable_filePath}\{bundleName}".Contains($@"{bundleName}\{bundleName}"))
                        {
                            Object_Logged_IDs.Add($@"{ID},{bundleName},{bundleType},{Game_Name},{checkable_filePath},{isACosmetic}");
                            continue;
                        }
                    }
                    Misc_Cosmetics_Logged_IDs.Add($@"{ID},{bundleName},{bundleType},{Game_Name},{checkable_filePath},{isACosmetic}");
                }

                //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
                //God this is such a fucking pain in the ass
                //It has yet to be dealt with, it barely works now and to be honest, even when it does work it skips/doubles some things

            }
            try
            {
                if (FilePerTypeBox.Checked)
                {
                    string separateIDFolder = $@"{Directory.GetParent(log_path)}\IDs_Separate_Types";
                    //MessageBox.Show($@"{Directory.GetParent(log_path)}");
                    if (!Directory.Exists($@"{Directory.GetParent(log_path)}\IDs_Separate_Types"))
                    {
                        Directory.CreateDirectory($@"{Directory.GetParent(log_path)}\IDs_Separate_Types");
                    }
                    FileStream VehicleIDs = File.Create($@"{separateIDFolder}\Vehicle_IDs.csv");
                    VehicleIDs.Close();
                    FileStream ItemIDs = File.Create($@"{separateIDFolder}\Item_IDs.csv");
                    ItemIDs.Close();
                    FileStream ObjectIDs = File.Create($@"{separateIDFolder}\Object_IDs.csv");
                    ObjectIDs.Close();
                    FileStream MiscIDs = File.Create($@"{separateIDFolder}\Misc_and_Cosmetics_IDs.csv");
                    MiscIDs.Close();
                    File.WriteAllLines($@"{separateIDFolder}\Vehicle_IDs.csv", Vehicle_Logged_IDs);
                    File.WriteAllLines($@"{separateIDFolder}\Item_IDs.csv", Item_Logged_IDs);
                    File.WriteAllLines($@"{separateIDFolder}\Object_IDs.csv", Object_Logged_IDs);
                    File.WriteAllLines($@"{separateIDFolder}\Misc_and_Cosmetics_IDs.csv", Misc_Cosmetics_Logged_IDs);

                    int totalLINES = Vehicle_Logged_IDs.Count + Item_Logged_IDs.Count + Object_Logged_IDs.Count + Misc_Cosmetics_Logged_IDs.Count - 4;
                    if (totalLINES > 0)
                    {
                        MessageBox.Show($@"Done grabbing .dat information! {totalLINES} .dat files found!", "Grabbed .dat information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Vehicle_Logged_IDs.Clear(); Item_Logged_IDs.Clear(); Object_Logged_IDs.Clear(); Misc_Cosmetics_Logged_IDs.Clear();
                }
                File.WriteAllLines(log_path, logged_IDs);
                logged_IDs.Clear();
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("The log file could not be edited because a different process is using it", "Log file busy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int totalLines = File.ReadLines(log_path).Count();
            if (totalLines > 1)
            {
                MessageBox.Show($@"Done grabbing .dat information! {totalLines - 1} .dat files found!", "Grabbed .dat information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void setIDRanges_Click(object sender, EventArgs e)
        {
            foreach (string line in logged_IDs)
            {
                if (line.Contains("Vehicle"))
                {
                    vehicleIDsLogged.Append(Convert.ToInt32(line.Split(',').First()));
                }
                else if (line.Contains("Item"))
                {
                    itemIDsLogged.Append(Convert.ToInt32(line.Split(',').First()));
                }
                else if (line.Contains("Object"))
                {
                    objectIDsLogged.Append(Convert.ToInt32(line.Split(',').First()));
                }
                else if (!line.Contains("Object") && !line.Contains("Item") && !line.Contains("Vehicle"))
                {

                }
            }
            IDRanges idranges = new IDRanges();
            idranges.Show();
        }

        private void InstallationPathLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(AppDomain.CurrentDomain.BaseDirectory);
        }

        private void LoadSubDirs(string dir)
        {
            string[] subdirectoryEntries = Directory.GetDirectories(dir);
            foreach (string subdirectory in subdirectoryEntries)
            {
                dirsUnchecked.Add(subdirectory);
                logLines.Add(subdirectory);
                debugLog.Add(subdirectory);
                LoadSubDirs(subdirectory);
            }
        }

        private void Change_Utd_Install_Path_Click(object sender, EventArgs e)
        {
            using(var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var path = dialog.SelectedPath;
                    MessageBox.Show($@"Changing the Unturned install directory to {path}", "Changing install path", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Utd_Path_Box.Text = path;
                    foreach (string configLine in configSettings)
                    {
                        if (configLine.Contains("Utd"))
                        {
                            configChanges.Add($@"Utd_install_path {path}");
                            utd_path = path;
                        }
                        else
                        {
                            configChanges.Add(configLine);
                        }
                    }
                    try
                    {
                        File.WriteAllLines(config_path, configChanges);
                    }
                    catch (System.InvalidOperationException)
                    {
                        //Usually shows up, skipping it seems to work just fine
                    }                    
                }
            }
        }

        private void OpenCredits_Click(object sender, EventArgs e)
        {
            CreditsForm creditsForm = new CreditsForm();
            creditsForm.Show();
        }
        
        private void findMasterBundle_Click(object sender, EventArgs e)
        {
            cleanManifestLines.Clear();
            ListOfBundles.BeginUpdate();
            ListOfBundles.Items.Clear();
            ListOfBundles.EndUpdate();
            EditBundle.Enabled = true;
            try
            {
                if (!String.IsNullOrEmpty(masterBundleFilterFolder.Text))
                {
                    bool masterBundleDat = false;
                    var PossibleMasterBundles = Directory.GetFiles($@"{utd_path}\Maps\{masterBundleFilterFolder.Text}\Bundles\");
                    foreach (string possibleMasterBundle in PossibleMasterBundles)
                    {
                        if (possibleMasterBundle.Contains(".masterbundle") && !possibleMasterBundle.Contains(".manifest"))
                        {
                            masterBundle = ($@"{possibleMasterBundle.Split('.').First()}");
                            masterBundle = ($@"{masterBundle.Split(Path.DirectorySeparatorChar).Last()}");
                            //MessageBox.Show($@"Found MasterBundle {masterBundle}!", "Found MasterBundle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            debugLog.Add($@"MASTERBUNDLE: {masterBundle} in {possibleMasterBundle}");
                            File.WriteAllLines(debugLogPath, debugLog);
                        }
                        else if (possibleMasterBundle.Contains(".manifest"))
                        {
                            pathToManifest = possibleMasterBundle;
                            debugLog.Add($@"MASTERBUNDLE MANIFEST: {pathToManifest} in {possibleMasterBundle}");
                            File.WriteAllLines(debugLogPath, debugLog);
                        }
                        else if (possibleMasterBundle.Contains("MasterBundle.dat"))
                        {
                            masterBundleDat = true;
                        }
                    }
                    if (!masterBundleDat)
                    {
                        FileStream masterBundleDatMaker = File.Create($@"{utd_path}\Maps\{masterBundleFilterFolder.Text}\Bundles\MasterBundle.dat");
                        masterBundleDatMaker.Close();
                        File.WriteAllText($@"{utd_path}\Maps\{masterBundleFilterFolder.Text}\Bundles\MasterBundle.dat", $@"Asset_Bundle_Name {masterBundle}.masterbundle" + "\n" + $@"Asset_Prefix Assets/{masterBundle}_masterbundle" + "\n" + $@"// Path to the asset bundle within Unity." + "\n" + $@"// Unity subfolders should match 1:1 with dat subfolders." + "\n" + "Master_Bundle_Version 3" + "\n\n" + $@"//File created automatically with a development version of Dat manager. If this is broken I 100% blame the end user.");
                    }
                }
                else
                {
                    MessageBox.Show($@"'{masterBundleFilterFolder.Text}' is not a Map folder in {utd_path}\Maps!", "Map folder missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch(System.IO.DirectoryNotFoundException)
            {
                MessageBox.Show($@"'{masterBundleFilterFolder.Text}' is not a Map folder in {utd_path}\Maps!", "Map folder missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                List<string> cleanLinesFinal = new List<string>();
                manifestLines = File.ReadAllLines(pathToManifest);
                foreach (string line in manifestLines)
                {
                    if (line.Contains("Asset"))
                    {
                        int indexOfBundles = line.IndexOf($@"Bundles");
                        if (indexOfBundles > 1)
                        {
                            //string cleanLine = line.Remove(0, indexOfBundles);
                            string cleanLine = line.Remove(0, indexOfBundles);
                            string secondCleanline = cleanLine;
                            int indexOfDirSeparation = line.IndexOf('/');
                            if(indexOfDirSeparation > 0)
                            {
                                cleanLine = cleanLine.Remove(indexOfDirSeparation, cleanLine.Length - indexOfDirSeparation);
                                string secondLineCleaner = $@"{secondCleanline.Split('/').Last()}";
                                secondCleanline = secondCleanline.Replace(secondLineCleaner, "");
                                secondCleanline = secondCleanline.Replace('/', Path.DirectorySeparatorChar);
                                if (!cleanManifestLines.Contains($@"{utd_path}\Maps\{masterBundleFilterFolder.Text}\{secondCleanline}"))
                                {
                                    fullPathFromManifest = $@"{utd_path}\Maps\{masterBundleFilterFolder.Text}\{secondCleanline}";
                                    debugLog.Add($@"Path found in manifest: {secondCleanline} converted to {fullPathFromManifest}");
                                    File.WriteAllLines(debugLogPath, debugLog);
                                    cleanLinesFinal.Add(secondCleanline);
                                    cleanManifestLines.Add(fullPathFromManifest);
                                }
                            }
                        }
                    }
                }

                ListOfBundles.BeginUpdate();
                cleanManifestLines.Sort();
                foreach (string manifestLine in cleanManifestLines)
                {
                    string manifestBundleName = manifestLine.Split(Path.DirectorySeparatorChar).Last();

                    if (ChooseBundleType.GetItemText(ChooseBundleType.SelectedItem).Equals("All"))
                    {
                        ListOfBundles.Items.Add(manifestLine);
                    }
                    else if (ChooseBundleType.GetItemText(ChooseBundleType.SelectedItem).Equals("Vehicles"))
                    {
                        if (manifestLine.Contains("Vehicle"))
                        {
                            ListOfBundles.Items.Add(manifestLine);
                        }
                    }
                    else if (ChooseBundleType.GetItemText(ChooseBundleType.SelectedItem).Equals("Objects"))
                    {
                        if (manifestLine.Contains("Object"))
                        {
                            ListOfBundles.Items.Add(manifestLine);
                        }
                    }
                    else if (ChooseBundleType.GetItemText(ChooseBundleType.SelectedItem).Equals("Items"))
                    {
                        if (manifestLine.Contains("Item"))
                        {
                            ListOfBundles.Items.Add(manifestLine);
                        }
                    }
                    else if (ChooseBundleType.GetItemText(ChooseBundleType.SelectedItem).Equals("Misc"))
                    {
                        if (!manifestLine.Contains("Vehicle") && !manifestLine.Contains("Object") && !manifestLine.Contains("Item"))
                        {
                            ListOfBundles.Items.Add(manifestLine);
                        }
                    }
                }
                ListOfBundles.EndUpdate();

                //DebugForm debugForm = new DebugForm();
                //debugForm.Show();
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show($"Manifest unaccesible, is another program using it? \n Manifest in: {pathToManifest}", $@"Unauthorized access to Manifest", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show($"Manifest missing (it was there not half a second ago, what the fuck. I seriously doubt anyone will ever get this messagebox, but if you do, make sure to show it to me on twitter or something idk. Oh the log, send me the log too. It probably fucked up some path somewhere if this shows up. Either that or you purposefully deleted the file in a split second. If you did, GG mate)", $@"Masterbundle manifest missing!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show($"An important masterbundle file does not exist in chosen map folder! Is the path correct?", $@"Masterbundle files missing!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void KnownBugsButton_Click(object sender, EventArgs e)
        {
            KnownBugsForm bugsForm = new KnownBugsForm();
            bugsForm.Show();
        }

        private void ReadmeButton_Click(object sender, EventArgs e)
        {
            Readme_Form readmeform = new Readme_Form();
            readmeform.Show();
        }

        private void EditBundle_Click(object sender, EventArgs e)
        {
            try
            {
                editingPath = ListOfBundles.SelectedItem.ToString();
                if (ListOfBundles.SelectedItem.ToString().Contains("Vehicle"))
                {
                    VehicleDatForm vehicleForm = new VehicleDatForm();
                    vehicleForm.Show();
                }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Empty/null file chosen, pick a line from the list above and try again", "Null reference exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}