using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace DroneProject2.Controller
{
    public class CommandController
    {
        /// <summary>
        /// This property keeps track of all the loaded Files in the directory.
        /// </summary>
        public List<string> Files = new List<string>();

        /// <summary>
        /// This is a simple Command CSV function structure. 
        /// </summary>
        public struct CommandCSV
        {
            public float Roll { get; set; }
            public float Yaw { get; set; }
            public float Gaz { get; set; }
            public float Pitch { get; set; }
            public int Sleep { get; set; }
        }


        /// <summary>
        /// Internal Thread Worker function to process commands
        /// </summary>
        /// <param name="cmds">List Commands to execute</param>
        internal void ExecuteCommands(List<CommandCSV> cmds)
        {
            foreach (var cmdRow in cmds)
            {
                if (Program.EmergencyTriggered)
                    return; //cancel the thread.

                Program.RegisteredCommands["Custom"].Execute(cmdRow.Roll, cmdRow.Pitch, cmdRow.Yaw, cmdRow.Gaz);

                //if sleep is above 0 then we will trigger the thread to sleep.
                if(cmdRow.Sleep > 0)
                    Thread.Sleep(cmdRow.Sleep);

                //Update the display
                Program.DP2.BeginInvoke(new MethodInvoker(delegate
                    {
                        Program.DP2.MovementLogDataGridBox.Rows.Add(cmdRow.Roll, cmdRow.Pitch, cmdRow.Yaw, cmdRow.Gaz,
                            cmdRow.Sleep);
                    }
                ));
            }
        }

        /// <summary>
        /// This function allows the execution of a CSV format file
        /// </summary>
        /// <param name="file"> The CSV file to execute </param>
        public void ExecuteFile(string file)
        {
            //use the read function below to read the CSV file and extract the 3 variables we need. 
            var cmds = ReadCommandsFromCSV(file);

            if (cmds == null)
                return;

            //throw the commands into the command executor thread.
            Program.DP2.CommandExecutorThread = new Thread(() => ExecuteCommands(cmds));
            Program.DP2.CommandExecutorThread.Start();
        }

        /// <summary>
        /// This function loads all the command CSV files into a list ready for validation.
        /// </summary>
        /// <param name="dir">The directory to use, Default is C:\\DroneData</param>
        public void BootstrapCommandCSVFiles(string @dir = "C:\\DroneData")
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

        /// <summary>
        /// This function reads a command CSV file and returns a List with all the commands in CommandCSV struct
        /// </summary>
        /// <param name="file"> File to read the commands from (Roll, Pitch, Yaw, Gaz) </param>
        /// <returns>CommandCSV List</returns>
        public List<CommandCSV> ReadCommandsFromCSV(string @file)
        {
            using (TextFieldParser csvParser = new TextFieldParser(file))
            {
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                // Skip the row with the column names
                csvParser.ReadLine();

                List<CommandCSV> Rows = new List<CommandCSV>();

                while (!csvParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] fields = csvParser.ReadFields();

                    //create the temporary structures
                    CommandCSV CCSV = new CommandCSV();

                    //make sure there is data
                    if (fields == null)
                    {
                        MessageBox.Show("Unable to parse file. File is empty: " + file,
                            "Error Parsing File", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return null;
                    }

                    //Check to make sure we have all fields...
                    if (fields.Length < 5)
                    {
                        MessageBox.Show("Unable to parse file. Make sure there are 5 fields per row (new line) in: " + file,
                            "Error Parsing File", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        //disable the autopilot UI buttons.
                        Program.DP2.DisableAutoPilotUI();
                        return null;
                    }

                    //roll, pitch, yaw, gaz
                    try
                    {
                        CCSV.Roll  = float.Parse(fields[0]);
                        CCSV.Pitch = float.Parse(fields[1]);
                        CCSV.Yaw   = float.Parse(fields[2]);
                        CCSV.Gaz   = float.Parse(fields[3]);
                        CCSV.Sleep = int.Parse(fields[4]);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Unable to parse file. One or more fields are not a float/int in: " + file,
                            "Error Parsing File", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        //disable the autopilot UI buttons.
                        Program.DP2.DisableAutoPilotUI();
                        return null;
                    }
                    
                    Rows.Add(CCSV);
                }
                return Rows;
            }
        }
    }
}
