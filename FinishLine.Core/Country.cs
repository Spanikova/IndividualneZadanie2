using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class Country
    {
        /// <summary>
        /// Property for storing of country code
        /// </summary>
        public string CountryCode { get; set; }
        /// <summary>
        /// Property for storing of slovak short name of country 
        /// </summary>
        public string SlovakShortName { get; set; }
        /// <summary>
        /// Property for storing of english short name of country 
        /// </summary>
        public string EnglishShortName { get; set; }
        /// <summary>
        /// Property for storing of official short name of country 
        /// </summary>
        public string OfficialShortName { get; set; }

        /// <summary>
        /// Constructor of Country class
        /// </summary>
        /// <param name="countryCode"></param>
        /// <param name="slovakShortName"></param>
        /// <param name="englishShortName"></param>
        /// <param name="officialShortName"></param>
        public Country(string countryCode, string slovakShortName, string englishShortName, string officialShortName)
        {
            CountryCode = countryCode;
            SlovakShortName = slovakShortName;
            EnglishShortName = englishShortName;
            OfficialShortName = officialShortName;
        }

        /// <summary>
        /// Constructor of Country class without parameters
        /// </summary>
        public Country()
        {
        }
    }
}
