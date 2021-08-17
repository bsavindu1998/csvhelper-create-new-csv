using System;
using System.Globalization;
using System.IO;
using CsvHelper;

namespace CSVCreate
{
    class Program
    {
        static void Main()
        {
            var csvPath = Path.Combine(Environment.CurrentDirectory, $"Rockets {DateTime.Now.ToFileTime()}.csv");
            using var steamfitter = new StreamWriter(csvPath);
            using var csvWriter = new CsvWriter(steamfitter,CultureInfo.InvariantCulture);
            var rockets = RocketInfo.GetRockets();
            csvWriter.Context.RegisterClassMap<RocketInfoClassMap>();
            csvWriter.WriteRecords(rockets);
        }
    }
}
