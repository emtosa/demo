using System;
using System.IO;
using System.IO.Compression;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream zipToOpen = new FileStream(@"C:\emtosa\demo\Samples\ZipArchiveDemo\ConsoleApp\release.zip", FileMode.OpenOrCreate))
            {
                using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                {
                    ZipArchiveEntry readmeEntry = archive.CreateEntry("Readme.txt");
                    using (StreamWriter writer = new StreamWriter(readmeEntry.Open()))
                    {
                        writer.WriteLine("Information about this package");
                        writer.WriteLine("==============================");
                    }
                }
            }
        }
    }
}
