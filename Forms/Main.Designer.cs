namespace DroneProject2
{
    partial class DroneProject2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DroneProject2));
            this.videoInput = new System.Windows.Forms.PictureBox();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.BackwardsButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.EmergencyButton = new System.Windows.Forms.Button();
            this.ResetEmergencyButton = new System.Windows.Forms.Button();
            this.TakeOffButton = new System.Windows.Forms.Button();
            this.LandButton = new System.Windows.Forms.Button();
            this.VideoUpdate_Tick = new System.Windows.Forms.Timer(this.components);
            this.UpButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.StatusTick = new System.Windows.Forms.Timer(this.components);
            this.StateLabel = new System.Windows.Forms.Label();
            this.StateBox = new System.Windows.Forms.TextBox();
            this.ConnectedBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.BatteryLevelPBLower = new System.Windows.Forms.ToolStripProgressBar();
            this.BatteryPercentageLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.FlightStatsGB = new System.Windows.Forms.GroupBox();
            this.YawBox = new System.Windows.Forms.TextBox();
            this.YawLabel = new System.Windows.Forms.Label();
            this.AltitudeBox = new System.Windows.Forms.TextBox();
            this.AltitudeLabel = new System.Windows.Forms.Label();
            this.PitchBox = new System.Windows.Forms.TextBox();
            this.PitchLabel = new System.Windows.Forms.Label();
            this.RollBox = new System.Windows.Forms.TextBox();
            this.RollLabel = new System.Windows.Forms.Label();
            this.VelocityZLabel = new System.Windows.Forms.Label();
            this.VelocityYLabel = new System.Windows.Forms.Label();
            this.VelocityXLabel = new System.Windows.Forms.Label();
            this.VelocityZBox = new System.Windows.Forms.TextBox();
            this.VelocityYBox = new System.Windows.Forms.TextBox();
            this.VelocityXBox = new System.Windows.Forms.TextBox();
            this.VelocityLabel = new System.Windows.Forms.Label();
            this.MagnetoRectifiedZLabel = new System.Windows.Forms.Label();
            this.MagnetoRectifiedYLabel = new System.Windows.Forms.Label();
            this.MagnetoRectifiedXLabel = new System.Windows.Forms.Label();
            this.MagnetoRectifiedZBox = new System.Windows.Forms.TextBox();
            this.MagnetoRectifiedYBox = new System.Windows.Forms.TextBox();
            this.MagnetoRectifiedXBox = new System.Windows.Forms.TextBox();
            this.MagnetoRectifiedLabel = new System.Windows.Forms.Label();
            this.MagnetoOffsetZLabel = new System.Windows.Forms.Label();
            this.MagnetoOffsetYLabel = new System.Windows.Forms.Label();
            this.MagnetoOffsetXLabel = new System.Windows.Forms.Label();
            this.MagnetoOffsetZBox = new System.Windows.Forms.TextBox();
            this.MagnetoOffsetYBox = new System.Windows.Forms.TextBox();
            this.MagnetoOffsetXBox = new System.Windows.Forms.TextBox();
            this.MagnetoOffsetLabel = new System.Windows.Forms.Label();
            this.ConnectedLabel = new System.Windows.Forms.Label();
            this.WifiQualityLabel = new System.Windows.Forms.Label();
            this.WifiQualityPB = new System.Windows.Forms.ProgressBar();
            this.WifiQualityPercentageLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TimeAliveLabel = new System.Windows.Forms.Label();
            this.VideoFrameLabel = new System.Windows.Forms.Label();
            this.VideoFrameNumberLabel = new System.Windows.Forms.Label();
            this.HoverButton = new System.Windows.Forms.Button();
            this.ExecuteCSVButton = new System.Windows.Forms.Button();
            this.APFilesCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.videoInput)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.FlightStatsGB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoInput
            // 
            this.videoInput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.videoInput.Location = new System.Drawing.Point(12, 12);
            this.videoInput.Name = "videoInput";
            this.videoInput.Size = new System.Drawing.Size(640, 360);
            this.videoInput.TabIndex = 0;
            this.videoInput.TabStop = false;
            // 
            // ForwardButton
            // 
            this.ForwardButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForwardButton.Location = new System.Drawing.Point(44, 11);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(32, 32);
            this.ForwardButton.TabIndex = 2;
            this.ForwardButton.Text = "↑";
            this.ForwardButton.UseVisualStyleBackColor = true;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // RightButton
            // 
            this.RightButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightButton.Location = new System.Drawing.Point(73, 41);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(32, 32);
            this.RightButton.TabIndex = 3;
            this.RightButton.Text = "→";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // BackwardsButton
            // 
            this.BackwardsButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackwardsButton.Location = new System.Drawing.Point(44, 71);
            this.BackwardsButton.Name = "BackwardsButton";
            this.BackwardsButton.Size = new System.Drawing.Size(32, 32);
            this.BackwardsButton.TabIndex = 4;
            this.BackwardsButton.Text = "↓";
            this.BackwardsButton.UseVisualStyleBackColor = true;
            this.BackwardsButton.Click += new System.EventHandler(this.BackwardsButton_Click);
            // 
            // LeftButton
            // 
            this.LeftButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftButton.Location = new System.Drawing.Point(16, 41);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(32, 32);
            this.LeftButton.TabIndex = 5;
            this.LeftButton.Text = "←";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.LightGreen;
            this.StartButton.Location = new System.Drawing.Point(250, 419);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 27);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.Firebrick;
            this.StopButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StopButton.Location = new System.Drawing.Point(250, 448);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 27);
            this.StopButton.TabIndex = 7;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // EmergencyButton
            // 
            this.EmergencyButton.BackColor = System.Drawing.Color.Red;
            this.EmergencyButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EmergencyButton.Location = new System.Drawing.Point(381, 386);
            this.EmergencyButton.Name = "EmergencyButton";
            this.EmergencyButton.Size = new System.Drawing.Size(170, 35);
            this.EmergencyButton.TabIndex = 8;
            this.EmergencyButton.Text = "EMERGENCY SHUTDOWN";
            this.EmergencyButton.UseVisualStyleBackColor = false;
            this.EmergencyButton.Click += new System.EventHandler(this.EmergencyButton_Click);
            // 
            // ResetEmergencyButton
            // 
            this.ResetEmergencyButton.Location = new System.Drawing.Point(381, 430);
            this.ResetEmergencyButton.Name = "ResetEmergencyButton";
            this.ResetEmergencyButton.Size = new System.Drawing.Size(170, 35);
            this.ResetEmergencyButton.TabIndex = 9;
            this.ResetEmergencyButton.Text = "RESET EMERGENCY";
            this.ResetEmergencyButton.UseVisualStyleBackColor = true;
            this.ResetEmergencyButton.Click += new System.EventHandler(this.ResetEmergencyButton_Click);
            // 
            // TakeOffButton
            // 
            this.TakeOffButton.Location = new System.Drawing.Point(169, 419);
            this.TakeOffButton.Name = "TakeOffButton";
            this.TakeOffButton.Size = new System.Drawing.Size(75, 24);
            this.TakeOffButton.TabIndex = 10;
            this.TakeOffButton.Text = "Take Off";
            this.TakeOffButton.UseVisualStyleBackColor = true;
            this.TakeOffButton.Click += new System.EventHandler(this.TakeOffButton_Click);
            // 
            // LandButton
            // 
            this.LandButton.Location = new System.Drawing.Point(169, 449);
            this.LandButton.Name = "LandButton";
            this.LandButton.Size = new System.Drawing.Size(75, 24);
            this.LandButton.TabIndex = 11;
            this.LandButton.Text = "Land";
            this.LandButton.UseVisualStyleBackColor = true;
            this.LandButton.Click += new System.EventHandler(this.LandButton_Click);
            // 
            // VideoUpdate_Tick
            // 
            this.VideoUpdate_Tick.Interval = 20;
            this.VideoUpdate_Tick.Tick += new System.EventHandler(this.VideoUpdate_Tick_Tick);
            // 
            // UpButton
            // 
            this.UpButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpButton.Location = new System.Drawing.Point(111, 11);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(32, 32);
            this.UpButton.TabIndex = 12;
            this.UpButton.Text = "↑";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // DownButton
            // 
            this.DownButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownButton.Location = new System.Drawing.Point(111, 71);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(32, 32);
            this.DownButton.TabIndex = 13;
            this.DownButton.Text = "↓";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // StatusTick
            // 
            this.StatusTick.Interval = 50;
            this.StatusTick.Tick += new System.EventHandler(this.StatusTick_Tick);
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(660, 15);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(35, 13);
            this.StateLabel.TabIndex = 14;
            this.StateLabel.Text = "State:";
            // 
            // StateBox
            // 
            this.StateBox.Location = new System.Drawing.Point(701, 12);
            this.StateBox.Name = "StateBox";
            this.StateBox.ReadOnly = true;
            this.StateBox.Size = new System.Drawing.Size(180, 20);
            this.StateBox.TabIndex = 15;
            // 
            // ConnectedBox
            // 
            this.ConnectedBox.Location = new System.Drawing.Point(728, 38);
            this.ConnectedBox.Name = "ConnectedBox";
            this.ConnectedBox.ReadOnly = true;
            this.ConnectedBox.Size = new System.Drawing.Size(153, 20);
            this.ConnectedBox.TabIndex = 17;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.BatteryLevelPBLower,
            this.BatteryPercentageLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 487);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(899, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabel1.Text = "Battery:";
            // 
            // BatteryLevelPBLower
            // 
            this.BatteryLevelPBLower.Name = "BatteryLevelPBLower";
            this.BatteryLevelPBLower.Size = new System.Drawing.Size(100, 16);
            // 
            // BatteryPercentageLabel
            // 
            this.BatteryPercentageLabel.Name = "BatteryPercentageLabel";
            this.BatteryPercentageLabel.Size = new System.Drawing.Size(23, 17);
            this.BatteryPercentageLabel.Text = "0%";
            // 
            // FlightStatsGB
            // 
            this.FlightStatsGB.Controls.Add(this.YawBox);
            this.FlightStatsGB.Controls.Add(this.YawLabel);
            this.FlightStatsGB.Controls.Add(this.AltitudeBox);
            this.FlightStatsGB.Controls.Add(this.AltitudeLabel);
            this.FlightStatsGB.Controls.Add(this.PitchBox);
            this.FlightStatsGB.Controls.Add(this.PitchLabel);
            this.FlightStatsGB.Controls.Add(this.RollBox);
            this.FlightStatsGB.Controls.Add(this.RollLabel);
            this.FlightStatsGB.Controls.Add(this.VelocityZLabel);
            this.FlightStatsGB.Controls.Add(this.VelocityYLabel);
            this.FlightStatsGB.Controls.Add(this.VelocityXLabel);
            this.FlightStatsGB.Controls.Add(this.VelocityZBox);
            this.FlightStatsGB.Controls.Add(this.VelocityYBox);
            this.FlightStatsGB.Controls.Add(this.VelocityXBox);
            this.FlightStatsGB.Controls.Add(this.VelocityLabel);
            this.FlightStatsGB.Controls.Add(this.MagnetoRectifiedZLabel);
            this.FlightStatsGB.Controls.Add(this.MagnetoRectifiedYLabel);
            this.FlightStatsGB.Controls.Add(this.MagnetoRectifiedXLabel);
            this.FlightStatsGB.Controls.Add(this.MagnetoRectifiedZBox);
            this.FlightStatsGB.Controls.Add(this.MagnetoRectifiedYBox);
            this.FlightStatsGB.Controls.Add(this.MagnetoRectifiedXBox);
            this.FlightStatsGB.Controls.Add(this.MagnetoRectifiedLabel);
            this.FlightStatsGB.Controls.Add(this.MagnetoOffsetZLabel);
            this.FlightStatsGB.Controls.Add(this.MagnetoOffsetYLabel);
            this.FlightStatsGB.Controls.Add(this.MagnetoOffsetXLabel);
            this.FlightStatsGB.Controls.Add(this.MagnetoOffsetZBox);
            this.FlightStatsGB.Controls.Add(this.MagnetoOffsetYBox);
            this.FlightStatsGB.Controls.Add(this.MagnetoOffsetXBox);
            this.FlightStatsGB.Controls.Add(this.MagnetoOffsetLabel);
            this.FlightStatsGB.Location = new System.Drawing.Point(663, 109);
            this.FlightStatsGB.Name = "FlightStatsGB";
            this.FlightStatsGB.Size = new System.Drawing.Size(226, 224);
            this.FlightStatsGB.TabIndex = 19;
            this.FlightStatsGB.TabStop = false;
            this.FlightStatsGB.Text = "Flight Stats";
            // 
            // YawBox
            // 
            this.YawBox.Location = new System.Drawing.Point(159, 187);
            this.YawBox.Name = "YawBox";
            this.YawBox.ReadOnly = true;
            this.YawBox.Size = new System.Drawing.Size(39, 20);
            this.YawBox.TabIndex = 46;
            // 
            // YawLabel
            // 
            this.YawLabel.AutoSize = true;
            this.YawLabel.Location = new System.Drawing.Point(125, 190);
            this.YawLabel.Name = "YawLabel";
            this.YawLabel.Size = new System.Drawing.Size(31, 13);
            this.YawLabel.TabIndex = 45;
            this.YawLabel.Text = "Yaw:";
            // 
            // AltitudeBox
            // 
            this.AltitudeBox.Location = new System.Drawing.Point(76, 187);
            this.AltitudeBox.Name = "AltitudeBox";
            this.AltitudeBox.ReadOnly = true;
            this.AltitudeBox.Size = new System.Drawing.Size(39, 20);
            this.AltitudeBox.TabIndex = 44;
            // 
            // AltitudeLabel
            // 
            this.AltitudeLabel.AutoSize = true;
            this.AltitudeLabel.Location = new System.Drawing.Point(29, 190);
            this.AltitudeLabel.Name = "AltitudeLabel";
            this.AltitudeLabel.Size = new System.Drawing.Size(45, 13);
            this.AltitudeLabel.TabIndex = 43;
            this.AltitudeLabel.Text = "Altitude:";
            // 
            // PitchBox
            // 
            this.PitchBox.Location = new System.Drawing.Point(159, 159);
            this.PitchBox.Name = "PitchBox";
            this.PitchBox.ReadOnly = true;
            this.PitchBox.Size = new System.Drawing.Size(39, 20);
            this.PitchBox.TabIndex = 42;
            // 
            // PitchLabel
            // 
            this.PitchLabel.AutoSize = true;
            this.PitchLabel.Location = new System.Drawing.Point(125, 162);
            this.PitchLabel.Name = "PitchLabel";
            this.PitchLabel.Size = new System.Drawing.Size(34, 13);
            this.PitchLabel.TabIndex = 41;
            this.PitchLabel.Text = "Pitch:";
            // 
            // RollBox
            // 
            this.RollBox.Location = new System.Drawing.Point(76, 159);
            this.RollBox.Name = "RollBox";
            this.RollBox.ReadOnly = true;
            this.RollBox.Size = new System.Drawing.Size(39, 20);
            this.RollBox.TabIndex = 21;
            // 
            // RollLabel
            // 
            this.RollLabel.AutoSize = true;
            this.RollLabel.Location = new System.Drawing.Point(29, 162);
            this.RollLabel.Name = "RollLabel";
            this.RollLabel.Size = new System.Drawing.Size(28, 13);
            this.RollLabel.TabIndex = 20;
            this.RollLabel.Text = "Roll:";
            // 
            // VelocityZLabel
            // 
            this.VelocityZLabel.AutoSize = true;
            this.VelocityZLabel.Location = new System.Drawing.Point(152, 121);
            this.VelocityZLabel.Name = "VelocityZLabel";
            this.VelocityZLabel.Size = new System.Drawing.Size(17, 13);
            this.VelocityZLabel.TabIndex = 40;
            this.VelocityZLabel.Text = "Z:";
            // 
            // VelocityYLabel
            // 
            this.VelocityYLabel.AutoSize = true;
            this.VelocityYLabel.Location = new System.Drawing.Point(78, 121);
            this.VelocityYLabel.Name = "VelocityYLabel";
            this.VelocityYLabel.Size = new System.Drawing.Size(17, 13);
            this.VelocityYLabel.TabIndex = 39;
            this.VelocityYLabel.Text = "Y:";
            // 
            // VelocityXLabel
            // 
            this.VelocityXLabel.AutoSize = true;
            this.VelocityXLabel.Location = new System.Drawing.Point(3, 120);
            this.VelocityXLabel.Name = "VelocityXLabel";
            this.VelocityXLabel.Size = new System.Drawing.Size(17, 13);
            this.VelocityXLabel.TabIndex = 38;
            this.VelocityXLabel.Text = "X:";
            // 
            // VelocityZBox
            // 
            this.VelocityZBox.Location = new System.Drawing.Point(175, 118);
            this.VelocityZBox.Name = "VelocityZBox";
            this.VelocityZBox.ReadOnly = true;
            this.VelocityZBox.Size = new System.Drawing.Size(45, 20);
            this.VelocityZBox.TabIndex = 37;
            // 
            // VelocityYBox
            // 
            this.VelocityYBox.Location = new System.Drawing.Point(101, 118);
            this.VelocityYBox.Name = "VelocityYBox";
            this.VelocityYBox.ReadOnly = true;
            this.VelocityYBox.Size = new System.Drawing.Size(45, 20);
            this.VelocityYBox.TabIndex = 36;
            // 
            // VelocityXBox
            // 
            this.VelocityXBox.Location = new System.Drawing.Point(27, 117);
            this.VelocityXBox.Name = "VelocityXBox";
            this.VelocityXBox.ReadOnly = true;
            this.VelocityXBox.Size = new System.Drawing.Size(45, 20);
            this.VelocityXBox.TabIndex = 35;
            // 
            // VelocityLabel
            // 
            this.VelocityLabel.AutoSize = true;
            this.VelocityLabel.Location = new System.Drawing.Point(6, 101);
            this.VelocityLabel.Name = "VelocityLabel";
            this.VelocityLabel.Size = new System.Drawing.Size(47, 13);
            this.VelocityLabel.TabIndex = 34;
            this.VelocityLabel.Text = "Velocity:";
            // 
            // MagnetoRectifiedZLabel
            // 
            this.MagnetoRectifiedZLabel.AutoSize = true;
            this.MagnetoRectifiedZLabel.Location = new System.Drawing.Point(155, 78);
            this.MagnetoRectifiedZLabel.Name = "MagnetoRectifiedZLabel";
            this.MagnetoRectifiedZLabel.Size = new System.Drawing.Size(17, 13);
            this.MagnetoRectifiedZLabel.TabIndex = 33;
            this.MagnetoRectifiedZLabel.Text = "Z:";
            // 
            // MagnetoRectifiedYLabel
            // 
            this.MagnetoRectifiedYLabel.AutoSize = true;
            this.MagnetoRectifiedYLabel.Location = new System.Drawing.Point(78, 78);
            this.MagnetoRectifiedYLabel.Name = "MagnetoRectifiedYLabel";
            this.MagnetoRectifiedYLabel.Size = new System.Drawing.Size(17, 13);
            this.MagnetoRectifiedYLabel.TabIndex = 32;
            this.MagnetoRectifiedYLabel.Text = "Y:";
            // 
            // MagnetoRectifiedXLabel
            // 
            this.MagnetoRectifiedXLabel.AutoSize = true;
            this.MagnetoRectifiedXLabel.Location = new System.Drawing.Point(3, 78);
            this.MagnetoRectifiedXLabel.Name = "MagnetoRectifiedXLabel";
            this.MagnetoRectifiedXLabel.Size = new System.Drawing.Size(17, 13);
            this.MagnetoRectifiedXLabel.TabIndex = 31;
            this.MagnetoRectifiedXLabel.Text = "X:";
            // 
            // MagnetoRectifiedZBox
            // 
            this.MagnetoRectifiedZBox.Location = new System.Drawing.Point(175, 75);
            this.MagnetoRectifiedZBox.Name = "MagnetoRectifiedZBox";
            this.MagnetoRectifiedZBox.ReadOnly = true;
            this.MagnetoRectifiedZBox.Size = new System.Drawing.Size(45, 20);
            this.MagnetoRectifiedZBox.TabIndex = 30;
            // 
            // MagnetoRectifiedYBox
            // 
            this.MagnetoRectifiedYBox.Location = new System.Drawing.Point(101, 75);
            this.MagnetoRectifiedYBox.Name = "MagnetoRectifiedYBox";
            this.MagnetoRectifiedYBox.ReadOnly = true;
            this.MagnetoRectifiedYBox.Size = new System.Drawing.Size(45, 20);
            this.MagnetoRectifiedYBox.TabIndex = 29;
            // 
            // MagnetoRectifiedXBox
            // 
            this.MagnetoRectifiedXBox.Location = new System.Drawing.Point(27, 75);
            this.MagnetoRectifiedXBox.Name = "MagnetoRectifiedXBox";
            this.MagnetoRectifiedXBox.ReadOnly = true;
            this.MagnetoRectifiedXBox.Size = new System.Drawing.Size(45, 20);
            this.MagnetoRectifiedXBox.TabIndex = 28;
            // 
            // MagnetoRectifiedLabel
            // 
            this.MagnetoRectifiedLabel.AutoSize = true;
            this.MagnetoRectifiedLabel.Location = new System.Drawing.Point(6, 59);
            this.MagnetoRectifiedLabel.Name = "MagnetoRectifiedLabel";
            this.MagnetoRectifiedLabel.Size = new System.Drawing.Size(97, 13);
            this.MagnetoRectifiedLabel.TabIndex = 27;
            this.MagnetoRectifiedLabel.Text = "Magneto Rectified:";
            // 
            // MagnetoOffsetZLabel
            // 
            this.MagnetoOffsetZLabel.AutoSize = true;
            this.MagnetoOffsetZLabel.Location = new System.Drawing.Point(152, 35);
            this.MagnetoOffsetZLabel.Name = "MagnetoOffsetZLabel";
            this.MagnetoOffsetZLabel.Size = new System.Drawing.Size(17, 13);
            this.MagnetoOffsetZLabel.TabIndex = 26;
            this.MagnetoOffsetZLabel.Text = "Z:";
            // 
            // MagnetoOffsetYLabel
            // 
            this.MagnetoOffsetYLabel.AutoSize = true;
            this.MagnetoOffsetYLabel.Location = new System.Drawing.Point(78, 35);
            this.MagnetoOffsetYLabel.Name = "MagnetoOffsetYLabel";
            this.MagnetoOffsetYLabel.Size = new System.Drawing.Size(17, 13);
            this.MagnetoOffsetYLabel.TabIndex = 25;
            this.MagnetoOffsetYLabel.Text = "Y:";
            // 
            // MagnetoOffsetXLabel
            // 
            this.MagnetoOffsetXLabel.AutoSize = true;
            this.MagnetoOffsetXLabel.Location = new System.Drawing.Point(4, 35);
            this.MagnetoOffsetXLabel.Name = "MagnetoOffsetXLabel";
            this.MagnetoOffsetXLabel.Size = new System.Drawing.Size(17, 13);
            this.MagnetoOffsetXLabel.TabIndex = 24;
            this.MagnetoOffsetXLabel.Text = "X:";
            // 
            // MagnetoOffsetZBox
            // 
            this.MagnetoOffsetZBox.Location = new System.Drawing.Point(175, 32);
            this.MagnetoOffsetZBox.Name = "MagnetoOffsetZBox";
            this.MagnetoOffsetZBox.ReadOnly = true;
            this.MagnetoOffsetZBox.Size = new System.Drawing.Size(45, 20);
            this.MagnetoOffsetZBox.TabIndex = 23;
            // 
            // MagnetoOffsetYBox
            // 
            this.MagnetoOffsetYBox.Location = new System.Drawing.Point(101, 32);
            this.MagnetoOffsetYBox.Name = "MagnetoOffsetYBox";
            this.MagnetoOffsetYBox.ReadOnly = true;
            this.MagnetoOffsetYBox.Size = new System.Drawing.Size(45, 20);
            this.MagnetoOffsetYBox.TabIndex = 22;
            // 
            // MagnetoOffsetXBox
            // 
            this.MagnetoOffsetXBox.Location = new System.Drawing.Point(27, 32);
            this.MagnetoOffsetXBox.Name = "MagnetoOffsetXBox";
            this.MagnetoOffsetXBox.ReadOnly = true;
            this.MagnetoOffsetXBox.Size = new System.Drawing.Size(45, 20);
            this.MagnetoOffsetXBox.TabIndex = 21;
            // 
            // MagnetoOffsetLabel
            // 
            this.MagnetoOffsetLabel.AutoSize = true;
            this.MagnetoOffsetLabel.Location = new System.Drawing.Point(6, 16);
            this.MagnetoOffsetLabel.Name = "MagnetoOffsetLabel";
            this.MagnetoOffsetLabel.Size = new System.Drawing.Size(83, 13);
            this.MagnetoOffsetLabel.TabIndex = 20;
            this.MagnetoOffsetLabel.Text = "Magneto Offset:";
            // 
            // ConnectedLabel
            // 
            this.ConnectedLabel.AutoSize = true;
            this.ConnectedLabel.Location = new System.Drawing.Point(660, 41);
            this.ConnectedLabel.Name = "ConnectedLabel";
            this.ConnectedLabel.Size = new System.Drawing.Size(62, 13);
            this.ConnectedLabel.TabIndex = 16;
            this.ConnectedLabel.Text = "Connected:";
            // 
            // WifiQualityLabel
            // 
            this.WifiQualityLabel.AutoSize = true;
            this.WifiQualityLabel.Location = new System.Drawing.Point(658, 74);
            this.WifiQualityLabel.Name = "WifiQualityLabel";
            this.WifiQualityLabel.Size = new System.Drawing.Size(85, 13);
            this.WifiQualityLabel.TabIndex = 20;
            this.WifiQualityLabel.Text = "Wireless Quality:";
            // 
            // WifiQualityPB
            // 
            this.WifiQualityPB.Location = new System.Drawing.Point(749, 68);
            this.WifiQualityPB.Name = "WifiQualityPB";
            this.WifiQualityPB.Size = new System.Drawing.Size(104, 23);
            this.WifiQualityPB.TabIndex = 21;
            // 
            // WifiQualityPercentageLabel
            // 
            this.WifiQualityPercentageLabel.AutoSize = true;
            this.WifiQualityPercentageLabel.Location = new System.Drawing.Point(860, 74);
            this.WifiQualityPercentageLabel.Name = "WifiQualityPercentageLabel";
            this.WifiQualityPercentageLabel.Size = new System.Drawing.Size(21, 13);
            this.WifiQualityPercentageLabel.TabIndex = 47;
            this.WifiQualityPercentageLabel.Text = "0%";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(840, 471);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(49, 13);
            this.TimeLabel.TabIndex = 48;
            this.TimeLabel.Text = "00:00:00";
            // 
            // TimeAliveLabel
            // 
            this.TimeAliveLabel.AutoSize = true;
            this.TimeAliveLabel.Location = new System.Drawing.Point(769, 471);
            this.TimeAliveLabel.Name = "TimeAliveLabel";
            this.TimeAliveLabel.Size = new System.Drawing.Size(66, 13);
            this.TimeAliveLabel.TabIndex = 49;
            this.TimeAliveLabel.Text = "Time Online:";
            // 
            // VideoFrameLabel
            // 
            this.VideoFrameLabel.AutoSize = true;
            this.VideoFrameLabel.Location = new System.Drawing.Point(766, 452);
            this.VideoFrameLabel.Name = "VideoFrameLabel";
            this.VideoFrameLabel.Size = new System.Drawing.Size(69, 13);
            this.VideoFrameLabel.TabIndex = 50;
            this.VideoFrameLabel.Text = "Video Frame:";
            // 
            // VideoFrameNumberLabel
            // 
            this.VideoFrameNumberLabel.AutoSize = true;
            this.VideoFrameNumberLabel.Location = new System.Drawing.Point(840, 452);
            this.VideoFrameNumberLabel.Name = "VideoFrameNumberLabel";
            this.VideoFrameNumberLabel.Size = new System.Drawing.Size(13, 13);
            this.VideoFrameNumberLabel.TabIndex = 51;
            this.VideoFrameNumberLabel.Text = "0";
            // 
            // HoverButton
            // 
            this.HoverButton.Location = new System.Drawing.Point(164, 11);
            this.HoverButton.Name = "HoverButton";
            this.HoverButton.Size = new System.Drawing.Size(75, 24);
            this.HoverButton.TabIndex = 52;
            this.HoverButton.Text = "Hover";
            this.HoverButton.UseVisualStyleBackColor = true;
            this.HoverButton.Click += new System.EventHandler(this.HoverButton_Click);
            // 
            // ExecuteCSVButton
            // 
            this.ExecuteCSVButton.Location = new System.Drawing.Point(21, 42);
            this.ExecuteCSVButton.Name = "ExecuteCSVButton";
            this.ExecuteCSVButton.Size = new System.Drawing.Size(91, 24);
            this.ExecuteCSVButton.TabIndex = 53;
            this.ExecuteCSVButton.Text = "Execute CSV";
            this.ExecuteCSVButton.UseVisualStyleBackColor = true;
            this.ExecuteCSVButton.Click += new System.EventHandler(this.ExecuteCSVButton_Click);
            // 
            // APFilesCombo
            // 
            this.APFilesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.APFilesCombo.FormattingEnabled = true;
            this.APFilesCombo.Location = new System.Drawing.Point(6, 15);
            this.APFilesCombo.Name = "APFilesCombo";
            this.APFilesCombo.Size = new System.Drawing.Size(121, 21);
            this.APFilesCombo.TabIndex = 54;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ExecuteCSVButton);
            this.groupBox1.Controls.Add(this.APFilesCombo);
            this.groupBox1.Location = new System.Drawing.Point(663, 339);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 110);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Autopilot";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.HoverButton);
            this.groupBox2.Controls.Add(this.LeftButton);
            this.groupBox2.Controls.Add(this.RightButton);
            this.groupBox2.Controls.Add(this.ForwardButton);
            this.groupBox2.Controls.Add(this.BackwardsButton);
            this.groupBox2.Controls.Add(this.UpButton);
            this.groupBox2.Controls.Add(this.DownButton);
            this.groupBox2.Location = new System.Drawing.Point(5, 378);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 106);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manual Controls";
            // 
            // DroneProject2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 509);
            this.Controls.Add(this.VideoFrameNumberLabel);
            this.Controls.Add(this.VideoFrameLabel);
            this.Controls.Add(this.TimeAliveLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.WifiQualityPercentageLabel);
            this.Controls.Add(this.WifiQualityPB);
            this.Controls.Add(this.WifiQualityLabel);
            this.Controls.Add(this.FlightStatsGB);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ConnectedBox);
            this.Controls.Add(this.ConnectedLabel);
            this.Controls.Add(this.StateBox);
            this.Controls.Add(this.StateLabel);
            this.Controls.Add(this.LandButton);
            this.Controls.Add(this.TakeOffButton);
            this.Controls.Add(this.ResetEmergencyButton);
            this.Controls.Add(this.EmergencyButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.videoInput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DroneProject2";
            this.Text = "Unfinished Drone Project 2";
            this.Load += new System.EventHandler(this.DroneProject2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videoInput)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.FlightStatsGB.ResumeLayout(false);
            this.FlightStatsGB.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox videoInput;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button BackwardsButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button EmergencyButton;
        private System.Windows.Forms.Button ResetEmergencyButton;
        private System.Windows.Forms.Button TakeOffButton;
        private System.Windows.Forms.Button LandButton;
        private System.Windows.Forms.Timer VideoUpdate_Tick;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Timer StatusTick;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.TextBox StateBox;
        private System.Windows.Forms.TextBox ConnectedBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar BatteryLevelPBLower;
        private System.Windows.Forms.ToolStripStatusLabel BatteryPercentageLabel;
        private System.Windows.Forms.GroupBox FlightStatsGB;
        private System.Windows.Forms.Label MagnetoOffsetZLabel;
        private System.Windows.Forms.Label MagnetoOffsetYLabel;
        private System.Windows.Forms.Label MagnetoOffsetXLabel;
        private System.Windows.Forms.TextBox MagnetoOffsetZBox;
        private System.Windows.Forms.TextBox MagnetoOffsetYBox;
        private System.Windows.Forms.TextBox MagnetoOffsetXBox;
        private System.Windows.Forms.Label MagnetoOffsetLabel;
        private System.Windows.Forms.Label MagnetoRectifiedZLabel;
        private System.Windows.Forms.Label MagnetoRectifiedYLabel;
        private System.Windows.Forms.Label MagnetoRectifiedXLabel;
        private System.Windows.Forms.TextBox MagnetoRectifiedZBox;
        private System.Windows.Forms.TextBox MagnetoRectifiedYBox;
        private System.Windows.Forms.TextBox MagnetoRectifiedXBox;
        private System.Windows.Forms.Label MagnetoRectifiedLabel;
        private System.Windows.Forms.TextBox PitchBox;
        private System.Windows.Forms.Label PitchLabel;
        private System.Windows.Forms.TextBox RollBox;
        private System.Windows.Forms.Label RollLabel;
        private System.Windows.Forms.Label VelocityZLabel;
        private System.Windows.Forms.Label VelocityYLabel;
        private System.Windows.Forms.Label VelocityXLabel;
        private System.Windows.Forms.TextBox VelocityZBox;
        private System.Windows.Forms.TextBox VelocityYBox;
        private System.Windows.Forms.TextBox VelocityXBox;
        private System.Windows.Forms.Label VelocityLabel;
        private System.Windows.Forms.TextBox YawBox;
        private System.Windows.Forms.Label YawLabel;
        private System.Windows.Forms.TextBox AltitudeBox;
        private System.Windows.Forms.Label AltitudeLabel;
        private System.Windows.Forms.Label ConnectedLabel;
        private System.Windows.Forms.Label WifiQualityLabel;
        private System.Windows.Forms.ProgressBar WifiQualityPB;
        private System.Windows.Forms.Label WifiQualityPercentageLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label TimeAliveLabel;
        private System.Windows.Forms.Label VideoFrameLabel;
        private System.Windows.Forms.Label VideoFrameNumberLabel;
        private System.Windows.Forms.Button HoverButton;
        public System.Windows.Forms.Button ExecuteCSVButton;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox APFilesCombo;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

