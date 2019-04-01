using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class LapStatistics
    {
        /// <summary>
        /// Property to store runner's start number
        /// </summary>
        public int RunnerRegNr { get; set; }
        /// <summary>
        /// Property to store runner's number of finished laps
        /// </summary>
        public int LapNr { get; set; }
        /// <summary>
        /// Property to store runner's total running time at finish line
        /// </summary>
        public TimeSpan TotalTime { get; set; }
        /// <summary>
        /// Property to store runner's time of lap
        /// </summary>
        public TimeSpan LapTime { get; set; }

        /// <summary>
        /// Constructor of LapStatistics class
        /// </summary>
        /// <param name="runnerRegNr"></param>
        /// <param name="lapNr"></param>
        /// <param name="finishLineTime"></param>
        /// <param name="lapTime"></param>
        public LapStatistics(int runnerRegNr, int lapNr, TimeSpan finishLineTime, TimeSpan lapTime)
        {
            RunnerRegNr = runnerRegNr;
            LapNr = lapNr;
            TotalTime = finishLineTime;
            LapTime = lapTime;
        }

        /// <summary>
        /// Constructor of LapStatistics class
        /// </summary>
        /// <param name="lapNr"></param>
        /// <param name="finishLineTime"></param>
        public LapStatistics(int lapNr, TimeSpan finishLineTime)
        {
            LapNr = lapNr;
            TotalTime = finishLineTime;
        }

        /// <summary>
        /// Constructor of LapStatistics class - without parameters
        /// </summary>
        public LapStatistics()
        {
        }
    }
}
