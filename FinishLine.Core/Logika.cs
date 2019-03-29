using KBCsv;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinishLine.Core
{
    public static class Logika
    {
        public static string[] _countries = new string[250];

        

        public static void ReadCsvFile()
        {
            string projectPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\.."));
            string dataPath = projectPath + @"\Data\countries.csv";
            using (var streamReader = new StreamReader(dataPath))
            using (var csvReader = new CsvReader(streamReader))
            {                
                csvReader.ValueSeparator = ';';
                csvReader.ReadHeaderRecord();
                int i = 0;
                while (csvReader.HasMoreRecords)
                {
                    var record = csvReader.ReadDataRecord();
                    _countries[i] = record["SlovakShortName"];
                    i++;
                }
            }
        }
    }
}
