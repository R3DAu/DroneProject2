using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        /// Sets the directory path for where the CSV files are.
        /// </summary>
        public static string directory = @"C:\\DroneData\\";

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
            //start execution timer
            Stopwatch ExecutionTime = Stopwatch.StartNew();

            //make sure the drone is not in a flying state
            if (Program.DClient.NavigationData.State != AR.Drone.Data.Navigation.NavigationState.Flying) {
                //We will do flattrim and then take off.
                Program.DClient.FlatTrim();
                Program.RegisteredCommands["Takeoff"].Execute();

                //wait for the drone to finish taking off.
                Thread.Sleep(5000);
            }

            foreach (var cmdRow in cmds)
            {
                //start command timer
                Stopwatch cmdTime = Stopwatch.StartNew();

                if (Program.EmergencyTriggered)
                    return; //cancel the thread.

                //if sleep < 0 then trigger and
                if (cmdRow.Sleep < 0)
                    Program.RegisteredCommands["Land"].Execute();

                //check for hover
                if(cmdRow.Roll == 0 && cmdRow.Pitch == 0 && cmdRow.Yaw == 0 && cmdRow.Gaz == 0)
                    Program.DClient.Hover();
                else
                    Program.RegisteredCommands["Custom"].Execute(cmdRow.Roll, cmdRow.Pitch, cmdRow.Yaw, cmdRow.Gaz);

                //if sleep is above 0 then we will trigger the thread to sleep.
                if(cmdRow.Sleep > 0)
                    Thread.Sleep(cmdRow.Sleep);

                //Update the display
                Program.DP2.BeginInvoke(new MethodInvoker(delegate
                    {
                        //publish timers
                        Program.DP2.TotalExecutionTimeLabel2.Text = (ExecutionTime.ElapsedMilliseconds / 1000.0).ToString();
                        Program.DP2.LastcmdTimeLabel2.Text = (cmdTime.ElapsedMilliseconds / 1000.0).ToString();

                        //push into the Movement Log DataGridBox
                        Program.DP2.MovementLogDataGridBox.Rows.Add(cmdRow.Roll, cmdRow.Pitch, cmdRow.Yaw, cmdRow.Gaz, cmdRow.Sleep);

                        //check to see if there is more than 2 items in the row then deselect the second last row.
                        if(Program.DP2.MovementLogDataGridBox.Rows.Count > 1)
                            Program.DP2.MovementLogDataGridBox.Rows[Program.DP2.MovementLogDataGridBox.Rows.Count - 2].Selected = false;

                        //Select the last row.
                        Program.DP2.MovementLogDataGridBox.Rows[Program.DP2.MovementLogDataGridBox.Rows.Count - 1].Selected = true;

                        //Scroll to the last (first) index that selected.
                        Program.DP2.MovementLogDataGridBox.FirstDisplayedScrollingRowIndex = Program.DP2.MovementLogDataGridBox.SelectedRows[0].Index;
                    }
                ));

                //stop the command timer
                cmdTime.Stop();
            }

            //stop the execution timer.
            ExecutionTime.Stop();

            //Update the display
            Program.DP2.BeginInvoke(new MethodInvoker(delegate
            {
                //publish timers
                Program.DP2.TotalExecutionTimeLabel2.Text = (ExecutionTime.ElapsedMilliseconds / 1000.0).ToString();

                //now we can renable the UI
                Program.DP2.EnableAutoPilotUI();
                Program.DP2.EnableManualUI();
            }
            
            ));
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
            //start the thread (this is important to do... otherwise it does nothing...)
            Program.DP2.CommandExecutorThread.Start();
        }

        /// <summary>
        /// This function loads all the command CSV files into a list ready for validation.
        /// </summary>
        /// <param name="dir">The directory to use, Default is C:\\DroneData</param>
        public void BootstrapCommandCSVFiles(string @dir = "C:\\DroneData\\")
        {
            //make sure the directory is set properly. We will add this back later on.
            directory = dir;

            //checks if the data directory exists. Will exit the program if this directory doesn't exist.
            if (!Directory.Exists(dir))
            {
                MessageBox.Show(dir + " was not found. Please create it first.");
                Environment.Exit((int)new System.ComponentModel.Int32Converter().ConvertFromString("0x80070002"));
                return;
            }

            //pull the files in the directory specified.
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
