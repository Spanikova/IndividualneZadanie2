using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinishLine.Core
{
    public class RaceProperties
    {
        public int LapLength { get; set; }
        public int LapCount { get; set; }
        public int NumOfWinners { get; set; }
        public DateTime StartTime { get; set; }

        public RaceProperties()
        {
        }

        public RaceProperties(int lapLength, int lapCount, int numOfWinners)
        {
            LapLength = lapLength;
            LapCount = lapCount;
            NumOfWinners = numOfWinners;
        }

        
        
    }
}
