using ARDC = AR.Drone.Client;
using ARDCC = AR.Drone.Client.Command;

namespace DroneProject2.src.controller
{
    class DroneController_API
    {
        //Client Constants
        private static string _hostname = "192.168.1.1";
        private static ARDC.DroneClient _client;

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
        public bool IsDroneConnected = _client.IsConnected;

        /// <summary>
        /// Checks to see if the drone is activated
        /// </summary>
        public bool IsDroneActive = _client.IsActive;

        /// <summary>
        /// Gives a float to specify current battery levels.
        /// </summary>
        public float DroneBatteryPercentage = _client.NavigationData.Battery.Percentage;

        /// <summary>
        /// Checks the battery condition to see if the drone is at critical battery levels.
        /// </summary>
        public bool IsDroneBatteryLow = _client.NavigationData.Battery.Low;

        /// <summary>
        /// Returns the current altitude from the drone. (Meters)
        /// </summary>
        public float DroneAltitude = _client.NavigationData.Altitude;

        /// <summary>
        /// Returns the quality of the wireless signal on the drone. 
        /// </summary>
        public float DroneWIFIQuality = _client.NavigationData.Wifi.LinkQuality;

        /// <summary>
        /// Returns the status of the Magneto Offset along the X axis
        /// </summary>
        public float DroneMagnetoOffsetX = _client.NavigationData.Magneto.Offset.X;

        /// <summary>
        /// Returns the status of the Magneto Offset along the Y axis
        /// </summary>
        public float DroneMagnetoOffsetY = _client.NavigationData.Magneto.Offset.Y;

        /// <summary>
        /// Returns the status of the Magneto Offset along the Z axis
        /// </summary>
        public float DroneMagnetoOffsetZ = _client.NavigationData.Magneto.Offset.Z;

        /// <summary>
        /// Returns the status of the Magneto Rectified along the X axis
        /// </summary>
        public float DroneMagnetoRectifiedX = _client.NavigationData.Magneto.Rectified.X;

        /// <summary>
        /// Returns the status of the Magneto Rectified along the Y axis
        /// </summary>
        public float DroneMagnetoRectifiedY = _client.NavigationData.Magneto.Rectified.Y;

        /// <summary>
        /// Returns the status of the Magneto Rectified along the Z axis
        /// </summary>
        public float DroneMagnetoRectifiedZ = _client.NavigationData.Magneto.Rectified.Z;

        /// <summary>
        /// Returns the current Pitch value of the Drone (Radians - Y axis)
        /// </summary>
        public float DronePitch = _client.NavigationData.Pitch;

        /// <summary>
        /// Returns the current Roll value of the Drone (Radians - X axis)
        /// </summary>
        public float DroneRoll = _client.NavigationData.Roll;

        /// <summary>
        /// Returns the current Yaw value of the Drone (Radians - Z axis)
        /// </summary>
        public float DroneYaw = _client.NavigationData.Yaw;

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
        public AR.Drone.Data.Navigation.NavigationState DroneNavigationState = _client.NavigationData.State;

        /// <summary>
        /// Drone Flight Time (seconds)
        /// </summary>
        public float DroneTime = _client.NavigationData.Time;

        /// <summary>
        /// Drone's Velocity along the X axis
        /// </summary>
        public float DroneVelocityX = _client.NavigationData.Velocity.X;

        /// <summary>
        /// Drone's Velocity along the Y axis
        /// </summary>
        public float DroneVelocityY = _client.NavigationData.Velocity.Y;

        /// <summary>
        /// Drone's Velocity along the Z axis
        /// </summary>
        public float DroneVelocityZ = _client.NavigationData.Velocity.Z;

        /// <summary>
        /// Drone's Video Frame Number.
        /// </summary>
        public uint DroneVideoFrame = _client.NavigationData.Video.FrameNumber;


        //------------------------------------              Drone Control Methods and Properties.       ------------------------------------------\\

        public DroneController_API()
        {
            //setup the client with the current details.
            _client = new ARDC.DroneClient(_hostname);
        }

        /// <summary>
        /// Starts the worker loops on the drone and activates the drone for commands.
        /// </summary>
        public void Start()
        {
            _client.Start();
        }

        /// <summary>
        /// Sets the default height and pushes the drone to 1 meter.
        /// </summary>
        public void Takeoff()
        {
            _client.Takeoff();
        }

        /// <summary>
        /// Performs a "slow descend" to the ground
        /// </summary>
        public void Land()
        {
            _client.Land();
        }

        /// <summary>
        /// Use this command while the Drone is on a flat surface to perform a calibration. (Use after emergency landing or sudden stops)
        /// </summary>
        public void FlatTrim()
        {
            _client.FlatTrim();
        }

        /// <summary>
        /// Kills power to the drones motors instantly.
        /// </summary>
        public void Emergency()
        {
            _client.Emergency();
        }

        /// <summary>
        /// This command will reset the Emergency Status on the drone. Please use flat trim command after this.
        /// </summary>
        public void ResetEmergency()
        {
            _client.ResetEmergency();
        }

        /// <summary>
        /// Allows the drone to be set in a "Default State".
        /// </summary>
        public void Hover()
        {
            _client.Hover();
        }

        /// <summary>
        /// Effective Shutdown of the drone.
        /// </summary>
        public void Stop()
        {
            _client.Stop();
        }

        /// <summary>
        /// Front and Back Tilt Directional Movement.
        /// </summary>
        /// <param name="direction">If True -> Move Forwards (Default), else Move Backwards</param>
        /// <param name="val">Float: Default is the pitchval constant.</param>
        public void Pitch(bool direction = true, float val = _pitchval)
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
        public void Roll(bool direction = true, float val = _rollval)
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
        public void Gaz(bool direction = true, float val = _gazval)
        {
            if (direction)
                _client.Progress(_flightMode, gaz: val);
            else
                _client.Progress(_flightMode, gaz: -val);
        }
    }
}
