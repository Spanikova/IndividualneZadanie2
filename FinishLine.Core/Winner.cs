using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class Winner
    {
        /// <summary>
        /// Property to store winner's place
        /// </summary>
        public int Place { get; set; }
        /// <summary>
        /// Property to store winner's start number
        /// </summary>
        public int RegNr { get; set; }
        /// <summary>
        /// Property to store winner's name
        /// </summary>
        public string RunnerName { get; set; }
        /// <summary>
        /// Property to store winner's total runing time
        /// </summary>
        public TimeSpan TotalTime { get; set; }
        /// <summary>
        /// Property to store winner's country
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Parametrized constructor
        /// </summary>
        /// <param name="place"></param>
        /// <param name="runnerName"></param>
        /// <param name="totalTime"></param>
        /// <param name="country"></param>
        public Winner(int place, string runnerName, TimeSpan totalTime, string country)
        {
            Place = place;
            RunnerName = runnerName;
            TotalTime = totalTime;
            Country = country;
        }

        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public Winner()
        {
        }
    }
}
