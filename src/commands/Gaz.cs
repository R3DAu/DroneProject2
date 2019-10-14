using AR.Drone.Client;

namespace DroneProject2.Commands
{
    /// <summary>
    /// This command allows the drone to Pitch.
    /// </summary>
    public class Gaz : Command
    {
        public Gaz(DroneClient client)
        {
            Client = client;
            Name = "Gaz";
        }

        public void Execute(float f = 0.25f)
        {
            Float = f;
            Execute(MovementType.gaz);
        }
    }
}