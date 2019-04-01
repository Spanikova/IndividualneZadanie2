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
    public partial class NewRaceWindow : Form
    {
        /// <summary>
        /// Property for changing the length of lap
        /// </summary>
        public int LapLength { get; set; }
        /// <summary>
        /// Property for changing the number of laps
        /// </summary>
        public int LapCount { get; set; }
        /// <summary>
        /// Property for changing the number of winners to end the race
        /// </summary>
        public int NumOfWinners { get; set; }

        /// <summary>
        /// Constructor of form with initialization
        /// </summary
        public NewRaceWindow()
        {
            InitializeComponent();
        }

        private void NewRaceWindow_Load(object sender, EventArgs e)
        {
            numWinnersCount.Maximum = RaceLogic._runners.Count;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            LapLength = (int) numLapLength.Value;
            LapCount = (int)numLapCount.Value;
            NumOfWinners = (int)numWinnersCount.Value;
            RaceLogic._currentRace = new RaceSettings(LapLength, LapCount, NumOfWinners);
            MainWindow.RaceIsSelected = true;
            DialogResult =  DialogResult.OK;
        }

    }
}
