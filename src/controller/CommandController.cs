using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DroneProject2.Controller
{
    class CommandController
    {
        /// <summary>
        /// This property keeps track of all the loaded Files in the directory.
        /// </summary>
        public List<string> Files = new List<string>();

        /// <summary>
        /// This function loads all the command CSV files into a list ready for validation.
        /// </summary>
        /// <param name="dir">The directory to use, Default is C:\\data</param>
        public void BootstrapCommandCSVFiles(string @dir = "C:\\data")
        {
            //checks if the data directory exists. Will exit the program if this directory doesn't exist.
            if (!Directory.Exists(dir))
            {
                MessageBox.Show(dir + " was not found. Please create it first.");
                Environment.Exit((int)new System.ComponentModel.Int32Converter().ConvertFromString("0x80070002"));
                return;
            }

            string[] fs = Directory.GetFiles(dir);
            if (fs.Length <= 0)
            {
                MessageBox.Show("There were no files found in: " + dir + ". Autopilot mode will be disabled.");

                //let's safely disable the form.
                Program.DP2.DisableAutoPilotUI();
            }

            //add the files to the Files list.
            foreach (var x in fs)
                Files.Add(x);
        }

        public void ReadCommandsFromCSV(string @file)
        {

        }
    }
}
