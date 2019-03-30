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
        public static string ProjectPath
        {
            get
            {
                return Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\.."));
            }
        }
        public static string DataPath
        {
            get
            {
                return ProjectPath + @"\Data\countries.csv";
            }
        }
        public static Dictionary<string, Country> _countries = new Dictionary<string, Country>();



        public static void ReadCsvFile()
        {

            using (var streamReader = new StreamReader(DataPath))
            using (var csvReader = new CsvReader(streamReader))
            {
                csvReader.ValueSeparator = ';';
                csvReader.ReadHeaderRecord();
                int i = 0;
                while (csvReader.HasMoreRecords)
                {
                    var record = csvReader.ReadDataRecord();
                    Country country = new Country(record[_slovakShortName], record[_englishShortName], record[_officialShortName]);
                    _countries.Add(record[_countryCode], country);
                    i++;
                }
            }
           
        }
    }
}
