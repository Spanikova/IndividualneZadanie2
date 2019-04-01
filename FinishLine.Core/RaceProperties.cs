using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinishLine.Core
{
    public class RaceSettings
    {
        /// <summary>
        /// Property to store length of lap
        /// </summary>
        public int LapLength { get; set; }
        /// <summary>
        /// Property to store number of laps
        /// </summary>
        public int LapCount { get; set; }
        /// <summary>
        /// Property to store number of winners
        /// </summary>
        public int NumOfWinners { get; set; }
        /// <summary>
        /// Property to store date and time of race start
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public RaceSettings()
        {
        }

        /// <summary>
        /// Parametrized constructor
        /// </summary>
        /// <param name="lapLength"></param>
        /// <param name="lapCount"></param>
        /// <param name="numOfWinners"></param>
        public RaceSettings(int lapLength, int lapCount, int numOfWinners)
        {
            LapLength = lapLength;
            LapCount = lapCount;
            NumOfWinners = numOfWinners;
        }

        
        
    }
}
