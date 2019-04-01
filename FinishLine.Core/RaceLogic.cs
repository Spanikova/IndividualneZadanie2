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
        public static Dictionary<int, LapTime> _runnerTimes = new Dictionary<int, LapTime>();
        public static DateTime StartTime { get; set; }


        public static int GetRegNumber()
        {
            int regNumber = 1;
            while (_runners.ContainsKey(regNumber))
            {
                regNumber++;
            }
            return regNumber;
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

        public static void AddLapTime (int regNr, DateTime finishLineTime)
        {
            LapTime lastLap = new LapTime();
            TimeSpan lapTime = finishLineTime - StartTime;
            lastLap.FinishLineTime = lapTime;
            lastLap.LapNr = 1;
            if (_runnerTimes.ContainsKey(regNr))
            {
                LapTime runnerTime = _runnerTimes[regNr];
                runnerTime.LapNr++;
                runnerTime.FinishLineTime = lapTime;
            }
            else
            {
                _runnerTimes.Add(regNr, lastLap);
            }
        }
    }
}
