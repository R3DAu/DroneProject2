using AR.Drone.Client;

namespace DroneProject2.Commands
{
    /// <summary>
    /// This command allows the drone to Pitch.
    /// </summary>
    public class Yaw : Command
    {
        public Yaw(DroneClient client)
        {
            Client = client;
            Name = "Yaw";
        }

        public override bool Execute(float f = 0.25f)
        {
            Float = f;
            return Execute(MovementType.yaw);
        }
    }
}