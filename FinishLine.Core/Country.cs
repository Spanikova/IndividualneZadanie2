using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class Country
    {
        public string CountryCode { get; set; }
        public string SlovakShortName { get; set; }
        public string EnglishShortName { get; set; }
        public string OfficialShortName { get; set; }
        public string DependencyOf { get; set; }

        public Country(string countryCode, string slovakShortName, string englishShortName, string officialShortName)
        {
            CountryCode = countryCode;
            SlovakShortName = slovakShortName;
            EnglishShortName = englishShortName;
            OfficialShortName = officialShortName;
        }

        public Country()
        {
        }
    }
}
