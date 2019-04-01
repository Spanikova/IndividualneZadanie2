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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.menuRace = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRunner = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.menuChangeDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRunnersList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLoadRunnersList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveWinners = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.pnlButtonsStartStop = new System.Windows.Forms.Panel();
            this.pnlRaceProperties = new System.Windows.Forms.Panel();
            this.lblRaceLength = new System.Windows.Forms.Label();
            this.lblWinnersCount = new System.Windows.Forms.Label();
            this.lblRndCount = new System.Windows.Forms.Label();
            this.lblRndLength = new System.Windows.Forms.Label();
            this.pnlRunThroughFinish = new System.Windows.Forms.Panel();
            this.btnAcceptRunnerNr = new System.Windows.Forms.Button();
            this.numRunnerRegNr = new System.Windows.Forms.NumericUpDown();
            this.lblInfoWriteNr = new System.Windows.Forms.Label();
            this.pnlRacePanel = new System.Windows.Forms.Panel();
            this.dtGrdRaceRun = new System.Windows.Forms.DataGridView();
            this.ColRegNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNrOfLaps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLapTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtGrdRaceResults = new System.Windows.Forms.DataGridView();
            this.ColPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStartNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRunnerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTables = new System.Windows.Forms.Panel();
            this.lblWinners = new System.Windows.Forms.Label();
            this.lblCurrentRank = new System.Windows.Forms.Label();
            this.pnlEndRace = new System.Windows.Forms.Panel();
            this.lblEndRace = new System.Windows.Forms.Label();
            menuNewRace = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.pnlButtonsStartStop.SuspendLayout();
            this.pnlRaceProperties.SuspendLayout();
            this.pnlRunThroughFinish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRunnerRegNr)).BeginInit();
            this.pnlRacePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdRaceRun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdRaceResults)).BeginInit();
            this.pnlTables.SuspendLayout();
            this.pnlEndRace.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuNewRace
            // 
            menuNewRace.Name = "menuNewRace";
            menuNewRace.Size = new System.Drawing.Size(144, 22);
            menuNewRace.Text = "Nové preteky";
            menuNewRace.Click += new System.EventHandler(this.menuNewRace_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRace,
            this.menuRunner,
            this.menuSaveWinners});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(950, 24);
            this.mainMenu.TabIndex = 0;
            // 
            // menuRace
            // 
            this.menuRace.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            menuNewRace,
            this.menuOpen,
            this.menuSave});
            this.menuRace.Name = "menuRace";
            this.menuRace.Size = new System.Drawing.Size(58, 20);
            this.menuRace.Text = "Preteky";
            // 
            // menuOpen
            // 
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(144, 22);
            this.menuOpen.Text = "Otvoriť";
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(144, 22);
            this.menuSave.Text = "Uložiť";
            // 
            // menuRunner
            // 
            this.menuRunner.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRegister,
            this.menuChangeDelete,
            this.menuRunnersList,
            this.menuSaveList,
            this.menuLoadRunnersList});
            this.menuRunner.Name = "menuRunner";
            this.menuRunner.Size = new System.Drawing.Size(46, 20);
            this.menuRunner.Text = "Bežci";
            this.menuRunner.Click += new System.EventHandler(this.menuRunner_Click);
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
            // menuSaveList
            // 
            this.menuSaveList.Name = "menuSaveList";
            this.menuSaveList.Size = new System.Drawing.Size(164, 22);
            this.menuSaveList.Text = "Uložiť zoznam";
            this.menuSaveList.Click += new System.EventHandler(this.menuSaveList_Click);
            // 
            // menuLoadRunnersList
            // 
            this.menuLoadRunnersList.Name = "menuLoadRunnersList";
            this.menuLoadRunnersList.Size = new System.Drawing.Size(164, 22);
            this.menuLoadRunnersList.Text = "Nahrať zoznam";
            this.menuLoadRunnersList.Click += new System.EventHandler(this.menuLoadRunnersList_Click);
            // 
            // menuSaveWinners
            // 
            this.menuSaveWinners.Name = "menuSaveWinners";
            this.menuSaveWinners.Size = new System.Drawing.Size(134, 20);
            this.menuSaveWinners.Text = "Uložiť poradie víťazov";
            this.menuSaveWinners.Visible = false;
            this.menuSaveWinners.Click += new System.EventHandler(this.menuSaveWinners_Click);
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
            this.btnFinish.Text = "Ukončiť preteky";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Visible = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // pnlButtonsStartStop
            // 
            this.pnlButtonsStartStop.Controls.Add(this.btnFinish);
            this.pnlButtonsStartStop.Controls.Add(this.btnStart);
            this.pnlButtonsStartStop.Location = new System.Drawing.Point(12, 8);
            this.pnlButtonsStartStop.Name = "pnlButtonsStartStop";
            this.pnlButtonsStartStop.Size = new System.Drawing.Size(249, 45);
            this.pnlButtonsStartStop.TabIndex = 3;
            // 
            // pnlRaceProperties
            // 
            this.pnlRaceProperties.Controls.Add(this.lblRaceLength);
            this.pnlRaceProperties.Controls.Add(this.lblWinnersCount);
            this.pnlRaceProperties.Controls.Add(this.lblRndCount);
            this.pnlRaceProperties.Controls.Add(this.lblRndLength);
            this.pnlRaceProperties.Location = new System.Drawing.Point(267, 8);
            this.pnlRaceProperties.Name = "pnlRaceProperties";
            this.pnlRaceProperties.Size = new System.Drawing.Size(751, 44);
            this.pnlRaceProperties.TabIndex = 4;
            this.pnlRaceProperties.Visible = false;
            // 
            // lblRaceLength
            // 
            this.lblRaceLength.AutoSize = true;
            this.lblRaceLength.Location = new System.Drawing.Point(224, 15);
            this.lblRaceLength.Name = "lblRaceLength";
            this.lblRaceLength.Size = new System.Drawing.Size(89, 13);
            this.lblRaceLength.TabIndex = 4;
            this.lblRaceLength.Text = " Dĺžka pretekov: ";
            // 
            // lblWinnersCount
            // 
            this.lblWinnersCount.AutoSize = true;
            this.lblWinnersCount.Location = new System.Drawing.Point(370, 15);
            this.lblWinnersCount.Name = "lblWinnersCount";
            this.lblWinnersCount.Size = new System.Drawing.Size(156, 13);
            this.lblWinnersCount.TabIndex = 2;
            this.lblWinnersCount.Text = "Počet vyhodnocovaných miest:";
            // 
            // lblRndCount
            // 
            this.lblRndCount.AutoSize = true;
            this.lblRndCount.Location = new System.Drawing.Point(120, 15);
            this.lblRndCount.Name = "lblRndCount";
            this.lblRndCount.Size = new System.Drawing.Size(55, 13);
            this.lblRndCount.TabIndex = 1;
            this.lblRndCount.Text = "Počet kôl:";
            // 
            // lblRndLength
            // 
            this.lblRndLength.AutoSize = true;
            this.lblRndLength.Location = new System.Drawing.Point(19, 15);
            this.lblRndLength.MinimumSize = new System.Drawing.Size(10, 0);
            this.lblRndLength.Name = "lblRndLength";
            this.lblRndLength.Size = new System.Drawing.Size(61, 13);
            this.lblRndLength.TabIndex = 0;
            this.lblRndLength.Text = "Dĺžka kola:";
            // 
            // pnlRunThroughFinish
            // 
            this.pnlRunThroughFinish.Controls.Add(this.btnAcceptRunnerNr);
            this.pnlRunThroughFinish.Controls.Add(this.numRunnerRegNr);
            this.pnlRunThroughFinish.Controls.Add(this.lblInfoWriteNr);
            this.pnlRunThroughFinish.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRunThroughFinish.Location = new System.Drawing.Point(0, 472);
            this.pnlRunThroughFinish.Name = "pnlRunThroughFinish";
            this.pnlRunThroughFinish.Size = new System.Drawing.Size(950, 82);
            this.pnlRunThroughFinish.TabIndex = 5;
            this.pnlRunThroughFinish.Visible = false;
            // 
            // btnAcceptRunnerNr
            // 
            this.btnAcceptRunnerNr.Location = new System.Drawing.Point(183, 41);
            this.btnAcceptRunnerNr.Name = "btnAcceptRunnerNr";
            this.btnAcceptRunnerNr.Size = new System.Drawing.Size(75, 20);
            this.btnAcceptRunnerNr.TabIndex = 2;
            this.btnAcceptRunnerNr.Text = "Potvrdiť";
            this.btnAcceptRunnerNr.UseVisualStyleBackColor = true;
            this.btnAcceptRunnerNr.Click += new System.EventHandler(this.btnAcceptRunnerNr_Click);
            // 
            // numRunnerRegNr
            // 
            this.numRunnerRegNr.Location = new System.Drawing.Point(98, 41);
            this.numRunnerRegNr.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numRunnerRegNr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRunnerRegNr.Name = "numRunnerRegNr";
            this.numRunnerRegNr.Size = new System.Drawing.Size(64, 20);
            this.numRunnerRegNr.TabIndex = 1;
            this.numRunnerRegNr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblInfoWriteNr
            // 
            this.lblInfoWriteNr.AutoSize = true;
            this.lblInfoWriteNr.Location = new System.Drawing.Point(57, 17);
            this.lblInfoWriteNr.Name = "lblInfoWriteNr";
            this.lblInfoWriteNr.Size = new System.Drawing.Size(225, 13);
            this.lblInfoWriteNr.TabIndex = 0;
            this.lblInfoWriteNr.Text = "Zadajte číslo pretekára, ktorý prebehol cieľom";
            // 
            // pnlRacePanel
            // 
            this.pnlRacePanel.Controls.Add(this.pnlButtonsStartStop);
            this.pnlRacePanel.Controls.Add(this.pnlRaceProperties);
            this.pnlRacePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRacePanel.Location = new System.Drawing.Point(0, 24);
            this.pnlRacePanel.Name = "pnlRacePanel";
            this.pnlRacePanel.Size = new System.Drawing.Size(950, 63);
            this.pnlRacePanel.TabIndex = 6;
            // 
            // dtGrdRaceRun
            // 
            this.dtGrdRaceRun.AllowUserToAddRows = false;
            this.dtGrdRaceRun.AllowUserToDeleteRows = false;
            this.dtGrdRaceRun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdRaceRun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColRegNr,
            this.ColName,
            this.ColNrOfLaps,
            this.ColLapTime,
            this.ColTotalTime});
            this.dtGrdRaceRun.Location = new System.Drawing.Point(12, 28);
            this.dtGrdRaceRun.Name = "dtGrdRaceRun";
            this.dtGrdRaceRun.ReadOnly = true;
            this.dtGrdRaceRun.RowHeadersVisible = false;
            this.dtGrdRaceRun.Size = new System.Drawing.Size(452, 357);
            this.dtGrdRaceRun.TabIndex = 7;
            // 
            // ColRegNr
            // 
            this.ColRegNr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColRegNr.HeaderText = "Št. č.";
            this.ColRegNr.Name = "ColRegNr";
            this.ColRegNr.ReadOnly = true;
            this.ColRegNr.Width = 40;
            // 
            // ColName
            // 
            this.ColName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColName.HeaderText = "Meno";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            // 
            // ColNrOfLaps
            // 
            this.ColNrOfLaps.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColNrOfLaps.HeaderText = "Kolo";
            this.ColNrOfLaps.Name = "ColNrOfLaps";
            this.ColNrOfLaps.ReadOnly = true;
            this.ColNrOfLaps.Width = 40;
            // 
            // ColLapTime
            // 
            this.ColLapTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColLapTime.HeaderText = "Čas kola";
            this.ColLapTime.Name = "ColLapTime";
            this.ColLapTime.ReadOnly = true;
            this.ColLapTime.Width = 73;
            // 
            // ColTotalTime
            // 
            this.ColTotalTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColTotalTime.HeaderText = "Celkový čas";
            this.ColTotalTime.Name = "ColTotalTime";
            this.ColTotalTime.ReadOnly = true;
            this.ColTotalTime.Width = 83;
            // 
            // dtGrdRaceResults
            // 
            this.dtGrdRaceResults.AllowUserToAddRows = false;
            this.dtGrdRaceResults.AllowUserToDeleteRows = false;
            this.dtGrdRaceResults.AllowUserToResizeColumns = false;
            this.dtGrdRaceResults.AllowUserToResizeRows = false;
            this.dtGrdRaceResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdRaceResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColPlace,
            this.ColStartNr,
            this.ColRunnerName,
            this.ColTime,
            this.ColCountry});
            this.dtGrdRaceResults.Location = new System.Drawing.Point(494, 28);
            this.dtGrdRaceResults.Name = "dtGrdRaceResults";
            this.dtGrdRaceResults.RowHeadersVisible = false;
            this.dtGrdRaceResults.Size = new System.Drawing.Size(444, 357);
            this.dtGrdRaceResults.TabIndex = 8;
            // 
            // ColPlace
            // 
            this.ColPlace.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColPlace.HeaderText = "Miesto";
            this.ColPlace.Name = "ColPlace";
            this.ColPlace.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColPlace.Width = 45;
            // 
            // ColStartNr
            // 
            this.ColStartNr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColStartNr.HeaderText = "Št. č.";
            this.ColStartNr.Name = "ColStartNr";
            this.ColStartNr.Width = 40;
            // 
            // ColRunnerName
            // 
            this.ColRunnerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColRunnerName.HeaderText = "Meno";
            this.ColRunnerName.Name = "ColRunnerName";
            this.ColRunnerName.Width = 59;
            // 
            // ColTime
            // 
            this.ColTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColTime.HeaderText = "Čas";
            this.ColTime.Name = "ColTime";
            this.ColTime.Width = 50;
            // 
            // ColCountry
            // 
            this.ColCountry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColCountry.HeaderText = "Krajina";
            this.ColCountry.Name = "ColCountry";
            // 
            // pnlTables
            // 
            this.pnlTables.Controls.Add(this.lblWinners);
            this.pnlTables.Controls.Add(this.lblCurrentRank);
            this.pnlTables.Controls.Add(this.dtGrdRaceRun);
            this.pnlTables.Controls.Add(this.dtGrdRaceResults);
            this.pnlTables.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTables.Location = new System.Drawing.Point(0, 87);
            this.pnlTables.Name = "pnlTables";
            this.pnlTables.Size = new System.Drawing.Size(950, 385);
            this.pnlTables.TabIndex = 3;
            this.pnlTables.Visible = false;
            // 
            // lblWinners
            // 
            this.lblWinners.AutoSize = true;
            this.lblWinners.Location = new System.Drawing.Point(676, 3);
            this.lblWinners.Name = "lblWinners";
            this.lblWinners.Size = new System.Drawing.Size(88, 13);
            this.lblWinners.TabIndex = 10;
            this.lblWinners.Text = "Konečné poradie";
            // 
            // lblCurrentRank
            // 
            this.lblCurrentRank.AutoSize = true;
            this.lblCurrentRank.Location = new System.Drawing.Point(180, 3);
            this.lblCurrentRank.Name = "lblCurrentRank";
            this.lblCurrentRank.Size = new System.Drawing.Size(92, 13);
            this.lblCurrentRank.TabIndex = 9;
            this.lblCurrentRank.Text = "Priebežné poradie";
            // 
            // pnlEndRace
            // 
            this.pnlEndRace.Controls.Add(this.lblEndRace);
            this.pnlEndRace.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEndRace.Location = new System.Drawing.Point(0, 542);
            this.pnlEndRace.Name = "pnlEndRace";
            this.pnlEndRace.Size = new System.Drawing.Size(950, 85);
            this.pnlEndRace.TabIndex = 7;
            this.pnlEndRace.Visible = false;
            // 
            // lblEndRace
            // 
            this.lblEndRace.AutoSize = true;
            this.lblEndRace.Location = new System.Drawing.Point(360, 15);
            this.lblEndRace.Name = "lblEndRace";
            this.lblEndRace.Size = new System.Drawing.Size(111, 13);
            this.lblEndRace.TabIndex = 0;
            this.lblEndRace.Text = "Preteky bol ukončené";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 627);
            this.Controls.Add(this.pnlEndRace);
            this.Controls.Add(this.pnlRunThroughFinish);
            this.Controls.Add(this.pnlTables);
            this.Controls.Add(this.pnlRacePanel);
            this.Controls.Add(this.mainMenu);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preteky";
            this.Activated += new System.EventHandler(this.MainWindow_Activated);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.pnlButtonsStartStop.ResumeLayout(false);
            this.pnlRaceProperties.ResumeLayout(false);
            this.pnlRaceProperties.PerformLayout();
            this.pnlRunThroughFinish.ResumeLayout(false);
            this.pnlRunThroughFinish.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRunnerRegNr)).EndInit();
            this.pnlRacePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdRaceRun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdRaceResults)).EndInit();
            this.pnlTables.ResumeLayout(false);
            this.pnlTables.PerformLayout();
            this.pnlEndRace.ResumeLayout(false);
            this.pnlEndRace.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuRace;
        private System.Windows.Forms.ToolStripMenuItem menuRunner;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem menuRegister;
        private System.Windows.Forms.ToolStripMenuItem menuChangeDelete;
        private System.Windows.Forms.ToolStripMenuItem menuRunnersList;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Panel pnlButtonsStartStop;
        private System.Windows.Forms.Panel pnlRaceProperties;
        private System.Windows.Forms.Label lblRndLength;
        private System.Windows.Forms.Label lblRndCount;
        private System.Windows.Forms.Label lblWinnersCount;
        private System.Windows.Forms.Panel pnlRunThroughFinish;
        private System.Windows.Forms.Button btnAcceptRunnerNr;
        private System.Windows.Forms.NumericUpDown numRunnerRegNr;
        private System.Windows.Forms.Label lblInfoWriteNr;
        private System.Windows.Forms.Panel pnlRacePanel;
        private System.Windows.Forms.DataGridView dtGrdRaceRun;
        private System.Windows.Forms.DataGridView dtGrdRaceResults;
        private System.Windows.Forms.Panel pnlTables;
        private System.Windows.Forms.Label lblRaceLength;
        private System.Windows.Forms.Label lblWinners;
        private System.Windows.Forms.Label lblCurrentRank;
        private System.Windows.Forms.Panel pnlEndRace;
        private System.Windows.Forms.Label lblEndRace;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRegNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNrOfLaps;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLapTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStartNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRunnerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCountry;
        private System.Windows.Forms.ToolStripMenuItem menuSaveList;
        private System.Windows.Forms.ToolStripMenuItem menuLoadRunnersList;
        private System.Windows.Forms.ToolStripMenuItem menuSaveWinners;
    }
}

