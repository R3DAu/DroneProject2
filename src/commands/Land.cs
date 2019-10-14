using System;
using System.Windows.Forms;
using AR.Drone.Client;
using AR.Drone.Data.Navigation;

namespace DroneProject2.Commands
{
    /// <summary>
    /// This command allows the drone to Land.
    /// </summary>
    public class Land : Command
    {
        public Land(DroneClient client)
        {
            Client = client;
            Name = "Land";
        }

        public override bool Execute()
        {
            try
            {
                //make sure the drone is connected / is flying before attempting the command.
                if (CheckAllowedToExecute() && Client.NavigationData.State.HasFlag(NavigationState.Flying))
                    Client.Land();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to perform Land", "Command Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
