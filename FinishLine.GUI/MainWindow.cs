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
        
        public static bool RaceIsSelected = false;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            
            if (RaceIsSelected)
            {
                btnStart.Visible = true;
                btnFinish.Visible = true;
                pnlRaceProperties.Visible = true;
                lblRndLength.Text = $"Dĺžka kola: {RaceLogic._currentRace.LapLength} km";
                lblRndCount.Text = $"Počet kôl: {RaceLogic._currentRace.LapCount}";
                lblRaceLength.Text = $"Dĺžka pretekov: {RaceLogic._currentRace.LapLength*RaceLogic._currentRace.LapCount} km";
                lblWinnersCount.Text = $"Počet vyhodnocovaných miest: {RaceLogic._currentRace.NumOfWinners}";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnFinish.Enabled = true;
            RaceLogic._currentRace.StartTime = DateTime.Now;
            RaceLogic.StartTime = DateTime.Now;
            pnlRunThroughFinish.Visible = true;
            pnlTables.Visible = true;

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            EndRace();
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

        private void EndRace()
        {
            btnFinish.Enabled = false;
            pnlEndRace.Visible = true;
            pnlRunThroughFinish.Visible = false;
            menuSaveWinners.Visible = true;
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
            
        }

        private void menuRunner_Click(object sender, EventArgs e)
        {
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

        
    }
}
