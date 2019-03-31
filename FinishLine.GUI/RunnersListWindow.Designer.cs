namespace FinishLine
{
    partial class RunnersListWindow
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
            this.dataRunnersList = new System.Windows.Forms.DataGridView();
            this.ColRegNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataRunnersList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataRunnersList
            // 
            this.dataRunnersList.AllowUserToAddRows = false;
            this.dataRunnersList.AllowUserToDeleteRows = false;
            this.dataRunnersList.AllowUserToResizeRows = false;
            this.dataRunnersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataRunnersList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataRunnersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRunnersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColRegNr,
            this.ColName,
            this.ColCountry,
            this.ColAge,
            this.ColSex});
            this.dataRunnersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataRunnersList.Location = new System.Drawing.Point(0, 0);
            this.dataRunnersList.Name = "dataRunnersList";
            this.dataRunnersList.ReadOnly = true;
            this.dataRunnersList.RowHeadersVisible = false;
            this.dataRunnersList.Size = new System.Drawing.Size(540, 359);
            this.dataRunnersList.TabIndex = 0;
            // 
            // ColRegNr
            // 
            this.ColRegNr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColRegNr.HeaderText = "Reg. číslo";
            this.ColRegNr.Name = "ColRegNr";
            this.ColRegNr.ReadOnly = true;
            this.ColRegNr.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColRegNr.Width = 81;
            // 
            // ColName
            // 
            this.ColName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColName.HeaderText = "Meno";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            // 
            // ColCountry
            // 
            this.ColCountry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColCountry.HeaderText = "Krajina";
            this.ColCountry.Name = "ColCountry";
            this.ColCountry.ReadOnly = true;
            // 
            // ColAge
            // 
            this.ColAge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColAge.HeaderText = "Vek";
            this.ColAge.Name = "ColAge";
            this.ColAge.ReadOnly = true;
            this.ColAge.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColAge.Width = 51;
            // 
            // ColSex
            // 
            this.ColSex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColSex.HeaderText = "Pohlavie";
            this.ColSex.Name = "ColSex";
            this.ColSex.ReadOnly = true;
            this.ColSex.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColSex.Width = 73;
            // 
            // RunnersListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(540, 359);
            this.Controls.Add(this.dataRunnersList);
            this.Name = "RunnersListWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zoznam bežcov";
            this.Load += new System.EventHandler(this.RunnersListWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataRunnersList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataRunnersList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRegNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSex;
    }
}