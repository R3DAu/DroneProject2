﻿using AR.Drone.Client;

namespace DroneProject2.Commands
{
    /// <summary>
    /// This command allows the drone to Pitch.
    /// </summary>
    public class Pitch : Command
    {
        public Pitch(DroneClient client)
        {
            Client = client;
            Name = "Pitch";
        }

        public void Execute(float f = 0.25f)
        {
            Float = f;
            Execute(MovementType.pitch);
        }
    }
}
