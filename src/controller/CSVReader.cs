using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace DroneProject2.src.controller
{
    public class CSVReader
    {
        private const string data = @"C:\data\test.csv";

        public Dictionary<int, Dictionary<string, string>> Read()
        {
            using (TextFieldParser csvParser = new TextFieldParser(data))
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
                        Row.Add("Float", fields[1]);
                        Row.Add("Check", fields[2]);
                    }

                    Rows.Add(x, Row);
                    x = x + 1;
                }

                return Rows;
            }
        }
    }
}
