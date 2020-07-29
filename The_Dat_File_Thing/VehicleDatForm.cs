using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Dat_File_Thing
{
    public partial class VehicleDatForm : Form
    {
        public static List<string> linesToWrite = new List<string>();
        static string colorVariantsPath = "";
        static string vehicleTypeDir;

        public VehicleDatForm()
        {
            InitializeComponent();
            vehicleTypeDir = MainForm.editingPath.Remove(MainForm.editingPath.Length - 1, 1);
            vehicleTypeDir = vehicleTypeDir.Remove(vehicleTypeDir.Length - vehicleTypeDir.Split(Path.DirectorySeparatorChar).Last().Length, vehicleTypeDir.Split(Path.DirectorySeparatorChar).Last().Length);
            //MessageBox.Show(vehicleTypeDir);
            FileNameLabel.Text = MainForm.editingPath.Remove(MainForm.editingPath.Length - 1, 1).Split(Path.DirectorySeparatorChar).Last();
            if (MainForm.advancedMode)
            {
                manualAdvancedCheckBox.Checked = true;
                advancedGroup.Enabled = true;
            }
            else
            {
                if (MainForm.demoMode)
                {
                    manualAdvancedCheckBox.Checked = false;
                    manualAdvancedCheckBox.Enabled = false;
                    advancedGroup.Enabled = false;
                }
                else
                {
                    manualAdvancedCheckBox.Checked = false;
                    advancedGroup.Enabled = false;
                }
            }
        }

        private void VehicleDatForm_Load(object sender, EventArgs e)
        {

        }

        private void writeDatFile_Click(object sender, EventArgs e)
        {
            Subtype(carRadioButton);Subtype(PlaneRadioButton);Subtype(heliRadioButton);Subtype(boatRadioButton);
        }

        private void Subtype(RadioButton typeRadioButton)
        {
            if (typeRadioButton.Checked)
            {
                generateFile(typeRadioButton.Text);
            }
        }

        private void generateFile(string vehicleSubtype)
        {

            double maxSpeedMPS = (double)maxSpeed.Value / 3.6;
            double minSpeedMPS = (double)reverseSpeed.Value / 3.6;

            linesToWrite.Clear();
            linesToWrite.Add($@"//Vehicle ID range {MainForm.minVehicleID} {MainForm.maxVehicleID}");

            linesToWrite.Add($@"Type Vehicle" + "\n");
            MainForm.debugLog.Add("Writing a vehicle's dat file");
            File.WriteAllLines(MainForm.debugLogPath, MainForm.debugLog);

            linesToWrite.Add($@"Rarity {rarityOptions.Text}" + "\n");

            if (vehicleSubtype.Equals("Car"))
            {
                if (isCrawler.Checked)
                {
                    linesToWrite.Add("Crawler" + "\n");
                }
                if (hasTraction.Checked)
                {
                    linesToWrite.Add("Traction" + "\n");
                }
            }
            if (vehicleSubtype.Equals("Plane"))
            {
                linesToWrite.Add("Engine Plane");
                linesToWrite.Add("LockMouse");
                linesToWrite.Add("Sleds" + "\n");
                linesToWrite.Add($@"Lift {Lift.Value}" + "\n");
            }
            if (vehicleSubtype.Equals("Helicopter"))
            {
                linesToWrite.Add("Engine Helicopter");
                linesToWrite.Add("LockMouse" + "\n");
            }
            if (vehicleSubtype.Equals("Boat"))
            {
                linesToWrite.Add("Engine Boat" + "\n");
            }
            linesToWrite.Add($@"Speed_Max {maxSpeedMPS}");
            linesToWrite.Add($@"Speed_Min -{minSpeedMPS}" + "\n");
            linesToWrite.Add($@"Steer_Max {steerAngle.Value}");
            linesToWrite.Add($@"Steer_Min {steerAngle.Value / 2}" + "\n");
            linesToWrite.Add($@"Trunk_Storage_X {TrunkHorizontal.Value}");
            linesToWrite.Add($@"Trunk_Storage_Y {TrunkVertical.Value}" + "\n");

            if (advancedGroup.Enabled)
            {
                MainForm.debugLog.Add("Advanced settings active - vehicles");
                File.WriteAllLines(MainForm.debugLogPath, MainForm.debugLog);

                linesToWrite.Add($@"Fuel {FuelAmount.Value}");
                linesToWrite.Add($@"Fuel_Min {spawnFuelMin.Value}");
                linesToWrite.Add($@"Fuel_Max {spawnFuelMax.Value}" + "\n");
                linesToWrite.Add($@"Health {HealthAmount.Value}");
                linesToWrite.Add($@"HealtH_Min {spawnerHealthMin.Value}");
                linesToWrite.Add($@"Health_Max {spawnerHealthMax.Value}" + "\n");
                float passengerArmor = (float)PassengerArmor.Value;
                if (passengerArmor > 0.0)
                {
                    linesToWrite.Add($@"Passenger_Explosion_armor {passengerArmor}");
                }
            }
            else
            {
                linesToWrite.Add($@"Fuel {FuelAmount.Value}");
                linesToWrite.Add($@"Fuel_Min {FuelAmount.Value/4}");
                linesToWrite.Add($@"Fuel_Max {FuelAmount.Value/2}" + "\n");
                linesToWrite.Add($@"Health {HealthAmount.Value}");
                linesToWrite.Add($@"Health_Min {HealthAmount.Value/4}");
                linesToWrite.Add($@"Health_Max {HealthAmount.Value/2}" + "\n");
            }
            if (hasInvulnerableTires.Checked && !vehicleSubtype.Equals("Boat"))
            {
                linesToWrite.Add("Tires_Invulnerable" + "\n");
            }
            if (isInvulnerable.Checked)
            {
                linesToWrite.Add("Invulnerable" + "\n");
            }
            float exitdistance = (float)ExitDistance.Value;
            if (exitdistance > 0.0)
            {
                linesToWrite.Add($@"Exit {exitdistance}" + "\n");
            }

            float cameradistance = (float)CameraDistance.Value;
            if (cameradistance > 0.0)
            {
                linesToWrite.Add($@"Cam_Follow_Distance {cameradistance}" + "\n");
            }

            if (!String.IsNullOrEmpty(PhysicsProfileBox.Text))
            {
                linesToWrite.Add($@"Physics_Profile {PhysicsProfileBox.Text}" + "\n");
            }

            float wheelMassOverride = (float)WheelColliderMassOverride.Value;
            if(wheelMassOverride > 0.0)
            {
                linesToWrite.Add($@"Wheel_Collider_Mass_Override {wheelMassOverride}");
            }
            linesToWrite.Add($@"Asset_Bundle_Version 2" + "\n");

            if (colorVariants.Checked)
            {
                try
                {
                    var colorVariantLines = File.ReadAllLines(colorVariantsPath);
                    foreach (string line in colorVariantLines)
                    {
                        if (colorIsPrefix.Checked)
                        {
                            //KEEP THESE TWO PLS THX
                            linesToWrite.Add($@"//Bundle: {line.Split('_').First()}_{FileNameLabel.Text.Split('_').Last()}" + "\n" + $@"//English.dat: Name {line.Split('_').Last()} {FileNameLabel.Text.Split('_').Last()}");
                            
                            //MessageBox.Show($@"Bundle: {line.Split('_').First()}_{FileNameLabel.Text.Split('_').Last()}" + "\n" + $@"English.dat: Name {FileNameLabel.Text.Split('_').Last()}_{line.Split('_').Last()}");

                            linesToWrite.Add($@"ID: {MainForm.currentVehicleID}");
                            MainForm.currentVehicleID++;

                            try
                            {
                                if (!File.Exists($@"{vehicleTypeDir}\{line.Split('_').First()}_{FileNameLabel.Text.Split('_').Last()}\{line.Split('_').First()}_{FileNameLabel.Text.Split('_').Last()}.dat"))
                                {
                                    FileStream fs = File.Create(($@"{vehicleTypeDir}\{line.Split('_').First()}_{FileNameLabel.Text.Split('_').Last()}\{line.Split('_').First()}_{FileNameLabel.Text.Split('_').Last()}.dat"));
                                    fs.Close();
                                    File.WriteAllLines($@"{vehicleTypeDir}\{line.Split('_').First()}_{FileNameLabel.Text.Split('_').Last()}\{line.Split('_').First()}_{FileNameLabel.Text.Split('_').Last()}.dat", linesToWrite);
                                    MainForm.debugLog.Add($@"Created Vehicle with ID: {MainForm.currentVehicleID}");
                                    File.WriteAllLines(MainForm.debugLogPath, MainForm.debugLog);
                                }
                                else
                                {
                                    var currentDatFile = File.ReadAllLines($@"{vehicleTypeDir}\{line.Split('_').First()}_{FileNameLabel.Text.Split('_').Last()}\{line.Split('_').First()}_{FileNameLabel.Text.Split('_').Last()}.dat");
                                }

                                if (!File.Exists($@"{vehicleTypeDir}\{line.Split('_').First()}_{FileNameLabel.Text.Split('_').Last()}\English.dat"))
                                {
                                    FileStream fs = File.Create($@"{vehicleTypeDir}\{line.Split('_').First()}_{FileNameLabel.Text.Split('_').Last()}\English.dat");
                                    fs.Close();
                                    File.WriteAllText($@"{vehicleTypeDir}\{line.Split('_').First()}_{FileNameLabel.Text.Split('_').Last()}\English.dat", $@"{line.Split('_').Last()} {FileNameLabel.Text.Split('_').Last()}");
                                }

                                MainForm.debugLog.Add($@"ID {MainForm.currentVehicleID}. Writing to { vehicleTypeDir}\{ line.Split('_').First()}_{ FileNameLabel.Text.Split('_').Last()}\{ line.Split('_').First()}_{ FileNameLabel.Text.Split('_').Last()}.dat");
                                File.WriteAllLines(MainForm.debugLogPath, MainForm.debugLog);

                            }
                            catch (DirectoryNotFoundException)
                            {
                                MessageBox.Show($"There was an error with the color variant prefix: A file with such a prefix does not exist, check for typos. \n \n Prefix and color with issues: \n {line}", "File with prefix not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                MainForm.debugLog.Add($@"File prefix does not exist: {line.Split('_').First()}");
                                File.WriteAllLines(MainForm.debugLogPath, MainForm.debugLog);
                                break;
                            }

                            linesToWrite.RemoveAt(linesToWrite.Count - 1); linesToWrite.RemoveAt(linesToWrite.Count - 1);

                        }
                        else if (colorIsSuffix.Checked)
                        {
                            MainForm.debugLog.Add("Color variants active - Suffix");
                            File.WriteAllLines(MainForm.debugLogPath, MainForm.debugLog);
                            MessageBox.Show("Use the prefix for now, this isn't ready yet because I got distracted by chess and smash.");
                        }
                        DebugForm debugForm = new DebugForm();
                        debugForm.Show();
                        MainForm.minVehicleID = MainForm.currentVehicleID;
                    }

                }
                catch (ArgumentException)
                {
                    MessageBox.Show("The color variant filepath is empty or it doesn't lead to a plaintext file, and the checkbox to use one is checked", "Color variants file error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MainForm.debugLog.Add("Color variants file path is empty or an illegal format");
                    File.WriteAllLines(MainForm.debugLogPath, MainForm.debugLog);
                }
            }
            else
            {
                MessageBox.Show("Someone remind me to code this part again, it was fucking shit when I checked", "fuckfuckfuckfuck", MessageBoxButtons.OK);
            }
        }

        private void manualAdvancedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            advancedGroup.Enabled = !advancedGroup.Enabled;
        }

        private void PlaneRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Lift.Enabled = !Lift.Enabled;
            hasTraction.Enabled = !hasTraction.Enabled;
        }

        private void carRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            isCrawler.Enabled = !isCrawler.Enabled;
            hasTraction.Enabled = !hasTraction.Enabled;
        }

        private void boatRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            hasInvulnerableTires.Enabled = !hasInvulnerableTires.Enabled;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = $@"c:\";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    colorVariantsPath = openFileDialog.FileName;
                    colorVariantsPathBox.Text = colorVariantsPath;
                }
            }
        }

        private void colorVariants_CheckedChanged(object sender, EventArgs e)
        {
            ColorVariantsBox.Enabled = !ColorVariantsBox.Enabled;
            if (!ColorVariantsBox.Enabled)
            {
                FileNameLabel.Text = MainForm.editingPath.Remove(MainForm.editingPath.Length - 1, 1).Split(Path.DirectorySeparatorChar).Last();
            }
            else if (colorIsSuffix.Checked && colorVariants.Checked)
            {
                FileNameLabel.Text = MainForm.editingPath.Remove(MainForm.editingPath.Length - 1, 1).Split(Path.DirectorySeparatorChar).Last().Split('_').First();
            }
            else if (colorIsPrefix.Checked && colorVariants.Checked)
            {
                FileNameLabel.Text = MainForm.editingPath.Remove(MainForm.editingPath.Length - 1, 1).Split(Path.DirectorySeparatorChar).Last().Split('_').Last();
            }
        }

        private void colorIsPrefix_CheckedChanged(object sender, EventArgs e)
        {
            if (colorIsPrefix.Checked && colorVariants.Checked)
            {
                FileNameLabel.Text = MainForm.editingPath.Remove(MainForm.editingPath.Length - 1, 1).Split(Path.DirectorySeparatorChar).Last().Split('_').Last();
            }
        }

        private void colorIsSuffix_CheckedChanged(object sender, EventArgs e)
        {
            if (colorIsSuffix.Checked && colorVariants.Checked)
            {
                FileNameLabel.Text = MainForm.editingPath.Remove(MainForm.editingPath.Length - 1, 1).Split(Path.DirectorySeparatorChar).Last().Split('_').First();
            }
        }
    }
}
