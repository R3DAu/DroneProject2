using AR.Drone.Client;
using System;
using System.Windows.Forms;
using System.Threading; 

using ATeam_DroneController.src;

namespace ARDrone2_Controller
{
    public partial class Form1 : Form
    {
        private api _a;

        // public Controller
        public Form1()
        {
            _a = new api();

            InitializeComponent();
        }

        private void Start(object sender, EventArgs e)
        {
            _a.Start();
        }

        private void TakeOff(object sender, EventArgs e)
        {
            _a.TakeOff();
        }

        private void Land(object sender, EventArgs e)
        {
            _a.Land();
        }

        private void Hover(object sender, EventArgs e)
        {
            _a.Hover();
        }

        // pitch ++
        private void PitchUp(object sender, EventArgs e)
        {
            _a.PitchForward();
        }


        // pitch --
        private void PitchDown(object sender, EventArgs e)
        {
            _a.PitchBack();
        }

        // yaw ++
        private void YawUp(object sender, EventArgs e)
        {
            _a.Ascend();
        }

        // yaw --
        private void YawDown(object sender, EventArgs e)
        {
            _a.Descend();
        }

        // roll left
        private void RollLeft(object sender, EventArgs e)
        {
            _a.RollLeft();
        }

        // roll right
        private void RollRight(object sender, EventArgs e)
        {
            _a.RollRight();
        }

        // pitch left
        private void PitchLeft(object sender, EventArgs e)
        {
           //?
        }

        // pitch right
        private void PitchRight(object sender, EventArgs e)
        {
         //?   
        }

        // emergency
        private void Emergency(object sender, EventArgs e)
        {
            _a.Emergency();
        }

        // stop
        private void Stop(object sender, EventArgs e)
        {
            _a.Stop();
        }

        // jump
        private void Jump(object sender, EventArgs e)
        {
            _a.Jump();
        }

        // Height ++
        private void HeightUp(object sender, EventArgs e)
        {
            _a.Ascend();
        }

        // height --
        private void HeightDown(object sender, EventArgs e)
        {
            _a.Descend();
        }

        // fly a circle 
        private void Circle(object sender, EventArgs e)
        {

        }

        // Figure-8
        private void Figure8(object sender, EventArgs e)
        {

        }

        // Helix
        private void Helix(object sender, EventArgs e)
        {

        }

        // Readout screen
        // drone angles and altitude and battery level
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //battery level
            var percentage = _a.DroneBatteryPercentage;
            txtDisplay.Text = "The battery percentage " + percentage.ToString();
            //connection
            if (_a.IsDroneConnected)
            {
                txtDisplay.Text = " Drone Connected: " + _a.IsDroneConnected;
            }
            // drone angles
            // do something here
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
