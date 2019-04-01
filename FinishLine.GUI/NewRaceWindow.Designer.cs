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
            this.lblRoundLength = new System.Windows.Forms.Label();
            this.numRoundLength = new System.Windows.Forms.NumericUpDown();
            this.lblM = new System.Windows.Forms.Label();
            this.lblRoundCount = new System.Windows.Forms.Label();
            this.numRoundCount = new System.Windows.Forms.NumericUpDown();
            this.lblWinnersCount = new System.Windows.Forms.Label();
            this.numWinnersCount = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numRoundLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoundCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWinnersCount)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRoundLength
            // 
            this.lblRoundLength.AutoSize = true;
            this.lblRoundLength.Location = new System.Drawing.Point(12, 13);
            this.lblRoundLength.Name = "lblRoundLength";
            this.lblRoundLength.Size = new System.Drawing.Size(117, 13);
            this.lblRoundLength.TabIndex = 0;
            this.lblRoundLength.Text = "Dĺžka kola  (v metroch)";
            // 
            // numRoundLength
            // 
            this.numRoundLength.Location = new System.Drawing.Point(130, 11);
            this.numRoundLength.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numRoundLength.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRoundLength.Name = "numRoundLength";
            this.numRoundLength.Size = new System.Drawing.Size(60, 20);
            this.numRoundLength.TabIndex = 1;
            this.numRoundLength.Value = new decimal(new int[] {
            10,
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
            // lblRoundCount
            // 
            this.lblRoundCount.AutoSize = true;
            this.lblRoundCount.Location = new System.Drawing.Point(12, 58);
            this.lblRoundCount.Name = "lblRoundCount";
            this.lblRoundCount.Size = new System.Drawing.Size(52, 13);
            this.lblRoundCount.TabIndex = 3;
            this.lblRoundCount.Text = "Počet kôl";
            // 
            // numRoundCount
            // 
            this.numRoundCount.Location = new System.Drawing.Point(130, 56);
            this.numRoundCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRoundCount.Name = "numRoundCount";
            this.numRoundCount.Size = new System.Drawing.Size(60, 20);
            this.numRoundCount.TabIndex = 4;
            this.numRoundCount.Value = new decimal(new int[] {
            1,
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
            1,
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
            this.panel1.Location = new System.Drawing.Point(13, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 44);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numWinnersCount);
            this.panel2.Controls.Add(this.lblWinnersCount);
            this.panel2.Controls.Add(this.numRoundCount);
            this.panel2.Controls.Add(this.lblRoundCount);
            this.panel2.Controls.Add(this.lblM);
            this.panel2.Controls.Add(this.numRoundLength);
            this.panel2.Controls.Add(this.lblRoundLength);
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
            this.Text = "Nový pretek";
            this.Load += new System.EventHandler(this.NewRaceWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRoundLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoundCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWinnersCount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRoundLength;
        private System.Windows.Forms.NumericUpDown numRoundLength;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblRoundCount;
        private System.Windows.Forms.NumericUpDown numRoundCount;
        private System.Windows.Forms.Label lblWinnersCount;
        private System.Windows.Forms.NumericUpDown numWinnersCount;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}