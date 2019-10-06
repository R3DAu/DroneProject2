using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace DroneProject2.src.controller
{
    public class CSVReader
    {
        public List<string> files = new List<string>();  
        private const string data = @"C:\data\test.csv";

        public bool AutoPilotIsAllowed = true;

        /// <summary>
        /// This function allows the execution of a CSV format file
        /// </summary>
        /// <param name="file"> The CSV file to execute </param>
        public void Execute_File(string file)
        {
            //use the read function below to read the CSV file and extract the 3 variables we need. 
            var cmds = Read(file);

            foreach (var cmdRow in cmds)
            {
                CSVFunction movement = CSVFunction.NULL;
                bool direction = false;
                float f = 0;

                bool MovementSet = false;
                bool DirectionSet = false;
                bool FloatSet = false;

                foreach (var cmd in cmdRow.Value)
                {
                    if (cmd.Key == "Movement")
                    {
                        var x = cmd.Value;

                        if (CSVFunctions.CSVStringEnums.ContainsKey(x))
                        {
                            movement = CSVFunctions.CSVStringEnums[x];
                            MovementSet = true;
                        }
                    }

                    if (cmd.Key == "Direction")
                    {
                        direction = bool.Parse(cmd.Value);
                        DirectionSet = true;
                    }

                    if (cmd.Key == "Float")
                    {
                        f = float.Parse(cmd.Value);
                        FloatSet = true;
                    }
                }

                if(!MovementSet || !DirectionSet || !FloatSet)
                {
                    //kill the drone.
                    DroneController_API.Emergency();

                    //send error message.
                    MessageBox.Show("Failure to communicate", "CSV File ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //Disable the autopilot
                    AutoPilotIsAllowed = false;
                    Program.DP2.APFilesCombo.Enabled = false;
                    Program.DP2.ExecuteCSVButton.Enabled = false;

                    //break the foreach
                    break;
                }
                else
                {
                    CSVFunctions.dir = direction;
                    CSVFunctions.f = f;

                    //call method.
                    CSVFunctions.CSVEnumFunctions[movement]();
                }
            }
        }

        //This function loads the directory and all the CSV files within it. 
        public void Load_Files(string dir = @"c:\data\")
        {
            //checks if the data directory exists. Will exit the program if this directory doesn't exist.
            if (!Directory.Exists(dir))
            {
                MessageBox.Show(dir + " was not found. Please create it first.");
                Environment.Exit((int)new System.ComponentModel.Int32Converter().ConvertFromString("0x80070002"));
                return;
            }

            string[] fs = Directory.GetFiles(dir);
            if(fs.Length <= 0)
            {
                MessageBox.Show("There were no files found in: " +dir+ ". Autopilot mode will be disabled.");
                AutoPilotIsAllowed = false;
            }

            foreach (var x in fs)
                files.Add(x);
        }

        /// <summary>
        /// This function verifies the CSV files pre-loaded and makes sure the values are within limits.
        /// </summary>
        /// <returns>True if all the files are verified. False if one or more files failed validation.</returns>
        public bool Verify_CSV_Files()
        {
            foreach (var file in files)
            {
                //read each file
                var commands = Read(file);

                //now that we have all the commands, we need to check if the commands fit within the controlled enums.
                foreach (var commandRow in commands)
                {
                    foreach (var command in commandRow.Value)
                    {
                        //check the movement value.
                        if (command.Key == "Movement")
                        {
                            //check for static command values.
                            if (!CSVFunctions.CSVStringEnums.ContainsKey(command.Value))
                            {
                                AutoPilotIsAllowed = false;
                                return false;
                            }
                        }

                        //check the directional value
                        if(command.Key == "Direction")
                        {
                            try
                            {
                                var x = bool.Parse(command.Value);
                            }
                            catch(Exception)
                            {
                                AutoPilotIsAllowed = false;
                                return false;
                            }
                        }

                        //check the float value
                        if (command.Key == "Float")
                        {
                            try
                            {
                                var x = float.Parse(command.Value);
                            }
                            catch (Exception)
                            {
                                AutoPilotIsAllowed = false;
                                return false;
                            }
                        }
                    }
                }
            }
        return true;
        }


        /// <summary>
        /// This function reads all the lines into a dictionary array.
        /// </summary>
        /// <param name="file">The file to read in</param>
        /// <returns> A Dictionary of the data </returns>
        public Dictionary<int, Dictionary<string, string>> Read(string file = data)
        {
            using (TextFieldParser csvParser = new TextFieldParser(file))
            {
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                // Skip the row with the column names
                csvParser.ReadLine();

                Dictionary<int,Dictionary<string, string>> Rows = new Dictionary<int, Dictionary<string, string>>();
                int x = 0;
                while (!csvParser.EndOfData)
                {
                    Dictionary<string, string> Row = new Dictionary<string, string>();
                    // Read current line fields, pointer moves to the next line.
                    string[] fields = csvParser.ReadFields();
                    if (fields[0] != null)
                    {
                        Row.Add("Movement", fields[0]);
                        Row.Add("Direction", fields[1]);
                        Row.Add("Float", fields[2]);
                    }

                    Rows.Add(x, Row);
                    x = x + 1;
                }

                return Rows;
            }
        }
    }
}
