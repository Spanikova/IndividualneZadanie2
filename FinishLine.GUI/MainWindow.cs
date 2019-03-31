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
    }
}
