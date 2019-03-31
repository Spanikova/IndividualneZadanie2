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
    public partial class NewRunnerWindow : Form
    {
        public string RunnerName { get; set; }
        public string CountryName { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public int RegNumber { get; set; }

        
        public NewRunnerWindow()
        {
            InitializeComponent();            
        }

        private void NewRunnerWindow_Load(object sender, EventArgs e)
        {
            FileRW.ReadCsvFile();
            cmbCountry.DataSource = FileRW._countries;
            cmbCountry.DisplayMember = nameof(Country.SlovakShortName);
            cmbCountry.ValueMember = nameof(Country.SlovakShortName);
            cmbCountry.SelectedIndex = 0;
            numRegNumber.Value = RaceLogic.GetRegNumber();
        }

        private void btnOk_Click(object sender, EventArgs e)
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
            RegNumber = (int)numRegNumber.Value;
            Runner runner = new Runner(RunnerName, CountryName, Age, Sex);
            RaceLogic.AddRunner(RegNumber, runner);
            DialogResult = DialogResult.OK;
        }


    }
}
