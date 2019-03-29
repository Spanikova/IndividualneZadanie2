namespace FinishLine
{
    partial class NewRunnerWindow
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtRunnername = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.lblSex = new System.Windows.Forms.Label();
            this.rdbtnMale = new System.Windows.Forms.RadioButton();
            this.rdbtnFemale = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblRegNumber = new System.Windows.Forms.Label();
            this.numRegNumber = new System.Windows.Forms.NumericUpDown();
            this.grpSex = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRegNumber)).BeginInit();
            this.grpSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(34, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Meno";
            // 
            // txtRunnername
            // 
            this.txtRunnername.Location = new System.Drawing.Point(116, 31);
            this.txtRunnername.Name = "txtRunnername";
            this.txtRunnername.Size = new System.Drawing.Size(100, 20);
            this.txtRunnername.TabIndex = 1;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(25, 69);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(39, 13);
            this.lblCountry.TabIndex = 2;
            this.lblCountry.Text = "Krajina";
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(116, 66);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(100, 21);
            this.cmbCountry.TabIndex = 3;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(25, 112);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Vek";
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(116, 110);
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
            this.numAge.Size = new System.Drawing.Size(42, 20);
            this.numAge.TabIndex = 5;
            this.numAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(25, 155);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(48, 13);
            this.lblSex.TabIndex = 6;
            this.lblSex.Text = "Pohlavie";
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
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(28, 254);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Zrušiť";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(141, 254);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblRegNumber
            // 
            this.lblRegNumber.AutoSize = true;
            this.lblRegNumber.Location = new System.Drawing.Point(25, 215);
            this.lblRegNumber.Name = "lblRegNumber";
            this.lblRegNumber.Size = new System.Drawing.Size(90, 13);
            this.lblRegNumber.TabIndex = 11;
            this.lblRegNumber.Text = "Registračné číslo";
            // 
            // numRegNumber
            // 
            this.numRegNumber.Location = new System.Drawing.Point(121, 213);
            this.numRegNumber.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numRegNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRegNumber.Name = "numRegNumber";
            this.numRegNumber.Size = new System.Drawing.Size(56, 20);
            this.numRegNumber.TabIndex = 12;
            this.numRegNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grpSex
            // 
            this.grpSex.Controls.Add(this.rdbtnMale);
            this.grpSex.Controls.Add(this.rdbtnFemale);
            this.grpSex.Location = new System.Drawing.Point(116, 136);
            this.grpSex.Name = "grpSex";
            this.grpSex.Size = new System.Drawing.Size(79, 65);
            this.grpSex.TabIndex = 13;
            this.grpSex.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // NewRunnerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(251, 322);
            this.Controls.Add(this.grpSex);
            this.Controls.Add(this.numRegNumber);
            this.Controls.Add(this.lblRegNumber);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtRunnername);
            this.Controls.Add(this.lblName);
            this.Name = "NewRunnerWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewRunner";
            this.Load += new System.EventHandler(this.NewRunnerWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRegNumber)).EndInit();
            this.grpSex.ResumeLayout(false);
            this.grpSex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtRunnername;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.RadioButton rdbtnMale;
        private System.Windows.Forms.RadioButton rdbtnFemale;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblRegNumber;
        private System.Windows.Forms.NumericUpDown numRegNumber;
        private System.Windows.Forms.GroupBox grpSex;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}