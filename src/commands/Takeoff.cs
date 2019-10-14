using System;
using System.Windows.Forms;
using AR.Drone.Client;

namespace DroneProject2.Commands
{
    /// <summary>
    /// This command allows the drone to take off.
    /// </summary>
    public class Takeoff : Command
    {
        public Takeoff(DroneClient client)
        {
            Client = client;
            Name = "Takeoff";
        }

        public bool Execute()
        {
            try
            {
                //make sure the drone is connected before attempting the flight.
                if (CheckAllowedToExecute())
                {
                    Client.Takeoff();
                    Client.Hover();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to perform takeoff", "Command Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
