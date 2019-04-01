using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class LapTime
    {
        public int RunnerRegNr { get; set; }
        public int LapNr { get; set; }
        public TimeSpan FinishLineTime { get; set; }

        public LapTime(int runnerRegNr, int lapNr, TimeSpan finishLineTime)
        {
            RunnerRegNr = runnerRegNr;
            LapNr = lapNr;
            FinishLineTime = finishLineTime;
        }

        public LapTime(int lapNr, TimeSpan finishLineTime)
        {
            LapNr = lapNr;
            FinishLineTime = finishLineTime;
        }

        public LapTime()
        {
        }
    }
}
