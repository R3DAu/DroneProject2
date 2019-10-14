using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DroneProject2.Commands;

namespace DroneProject2
{
    static class Program
    {
        public static DroneProject2 DP2;
        public static bool EmergencyTriggered = false;
        public static Dictionary<String, Command> RegisteredCommands = new Dictionary<String, Command>();
        private static string _hostname = "192.168.1.1";
        public static AR.Drone.Client.DroneClient DClient = new AR.Drone.Client.DroneClient(_hostname);

        internal static void LoadCommands()
        {
            new Takeoff(DClient).Load();
            new Land(DClient).Load();
            new CustomCommand(DClient).Load();

            new Pitch(DClient).Load();
            new Yaw(DClient).Load();
            new Roll(DClient).Load();
            new Gaz(DClient).Load();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DP2 = new DroneProject2();

            LoadCommands();

            Application.Run(DP2);
        }
    }
}
