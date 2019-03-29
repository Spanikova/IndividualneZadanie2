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
            ((System.ComponentModel.ISupportInitialize)(this.numRoundLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoundCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWinnersCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRoundLength
            // 
            this.lblRoundLength.AutoSize = true;
            this.lblRoundLength.Location = new System.Drawing.Point(32, 44);
            this.lblRoundLength.Name = "lblRoundLength";
            this.lblRoundLength.Size = new System.Drawing.Size(58, 13);
            this.lblRoundLength.TabIndex = 0;
            this.lblRoundLength.Text = "Dĺžka kola";
            // 
            // numRoundLength
            // 
            this.numRoundLength.Location = new System.Drawing.Point(129, 42);
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
            this.lblM.Location = new System.Drawing.Point(195, 44);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(15, 13);
            this.lblM.TabIndex = 2;
            this.lblM.Text = "m";
            // 
            // lblRoundCount
            // 
            this.lblRoundCount.AutoSize = true;
            this.lblRoundCount.Location = new System.Drawing.Point(32, 89);
            this.lblRoundCount.Name = "lblRoundCount";
            this.lblRoundCount.Size = new System.Drawing.Size(52, 13);
            this.lblRoundCount.TabIndex = 3;
            this.lblRoundCount.Text = "Počet kôl";
            // 
            // numRoundCount
            // 
            this.numRoundCount.Location = new System.Drawing.Point(129, 87);
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
            this.lblWinnersCount.Location = new System.Drawing.Point(31, 132);
            this.lblWinnersCount.Name = "lblWinnersCount";
            this.lblWinnersCount.Size = new System.Drawing.Size(78, 13);
            this.lblWinnersCount.TabIndex = 5;
            this.lblWinnersCount.Text = "Víťazné miesta";
            // 
            // numWinnersCount
            // 
            this.numWinnersCount.Location = new System.Drawing.Point(129, 130);
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
            this.btnOk.Location = new System.Drawing.Point(129, 170);
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
            this.btnCancel.Location = new System.Drawing.Point(25, 170);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Zrušiť";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // NewRaceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(245, 218);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.numWinnersCount);
            this.Controls.Add(this.lblWinnersCount);
            this.Controls.Add(this.numRoundCount);
            this.Controls.Add(this.lblRoundCount);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.numRoundLength);
            this.Controls.Add(this.lblRoundLength);
            this.Name = "NewRaceWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nový pretek";
            this.Load += new System.EventHandler(this.NewRaceWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRoundLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoundCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWinnersCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}