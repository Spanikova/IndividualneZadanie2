namespace FinishLine
{
    partial class NewRaceWindow
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
            this.lblLapLength = new System.Windows.Forms.Label();
            this.numLapLength = new System.Windows.Forms.NumericUpDown();
            this.lblM = new System.Windows.Forms.Label();
            this.lblLapCount = new System.Windows.Forms.Label();
            this.numLapCount = new System.Windows.Forms.NumericUpDown();
            this.lblWinnersCount = new System.Windows.Forms.Label();
            this.numWinnersCount = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numLapLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLapCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWinnersCount)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLapLength
            // 
            this.lblLapLength.AutoSize = true;
            this.lblLapLength.Location = new System.Drawing.Point(12, 13);
            this.lblLapLength.Name = "lblLapLength";
            this.lblLapLength.Size = new System.Drawing.Size(93, 13);
            this.lblLapLength.TabIndex = 0;
            this.lblLapLength.Text = "Dĺžka kola  (v km)";
            // 
            // numLapLength
            // 
            this.numLapLength.Location = new System.Drawing.Point(130, 11);
            this.numLapLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLapLength.Name = "numLapLength";
            this.numLapLength.Size = new System.Drawing.Size(60, 20);
            this.numLapLength.TabIndex = 1;
            this.numLapLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(196, 13);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(0, 13);
            this.lblM.TabIndex = 2;
            // 
            // lblLapCount
            // 
            this.lblLapCount.AutoSize = true;
            this.lblLapCount.Location = new System.Drawing.Point(12, 58);
            this.lblLapCount.Name = "lblLapCount";
            this.lblLapCount.Size = new System.Drawing.Size(52, 13);
            this.lblLapCount.TabIndex = 3;
            this.lblLapCount.Text = "Počet kôl";
            // 
            // numLapCount
            // 
            this.numLapCount.Location = new System.Drawing.Point(130, 56);
            this.numLapCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLapCount.Name = "numLapCount";
            this.numLapCount.Size = new System.Drawing.Size(60, 20);
            this.numLapCount.TabIndex = 4;
            this.numLapCount.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblWinnersCount
            // 
            this.lblWinnersCount.AutoSize = true;
            this.lblWinnersCount.Location = new System.Drawing.Point(12, 103);
            this.lblWinnersCount.Name = "lblWinnersCount";
            this.lblWinnersCount.Size = new System.Drawing.Size(118, 13);
            this.lblWinnersCount.TabIndex = 5;
            this.lblWinnersCount.Text = "Vyhodnocované miesta";
            // 
            // numWinnersCount
            // 
            this.numWinnersCount.Location = new System.Drawing.Point(130, 101);
            this.numWinnersCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWinnersCount.Name = "numWinnersCount";
            this.numWinnersCount.Size = new System.Drawing.Size(60, 20);
            this.numWinnersCount.TabIndex = 6;
            this.numWinnersCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(116, 7);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(12, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Zrušiť";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Location = new System.Drawing.Point(20, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 44);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numWinnersCount);
            this.panel2.Controls.Add(this.lblWinnersCount);
            this.panel2.Controls.Add(this.numLapCount);
            this.panel2.Controls.Add(this.lblLapCount);
            this.panel2.Controls.Add(this.lblM);
            this.panel2.Controls.Add(this.numLapLength);
            this.panel2.Controls.Add(this.lblLapLength);
            this.panel2.Location = new System.Drawing.Point(20, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 132);
            this.panel2.TabIndex = 10;
            // 
            // NewRaceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(232, 218);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "NewRaceWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nové preteky";
            this.Load += new System.EventHandler(this.NewRaceWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numLapLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLapCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWinnersCount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLapLength;
        private System.Windows.Forms.NumericUpDown numLapLength;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblLapCount;
        private System.Windows.Forms.NumericUpDown numLapCount;
        private System.Windows.Forms.Label lblWinnersCount;
        private System.Windows.Forms.NumericUpDown numWinnersCount;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}