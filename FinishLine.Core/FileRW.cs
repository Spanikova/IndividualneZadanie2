using KBCsv;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public static class FileRW
    {
        private static string _countryCode = "CountryCode";
        private static string _slovakShortName = "SlovakShortName";
        private static string _englishShortName = "EnglishShortName";
        private static string _officialShortName = "OfficialShortName";
        public static string ProjectPath { get => Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..")); }
        public const string DATA_PATH = @"\Data\countries.csv";
        public const string SAVE_PATH = @"\Saves\";
        public static List<Country> _countries = new List<Country>(250);

        public static void ReadCsvFile()
        {

            using (var streamReader = new StreamReader(ProjectPath + DATA_PATH))
            using (var csvReader = new CsvReader(streamReader))
            {
                csvReader.ValueSeparator = ';';
                csvReader.ReadHeaderRecord();

                while (csvReader.HasMoreRecords)
                {
                    var record = csvReader.ReadDataRecord();
                    Country country = new Country(record[_countryCode], record[_slovakShortName], record[_englishShortName], record[_officialShortName]);
                    _countries.Add(country);
                }
            }
        }

        public static void WriteRunnersListToFile(string fileName)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var runner in RaceLogic._runners)
            {
                sb.AppendLine($"{runner.Key}\t{runner.Value.RunnerName}\t{runner.Value.Country}\t{runner.Value.Age}\t{runner.Value.Sex}");
            }
            File.WriteAllText(fileName, sb.ToString());
        }

        public static void ReadRunnersListFromFile(string fileName)
        {
            RaceLogic._runners.Clear();
            List<string> lines = new List<string>(100);
            lines = File.ReadAllLines(fileName).ToList();
            string[] zaznam = new string[5];
            foreach (string line in lines)
            {
                if (line.Length > 0)
                {
                    zaznam = line.Split('\t');
                    Runner runner = new Runner(zaznam[1], zaznam[2], int.Parse(zaznam[3]), zaznam[4]);
                    RaceLogic._runners.Add(int.Parse(zaznam[0]), runner);
                }                
            }
        }

        public static void WriteWinnersToFile(string fileName)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var winner in RaceLogic._winners)
            {
                sb.AppendLine($"{winner.Key}\t{winner.Value.Place}\t{winner.Value.RunnerName}\t{winner.Value.TotalTime}\t{winner.Value.Country}");
            }
            File.WriteAllText(fileName, sb.ToString());
        }

        private static void ReadWinnersFromFile(string fileName)
        {
            RaceLogic._winners.Clear();
            List<string> lines = new List<string>(100);
            lines = File.ReadAllLines(fileName).ToList();
            string[] zaznam = new string[5];
            foreach (string line in lines)
            {
                if (line.Length > 0)
                {
                    zaznam = line.Split('\t');
                    Winner winner = new Winner(int.Parse(zaznam[1]), zaznam[2], TimeSpan.Parse(zaznam[3]), zaznam[4]);
                    RaceLogic._winners.Add(int.Parse(zaznam[0]), winner);
                }
            }
        }

    }
}
