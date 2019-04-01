using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class LapStatistics
    {
        public int RunnerRegNr { get; set; }
        public int LapNr { get; set; }
        public TimeSpan TotalTime { get; set; }
        public TimeSpan LapTime { get; set; }

        public LapStatistics(int runnerRegNr, int lapNr, TimeSpan finishLineTime, TimeSpan lapTime)
        {
            RunnerRegNr = runnerRegNr;
            LapNr = lapNr;
            TotalTime = finishLineTime;
            LapTime = lapTime;
        }

        public LapStatistics(int lapNr, TimeSpan finishLineTime)
        {
            LapNr = lapNr;
            TotalTime = finishLineTime;
        }

        public LapStatistics()
        {
        }
    }
}
