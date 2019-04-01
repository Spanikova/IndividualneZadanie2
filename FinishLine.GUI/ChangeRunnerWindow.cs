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
    public partial class ChangeRunnerWindow : Form
    {
        public string RunnerName { get; set; }
        public string CountryName { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public int RegNumber { get; set; }


        public ChangeRunnerWindow()
        {
            InitializeComponent();
        }

        private void ChangeRunnerWindow_Load(object sender, EventArgs e)
        {
            cmbCountry.DataSource = FileRW._countries;
            cmbCountry.DisplayMember = nameof(Country.SlovakShortName);
            cmbCountry.ValueMember = nameof(Country.SlovakShortName);
            cmbRegNumber.DataSource = RaceLogic._runners.Keys.ToList();
        }

        private void cmbRegNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            RegNumber = int.Parse(cmbRegNumber.SelectedValue.ToString());
            Runner runner = RaceLogic._runners[RegNumber];
            txtRunnername.Text = runner.RunnerName;
            cmbCountry.SelectedValue = runner.Country;
            numAge.Value = runner.Age;
            if (runner.Sex == "Muž")
            {
                rdbtnMale.Checked = true;
            }
            else if (runner.Sex == "Žena")
            {
                rdbtnFemale.Checked = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            RaceLogic.DeleteRunner(RegNumber);
            DialogResult = DialogResult.OK;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            RunnerName = txtRunnername.Text;
            CountryName = cmbCountry.SelectedValue.ToString();
            Age = (int)numAge.Value;
            if (rdbtnMale.Checked)
            {
                Sex = rdbtnMale.Text;
            }
            else
            {
                Sex = rdbtnFemale.Text;
            }
            RegNumber = int.Parse(cmbRegNumber.SelectedValue.ToString());
            Runner runner = new Runner(RunnerName, CountryName, Age, Sex);
            RaceLogic.ChangeRunner(RegNumber, runner);
            DialogResult = DialogResult.OK;
        }

       
    }
}
