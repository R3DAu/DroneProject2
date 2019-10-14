using System;
using System.Windows.Forms;
using AR.Drone.Client;
using AR.Drone.Data.Navigation;

namespace DroneProject2.Commands
{
    /// <summary>
    /// This command allows the drone to Pitch.
    /// </summary>
    public class CustomCommand : Command
    {
        public CustomCommand(DroneClient client)
        {
            Client = client;
            Name = "Custom";
        }

        public override bool Execute(float roll = 0.25f, float pitch = 0.25f, float yaw = 0.25f, float gaz = 0.25f)
        {
            try
            {
                //make sure the drone is connected / is flying before attempting the command.
                if (CheckAllowedToExecute() && Client.NavigationData.State.HasFlag(NavigationState.Flying))
                    Client.Progress(flightMode, roll, pitch, yaw, gaz);
                
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to perform Custom Command", "Command Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}