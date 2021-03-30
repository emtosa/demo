using System;
using System.IO;

namespace CsvSplitDemo
{
    /// <summary>
    /// Tool for splitting CSV files at a certain byte size on a line break.
    /// </summary>
    internal class CsvSplitTool
    {
        /// <summary>
        /// Split CSV files on line breaks before a certain size in bytes.
        /// </summary>
        internal static void SplitCsv(string file, string prefix, int size)
        {
            string[] arr = System.IO.File.ReadAllLines(file);
            string header = string.Empty;

            int total = 0;
            int num = 0;
            var writer = new System.IO.StreamWriter(GetFileName(prefix, num));

            // loop through all source lines
            for (int i = 0; i < arr.Length; i++)
            {
                // current line
                string line = arr[i];
                // length of current line
                int length = line.Length;

                // see if adding this line would exceed the size threshold
                if (total + length >= size)
                {
                    // create a new file
                    num++;
                    total = 0;
                    writer.Dispose();
                    writer = new System.IO.StreamWriter(GetFileName(prefix, num));
                    header = arr[0];
                    writer.WriteLine(header);
                }
                // write the line to the current file
                writer.WriteLine(line);

                // add length of line in bytes to running size
                total += length;

                // add size of newlines
                total += Environment.NewLine.Length;
            }
            writer.Dispose();
        }

        private static string GetFileName(string prefix, int num)
        {
            return prefix + "_" + num.ToString("00") + ".csv";
        }
    }
}