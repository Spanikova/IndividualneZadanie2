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
        public static Race NewRace = new Race();
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
            }
        }

        private void dataGridViewGrouper1_DisplayGroup(object sender, Subro.Controls.GroupDisplayEventArgs e)
        {
            
        }
    }
}
