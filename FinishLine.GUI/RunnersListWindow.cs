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
    public partial class RunnersListWindow : Form
    {
        public RunnersListWindow()
        {
            InitializeComponent();
        }

        private void RunnersListWindow_Load(object sender, EventArgs e)
        {
            dataRunnersList.ColumnCount = 5;
            foreach (var runner in RaceLogic._runners)
            {
                dataRunnersList.Rows.Add(RaceLogic.RegNrToString(runner.Key), runner.Value.RunnerName, runner.Value.Country, runner.Value.Age, runner.Value.Sex);
            }
        }
    }
}
