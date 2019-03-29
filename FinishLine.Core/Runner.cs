using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    class Runner
    {
        public string RunnerName { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public int RegNumber { get; set; }

        public Runner(string runnerName, string country, int age, string sex, int regNumber)
        {
            RunnerName = runnerName;
            Country = country;
            Age = age;
            Sex = sex;
            RegNumber = regNumber;
        }
    }
}
