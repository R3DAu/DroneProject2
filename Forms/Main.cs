using System;
using System.Windows.Forms;
using DroneProject2.src.controller;
using DVAPI = DroneProject2.src.controller.DroneVideo_API;
using DCAPI = DroneProject2.Controller.DroneController_API;
using System.Threading;
using DroneProject2.Controller;

namespace DroneProject2
{
    public partial class DroneProject2 : Form
    {
        public static AR.Drone.Client.DroneClient DC = Program.DClient;
        public Thread CommandExecutorThread;
        public CommandController ComController = new CommandController();

        public DroneProject2()
        {
            InitializeComponent();
            
            //let's bind some video events.
            DVAPI.VideoWorkerBinder();

            DC.NavigationPacketAcquired += DVAPI.OnNavigationPacketAcquired;
            DC.VideoPacketAcquired += DVAPI.OnVideoPacketAcquired;

            //rebind the nav data
            DC.NavigationDataAcquired += data => DVAPI.NavigationData = data;
            
            //start all the timers.
            VideoUpdate_Tick.Enabled = true;
            StatusTick.Enabled = true;

            //now drop the video packet decoder worker if it registers an issue. 
            DVAPI.VideoPacketDecoderWorker.UnhandledException += UnhandledException;

            //We will load files here.
            ComController.BootstrapCommandCSVFiles();
        }

        private void DroneProject2_Load(object sender, EventArgs e)
        {
            Text += Environment.Is64BitProcess ? " [64-bit]" : " [32-bit]";

            //update the file list in the display
            foreach (var file in ComController.Files)
                APFilesCombo.Items.Add(file);
        }

        public void DisableAutoPilotUI()
        {
            ExecuteCSVButton.Enabled = false;
            APFilesCombo.Enabled = false;
        }

        public void EnableAutoPilotUI()
        {
            ExecuteCSVButton.Enabled = true;
            APFilesCombo.Enabled = true;
        }

        private void UnhandledException(object sender, Exception exception)
        {
            MessageBox.Show(exception.ToString(), "Unhandled Exception (Ctrl+C)", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        protected override void OnClosed(EventArgs e)
        {
            DVAPI.VideoPacketDecoderWorker.Dispose();
            DC.Dispose();
            base.OnClosed(e);
        }

        private void VideoUpdate_Tick_Tick(object sender, EventArgs e)
        {
            DVAPI.VideoTimerTick();
            videoInput.Image = DVAPI.FrameBitmap;
        }

     

        private void StartButton_Click(object sender, EventArgs e)
        {
            DCAPI.Start();
            //automatically do the flat trim on startup.
            DCAPI.FlatTrim();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            DCAPI.Stop();
        }

        private void TakeOffButton_Click(object sender, EventArgs e)
        {
            Program.RegisteredCommands["TakeOff"].Execute();
        }

        private void LandButton_Click(object sender, EventArgs e)
        {
            Program.RegisteredCommands["Land"].Execute();
        }

        private void EmergencyButton_Click(object sender, EventArgs e)
        {
            DCAPI.Emergency();
        }

        private void ResetEmergencyButton_Click(object sender, EventArgs e)
        {
            DCAPI.ResetEmergency();
            //automatically redo the flat trim.
            DCAPI.FlatTrim();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            Program.RegisteredCommands["Gaz"].Execute();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            Program.RegisteredCommands["Gaz"].Execute(-0.25f);
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            Program.RegisteredCommands["Pitch"].Execute(0.25f);
        }

        private void BackwardsButton_Click(object sender, EventArgs e)
        {
            Program.RegisteredCommands["Pitch"].Execute(-0.25f);
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            Program.RegisteredCommands["Yaw"].Execute(0.25f);
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            Program.RegisteredCommands["Yaw"].Execute(-0.25f);
        }

        private void StatusTick_Tick(object sender, EventArgs e)
        {
            //force the API to pull the current status values in.
            DCAPI.UpdateStatus();

            //update the state and the connected text boxes
            StateBox.Text = DCAPI.DroneNavigationState.ToString();
            ConnectedBox.Text = DCAPI.IsDroneConnected.ToString();

            //update the battery levels and progress percentages
            BatteryLevelPBLower.Value = int.Parse(DCAPI.DroneBatteryPercentage.ToString());
            BatteryPercentageLabel.Text = DCAPI.DroneBatteryPercentage.ToString() + "%";

            //update the wireless quality and percentages.
            WifiQualityPB.Value = int.Parse(DCAPI.DroneWIFIQuality.ToString()) * 100;
            WifiQualityPercentageLabel.Text = (int.Parse(DCAPI.DroneWIFIQuality.ToString()) * 100).ToString() + "%";

            //deal with the flight stats. Need to round off the floats to make it look good.
            MagnetoOffsetXBox.Text = Math.Round(DCAPI.DroneMagnetoOffsetX, 2).ToString();
            MagnetoOffsetYBox.Text = Math.Round(DCAPI.DroneMagnetoOffsetY, 2).ToString();
            MagnetoOffsetZBox.Text = Math.Round(DCAPI.DroneMagnetoOffsetZ, 2).ToString();

            MagnetoRectifiedXBox.Text = Math.Round(DCAPI.DroneMagnetoRectifiedX, 2).ToString();
            MagnetoRectifiedYBox.Text = Math.Round(DCAPI.DroneMagnetoRectifiedY, 2).ToString();
            MagnetoRectifiedZBox.Text = Math.Round(DCAPI.DroneMagnetoRectifiedZ, 2).ToString();

            VelocityXBox.Text = Math.Round(DCAPI.DroneVelocityX, 2).ToString();
            VelocityYBox.Text = Math.Round(DCAPI.DroneVelocityY, 2).ToString();
            VelocityZBox.Text = Math.Round(DCAPI.DroneVelocityZ, 2).ToString();

            RollBox.Text = Math.Round(DCAPI.DroneRoll, 2).ToString();
            PitchBox.Text = Math.Round(DCAPI.DronePitch, 2).ToString();
            AltitudeBox.Text = Math.Round(DCAPI.DroneAltitude, 2).ToString() + "M";
            YawBox.Text = Math.Round(DCAPI.DroneYaw, 2).ToString();

            //add useless stats.
            TimeLabel.Text = TimeSpan.FromMilliseconds((DCAPI.DroneTime / 1000)).ToString(@"hh\:mm\:ss");
            VideoFrameNumberLabel.Text = DCAPI.DroneVideoFrame.ToString();
        }

        private void HoverButton_Click(object sender, EventArgs e)
        {
            DCAPI.Hover();
        }

        private void ExecuteCSVButton_Click(object sender, EventArgs e)
        {
            //we need whatever selected file is in the list. 
            var file = APFilesCombo.SelectedItem.ToString();
            MovementLogDataGridBox.Rows.Clear();
            ComController.ExecuteFile(file);
        }

        private void MovementLogDataGridBox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
