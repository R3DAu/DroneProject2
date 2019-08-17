using ARDC = AR.Drone.Client;
using ARDCC = AR.Drone.Client.Command;

namespace DroneProject2.src.controller
{
    public static class DroneController_API
    {
        //Client Constants
        private static string _hostname = "192.168.1.1";
        public static ARDC.DroneClient _client = new ARDC.DroneClient(_hostname);

        //set the flightmode
        private const ARDCC.FlightMode _flightMode = ARDCC.FlightMode.Progressive;

        //now adjust the other constants.
        private const float _yawval   = 0.25f;
        private const float _gazval   = 0.25f;
        private const float _rollval  = 0.05f;
        private const float _pitchval = 0.05f;

        //------------------------------------              status commands and properties.       ------------------------------------------\\

        /// <summary>
        /// Checks if the drone is still connected.
        /// </summary>
        public static bool IsDroneConnected = _client.IsConnected;

        /// <summary>
        /// Checks to see if the drone is activated
        /// </summary>
        public static bool IsDroneActive = _client.IsActive;

        /// <summary>
        /// Gives a float to specify current battery levels.
        /// </summary>
        public static float DroneBatteryPercentage = _client.NavigationData.Battery.Percentage;

        /// <summary>
        /// Checks the battery condition to see if the drone is at critical battery levels.
        /// </summary>
        public static bool IsDroneBatteryLow = _client.NavigationData.Battery.Low;

        /// <summary>
        /// Returns the current altitude from the drone. (Meters)
        /// </summary>
        public static float DroneAltitude = _client.NavigationData.Altitude;

        /// <summary>
        /// Returns the quality of the wireless signal on the drone. 
        /// </summary>
        public static float DroneWIFIQuality = _client.NavigationData.Wifi.LinkQuality;

        /// <summary>
        /// Returns the status of the Magneto Offset along the X axis
        /// </summary>
        public static float DroneMagnetoOffsetX = _client.NavigationData.Magneto.Offset.X;

        /// <summary>
        /// Returns the status of the Magneto Offset along the Y axis
        /// </summary>
        public static float DroneMagnetoOffsetY = _client.NavigationData.Magneto.Offset.Y;

        /// <summary>
        /// Returns the status of the Magneto Offset along the Z axis
        /// </summary>
        public static float DroneMagnetoOffsetZ = _client.NavigationData.Magneto.Offset.Z;

        /// <summary>
        /// Returns the status of the Magneto Rectified along the X axis
        /// </summary>
        public static float DroneMagnetoRectifiedX = _client.NavigationData.Magneto.Rectified.X;

        /// <summary>
        /// Returns the status of the Magneto Rectified along the Y axis
        /// </summary>
        public static float DroneMagnetoRectifiedY = _client.NavigationData.Magneto.Rectified.Y;

        /// <summary>
        /// Returns the status of the Magneto Rectified along the Z axis
        /// </summary>
        public static float DroneMagnetoRectifiedZ = _client.NavigationData.Magneto.Rectified.Z;

        /// <summary>
        /// Returns the current Pitch value of the Drone (Radians - Y axis)
        /// </summary>
        public static float DronePitch = _client.NavigationData.Pitch;

        /// <summary>
        /// Returns the current Roll value of the Drone (Radians - X axis)
        /// </summary>
        public static float DroneRoll = _client.NavigationData.Roll;

        /// <summary>
        /// Returns the current Yaw value of the Drone (Radians - Z axis)
        /// </summary>
        public static float DroneYaw = _client.NavigationData.Yaw;

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
        public static AR.Drone.Data.Navigation.NavigationState DroneNavigationState = _client.NavigationData.State;

        /// <summary>
        /// Drone Flight Time (seconds)
        /// </summary>
        public static float DroneTime = _client.NavigationData.Time;

        /// <summary>
        /// Drone's Velocity along the X axis
        /// </summary>
        public static float DroneVelocityX = _client.NavigationData.Velocity.X;

        /// <summary>
        /// Drone's Velocity along the Y axis
        /// </summary>
        public static float DroneVelocityY = _client.NavigationData.Velocity.Y;

        /// <summary>
        /// Drone's Velocity along the Z axis
        /// </summary>
        public static float DroneVelocityZ = _client.NavigationData.Velocity.Z;

        /// <summary>
        /// Drone's Video Frame Number.
        /// </summary>
        public static uint DroneVideoFrame = _client.NavigationData.Video.FrameNumber;


        //------------------------------------              Drone Control Methods and Properties.       ------------------------------------------\\

      

        /// <summary>
        /// Starts the worker loops on the drone and activates the drone for commands.
        /// </summary>
        public static void Start()
        {
            _client.Start();
        }

        /// <summary>
        /// Sets the default height and pushes the drone to 1 meter.
        /// </summary>
        public static void Takeoff()
        {
            _client.Takeoff();
        }

        /// <summary>
        /// Performs a "slow descend" to the ground
        /// </summary>
        public static void Land()
        {
            _client.Land();
        }

        /// <summary>
        /// Use this command while the Drone is on a flat surface to perform a calibration. (Use after emergency landing or sudden stops)
        /// </summary>
        public static void FlatTrim()
        {
            _client.FlatTrim();
        }

        /// <summary>
        /// Kills power to the drones motors instantly.
        /// </summary>
        public static void Emergency()
        {
            _client.Emergency();
        }

        /// <summary>
        /// This command will reset the Emergency Status on the drone. Please use flat trim command after this.
        /// </summary>
        public static void ResetEmergency()
        {
            _client.ResetEmergency();
        }

        /// <summary>
        /// Allows the drone to be set in a "Default State".
        /// </summary>
        public static void Hover()
        {
            _client.Hover();
        }

        /// <summary>
        /// Effective Shutdown of the drone.
        /// </summary>
        public static void Stop()
        {
            _client.Stop();
        }

        /// <summary>
        /// Front and Back Tilt Directional Movement.
        /// </summary>
        /// <param name="direction">If True -> Move Forwards (Default), else Move Backwards</param>
        /// <param name="val">Float: Default is the pitchval constant.</param>
        public static void Pitch(bool direction = true, float val = _pitchval)
        {
            if (direction)
                _client.Progress(_flightMode, pitch: val);
            else
                _client.Progress(_flightMode, pitch: -val);
        }

        /// <summary>
        /// Roll Left and Right Directional Movement.
        /// </summary>
        /// <param name="direction">If True -> Roll Left (Default), else Roll Right</param>
        /// <param name="val">Float: Default is the rollval constant.</param>
        public static void Roll(bool direction = true, float val = _rollval)
        {
            if (direction)
                _client.Progress(_flightMode, roll: -val);
            else
                _client.Progress(_flightMode, roll: val);
        }

        /// <summary>
        /// Height Directional Movement.
        /// </summary>
        /// <param name="direction">If True -> Ascend (Default), else descend</param>
        /// <param name="val">Float: Default is the gazval constant.</param>
        public static void Gaz(bool direction = true, float val = _gazval)
        {
            if (direction)
                _client.Progress(_flightMode, gaz: val);
            else
                _client.Progress(_flightMode, gaz: -val);
        }
    }
}
