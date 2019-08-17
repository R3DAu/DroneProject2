using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DVAPI = DroneProject2.src.controller.DroneVideo_API;
using DCAPI = DroneProject2.src.controller.DroneController_API;

namespace DroneProject2
{
    public partial class DroneProject2 : Form
    {
        public static AR.Drone.Client.DroneClient DC = DCAPI._client;

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

            //now drop the video packet decoder worker if it registers an issue. 
            DVAPI.VideoPacketDecoderWorker.UnhandledException += UnhandledException;
        }

        private void DroneProject2_Load(object sender, EventArgs e)
        {
            Text += Environment.Is64BitProcess ? " [64-bit]" : " [32-bit]";
        }

        private void UnhandledException(object sender, Exception exception)
        {
            MessageBox.Show(exception.ToString(), "Unhandled Exception (Ctrl+C)", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
        }

        private void VideoUpdate_Tick_Tick(object sender, EventArgs e)
        {
            DVAPI.VideoTimerTick();
            videoInput.Image = DVAPI.FrameBitmap;
        }
    }
}
