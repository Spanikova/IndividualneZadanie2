namespace FinishLine
{
    partial class MainWindow
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
            System.Windows.Forms.ToolStripMenuItem menuNewRace;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRunner = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.menuChangeDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRunnersList = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlRaceProperties = new System.Windows.Forms.Panel();
            this.lblWinnersCount = new System.Windows.Forms.Label();
            this.lblRndCount = new System.Windows.Forms.Label();
            this.lblRndLength = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            menuNewRace = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlRaceProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuNewRace
            // 
            menuNewRace.Name = "menuNewRace";
            menuNewRace.Size = new System.Drawing.Size(138, 22);
            menuNewRace.Text = "Nový pretek";
            menuNewRace.Click += new System.EventHandler(this.menuNewRace_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuRunner});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1021, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            menuNewRace,
            this.menuOpen,
            this.menuSave});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(50, 20);
            this.menuFile.Text = "Súbor";
            // 
            // menuOpen
            // 
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(138, 22);
            this.menuOpen.Text = "Otvoriť";
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(138, 22);
            this.menuSave.Text = "Uložiť";
            // 
            // menuRunner
            // 
            this.menuRunner.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRegister,
            this.menuChangeDelete,
            this.menuRunnersList});
            this.menuRunner.Name = "menuRunner";
            this.menuRunner.Size = new System.Drawing.Size(46, 20);
            this.menuRunner.Text = "Bežci";
            // 
            // menuRegister
            // 
            this.menuRegister.Name = "menuRegister";
            this.menuRegister.Size = new System.Drawing.Size(164, 22);
            this.menuRegister.Text = "Registrácia";
            this.menuRegister.Click += new System.EventHandler(this.menuRegister_Click);
            // 
            // menuChangeDelete
            // 
            this.menuChangeDelete.Name = "menuChangeDelete";
            this.menuChangeDelete.Size = new System.Drawing.Size(164, 22);
            this.menuChangeDelete.Text = "Zmazať / Upraviť";
            this.menuChangeDelete.Click += new System.EventHandler(this.menuChangeDelete_Click);
            // 
            // menuRunnersList
            // 
            this.menuRunnersList.Name = "menuRunnersList";
            this.menuRunnersList.Size = new System.Drawing.Size(164, 22);
            this.menuRunnersList.Text = "Zobraziť zoznam";
            this.menuRunnersList.Click += new System.EventHandler(this.menuRunnersList_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(7, 10);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Štart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Visible = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Enabled = false;
            this.btnFinish.Location = new System.Drawing.Point(119, 10);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(95, 23);
            this.btnFinish.TabIndex = 2;
            this.btnFinish.Text = "Ukončiť pretek";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Visible = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFinish);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Location = new System.Drawing.Point(19, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 45);
            this.panel1.TabIndex = 3;
            // 
            // pnlRaceProperties
            // 
            this.pnlRaceProperties.Controls.Add(this.lblStartTime);
            this.pnlRaceProperties.Controls.Add(this.lblWinnersCount);
            this.pnlRaceProperties.Controls.Add(this.lblRndCount);
            this.pnlRaceProperties.Controls.Add(this.lblRndLength);
            this.pnlRaceProperties.Location = new System.Drawing.Point(371, 29);
            this.pnlRaceProperties.Name = "pnlRaceProperties";
            this.pnlRaceProperties.Size = new System.Drawing.Size(638, 44);
            this.pnlRaceProperties.TabIndex = 4;
            this.pnlRaceProperties.Visible = false;
            // 
            // lblWinnersCount
            // 
            this.lblWinnersCount.AutoSize = true;
            this.lblWinnersCount.Location = new System.Drawing.Point(262, 15);
            this.lblWinnersCount.Name = "lblWinnersCount";
            this.lblWinnersCount.Size = new System.Drawing.Size(153, 13);
            this.lblWinnersCount.TabIndex = 2;
            this.lblWinnersCount.Text = "Počet vyhodnocovaných miest";
            // 
            // lblRndCount
            // 
            this.lblRndCount.AutoSize = true;
            this.lblRndCount.Location = new System.Drawing.Point(157, 15);
            this.lblRndCount.Name = "lblRndCount";
            this.lblRndCount.Size = new System.Drawing.Size(52, 13);
            this.lblRndCount.TabIndex = 1;
            this.lblRndCount.Text = "Počet kôl";
            // 
            // lblRndLength
            // 
            this.lblRndLength.AutoSize = true;
            this.lblRndLength.Location = new System.Drawing.Point(19, 15);
            this.lblRndLength.MinimumSize = new System.Drawing.Size(10, 0);
            this.lblRndLength.Name = "lblRndLength";
            this.lblRndLength.Size = new System.Drawing.Size(58, 13);
            this.lblRndLength.TabIndex = 0;
            this.lblRndLength.Text = "Dĺžka kola";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(468, 15);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(60, 13);
            this.lblStartTime.TabIndex = 3;
            this.lblStartTime.Text = "Čas štartu: ";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 519);
            this.Controls.Add(this.pnlRaceProperties);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preteky";
            this.Activated += new System.EventHandler(this.MainWindow_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlRaceProperties.ResumeLayout(false);
            this.pnlRaceProperties.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuRunner;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem menuRegister;
        private System.Windows.Forms.ToolStripMenuItem menuChangeDelete;
        private System.Windows.Forms.ToolStripMenuItem menuRunnersList;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlRaceProperties;
        private System.Windows.Forms.Label lblRndLength;
        private System.Windows.Forms.Label lblRndCount;
        private System.Windows.Forms.Label lblWinnersCount;
        private System.Windows.Forms.Label lblStartTime;
    }
}

