namespace The_Dat_File_Thing
{
    partial class VehicleDatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleDatForm));
            this.vehicleTypeBox = new System.Windows.Forms.GroupBox();
            this.heliRadioButton = new System.Windows.Forms.RadioButton();
            this.PlaneRadioButton = new System.Windows.Forms.RadioButton();
            this.boatRadioButton = new System.Windows.Forms.RadioButton();
            this.carRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.speedSteerBox = new System.Windows.Forms.GroupBox();
            this.HealthAmount = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.rarityOptions = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TrunkVertical = new System.Windows.Forms.NumericUpDown();
            this.TrunkHorizontal = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.FuelAmount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.steerAngle = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.reverseSpeed = new System.Windows.Forms.NumericUpDown();
            this.maxSpeed = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.writeDatFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lift = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.CameraDistance = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.ExitDistance = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.isCrawler = new System.Windows.Forms.CheckBox();
            this.isInvulnerable = new System.Windows.Forms.CheckBox();
            this.hasInvulnerableTires = new System.Windows.Forms.CheckBox();
            this.hasTraction = new System.Windows.Forms.CheckBox();
            this.explosionEffect = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.advancedGroup = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.PassengerArmor = new System.Windows.Forms.NumericUpDown();
            this.WheelColliderMassOverride = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.spawnerHealthMax = new System.Windows.Forms.NumericUpDown();
            this.spawnerHealthMin = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.spawnFuelMin = new System.Windows.Forms.NumericUpDown();
            this.spawnFuelMax = new System.Windows.Forms.NumericUpDown();
            this.PhysicsProfileBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.manualAdvancedCheckBox = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.colorIsSuffix = new System.Windows.Forms.RadioButton();
            this.colorIsPrefix = new System.Windows.Forms.RadioButton();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorVariants = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ColorVariantsBox = new System.Windows.Forms.GroupBox();
            this.colorVariantsPathBox = new System.Windows.Forms.TextBox();
            this.vehicleTypeBox.SuspendLayout();
            this.speedSteerBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HealthAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrunkVertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrunkHorizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuelAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.steerAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reverseSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSpeed)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CameraDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitDistance)).BeginInit();
            this.advancedGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassengerArmor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WheelColliderMassOverride)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spawnerHealthMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spawnerHealthMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spawnFuelMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spawnFuelMax)).BeginInit();
            this.ColorVariantsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // vehicleTypeBox
            // 
            this.vehicleTypeBox.Controls.Add(this.heliRadioButton);
            this.vehicleTypeBox.Controls.Add(this.PlaneRadioButton);
            this.vehicleTypeBox.Controls.Add(this.boatRadioButton);
            this.vehicleTypeBox.Controls.Add(this.carRadioButton);
            this.vehicleTypeBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.vehicleTypeBox.Location = new System.Drawing.Point(12, 82);
            this.vehicleTypeBox.Name = "vehicleTypeBox";
            this.vehicleTypeBox.Size = new System.Drawing.Size(106, 112);
            this.vehicleTypeBox.TabIndex = 0;
            this.vehicleTypeBox.TabStop = false;
            this.vehicleTypeBox.Text = "Vehicle Type";
            // 
            // heliRadioButton
            // 
            this.heliRadioButton.AutoSize = true;
            this.heliRadioButton.Location = new System.Drawing.Point(6, 88);
            this.heliRadioButton.Name = "heliRadioButton";
            this.heliRadioButton.Size = new System.Drawing.Size(73, 17);
            this.heliRadioButton.TabIndex = 3;
            this.heliRadioButton.TabStop = true;
            this.heliRadioButton.Text = "Helicopter";
            this.heliRadioButton.UseVisualStyleBackColor = true;
            // 
            // PlaneRadioButton
            // 
            this.PlaneRadioButton.AutoSize = true;
            this.PlaneRadioButton.Location = new System.Drawing.Point(6, 65);
            this.PlaneRadioButton.Name = "PlaneRadioButton";
            this.PlaneRadioButton.Size = new System.Drawing.Size(52, 17);
            this.PlaneRadioButton.TabIndex = 2;
            this.PlaneRadioButton.TabStop = true;
            this.PlaneRadioButton.Text = "Plane";
            this.PlaneRadioButton.UseVisualStyleBackColor = true;
            this.PlaneRadioButton.CheckedChanged += new System.EventHandler(this.PlaneRadioButton_CheckedChanged);
            // 
            // boatRadioButton
            // 
            this.boatRadioButton.AutoSize = true;
            this.boatRadioButton.Location = new System.Drawing.Point(6, 42);
            this.boatRadioButton.Name = "boatRadioButton";
            this.boatRadioButton.Size = new System.Drawing.Size(47, 17);
            this.boatRadioButton.TabIndex = 1;
            this.boatRadioButton.TabStop = true;
            this.boatRadioButton.Text = "Boat";
            this.boatRadioButton.UseVisualStyleBackColor = true;
            this.boatRadioButton.CheckedChanged += new System.EventHandler(this.boatRadioButton_CheckedChanged);
            // 
            // carRadioButton
            // 
            this.carRadioButton.AutoSize = true;
            this.carRadioButton.Location = new System.Drawing.Point(6, 19);
            this.carRadioButton.Name = "carRadioButton";
            this.carRadioButton.Size = new System.Drawing.Size(41, 17);
            this.carRadioButton.TabIndex = 0;
            this.carRadioButton.TabStop = true;
            this.carRadioButton.Text = "Car";
            this.carRadioButton.UseVisualStyleBackColor = true;
            this.carRadioButton.CheckedChanged += new System.EventHandler(this.carRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(72, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vehicle";
            // 
            // speedSteerBox
            // 
            this.speedSteerBox.Controls.Add(this.HealthAmount);
            this.speedSteerBox.Controls.Add(this.label18);
            this.speedSteerBox.Controls.Add(this.rarityOptions);
            this.speedSteerBox.Controls.Add(this.label9);
            this.speedSteerBox.Controls.Add(this.TrunkVertical);
            this.speedSteerBox.Controls.Add(this.TrunkHorizontal);
            this.speedSteerBox.Controls.Add(this.label8);
            this.speedSteerBox.Controls.Add(this.FuelAmount);
            this.speedSteerBox.Controls.Add(this.label5);
            this.speedSteerBox.Controls.Add(this.steerAngle);
            this.speedSteerBox.Controls.Add(this.label4);
            this.speedSteerBox.Controls.Add(this.reverseSpeed);
            this.speedSteerBox.Controls.Add(this.maxSpeed);
            this.speedSteerBox.Controls.Add(this.label3);
            this.speedSteerBox.Controls.Add(this.label2);
            this.speedSteerBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.speedSteerBox.Location = new System.Drawing.Point(125, 82);
            this.speedSteerBox.Name = "speedSteerBox";
            this.speedSteerBox.Size = new System.Drawing.Size(597, 112);
            this.speedSteerBox.TabIndex = 3;
            this.speedSteerBox.TabStop = false;
            this.speedSteerBox.Text = "Basics";
            // 
            // HealthAmount
            // 
            this.HealthAmount.Location = new System.Drawing.Point(382, 86);
            this.HealthAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.HealthAmount.Name = "HealthAmount";
            this.HealthAmount.Size = new System.Drawing.Size(82, 20);
            this.HealthAmount.TabIndex = 12;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(338, 90);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "Health";
            // 
            // rarityOptions
            // 
            this.rarityOptions.FormattingEnabled = true;
            this.rarityOptions.Items.AddRange(new object[] {
            "Common",
            "Uncommon",
            "Rare",
            "Epic",
            "Legendary",
            "Mythical"});
            this.rarityOptions.Location = new System.Drawing.Point(382, 15);
            this.rarityOptions.Name = "rarityOptions";
            this.rarityOptions.Size = new System.Drawing.Size(200, 21);
            this.rarityOptions.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(342, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Rarity";
            // 
            // TrunkVertical
            // 
            this.TrunkVertical.Location = new System.Drawing.Point(513, 42);
            this.TrunkVertical.Name = "TrunkVertical";
            this.TrunkVertical.Size = new System.Drawing.Size(69, 20);
            this.TrunkVertical.TabIndex = 9;
            // 
            // TrunkHorizontal
            // 
            this.TrunkHorizontal.Location = new System.Drawing.Point(382, 42);
            this.TrunkHorizontal.Name = "TrunkHorizontal";
            this.TrunkHorizontal.Size = new System.Drawing.Size(69, 20);
            this.TrunkHorizontal.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(240, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(273, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Trunk Space:  Horizontal (X):                          Vertical(Y):";
            // 
            // FuelAmount
            // 
            this.FuelAmount.Location = new System.Drawing.Point(134, 85);
            this.FuelAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.FuelAmount.Name = "FuelAmount";
            this.FuelAmount.Size = new System.Drawing.Size(82, 20);
            this.FuelAmount.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fuel amount";
            // 
            // steerAngle
            // 
            this.steerAngle.Location = new System.Drawing.Point(134, 62);
            this.steerAngle.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.steerAngle.Name = "steerAngle";
            this.steerAngle.Size = new System.Drawing.Size(82, 20);
            this.steerAngle.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Steering Angle (Deg)";
            // 
            // reverseSpeed
            // 
            this.reverseSpeed.Location = new System.Drawing.Point(134, 39);
            this.reverseSpeed.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.reverseSpeed.Name = "reverseSpeed";
            this.reverseSpeed.Size = new System.Drawing.Size(82, 20);
            this.reverseSpeed.TabIndex = 3;
            // 
            // maxSpeed
            // 
            this.maxSpeed.Location = new System.Drawing.Point(134, 16);
            this.maxSpeed.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.maxSpeed.Name = "maxSpeed";
            this.maxSpeed.Size = new System.Drawing.Size(82, 20);
            this.maxSpeed.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Reversing speed (km/h)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Maximum speed (km/h)";
            // 
            // writeDatFile
            // 
            this.writeDatFile.Location = new System.Drawing.Point(606, 426);
            this.writeDatFile.Name = "writeDatFile";
            this.writeDatFile.Size = new System.Drawing.Size(116, 23);
            this.writeDatFile.TabIndex = 4;
            this.writeDatFile.Text = "Write";
            this.writeDatFile.UseVisualStyleBackColor = true;
            this.writeDatFile.Click += new System.EventHandler(this.writeDatFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lift);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.CameraDistance);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.ExitDistance);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.isCrawler);
            this.groupBox1.Controls.Add(this.isInvulnerable);
            this.groupBox1.Controls.Add(this.hasInvulnerableTires);
            this.groupBox1.Controls.Add(this.hasTraction);
            this.groupBox1.Controls.Add(this.explosionEffect);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 218);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Intermediate";
            // 
            // Lift
            // 
            this.Lift.Enabled = false;
            this.Lift.Location = new System.Drawing.Point(82, 190);
            this.Lift.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Lift.Name = "Lift";
            this.Lift.Size = new System.Drawing.Size(82, 20);
            this.Lift.TabIndex = 11;
            this.Lift.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 192);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "Lift";
            this.toolTip1.SetToolTip(this.label16, "Lift force applied on the rigidbody");
            // 
            // CameraDistance
            // 
            this.CameraDistance.DecimalPlaces = 1;
            this.CameraDistance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CameraDistance.Location = new System.Drawing.Point(82, 83);
            this.CameraDistance.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.CameraDistance.Name = "CameraDistance";
            this.CameraDistance.Size = new System.Drawing.Size(82, 20);
            this.CameraDistance.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Cam distance";
            this.toolTip1.SetToolTip(this.label15, "Set to 0.0 for default");
            // 
            // ExitDistance
            // 
            this.ExitDistance.DecimalPlaces = 1;
            this.ExitDistance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ExitDistance.Location = new System.Drawing.Point(82, 58);
            this.ExitDistance.Name = "ExitDistance";
            this.ExitDistance.Size = new System.Drawing.Size(82, 20);
            this.ExitDistance.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Exit distance";
            this.toolTip1.SetToolTip(this.label14, "Set to 0.0 for default");
            // 
            // isCrawler
            // 
            this.isCrawler.AutoSize = true;
            this.isCrawler.Enabled = false;
            this.isCrawler.Location = new System.Drawing.Point(283, 35);
            this.isCrawler.Name = "isCrawler";
            this.isCrawler.Size = new System.Drawing.Size(61, 17);
            this.isCrawler.TabIndex = 6;
            this.isCrawler.Text = "Crawler";
            this.toolTip1.SetToolTip(this.isCrawler, "Tank tread drive");
            this.isCrawler.UseVisualStyleBackColor = true;
            // 
            // isInvulnerable
            // 
            this.isInvulnerable.AutoSize = true;
            this.isInvulnerable.Location = new System.Drawing.Point(195, 35);
            this.isInvulnerable.Name = "isInvulnerable";
            this.isInvulnerable.Size = new System.Drawing.Size(84, 17);
            this.isInvulnerable.TabIndex = 5;
            this.isInvulnerable.Text = "Invulnerable";
            this.toolTip1.SetToolTip(this.isInvulnerable, "Small arms fire and melee deals no damage");
            this.isInvulnerable.UseVisualStyleBackColor = true;
            // 
            // hasInvulnerableTires
            // 
            this.hasInvulnerableTires.AutoSize = true;
            this.hasInvulnerableTires.Location = new System.Drawing.Point(80, 35);
            this.hasInvulnerableTires.Name = "hasInvulnerableTires";
            this.hasInvulnerableTires.Size = new System.Drawing.Size(109, 17);
            this.hasInvulnerableTires.TabIndex = 4;
            this.hasInvulnerableTires.Text = "Tires invulnerable";
            this.toolTip1.SetToolTip(this.hasInvulnerableTires, "Tires are bulletproof");
            this.hasInvulnerableTires.UseVisualStyleBackColor = true;
            // 
            // hasTraction
            // 
            this.hasTraction.AutoSize = true;
            this.hasTraction.Enabled = false;
            this.hasTraction.Location = new System.Drawing.Point(9, 34);
            this.hasTraction.Name = "hasTraction";
            this.hasTraction.Size = new System.Drawing.Size(65, 17);
            this.hasTraction.TabIndex = 3;
            this.hasTraction.Text = "Traction";
            this.toolTip1.SetToolTip(this.hasTraction, "Enables traction on snowy/icy terrains");
            this.hasTraction.UseVisualStyleBackColor = true;
            // 
            // explosionEffect
            // 
            this.explosionEffect.Location = new System.Drawing.Point(113, 13);
            this.explosionEffect.Name = "explosionEffect";
            this.explosionEffect.Size = new System.Drawing.Size(60, 20);
            this.explosionEffect.TabIndex = 2;
            this.explosionEffect.Text = "20";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Explosion Effect ID";
            // 
            // advancedGroup
            // 
            this.advancedGroup.Controls.Add(this.panel2);
            this.advancedGroup.Controls.Add(this.label17);
            this.advancedGroup.Controls.Add(this.PassengerArmor);
            this.advancedGroup.Controls.Add(this.WheelColliderMassOverride);
            this.advancedGroup.Controls.Add(this.label12);
            this.advancedGroup.Controls.Add(this.spawnerHealthMax);
            this.advancedGroup.Controls.Add(this.spawnerHealthMin);
            this.advancedGroup.Controls.Add(this.label11);
            this.advancedGroup.Controls.Add(this.spawnFuelMin);
            this.advancedGroup.Controls.Add(this.spawnFuelMax);
            this.advancedGroup.Controls.Add(this.PhysicsProfileBox);
            this.advancedGroup.Controls.Add(this.label6);
            this.advancedGroup.Controls.Add(this.label10);
            this.advancedGroup.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.advancedGroup.Location = new System.Drawing.Point(368, 204);
            this.advancedGroup.Name = "advancedGroup";
            this.advancedGroup.Size = new System.Drawing.Size(354, 218);
            this.advancedGroup.TabIndex = 6;
            this.advancedGroup.TabStop = false;
            this.advancedGroup.Text = "Advanced";
            this.toolTip1.SetToolTip(this.advancedGroup, "Make sure you know what you\'re doing, these things are usually a little harder th" +
        "an your average setting");
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::The_Dat_File_Thing.Properties.Resources.info64;
            this.panel2.Location = new System.Drawing.Point(284, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(64, 64);
            this.panel2.TabIndex = 22;
            this.toolTip1.SetToolTip(this.panel2, "Extra steering tires and so on coming soon-ish.");
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 138);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "Passenger defense";
            this.toolTip1.SetToolTip(this.label17, "Overrides the Rigidbody mass setting, both in the Physics profile and in the bund" +
        "le itself");
            // 
            // PassengerArmor
            // 
            this.PassengerArmor.DecimalPlaces = 1;
            this.PassengerArmor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.PassengerArmor.Location = new System.Drawing.Point(139, 136);
            this.PassengerArmor.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PassengerArmor.Name = "PassengerArmor";
            this.PassengerArmor.Size = new System.Drawing.Size(82, 20);
            this.PassengerArmor.TabIndex = 20;
            // 
            // WheelColliderMassOverride
            // 
            this.WheelColliderMassOverride.DecimalPlaces = 1;
            this.WheelColliderMassOverride.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.WheelColliderMassOverride.Location = new System.Drawing.Point(266, 110);
            this.WheelColliderMassOverride.Name = "WheelColliderMassOverride";
            this.WheelColliderMassOverride.Size = new System.Drawing.Size(82, 20);
            this.WheelColliderMassOverride.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(236, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Wheel collider mass override (0.0 to use profile\'s)";
            this.toolTip1.SetToolTip(this.label12, "Overrides the Rigidbody mass setting, both in the Physics profile and in the bund" +
        "le itself");
            // 
            // spawnerHealthMax
            // 
            this.spawnerHealthMax.Location = new System.Drawing.Point(266, 83);
            this.spawnerHealthMax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.spawnerHealthMax.Name = "spawnerHealthMax";
            this.spawnerHealthMax.Size = new System.Drawing.Size(82, 20);
            this.spawnerHealthMax.TabIndex = 15;
            // 
            // spawnerHealthMin
            // 
            this.spawnerHealthMin.Location = new System.Drawing.Point(139, 84);
            this.spawnerHealthMin.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.spawnerHealthMin.Name = "spawnerHealthMin";
            this.spawnerHealthMin.Size = new System.Drawing.Size(82, 20);
            this.spawnerHealthMin.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Spawner Health Range";
            this.toolTip1.SetToolTip(this.label11, "Default max health is 1/2 of total health\r\nDefault min health is 1/4 of total hea" +
        "lth");
            // 
            // spawnFuelMin
            // 
            this.spawnFuelMin.Location = new System.Drawing.Point(139, 58);
            this.spawnFuelMin.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.spawnFuelMin.Name = "spawnFuelMin";
            this.spawnFuelMin.Size = new System.Drawing.Size(82, 20);
            this.spawnFuelMin.TabIndex = 11;
            // 
            // spawnFuelMax
            // 
            this.spawnFuelMax.Location = new System.Drawing.Point(266, 58);
            this.spawnFuelMax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.spawnFuelMax.Name = "spawnFuelMax";
            this.spawnFuelMax.Size = new System.Drawing.Size(82, 20);
            this.spawnFuelMax.TabIndex = 10;
            // 
            // PhysicsProfileBox
            // 
            this.PhysicsProfileBox.Location = new System.Drawing.Point(9, 32);
            this.PhysicsProfileBox.Name = "PhysicsProfileBox";
            this.PhysicsProfileBox.Size = new System.Drawing.Size(339, 20);
            this.PhysicsProfileBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.PhysicsProfileBox, "Nelson\'s experimental front wheel drive profile:\r\n\r\nbb4625d972b342f382b2074aa5dc5" +
        "6e5");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Physics profile (GUID) - Leave empty for none";
            this.toolTip1.SetToolTip(this.label6, "Nelson\'s experimental front wheel drive profile:");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Spawner Fuel Range\r\n";
            this.toolTip1.SetToolTip(this.label10, "Default max fuel is 1/2 of total fuel capacity\r\nDefault min fuel is 1/4 of total " +
        "fuel capacity");
            // 
            // manualAdvancedCheckBox
            // 
            this.manualAdvancedCheckBox.AutoSize = true;
            this.manualAdvancedCheckBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.manualAdvancedCheckBox.Location = new System.Drawing.Point(76, 59);
            this.manualAdvancedCheckBox.Name = "manualAdvancedCheckBox";
            this.manualAdvancedCheckBox.Size = new System.Drawing.Size(154, 17);
            this.manualAdvancedCheckBox.TabIndex = 7;
            this.manualAdvancedCheckBox.Text = "Manual Advanced Settings";
            this.manualAdvancedCheckBox.UseVisualStyleBackColor = true;
            this.manualAdvancedCheckBox.CheckedChanged += new System.EventHandler(this.manualAdvancedCheckBox_CheckedChanged);
            // 
            // colorIsSuffix
            // 
            this.colorIsSuffix.AutoSize = true;
            this.colorIsSuffix.Checked = true;
            this.colorIsSuffix.Location = new System.Drawing.Point(65, 19);
            this.colorIsSuffix.Name = "colorIsSuffix";
            this.colorIsSuffix.Size = new System.Drawing.Size(51, 17);
            this.colorIsSuffix.TabIndex = 13;
            this.colorIsSuffix.TabStop = true;
            this.colorIsSuffix.Text = "Suffix";
            this.toolTip1.SetToolTip(this.colorIsSuffix, "The color variant marker is a suffix in the bundle name");
            this.colorIsSuffix.UseVisualStyleBackColor = true;
            this.colorIsSuffix.CheckedChanged += new System.EventHandler(this.colorIsSuffix_CheckedChanged);
            // 
            // colorIsPrefix
            // 
            this.colorIsPrefix.AutoSize = true;
            this.colorIsPrefix.Location = new System.Drawing.Point(7, 20);
            this.colorIsPrefix.Name = "colorIsPrefix";
            this.colorIsPrefix.Size = new System.Drawing.Size(51, 17);
            this.colorIsPrefix.TabIndex = 12;
            this.colorIsPrefix.TabStop = true;
            this.colorIsPrefix.Text = "Prefix";
            this.toolTip1.SetToolTip(this.colorIsPrefix, "The color variant marker is a prefix in the bundle name");
            this.colorIsPrefix.UseVisualStyleBackColor = true;
            this.colorIsPrefix.CheckedChanged += new System.EventHandler(this.colorIsPrefix_CheckedChanged);
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileNameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FileNameLabel.Location = new System.Drawing.Point(72, 36);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(133, 20);
            this.FileNameLabel.TabIndex = 8;
            this.FileNameLabel.Text = "<FileNameLabel>";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(64, 64);
            this.panel1.TabIndex = 9;
            // 
            // colorVariants
            // 
            this.colorVariants.AutoSize = true;
            this.colorVariants.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.colorVariants.Location = new System.Drawing.Point(236, 59);
            this.colorVariants.Name = "colorVariants";
            this.colorVariants.Size = new System.Drawing.Size(90, 17);
            this.colorVariants.TabIndex = 10;
            this.colorVariants.Text = "Color variants";
            this.colorVariants.UseVisualStyleBackColor = true;
            this.colorVariants.CheckedChanged += new System.EventHandler(this.colorVariants_CheckedChanged);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(270, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Change...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ColorVariantsBox
            // 
            this.ColorVariantsBox.Controls.Add(this.colorVariantsPathBox);
            this.ColorVariantsBox.Controls.Add(this.colorIsSuffix);
            this.ColorVariantsBox.Controls.Add(this.colorIsPrefix);
            this.ColorVariantsBox.Controls.Add(this.button1);
            this.ColorVariantsBox.Enabled = false;
            this.ColorVariantsBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ColorVariantsBox.Location = new System.Drawing.Point(368, 12);
            this.ColorVariantsBox.Name = "ColorVariantsBox";
            this.ColorVariantsBox.Size = new System.Drawing.Size(354, 66);
            this.ColorVariantsBox.TabIndex = 12;
            this.ColorVariantsBox.TabStop = false;
            this.ColorVariantsBox.Text = "Color variants";
            // 
            // colorVariantsPathBox
            // 
            this.colorVariantsPathBox.Location = new System.Drawing.Point(6, 40);
            this.colorVariantsPathBox.Name = "colorVariantsPathBox";
            this.colorVariantsPathBox.ReadOnly = true;
            this.colorVariantsPathBox.Size = new System.Drawing.Size(258, 20);
            this.colorVariantsPathBox.TabIndex = 14;
            // 
            // VehicleDatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.ColorVariantsBox);
            this.Controls.Add(this.colorVariants);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.manualAdvancedCheckBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.writeDatFile);
            this.Controls.Add(this.speedSteerBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vehicleTypeBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.advancedGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "VehicleDatForm";
            this.Text = "Vehicles";
            this.Load += new System.EventHandler(this.VehicleDatForm_Load);
            this.vehicleTypeBox.ResumeLayout(false);
            this.vehicleTypeBox.PerformLayout();
            this.speedSteerBox.ResumeLayout(false);
            this.speedSteerBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HealthAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrunkVertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrunkHorizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuelAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.steerAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reverseSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSpeed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CameraDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitDistance)).EndInit();
            this.advancedGroup.ResumeLayout(false);
            this.advancedGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassengerArmor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WheelColliderMassOverride)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spawnerHealthMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spawnerHealthMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spawnFuelMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spawnFuelMax)).EndInit();
            this.ColorVariantsBox.ResumeLayout(false);
            this.ColorVariantsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox vehicleTypeBox;
        private System.Windows.Forms.RadioButton heliRadioButton;
        private System.Windows.Forms.RadioButton PlaneRadioButton;
        private System.Windows.Forms.RadioButton boatRadioButton;
        private System.Windows.Forms.RadioButton carRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox speedSteerBox;
        private System.Windows.Forms.NumericUpDown reverseSpeed;
        private System.Windows.Forms.NumericUpDown maxSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown steerAngle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown FuelAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button writeDatFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox advancedGroup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox manualAdvancedCheckBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox explosionEffect;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown TrunkHorizontal;
        private System.Windows.Forms.NumericUpDown TrunkVertical;
        private System.Windows.Forms.TextBox PhysicsProfileBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown spawnFuelMin;
        private System.Windows.Forms.NumericUpDown spawnFuelMax;
        private System.Windows.Forms.ComboBox rarityOptions;
        private System.Windows.Forms.NumericUpDown spawnerHealthMax;
        private System.Windows.Forms.NumericUpDown spawnerHealthMin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox isInvulnerable;
        private System.Windows.Forms.CheckBox hasInvulnerableTires;
        private System.Windows.Forms.CheckBox hasTraction;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.NumericUpDown WheelColliderMassOverride;
        private System.Windows.Forms.CheckBox isCrawler;
        private System.Windows.Forms.NumericUpDown ExitDistance;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown CameraDistance;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown Lift;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox colorVariants;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown PassengerArmor;
        private System.Windows.Forms.GroupBox ColorVariantsBox;
        private System.Windows.Forms.RadioButton colorIsSuffix;
        private System.Windows.Forms.RadioButton colorIsPrefix;
        private System.Windows.Forms.TextBox colorVariantsPathBox;
        private System.Windows.Forms.NumericUpDown HealthAmount;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel2;
    }
}