using KBCsv;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinishLine.Core
{
    public static class RaceLogic
    {
        public static Dictionary<int, Runner> _runners = new Dictionary<int, Runner>();
        private static int _regNumber = 1;

        public static int GetRegNumber()
        {
            while (_runners.ContainsKey(_regNumber))
            {
                _regNumber++;
            }
            return _regNumber;
        }

        public static void AddRunner(int regNumber, Runner runner)
        {            
            _runners.Add(regNumber, runner);
        }

        public static void DeleteRunner (int regNumber)
        {
            _runners.Remove(regNumber);
        }

        public static void ChangeRunner(int regNumber, Runner runner)
        {
            _runners[regNumber] = runner;
        }

        public static string RegNrToString(int regNumber)
        {
            string strRegNr = $"{regNumber}";
            if(regNumber < 10)
            {
                strRegNr = $"00{regNumber}";
            }
            else if (regNumber >= 10 && regNumber < 100)
            {
                strRegNr = $"0{regNumber}";
            }
            return strRegNr;
        }
    }
}
