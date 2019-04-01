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
        /// <summary>
        /// Property to store current race settings
        /// </summary>
        public static RaceSettings _currentRace = new RaceSettings();
        /// <summary>
        /// Dictionary of runners with start number as key
        /// </summary>
        public static Dictionary<int, Runner> _runners = new Dictionary<int, Runner>();
        /// <summary>
        /// Dictionary of runner's last lap statistics with start number as key
        /// </summary>
        public static Dictionary<int, LapStatistics> _runnerTimes = new Dictionary<int, LapStatistics>();
        /// <summary>
        /// Dictionary of winners with start number as key
        /// </summary>
        public static Dictionary<int, Winner> _winners = new Dictionary<int, Winner>();
        /// <summary>
        /// Dictionary of runner's lap times with start number as key
        /// </summary>
        public static Dictionary<int, List<DateTime>> _lapTimes = new Dictionary<int, List<DateTime>>();
        /// <summary>
        /// Property to store date and time of race start
        /// </summary>
        public static DateTime StartTime { get; set; }
        /// <summary>
        /// Property to store the place for next winner
        /// </summary>
        public static int _place { get; set; } = 0;

        /// <summary>
        /// Generates next start number
        /// </summary>
        /// <returns></returns>
        public static int GetRegNumber()
        {
            int regNumber = 1;
            while (_runners.ContainsKey(regNumber))
            {
                regNumber++;
            }
            return regNumber;
        }

        /// <summary>
        /// Adds new runner to _runners dictionary
        /// </summary>
        /// <param name="regNumber"></param>
        /// <param name="runner"></param>
        public static void AddRunner(int regNumber, Runner runner)
        {            
            _runners.Add(regNumber, runner);
        }

        /// <summary>
        /// Deletes selected runner from _runners dictionary
        /// </summary>
        /// <param name="regNumber"></param>
        public static void DeleteRunner (int regNumber)
        {
            _runners.Remove(regNumber);
        }

        /// <summary>
        /// Changes properties of selected runner in _runners dictionary
        /// </summary>
        /// <param name="regNumber"></param>
        /// <param name="runner"></param>
        public static void ChangeRunner(int regNumber, Runner runner)
        {
            _runners[regNumber] = runner;
        }

        /// <summary>
        /// Converts start number from int to string - format 001
        /// </summary>
        /// <param name="regNumber"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Adds time of last lap to _lapTimes dictionary
        /// </summary>
        /// <param name="regNr"></param>
        /// <param name="finishLineTime"></param>
        public static void AddLapTime (int regNr, DateTime finishLineTime)
        {
            LapStatistics lastLap = new LapStatistics();
            TimeSpan lapTime = finishLineTime - StartTime;
            lastLap.TotalTime = lapTime;
            lastLap.LapNr = 1;
            if (_runnerTimes.ContainsKey(regNr))
            {
                LapStatistics runnerTime = _runnerTimes[regNr];
                TimeSpan timeToCompare = _lapTimes[regNr].Last() - StartTime;
                runnerTime.LapNr++;
                runnerTime.TotalTime = lapTime;
                runnerTime.LapTime = lapTime - timeToCompare;
                _lapTimes[regNr].Add(finishLineTime);
            }
            else
            {
                lastLap.LapTime = lastLap.TotalTime;
                _runnerTimes.Add(regNr, lastLap);
                _lapTimes.Add(regNr, new List<DateTime>());
                _lapTimes[regNr].Add(finishLineTime);
            }
        }

        /// <summary>
        /// Adds winner to _winners dictionary
        /// </summary>
        /// <param name="regNr"></param>
        /// <returns></returns>
        public static Winner AddWinner(int regNr)
        {
            _place++;
            Winner winner = new Winner();
            winner.Place = _place;
            winner.RunnerName = _runners[regNr].RunnerName;
            winner.Country = _runners[regNr].Country;
            winner.TotalTime = _runnerTimes[regNr].TotalTime;
            _winners.Add(regNr, winner);
            return winner;
        }

        /// <summary>
        /// Checks if runner with selected start number is running
        /// </summary>
        /// <param name="regNr"></param>
        /// <returns></returns>
        public static bool CheckRegNrRace(int regNr )
        {
            if (_runners.ContainsKey(regNr) && !_winners.ContainsKey(regNr))
            {               
                return true;
            }
            else
            {
                return false;
            }          
        }

        /// <summary>
        /// Checks if number of winners is enough to stop the race
        /// </summary>
        /// <returns></returns>
        public static bool EnoughWinners()
        {
            if (_winners.Keys.Count == _currentRace.NumOfWinners)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
