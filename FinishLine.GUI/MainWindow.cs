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
        public static Race _currentRace = new Race();
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
            if (RaceLogic._runners.Count == 0)
            {
                menuRunnersList.Enabled = false;
                menuChangeDelete.Enabled = false;
            }
            else
            {
                menuRunnersList.Enabled = true;
                menuChangeDelete.Enabled = true;
            }
            if (RaceIsSelected)
            {
                btnStart.Visible = true;
                btnFinish.Visible = true;
                pnlRaceProperties.Visible = true;
                lblRndLength.Text = $"Dĺžka kola: {_currentRace.RoundLength} km";
                lblRndCount.Text = $"Počet kôl: {_currentRace.RoundCount}";
                lblWinnersCount.Text = $"Počet vyhodnocovaných miest: {_currentRace.NumOfWinners}";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnFinish.Enabled = true;
            _currentRace.StartTime = DateTime.Now;
            lblStartTime.Text = $"Čas štartu: {_currentRace.StartTime}";
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            btnFinish.Enabled = false;
        }
    }
}
