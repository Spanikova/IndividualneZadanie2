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
        /// <summary>
        /// Property for changing the name of the runner
        /// </summary
        public string RunnerName { get; set; }
        /// <summary>
        /// Property for changing the country of the runner
        /// </summary>
        public string CountryName { get; set; }
        /// <summary>
        /// Property for changing the age of the runner
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// Property for changing the sex of the runner
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// Property for changing the start number of the runner
        /// </summary>
        public int RegNumber { get; set; }

        /// <summary>
        /// Constructor of form with initialization
        /// </summary>
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
