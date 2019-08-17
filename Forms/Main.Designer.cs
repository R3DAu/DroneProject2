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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UpButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.EmergencyButton = new System.Windows.Forms.Button();
            this.ResetEmergencyButton = new System.Windows.Forms.Button();
            this.TakeOffButton = new System.Windows.Forms.Button();
            this.LandButton = new System.Windows.Forms.Button();
            this.VideoUpdate_Tick = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.videoInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Location = new System.Drawing.Point(460, 264);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 108);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // UpButton
            // 
            this.UpButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpButton.Location = new System.Drawing.Point(76, 394);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(32, 32);
            this.UpButton.TabIndex = 2;
            this.UpButton.Text = "↑";
            this.UpButton.UseVisualStyleBackColor = true;
            // 
            // RightButton
            // 
            this.RightButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightButton.Location = new System.Drawing.Point(106, 423);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(32, 32);
            this.RightButton.TabIndex = 3;
            this.RightButton.Text = "→";
            this.RightButton.UseVisualStyleBackColor = true;
            // 
            // DownButton
            // 
            this.DownButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownButton.Location = new System.Drawing.Point(76, 452);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(32, 32);
            this.DownButton.TabIndex = 4;
            this.DownButton.Text = "↓";
            this.DownButton.UseVisualStyleBackColor = true;
            // 
            // LeftButton
            // 
            this.LeftButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftButton.Location = new System.Drawing.Point(46, 423);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(32, 32);
            this.LeftButton.TabIndex = 5;
            this.LeftButton.Text = "←";
            this.LeftButton.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.LightGreen;
            this.StartButton.Location = new System.Drawing.Point(577, 378);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 27);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.Firebrick;
            this.StopButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StopButton.Location = new System.Drawing.Point(577, 411);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 27);
            this.StopButton.TabIndex = 7;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = false;
            // 
            // EmergencyButton
            // 
            this.EmergencyButton.BackColor = System.Drawing.Color.Red;
            this.EmergencyButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EmergencyButton.Location = new System.Drawing.Point(231, 452);
            this.EmergencyButton.Name = "EmergencyButton";
            this.EmergencyButton.Size = new System.Drawing.Size(244, 35);
            this.EmergencyButton.TabIndex = 8;
            this.EmergencyButton.Text = "EMERGENCY SHUTDOWN";
            this.EmergencyButton.UseVisualStyleBackColor = false;
            // 
            // ResetEmergencyButton
            // 
            this.ResetEmergencyButton.Location = new System.Drawing.Point(482, 452);
            this.ResetEmergencyButton.Name = "ResetEmergencyButton";
            this.ResetEmergencyButton.Size = new System.Drawing.Size(170, 35);
            this.ResetEmergencyButton.TabIndex = 9;
            this.ResetEmergencyButton.Text = "RESET EMERGENCY";
            this.ResetEmergencyButton.UseVisualStyleBackColor = true;
            // 
            // TakeOffButton
            // 
            this.TakeOffButton.Location = new System.Drawing.Point(482, 381);
            this.TakeOffButton.Name = "TakeOffButton";
            this.TakeOffButton.Size = new System.Drawing.Size(75, 24);
            this.TakeOffButton.TabIndex = 10;
            this.TakeOffButton.Text = "Take Off";
            this.TakeOffButton.UseVisualStyleBackColor = true;
            // 
            // LandButton
            // 
            this.LandButton.Location = new System.Drawing.Point(482, 414);
            this.LandButton.Name = "LandButton";
            this.LandButton.Size = new System.Drawing.Size(75, 24);
            this.LandButton.TabIndex = 11;
            this.LandButton.Text = "Land";
            this.LandButton.UseVisualStyleBackColor = true;
            // 
            // VideoUpdate_Tick
            // 
            this.VideoUpdate_Tick.Interval = 20;
            this.VideoUpdate_Tick.Tick += new System.EventHandler(this.VideoUpdate_Tick_Tick);
            // 
            // DroneProject2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 499);
            this.Controls.Add(this.LandButton);
            this.Controls.Add(this.TakeOffButton);
            this.Controls.Add(this.ResetEmergencyButton);
            this.Controls.Add(this.EmergencyButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.LeftButton);
            this.Controls.Add(this.DownButton);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.UpButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.videoInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DroneProject2";
            this.Text = "Unfinished Drone Project 2";
            this.Load += new System.EventHandler(this.DroneProject2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videoInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox videoInput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button EmergencyButton;
        private System.Windows.Forms.Button ResetEmergencyButton;
        private System.Windows.Forms.Button TakeOffButton;
        private System.Windows.Forms.Button LandButton;
        private System.Windows.Forms.Timer VideoUpdate_Tick;
    }
}

