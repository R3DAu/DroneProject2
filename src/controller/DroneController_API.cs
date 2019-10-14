using System;

namespace DroneProject2.Controller
{
    public static class DroneController_API
    {
        //------------------------------------              status commands and properties.       ------------------------------------------\\

        /// <summary>
        /// Checks if the drone is still connected.
        /// </summary>
        public static bool IsDroneConnected = Program.DClient.IsConnected;

        /// <summary>
        /// Checks to see if the drone is activated
        /// </summary>
        public static bool IsDroneActive = Program.DClient.IsActive;

        /// <summary>
        /// Gives a float to specify current battery levels.
        /// </summary>
        public static float DroneBatteryPercentage = Program.DClient.NavigationData.Battery.Percentage;

        /// <summary>
        /// Checks the battery condition to see if the drone is at critical battery levels.
        /// </summary>
        public static bool IsDroneBatteryLow = Program.DClient.NavigationData.Battery.Low;

        /// <summary>
        /// Returns the current altitude from the drone. (Meters)
        /// </summary>
        public static float DroneAltitude = Program.DClient.NavigationData.Altitude;

        /// <summary>
        /// Returns the quality of the wireless signal on the drone. 
        /// </summary>
        public static float DroneWIFIQuality = Program.DClient.NavigationData.Wifi.LinkQuality;

        /// <summary>
        /// Returns the status of the Magneto Offset along the X axis
        /// </summary>
        public static float DroneMagnetoOffsetX = Program.DClient.NavigationData.Magneto.Offset.X;

        /// <summary>
        /// Returns the status of the Magneto Offset along the Y axis
        /// </summary>
        public static float DroneMagnetoOffsetY = Program.DClient.NavigationData.Magneto.Offset.Y;

        /// <summary>
        /// Returns the status of the Magneto Offset along the Z axis
        /// </summary>
        public static float DroneMagnetoOffsetZ = Program.DClient.NavigationData.Magneto.Offset.Z;

        /// <summary>
        /// Returns the status of the Magneto Rectified along the X axis
        /// </summary>
        public static float DroneMagnetoRectifiedX = Program.DClient.NavigationData.Magneto.Rectified.X;

        /// <summary>
        /// Returns the status of the Magneto Rectified along the Y axis
        /// </summary>
        public static float DroneMagnetoRectifiedY = Program.DClient.NavigationData.Magneto.Rectified.Y;

        /// <summary>
        /// Returns the status of the Magneto Rectified along the Z axis
        /// </summary>
        public static float DroneMagnetoRectifiedZ = Program.DClient.NavigationData.Magneto.Rectified.Z;

        /// <summary>
        /// Returns the current Pitch value of the Drone (Radians - Y axis)
        /// </summary>
        public static float DronePitch = Program.DClient.NavigationData.Pitch;

        /// <summary>
        /// Returns the current Roll value of the Drone (Radians - X axis)
        /// </summary>
        public static float DroneRoll = Program.DClient.NavigationData.Roll;

        /// <summary>
        /// Returns the current Yaw value of the Drone (Radians - Z axis)
        /// </summary>
        public static float DroneYaw = Program.DClient.NavigationData.Yaw;

        /// <summary>
        /// Navigation State:
        /// 0    = Unknown
        /// 1    = Bootstrap
        /// 2    = Landed
        /// 4    = Take off
        /// 8    = Flying
        /// 16   = Hovering
        /// 32   = Landing
        /// 64   = Emergency
        /// 128  = Wind
        /// 256  = Command
        /// 512  = Control
        /// 1024 = Watchdog
        /// </summary>
        public static AR.Drone.Data.Navigation.NavigationState DroneNavigationState = Program.DClient.NavigationData.State;

        /// <summary>
        /// Drone Flight Time (milliseconds)
        /// </summary>
        public static float DroneTime = Program.DClient.NavigationData.Time;

