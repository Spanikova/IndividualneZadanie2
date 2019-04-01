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
        public int RoundLength { get; set; }
        public int RoundCount { get; set; }
        public int NumOfWinners { get; set; }

        public NewRaceWindow()
        {
            InitializeComponent();
        }

        private void NewRaceWindow_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            RoundLength = (int) numRoundLength.Value;
            RoundCount = (int)numRoundCount.Value;
            NumOfWinners = (int)numWinnersCount.Value;
            MainWindow._newRace = new Core.Race(RoundLength, RoundCount, NumOfWinners);
            MainWindow.RaceIsSelected = true;
            DialogResult =  DialogResult.OK;
        }

    }
}
