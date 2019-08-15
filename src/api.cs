using AR.Drone.Client;
using ARDCC = AR.Drone.Client.Command;
using System;
using System.Threading;

namespace ATeam_DroneController.src
{
    public class api
    {
        private DroneClient _client;

        //Flightmode Variable.
        private readonly ARDCC.FlightMode flightMode = ARDCC.FlightMode.Progressive;

        //Flight float adjustment constants.
        const float YAWVAL = 0.25f;
        const float GAZVAL = 0.25f;
        const float ROLLVAL = 0.05f;
        const float PITCHVAL = 0.05f;

        /// <summary>
        /// Constructor Class
        /// </summary>
        public api()
        {
            //setup the drone client.
            _client = new DroneClient();
        }

        /// <summary>
        /// Checks to see if the drone is connected to the computer
        /// </summary>
        public bool IsDroneConnected => _client.IsConnected;

        /// <summary>
        /// Returns battery usage information of the drone
        /// </summary>
        public float DroneBatteryPercentage => _client.NavigationData.Battery.Percentage;

        /// <summary>
        /// Returns whether the battery is low.
        /// </summary>
        public bool DroneBatteryLow => _client.NavigationData.Battery.Low;

        /// <summary>
        /// Lands the drone
        /// </summary>
        /// <returns>Boolean Value whether the command works properly</returns>
        public bool Land()
        {
            try
            {
                _client.Land();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Take off mechanism
        /// </summary>
        /// <returns>Boolean Value whether the command works properly</returns>
        public bool TakeOff()
        {
            try
            {
               _client.Takeoff();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Activates the drone
        /// </summary>
        /// <returns>Boolean Value whether the command works properly</returns>
        public bool Start()
        {
            try
            {
                _client.Start();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Deactivates the drone
        /// </summary>
        /// <returns>Boolean Value whether the command works properly</returns>
        public bool Stop()
        {
            try
            {
                _client.Stop();
                return true;
            }
            catch (Exception)
            {
                return false;
            }  
        }

        /// <summary>
        /// Allows the drone to hover
        /// </summary>
        /// <returns>Boolean Value whether the command works properly</returns>
        public bool Hover()
        {
            try
            {
                _client.Hover();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Pitches the drone forwards
        /// </summary>
        /// <returns>Boolean Value whether the command works properly</returns>
        public bool PitchForward()
        {
            try
            {
                _client.Progress(flightMode, pitch: PITCHVAL);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Pitches the drone backwards
        /// </summary>
        /// <returns>Boolean Value whether the command works properly</returns>
        public bool PitchBack()
        {
            try
            {
                _client.Progress(flightMode, pitch: -PITCHVAL);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Rolls the drone to the left
        /// </summary>
        /// <returns>Boolean Value whether the command works properly</returns>
        public bool RollLeft()
        {
            try
            {
                _client.Progress(flightMode, pitch: -ROLLVAL);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Rolls the drone to the right
        /// </summary>
        /// <returns>Boolean Value whether the command works properly</returns>
        public bool RollRight()
        {
            try
            {
                _client.Progress(flightMode, pitch: ROLLVAL);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        /// <summary>
        /// Adjusts the height of the drone in respect to the surface
        /// </summary>
        /// <returns>Boolean Value whether the command works properly</returns>
        public bool Ascend() //height++
        {
            try
            {
                _client.Progress(flightMode, pitch: GAZVAL);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Lowers the height of the drone in respect to the surface
        /// </summary>
        /// <returns>Boolean Value whether the command works properly</returns>
        public bool Descend() //height--
        {
            try
            {
                _client.Progress(flightMode, pitch: -GAZVAL);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Lands the drone and automatically kills all the power to the engines
        /// </summary>
        /// <returns>Boolean Value whether the command works properly</returns>
        public bool Emergency()
        {
            try
            {
                _client.Emergency();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Resets the drone's emergency mode. 
        /// </summary>
        /// <returns>Boolean Value whether the command works properly</returns>
        public bool ResetEmergency()
        {
            try
            {
                _client.ResetEmergency();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Makes the drone jump. 
        /// </summary>
        /// <returns>Boolean Value whether the command works properly</returns>
        public bool Jump()
        {
            try
            {
                Ascend();
                Thread.Sleep(4000);
                Descend();
                Thread.Sleep(4000);
                Hover();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        

    }
}
