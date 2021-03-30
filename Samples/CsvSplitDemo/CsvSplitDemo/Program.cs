using System;

namespace CsvSplitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Segment CSV files into 1 MB chunks.");
            CsvSplitTool.SplitCsv("BilledOneTimeInvoiceLineItems.csv", "BilledOneTimeInvoiceLineItems", 1024 * 1024);
        }
    }
}
