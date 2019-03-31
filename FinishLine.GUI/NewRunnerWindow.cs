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
        Country country = new Country();
        
        public NewRunnerWindow()
        {
            InitializeComponent();
            FileRW.ReadCsvFile();
            cmbCountry.DataSource = FileRW._countries;
            cmbCountry.DisplayMember = nameof(country.SlovakShortName);
            cmbCountry.ValueMember = nameof(country.SlovakShortName);
            cmbCountry.SelectedIndex = 0;
        }

        private void NewRunnerWindow_Load(object sender, EventArgs e)
        {

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
            DialogResult = DialogResult.OK;
        }


    }
}
