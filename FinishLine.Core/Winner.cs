using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class Winner
    {
        public int Place { get; set; }
        public int RegNr { get; set; }
        public string RunnerName { get; set; }
        public TimeSpan TotalTime { get; set; }
        public string Country { get; set; }
    }
}
