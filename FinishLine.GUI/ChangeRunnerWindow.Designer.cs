namespace FinishLine
{
    partial class ChangeRunnerWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpSex = new System.Windows.Forms.GroupBox();
            this.rdbtnMale = new System.Windows.Forms.RadioButton();
            this.rdbtnFemale = new System.Windows.Forms.RadioButton();
            this.lblSex = new System.Windows.Forms.Label();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.lblAge = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtRunnername = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbRegNumber = new System.Windows.Forms.ComboBox();
            this.lblRegNumber = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grpSex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpSex);
            this.panel1.Controls.Add(this.lblSex);
            this.panel1.Controls.Add(this.numAge);
            this.panel1.Controls.Add(this.lblAge);
            this.panel1.Controls.Add(this.cmbCountry);
            this.panel1.Controls.Add(this.lblCountry);
            this.panel1.Controls.Add(this.txtRunnername);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 155);
            this.panel1.TabIndex = 15;
            // 
            // grpSex
            // 
            this.grpSex.Controls.Add(this.rdbtnMale);
            this.grpSex.Controls.Add(this.rdbtnFemale);
            this.grpSex.Location = new System.Drawing.Point(269, 73);
            this.grpSex.Name = "grpSex";
            this.grpSex.Size = new System.Drawing.Size(79, 65);
            this.grpSex.TabIndex = 13;
            this.grpSex.TabStop = false;
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.AutoSize = true;
            this.rdbtnMale.Checked = true;
            this.rdbtnMale.Location = new System.Drawing.Point(13, 15);
            this.rdbtnMale.Name = "rdbtnMale";
            this.rdbtnMale.Size = new System.Drawing.Size(45, 17);
            this.rdbtnMale.TabIndex = 7;
            this.rdbtnMale.TabStop = true;
            this.rdbtnMale.Text = "Muž";
            this.rdbtnMale.UseVisualStyleBackColor = true;
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.AutoSize = true;
            this.rdbtnFemale.Location = new System.Drawing.Point(13, 38);
            this.rdbtnFemale.Name = "rdbtnFemale";
            this.rdbtnFemale.Size = new System.Drawing.Size(50, 17);
            this.rdbtnFemale.TabIndex = 8;
            this.rdbtnFemale.Text = "Žena";
            this.rdbtnFemale.UseVisualStyleBackColor = true;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(215, 92);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(48, 13);
            this.lblSex.TabIndex = 6;
            this.lblSex.Text = "Pohlavie";
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(111, 92);
            this.numAge.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(56, 20);
            this.numAge.TabIndex = 5;
            this.numAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(55, 94);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Vek";
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(111, 46);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(247, 21);
            this.cmbCountry.TabIndex = 3;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(20, 49);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(39, 13);
            this.lblCountry.TabIndex = 2;
            this.lblCountry.Text = "Krajina";
            // 
            // txtRunnername
            // 
            this.txtRunnername.Location = new System.Drawing.Point(111, 11);
            this.txtRunnername.Name = "txtRunnername";
            this.txtRunnername.Size = new System.Drawing.Size(247, 20);
            this.txtRunnername.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(34, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Meno";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbRegNumber);
            this.panel2.Controls.Add(this.lblRegNumber);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 35);
            this.panel2.TabIndex = 16;
            // 
            // cmbRegNumber
            // 
            this.cmbRegNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRegNumber.FormattingEnabled = true;
            this.cmbRegNumber.Location = new System.Drawing.Point(99, 7);
            this.cmbRegNumber.Name = "cmbRegNumber";
            this.cmbRegNumber.Size = new System.Drawing.Size(65, 21);
            this.cmbRegNumber.TabIndex = 12;
            this.cmbRegNumber.SelectedIndexChanged += new System.EventHandler(this.cmbRegNumber_SelectedIndexChanged);
            // 
            // lblRegNumber
            // 
            this.lblRegNumber.AutoSize = true;
            this.lblRegNumber.Location = new System.Drawing.Point(3, 10);
            this.lblRegNumber.Name = "lblRegNumber";
            this.lblRegNumber.Size = new System.Drawing.Size(90, 13);
            this.lblRegNumber.TabIndex = 11;
            this.lblRegNumber.Text = "Registračné číslo";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnChange);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Location = new System.Drawing.Point(70, 240);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(316, 47);
            this.panel3.TabIndex = 17;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(238, 9);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 18;
            this.btnChange.Text = "Zmeniť";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(129, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Zmazať";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(18, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Zrušiť";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ChangeRunnerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(398, 313);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ChangeRunnerWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zmeniť alebo vymazať bežca";
            this.Load += new System.EventHandler(this.ChangeRunnerWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpSex.ResumeLayout(false);
            this.grpSex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpSex;
        private System.Windows.Forms.RadioButton rdbtnMale;
        private System.Windows.Forms.RadioButton rdbtnFemale;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtRunnername;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRegNumber;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.ComboBox cmbRegNumber;
    }
}