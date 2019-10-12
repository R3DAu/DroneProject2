using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace DroneProject2.src.controller
{
    public class CSVReader
    {
        public List<string> files = new List<string>();  
        private const string data = @"C:\data\test.csv";

        public bool AutoPilotIsAllowed = true;

        internal void ExecuteCommands(List<CSVCMD> cmds)
        {
            foreach (var cmdRow in cmds)
            {
                if (Program.EmergencyTriggered)
                    return; //cancel the thread.

                //set defaults

                CSVFunction movement = CSVFunction.NULL;
                bool direction = false;
                float f = 0;

                movement = CSVFunctions.CSVStringEnums[cmdRow.Movement];
                direction = cmdRow.Direction;
                f = cmdRow.Float;

                CSVFunctions.dir = direction;
                CSVFunctions.f = f;

                //call method.
                CSVFunctions.CSVEnumFunctions[movement]();
            }

            //execute the land command.
            CSVFunctions.CSVEnumFunctions[CSVFunctions.CSVStringEnums["LAND"]]();

            return;
        }


        /// <summary>
        /// This function allows the execution of a CSV format file
        /// </summary>
        /// <param name="file"> The CSV file to execute </param>
        public void Execute_File(string file)
        {
            //use the read function below to read the CSV file and extract the 3 variables we need. 
            var cmds = Read(file);

            if (cmds == null)
                return;
              
            //throw the commands into the command executor thread.
            Program.DP2.CommandExecutorThread = new Thread( () => ExecuteCommands(cmds));
            Program.DP2.CommandExecutorThread.Start();
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

        /// This function reads all the lines into a dictionary array.
        /// </summary>
        /// <param name="file">The file to read in</param>
        /// <returns> A Dictionary of the data </returns>
        public List<CSVCMD> Read(string file = data)
        {
            using (TextFieldParser csvParser = new TextFieldParser(file))
            {
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                // Skip the row with the column names
                csvParser.ReadLine();

                List<CSVCMD> Rows = new List<CSVCMD>();

                while (!csvParser.EndOfData)
                {
                    Dictionary<string, string> Row = new Dictionary<string, string>();
                    // Read current line fields, pointer moves to the next line.
                    string[] fields = csvParser.ReadFields();

                    if(fields[0] == null || fields[1] == null || fields[2] == null)
                    {
                        AutoPilotIsAllowed = false;
                        MessageBox.Show("Null Field/s In: " + file);
                        return null;
                    }

                    CSVCMD c = new CSVCMD();
                    //validate the fields. 
                    if (!CSVFunctions.CSVStringEnums.ContainsKey(fields[0]))
                    {
                        AutoPilotIsAllowed = false;
                        MessageBox.Show("Invalid Movement Field In: " + file);
                        return null;
                    }

                    c.Movement = fields[0];

                    try
                    {
                        c.Direction = bool.Parse(fields[1]);
                    }
                    catch (Exception)
                    {
                        AutoPilotIsAllowed = false;
                        MessageBox.Show("Invalid Direction Field In: " + file);
                        return null;
                    }

                    try
                    {
                        c.Float = float.Parse(fields[2]);
                    }
                    catch (Exception)
                    {
                        AutoPilotIsAllowed = false;
                        MessageBox.Show("Invalid Direction Field In: " + file);
                        return null;
                    }

                    Rows.Add(c);
                }

                return Rows;
            }
        }
    }
}
