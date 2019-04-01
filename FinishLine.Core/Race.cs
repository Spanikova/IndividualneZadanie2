using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinishLine.Core
{
    public class Race
    {
        public int RoundLength { get; set; }
        public int RoundCount { get; set; }
        public int NumOfWinners { get; set; }
        public DateTime StartTime { get; set; }

        public Race()
        {
        }

        public Race(int roundLength, int roundCount, int numOfWinners)
        {
            RoundLength = roundLength;
            RoundCount = roundCount;
            NumOfWinners = numOfWinners;
        }

        
        
    }
}
