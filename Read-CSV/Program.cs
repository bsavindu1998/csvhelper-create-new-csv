using System;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

namespace Read_CSV
{
    internal class Program
    {
        private static void Main()
        {
            using var streamer = new StreamReader(@"D:\Education\99x\CSV\sample.csv");
            using var csvreader = new CsvReader(streamer,CultureInfo.InvariantCulture);
            csvreader.Context.RegisterClassMap<PersonsMap>();
            var records = csvreader.GetRecords<Persons>().ToList();
            foreach (var n in records)
            {
                Console.WriteLine(n.FirstName+" "+n.LastName);
            }
        }
    }
}
