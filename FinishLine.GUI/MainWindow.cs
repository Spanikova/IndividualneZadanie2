using FinishLine.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinishLine
{
    public partial class MainWindow : Form
    {
        /// <summary>
        /// Property for check if race is set
        /// </summary>
        public static bool RaceIsSelected = false;
        /// <summary>
        /// Property for check if race ended
        /// </summary>
        public static bool RaceEnded = false;
        /// <summary>
        /// Property for check if race started
        /// </summary>
        public static bool RaceStarted = false;

        /// <summary>
        /// Constructor of the form with initialization
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

  

        private void menuNewRace_Click(object sender, EventArgs e)
        {
            NewRaceWindow newRace = new NewRaceWindow();
            newRace.ShowDialog();
        }

        private void menuRegister_Click(object sender, EventArgs e)
        {
            NewRunnerWindow newRunner = new NewRunnerWindow();
            newRunner.ShowDialog();
        }

        private void menuChangeDelete_Click(object sender, EventArgs e)
        {
            ChangeRunnerWindow changeRunner = new ChangeRunnerWindow();
            changeRunner.ShowDialog();
        }

        private void menuRunnersList_Click(object sender, EventArgs e)
        {
            RunnersListWindow runnersList = new RunnersListWindow();
            runnersList.ShowDialog();
        }

        private void MainWindow_Activated(object sender, EventArgs e)
        {
            LoadMainWindow();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            RaceStarted = true;
            LoadMainWindow();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            EndRace();
        }

        private void EndRace()
        {
            RaceEnded = true;
            LoadMainWindow();
        }

        private void btnAcceptRunnerNr_Click(object sender, EventArgs e)
        {           
            int runnerRegNr = (int)numRunnerRegNr.Value;
            bool runnerRuns = RaceLogic.CheckRegNrRace(runnerRegNr);
            if (runnerRuns)
            {
                DateTime finishLineTime = DateTime.Now;
                RaceLogic.AddLapTime(runnerRegNr, finishLineTime);
                var lastLap = RaceLogic._runnerTimes[runnerRegNr];
                dtGrdRaceRun.Rows.Add(runnerRegNr, RaceLogic._runners[runnerRegNr].RunnerName, lastLap.LapNr, lastLap.LapTime, lastLap.TotalTime);
                dtGrdRaceRun.Sort(ColNrOfLaps, ListSortDirection.Descending);
                if (lastLap.LapNr == RaceLogic._currentRace.LapCount)
                {
                    Winner winner = RaceLogic.AddWinner(runnerRegNr);
                    int place = RaceLogic._place;
                    dtGrdRaceResults.Rows.Add(winner.Place, runnerRegNr, winner.RunnerName, winner.TotalTime, winner.Country);
                    if (RaceLogic.EnoughWinners())
                    {
                        EndRace();
                    }
                }                
            }            
        }


        private void menuSaveList_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.InitialDirectory = FileRW.ProjectPath + FileRW.SAVE_PATH;
            saveFile.Filter = "Text files (*.txt)|*.txt";
            saveFile.FileName = "zoznam_bezcov.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                FileRW.WriteRunnersListToFile(saveFile.FileName);
            }            
        }

        private void menuLoadRunnersList_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = FileRW.ProjectPath + FileRW.SAVE_PATH;
            openFile.Filter = "Text files (*.txt)|*.txt";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                FileRW.ReadRunnersListFromFile(openFile.FileName);
            }
            LoadMainWindow();
        }


        private void menuSaveWinners_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.InitialDirectory = FileRW.ProjectPath + FileRW.SAVE_PATH;
            saveFile.Filter = "Text files (*.txt)|*.txt";
            saveFile.FileName = "zoznam_vitazov.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                FileRW.WriteWinnersToFile(saveFile.FileName);
            }
        }

        private void menuSaveSettings_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.InitialDirectory = FileRW.ProjectPath + FileRW.SAVE_PATH;
            saveFile.Filter = "Text files (*.txt)|*.txt";
            saveFile.FileName = "preteky_nastavenie.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                FileRW.WriteRaceSettingsToFile(saveFile.FileName);
            }
        }

        private void menuLoadSettings_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = FileRW.ProjectPath + FileRW.SAVE_PATH;
            openFile.Filter = "Text files (*.txt)|*.txt";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                FileRW.ReadRaceSettingsFromFile(openFile.FileName);
                RaceIsSelected = true;
                LoadMainWindow();
            }
        }

        private void menuSaveRace_Click(object sender, EventArgs e)
        {
            string path = FileRW.ProjectPath + FileRW.SAVE_RACE_PATH;
            FileRW.WriteRaceSettingsToFile($"{path}/race_settings.txt");
            FileRW.WriteRunnersListToFile($"{path}/runners_list.txt");
            FileRW.WriteWinnersToFile($"{path}/winners_list.txt");
        }

        private void menuLoadLastRace_Click(object sender, EventArgs e)
        {
            string path = FileRW.ProjectPath + FileRW.SAVE_RACE_PATH;
            FileRW.ReadRaceSettingsFromFile($"{path}/race_settings.txt");
            FileRW.ReadRunnersListFromFile($"{path}/runners_list.txt");
            FileRW.ReadWinnersFromFile($"{path}/winners_list.txt");
            if(RaceLogic._currentRace.LapCount > 0)
            {
                RaceIsSelected = true;
            }
            if(RaceLogic._winners.Count > 0)
            {
                foreach (var winner in RaceLogic._winners)
                {
                    dtGrdRaceResults.Rows.Add(winner.Value.Place, winner.Key, winner.Value.RunnerName, winner.Value.TotalTime, winner.Value.Country);
                }                
                EndRace();
            }
            LoadMainWindow();
        }

        private void LoadMainWindow()
        {
            menuSaveWinners.Visible = false;
            if (RaceIsSelected)
            {
                btnStart.Visible = true;
                btnFinish.Visible = true;
                pnlRaceProperties.Visible = true;
                lblRndLength.Text = $"Dĺžka kola: {RaceLogic._currentRace.LapLength} km";
                lblRndCount.Text = $"Počet kôl: {RaceLogic._currentRace.LapCount}";
                lblRaceLength.Text = $"Dĺžka pretekov: {RaceLogic._currentRace.LapLength * RaceLogic._currentRace.LapCount} km";
                lblWinnersCount.Text = $"Počet vyhodnocovaných miest: {RaceLogic._currentRace.NumOfWinners}";
            }
            if (RaceEnded)
            {
                btnFinish.Enabled = false;
                pnlEndRace.Visible = true;
                pnlRunThroughFinish.Visible = false;
                menuSaveWinners.Visible = true;
                pnlRacePanel.Visible = true;
                pnlTables.Visible = true;
                btnStart.Enabled = false;
            }
            if (RaceStarted)
            {
                btnStart.Enabled = false;
                btnFinish.Enabled = true;
                RaceLogic._currentRace.StartTime = DateTime.Now;
                RaceLogic.StartTime = DateTime.Now;
                pnlRunThroughFinish.Visible = true;
                pnlTables.Visible = true;
            }
            if (RaceLogic._runners.Count == 0)
            {
                menuRunnersList.Enabled = false;
                menuChangeDelete.Enabled = false;
                menuSaveList.Enabled = false;
            }
            else
            {
                menuRunnersList.Enabled = true;
                menuChangeDelete.Enabled = true;
                menuSaveList.Enabled = true;
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
