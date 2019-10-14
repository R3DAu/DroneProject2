using AR.Drone.Client;

namespace DroneProject2.Commands
{
    /// <summary>
    /// This command allows the drone to Roll.
    /// </summary>
    public class Roll : Command
    {
        public Roll(DroneClient client)
        {
            Client = client;
            Name = "Roll";
        }

        public void Execute(float f = 0.25f)
        {
            Float = f;
            Execute(MovementType.roll);
        }
    }
}