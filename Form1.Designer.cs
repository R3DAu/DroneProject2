namespace ARDrone2_Controller
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.butStart = new System.Windows.Forms.Button();
            this.butTakeOff = new System.Windows.Forms.Button();
            this.butLand = new System.Windows.Forms.Button();
            this.butHover = new System.Windows.Forms.Button();
            this.butPitchUp = new System.Windows.Forms.Button();
            this.butPitchDown = new System.Windows.Forms.Button();
            this.butYawUp = new System.Windows.Forms.Button();
            this.butYawDown = new System.Windows.Forms.Button();
            this.butRollLeft = new System.Windows.Forms.Button();
            this.butRollRight = new System.Windows.Forms.Button();
            this.butPitchLeft = new System.Windows.Forms.Button();
            this.butPitchRight = new System.Windows.Forms.Button();
            this.butEmergency = new System.Windows.Forms.Button();
            this.butStop = new System.Windows.Forms.Button();
            this.butJump = new System.Windows.Forms.Button();
            this.butHeightUp = new System.Windows.Forms.Button();
            this.butHeightDown = new System.Windows.Forms.Button();
            this.butCircle = new System.Windows.Forms.Button();
            this.butHelix = new System.Windows.Forms.Button();
            this.butFigure8 = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butStart
            // 
            this.butStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butStart.Location = new System.Drawing.Point(29, 340);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(86, 34);
            this.butStart.TabIndex = 0;
            this.butStart.Text = "Start";
            this.butStart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.Start);
            // 
            // butTakeOff
            // 
            this.butTakeOff.Location = new System.Drawing.Point(29, 380);
            this.butTakeOff.Name = "butTakeOff";
            this.butTakeOff.Size = new System.Drawing.Size(86, 34);
            this.butTakeOff.TabIndex = 1;
            this.butTakeOff.Text = "Take Off";
            this.butTakeOff.UseVisualStyleBackColor = true;
            this.butTakeOff.Click += new System.EventHandler(this.TakeOff);
            // 
            // butLand
            // 
            this.butLand.Location = new System.Drawing.Point(29, 420);
            this.butLand.Name = "butLand";
            this.butLand.Size = new System.Drawing.Size(86, 34);
            this.butLand.TabIndex = 2;
            this.butLand.Text = "Landing";
            this.butLand.UseVisualStyleBackColor = true;
            this.butLand.Click += new System.EventHandler(this.Land);
            // 
            // butHover
            // 
            this.butHover.Location = new System.Drawing.Point(29, 460);
            this.butHover.Name = "butHover";
            this.butHover.Size = new System.Drawing.Size(86, 34);
            this.butHover.TabIndex = 3;
            this.butHover.Text = "Hover";
            this.butHover.UseVisualStyleBackColor = true;
            this.butHover.Click += new System.EventHandler(this.Hover);
            // 
            // butPitchUp
            // 
            this.butPitchUp.Location = new System.Drawing.Point(141, 340);
            this.butPitchUp.Name = "butPitchUp";
            this.butPitchUp.Size = new System.Drawing.Size(86, 34);
            this.butPitchUp.TabIndex = 4;
            this.butPitchUp.Text = "Pitch ++";
            this.butPitchUp.UseVisualStyleBackColor = true;
            this.butPitchUp.Click += new System.EventHandler(this.PitchUp);
            // 
            // butPitchDown
            // 
            this.butPitchDown.Location = new System.Drawing.Point(141, 380);
            this.butPitchDown.Name = "butPitchDown";
            this.butPitchDown.Size = new System.Drawing.Size(86, 34);
            this.butPitchDown.TabIndex = 5;
            this.butPitchDown.Text = "Pitch --";
            this.butPitchDown.UseVisualStyleBackColor = true;
            this.butPitchDown.Click += new System.EventHandler(this.PitchDown);
            // 
            // butYawUp
            // 
            this.butYawUp.Location = new System.Drawing.Point(141, 420);
            this.butYawUp.Name = "butYawUp";
            this.butYawUp.Size = new System.Drawing.Size(86, 34);
            this.butYawUp.TabIndex = 6;
            this.butYawUp.Text = "Yaw ++";
            this.butYawUp.UseVisualStyleBackColor = true;
            this.butYawUp.Click += new System.EventHandler(this.YawUp);
            // 
            // butYawDown
            // 
            this.butYawDown.Location = new System.Drawing.Point(141, 460);
            this.butYawDown.Name = "butYawDown";
            this.butYawDown.Size = new System.Drawing.Size(86, 34);
            this.butYawDown.TabIndex = 7;
            this.butYawDown.Text = "Yaw --";
            this.butYawDown.UseVisualStyleBackColor = true;
            this.butYawDown.Click += new System.EventHandler(this.YawDown);
            // 
            // butRollLeft
            // 
            this.butRollLeft.Location = new System.Drawing.Point(252, 340);
            this.butRollLeft.Name = "butRollLeft";
            this.butRollLeft.Size = new System.Drawing.Size(86, 34);
            this.butRollLeft.TabIndex = 8;
            this.butRollLeft.Text = "Roll Left";
            this.butRollLeft.UseVisualStyleBackColor = true;
            this.butRollLeft.Click += new System.EventHandler(this.RollLeft);
            // 
            // butRollRight
            // 
            this.butRollRight.Location = new System.Drawing.Point(252, 380);
            this.butRollRight.Name = "butRollRight";
            this.butRollRight.Size = new System.Drawing.Size(86, 34);
            this.butRollRight.TabIndex = 9;
            this.butRollRight.Text = "Roll Right";
            this.butRollRight.UseVisualStyleBackColor = true;
            this.butRollRight.Click += new System.EventHandler(this.RollRight);
            // 
            // butPitchLeft
            // 
            this.butPitchLeft.Location = new System.Drawing.Point(252, 420);
            this.butPitchLeft.Name = "butPitchLeft";
            this.butPitchLeft.Size = new System.Drawing.Size(86, 34);
            this.butPitchLeft.TabIndex = 10;
            this.butPitchLeft.Text = "Pitch Left";
            this.butPitchLeft.UseVisualStyleBackColor = true;
            this.butPitchLeft.Click += new System.EventHandler(this.PitchLeft);
            // 
            // butPitchRight
            // 
            this.butPitchRight.Location = new System.Drawing.Point(252, 460);
            this.butPitchRight.Name = "butPitchRight";
            this.butPitchRight.Size = new System.Drawing.Size(86, 34);
            this.butPitchRight.TabIndex = 11;
            this.butPitchRight.Text = "Pitch Right";
            this.butPitchRight.UseVisualStyleBackColor = true;
            this.butPitchRight.Click += new System.EventHandler(this.PitchRight);
            // 
            // butEmergency
            // 
            this.butEmergency.Location = new System.Drawing.Point(356, 340);
            this.butEmergency.Name = "butEmergency";
            this.butEmergency.Size = new System.Drawing.Size(96, 34);
            this.butEmergency.TabIndex = 12;
            this.butEmergency.Text = "Emergency";
            this.butEmergency.UseVisualStyleBackColor = true;
            this.butEmergency.Click += new System.EventHandler(this.Emergency);
            // 
            // butStop
            // 
            this.butStop.Location = new System.Drawing.Point(356, 380);
            this.butStop.Name = "butStop";
            this.butStop.Size = new System.Drawing.Size(86, 34);
            this.butStop.TabIndex = 13;
            this.butStop.Text = "Stop";
            this.butStop.UseVisualStyleBackColor = true;
            this.butStop.Click += new System.EventHandler(this.Stop);
            // 
            // butJump
            // 
            this.butJump.Location = new System.Drawing.Point(356, 420);
            this.butJump.Name = "butJump";
            this.butJump.Size = new System.Drawing.Size(86, 34);
            this.butJump.TabIndex = 14;
            this.butJump.Text = "Jump";
            this.butJump.UseVisualStyleBackColor = true;
            this.butJump.Click += new System.EventHandler(this.Jump);
            // 
            // butHeightUp
            // 
            this.butHeightUp.Location = new System.Drawing.Point(356, 460);
            this.butHeightUp.Name = "butHeightUp";
            this.butHeightUp.Size = new System.Drawing.Size(86, 34);
            this.butHeightUp.TabIndex = 15;
            this.butHeightUp.Text = "Height ++";
            this.butHeightUp.UseVisualStyleBackColor = true;
            this.butHeightUp.Click += new System.EventHandler(this.HeightUp);
            // 
            // butHeightDown
            // 
            this.butHeightDown.Location = new System.Drawing.Point(458, 340);
            this.butHeightDown.Name = "butHeightDown";
            this.butHeightDown.Size = new System.Drawing.Size(86, 34);
            this.butHeightDown.TabIndex = 16;
            this.butHeightDown.Text = "Height --";
            this.butHeightDown.UseVisualStyleBackColor = true;
            this.butHeightDown.Click += new System.EventHandler(this.HeightDown);
            // 
            // butCircle
            // 
            this.butCircle.Location = new System.Drawing.Point(458, 380);
            this.butCircle.Name = "butCircle";
            this.butCircle.Size = new System.Drawing.Size(86, 34);
            this.butCircle.TabIndex = 17;
            this.butCircle.Text = "Circle";
            this.butCircle.UseVisualStyleBackColor = true;
            this.butCircle.Click += new System.EventHandler(this.Circle);
            // 
            // butHelix
            // 
            this.butHelix.Location = new System.Drawing.Point(458, 460);
            this.butHelix.Name = "butHelix";
            this.butHelix.Size = new System.Drawing.Size(86, 34);
            this.butHelix.TabIndex = 18;
            this.butHelix.Text = "Helix";
            this.butHelix.UseVisualStyleBackColor = true;
            this.butHelix.Click += new System.EventHandler(this.Helix);
            // 
            // butFigure8
            // 
            this.butFigure8.Location = new System.Drawing.Point(458, 420);
            this.butFigure8.Name = "butFigure8";
            this.butFigure8.Size = new System.Drawing.Size(86, 34);
            this.butFigure8.TabIndex = 19;
            this.butFigure8.Text = "Figure-8";
            this.butFigure8.UseVisualStyleBackColor = true;
            this.butFigure8.Click += new System.EventHandler(this.Figure8);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(724, 69);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(160, 385);
            this.txtDisplay.TabIndex = 20;
            this.txtDisplay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "Forward Camera:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(350, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 32);
            this.label2.TabIndex = 24;
            this.label2.Text = "Bottom Camera:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(718, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "ReadOuts:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 32);
            this.label4.TabIndex = 26;
            this.label4.Text = "Actions:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(595, 469);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(931, 538);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.butFigure8);
            this.Controls.Add(this.butHelix);
            this.Controls.Add(this.butCircle);
            this.Controls.Add(this.butHeightDown);
            this.Controls.Add(this.butHeightUp);
            this.Controls.Add(this.butJump);
            this.Controls.Add(this.butStop);
            this.Controls.Add(this.butEmergency);
            this.Controls.Add(this.butPitchRight);
            this.Controls.Add(this.butPitchLeft);
            this.Controls.Add(this.butRollRight);
            this.Controls.Add(this.butRollLeft);
            this.Controls.Add(this.butYawDown);
            this.Controls.Add(this.butYawUp);
            this.Controls.Add(this.butPitchDown);
            this.Controls.Add(this.butPitchUp);
            this.Controls.Add(this.butHover);
            this.Controls.Add(this.butLand);
            this.Controls.Add(this.butTakeOff);
            this.Controls.Add(this.butStart);
            this.Name = "Form1";
            this.Text = "Drone Interface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.Button butTakeOff;
        private System.Windows.Forms.Button butLand;
        private System.Windows.Forms.Button butHover;
        private System.Windows.Forms.Button butPitchUp;
        private System.Windows.Forms.Button butPitchDown;
        private System.Windows.Forms.Button butYawUp;
        private System.Windows.Forms.Button butYawDown;
        private System.Windows.Forms.Button butRollLeft;
        private System.Windows.Forms.Button butRollRight;
        private System.Windows.Forms.Button butPitchLeft;
        private System.Windows.Forms.Button butPitchRight;
        private System.Windows.Forms.Button butEmergency;
        private System.Windows.Forms.Button butStop;
        private System.Windows.Forms.Button butJump;
        private System.Windows.Forms.Button butHeightUp;
        private System.Windows.Forms.Button butHeightDown;
        private System.Windows.Forms.Button butCircle;
        private System.Windows.Forms.Button butHelix;
        private System.Windows.Forms.Button butFigure8;
        private System.Windows.Forms.TextBox txtDisplay;
       /* private AxMSVidCtlLib.AxMSVidCtl axMSVidCtl1;
        private AxMSVidCtlLib.AxMSVidCtl axMSVidCtl2; */
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}