        /// <summary>
        /// Drone's Velocity along the X axis
        /// </summary>
        public static float DroneVelocityX = Program.DClient.NavigationData.Velocity.X;

        /// <summary>
        /// Drone's Velocity along the Y axis
        /// </summary>
        public static float DroneVelocityY = Program.DClient.NavigationData.Velocity.Y;

        /// <summary>
        /// Drone's Velocity along the Z axis
        /// </summary>
        public static float DroneVelocityZ = Program.DClient.NavigationData.Velocity.Z;

        /// <summary>
        /// Drone's Video Frame Number.
        /// </summary>
        public static uint DroneVideoFrame = Program.DClient.NavigationData.Video.FrameNumber;


        //------------------------------------              Drone Control Methods and Properties.       ------------------------------------------\\


        public static void UpdateStatus()
        {
            IsDroneConnected = Program.DClient.IsConnected;
            IsDroneActive = Program.DClient.IsActive;
            DroneBatteryPercentage = Program.DClient.NavigationData.Battery.Percentage;
            IsDroneBatteryLow = Program.DClient.NavigationData.Battery.Low;
            DroneAltitude = Program.DClient.NavigationData.Altitude;
            DroneWIFIQuality = Program.DClient.NavigationData.Wifi.LinkQuality;
            DroneMagnetoOffsetX = Program.DClient.NavigationData.Magneto.Offset.X;
            DroneMagnetoOffsetY = Program.DClient.NavigationData.Magneto.Offset.Y;
            DroneMagnetoOffsetZ = Program.DClient.NavigationData.Magneto.Offset.Z;
            DroneMagnetoRectifiedX = Program.DClient.NavigationData.Magneto.Rectified.X;
            DroneMagnetoRectifiedY = Program.DClient.NavigationData.Magneto.Rectified.Y;
            DroneMagnetoRectifiedZ = Program.DClient.NavigationData.Magneto.Rectified.Z;
            DronePitch = Program.DClient.NavigationData.Pitch;
            DroneRoll = Program.DClient.NavigationData.Roll;
            DroneYaw = Program.DClient.NavigationData.Yaw;
            DroneNavigationState = Program.DClient.NavigationData.State;
            DroneTime = Program.DClient.NavigationData.Time;
            DroneVelocityX = Program.DClient.NavigationData.Velocity.X;
            DroneVelocityY = Program.DClient.NavigationData.Velocity.Y;
            DroneVelocityZ = Program.DClient.NavigationData.Velocity.Z;
            DroneVideoFrame = Program.DClient.NavigationData.Video.FrameNumber;

        }


        /// <summary>
        /// Starts the worker loops on the drone and activates the drone for commands.
        /// </summary>
        public static void Start()
        {
            Program.DClient.Start();
        }

        /// <summary>
        /// Stops the worker loops on the drone and deactivates the drone for commands.
        /// </summary>
        public static void Stop()
        {
            Program.DClient.Stop();
        }

        /// <summary>
        /// Use this command while the Drone is on a flat surface to perform a calibration. (Use after emergency landing or sudden stops)
        /// </summary>
        public static void FlatTrim()
        {
            Program.DClient.FlatTrim();
        }

        /// <summary>
        /// Kills power to the drones motors instantly.
        /// </summary>
        public static void Emergency()
        {
            try
            {
                //set the program to trigger the commands
                Program.EmergencyTriggered = true;
                Program.DP2.CommandExecutorThread.Abort(); //abort that thread.
            }
            catch (Exception)
            {
                //don't do anything.
            }
            finally
            {
                Program.DClient.Emergency();
            }
        }

        /// <summary>
        /// This command will reset the Emergency Status on the drone. Please use flat trim command after this.
        /// </summary>
        public static void ResetEmergency()
        {
            Program.EmergencyTriggered = false;
            Program.DClient.ResetEmergency();
        }

        /// <summary>
        /// Allows the drone to be set in a "Default State".
        /// </summary>
        public static void Hover()
        {
            Program.DClient.Hover();
        }
    }
}
