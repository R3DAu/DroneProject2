using System;
using System.Windows.Forms;
using AR.Drone.Data.Navigation;
using ARDC = AR.Drone.Client;

namespace DroneProject2.Commands
{
    public enum MovementType
    {
        roll,
        pitch,
        yaw,
        gaz
    }

    /// <summary>
    /// Abstract Class to mold any commands to a single type.
    /// </summary>
    public abstract class Command
    {
        /// <summary>
        /// Preselected Flightmode
        /// </summary>
        protected const ARDC.Command.FlightMode flightMode = ARDC.Command.FlightMode.Progressive;

        /// <summary>
        /// Drone Client Class (Instead of making a new one every time.
        /// </summary>
        public ARDC.DroneClient Client;

        /// <summary>
        /// Name of the command to identify it
        /// </summary>
        public string Name;
        
        /// <summary>
        /// Float Integer if the command uses one. 
        /// </summary>
        protected float Float;

        /// <summary>
        /// Basic check to see if the PC is connected or not to the drone. 
        /// </summary>
        /// <returns>True if the command can run on the drone</returns>
        protected bool CheckAllowedToExecute()
        {
            if (Client.IsConnected)
                return true;

            return false;
        }

        /// <summary>
        /// Default execute funtion.
        /// </summary>
        /// <returns>False if not implemented.</returns>
        public virtual bool Execute()
        {
            return false;
        }

        /// <summary>
        /// Sets the float value
        /// </summary>
        /// <param name="f">Float Value</param>
        /// <returns>false if the command is not implemented.</returns>
        public virtual bool Execute(float f = 0.25f)
        {
            Float = f;
            return false;
        }

        /// <summary>
        /// Sets custom command values.
        /// </summary>
        /// <param name="roll">Roll float value set to 0.25f by default</param>
        /// <param name="pitch">Pitch float value set to 0.25f by default</param>
        /// <param name="yaw">Yaw float value set to 0.25f by default</param>
        /// <param name="gaz">Gaz float value set to 0.25f by default</param>
        /// <returns>false if the command is not implemented</returns>
        public virtual bool Execute(float roll = 0.25f, float pitch = 0.25f, float yaw = 0.25f, float gaz = 0.25f)
        {
            return false;
        }

        /// <summary>
        /// Internal set type. This allows the basic commands to be set automatically.
        /// </summary>
        /// <param name="mt">Movement Type</param>
        /// <returns>true if executed correctly, false if it failed.</returns>
        public virtual bool Execute(MovementType mt)
        {
            try
            {
                //make sure the drone is connected / is flying before attempting the command.
                if (CheckAllowedToExecute() && Client.NavigationData.State.HasFlag(NavigationState.Flying))
                {
                    switch (mt)
                    {
                        case MovementType.gaz:
                            Client.Progress(flightMode, gaz: Float);
                            break;
                        case MovementType.pitch:
                            Client.Progress(flightMode, pitch: Float);
                            break;
                        case MovementType.roll:
                            Client.Progress(flightMode, roll: Float);
                            break;
                        case MovementType.yaw:
                            Client.Progress(flightMode, yaw: Float);
                            break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to perform Land", "Command Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        /// <summary>
        /// This allows the command to be automatically registered to the RegisteredCommands List.
        /// </summary>
        public void Load()
        {
            Program.RegisteredCommands.Add(Name, this);
        }
    }
}
