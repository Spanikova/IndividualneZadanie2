using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class Runner
    {
        /// <summary>
        /// Property to store runner's name
        /// </summary>
        public string RunnerName { get; set; }
        /// <summary>
        /// Property to store runner's country
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// Property to store runner's age
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// Property to store runner's sex
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        ///Parametrized constructor 
        /// </summary>
        public Runner(string runnerName, string country, int age, string sex)
        {
            RunnerName = runnerName;
            Country = country;
            Age = age;
            Sex = sex;
        }

        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public Runner()
        {
        }
    }
}
