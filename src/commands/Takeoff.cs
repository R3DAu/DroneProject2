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
            //set the controller client.
            Client = client;

            //set the command name for assignment and identification purposes.
            Name = "Takeoff";
        }

        public override bool Execute()
        {
            try
            {
                //make sure the drone is connected before attempting the flight.
                if (CheckAllowedToExecute())
                {
                    //We will reset the Flat Trim upon takeoff
                    Client.FlatTrim();

                    //Now we know where the ground is, Push upwards
                    Client.Takeoff();

                    //Stableize now.
                    Client.Hover();
                }
            }
            catch (Exception)
            {
                //if we cannot do this then we will receive an error
                MessageBox.Show("Unable to perform takeoff", "Command Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
