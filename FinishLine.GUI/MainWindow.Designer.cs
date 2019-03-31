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
            menuNewRace = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(902, 24);
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
            this.menuRegister.Size = new System.Drawing.Size(180, 22);
            this.menuRegister.Text = "Registrácia";
            this.menuRegister.Click += new System.EventHandler(this.menuRegister_Click);
            // 
            // menuChangeDelete
            // 
            this.menuChangeDelete.Name = "menuChangeDelete";
            this.menuChangeDelete.Size = new System.Drawing.Size(180, 22);
            this.menuChangeDelete.Text = "Zmazať / Upraviť";
            this.menuChangeDelete.Click += new System.EventHandler(this.menuChangeDelete_Click);
            // 
            // menuRunnersList
            // 
            this.menuRunnersList.Name = "menuRunnersList";
            this.menuRunnersList.Size = new System.Drawing.Size(180, 22);
            this.menuRunnersList.Text = "Zobraziť zoznam";
            this.menuRunnersList.Click += new System.EventHandler(this.menuRunnersList_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 519);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preteky";
            this.Activated += new System.EventHandler(this.MainWindow_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

