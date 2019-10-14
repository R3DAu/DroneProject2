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

    public abstract class Command
    {
        protected const ARDC.Command.FlightMode flightMode = ARDC.Command.FlightMode.Progressive;

        public ARDC.DroneClient Client;
        public string Name;
        
        protected float Float;

        protected bool CheckAllowedToExecute()
        {
            if (Client.IsConnected)
                return true;

            return false;
        }

        public virtual bool Execute()
        {
            return false;
        }

        public virtual bool Execute(float f = 0.25f)
        {
            Float = f;
            return false;
        }

        public virtual bool Execute(float roll = 0.25f, float pitch = 0.25f, float yaw = 0.25f, float gaz = 0.25f)
        {
            return false;
        }

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

        public void Load()
        {
            Program.RegisteredCommands.Add(Name, this);
        }
    }
}
