namespace League_All_in_One
{
    partial class LeagueAIO
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TabControllerPanel = new System.Windows.Forms.Panel();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.MainPage = new System.Windows.Forms.TabPage();
            this.AutoSpamChatToggle = new League_All_in_One.FlatToggle();
            this.AutoChampSelectToggle = new League_All_in_One.FlatToggle();
            this.AutoAcceptToggle = new League_All_in_One.FlatToggle();
            this.CreateMatchToggle = new League_All_in_One.FlatToggle();
            this.AutoLoginToggle = new League_All_in_One.FlatToggle();
            this.AutoStartLeagueToggle = new League_All_in_One.FlatToggle();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.LiveStatusLabel = new MaterialSkin.Controls.MaterialLabel();
            this.LiveStatusColorPanel = new System.Windows.Forms.Panel();
            this.MainOperationsBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.MainPanel.SuspendLayout();
            this.TabControllerPanel.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.MainPage.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.Controls.Add(this.TabControllerPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainPanel.ForeColor = System.Drawing.Color.Transparent;
            this.MainPanel.Location = new System.Drawing.Point(0, 64);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(826, 579);
            this.MainPanel.TabIndex = 1;
            // 
            // TabControllerPanel
            // 
            this.TabControllerPanel.Controls.Add(this.materialTabControl1);
            this.TabControllerPanel.Controls.Add(this.TopPanel);
            this.TabControllerPanel.Controls.Add(this.BottomPanel);
            this.TabControllerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControllerPanel.Location = new System.Drawing.Point(0, 0);
            this.TabControllerPanel.Name = "TabControllerPanel";
            this.TabControllerPanel.Size = new System.Drawing.Size(826, 579);
            this.TabControllerPanel.TabIndex = 2;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.MainPage);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 45);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(826, 514);
            this.materialTabControl1.TabIndex = 2;
            // 
            // MainPage
            // 
            this.MainPage.Controls.Add(this.AutoSpamChatToggle);
            this.MainPage.Controls.Add(this.AutoChampSelectToggle);
            this.MainPage.Controls.Add(this.AutoAcceptToggle);
            this.MainPage.Controls.Add(this.CreateMatchToggle);
            this.MainPage.Controls.Add(this.AutoLoginToggle);
            this.MainPage.Controls.Add(this.AutoStartLeagueToggle);
            this.MainPage.Controls.Add(this.materialLabel6);
            this.MainPage.Controls.Add(this.materialLabel5);
            this.MainPage.Controls.Add(this.materialLabel4);
            this.MainPage.Controls.Add(this.materialLabel3);
            this.MainPage.Controls.Add(this.materialLabel2);
            this.MainPage.Controls.Add(this.materialLabel1);
            this.MainPage.Location = new System.Drawing.Point(4, 22);
            this.MainPage.Name = "MainPage";
            this.MainPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainPage.Size = new System.Drawing.Size(818, 488);
            this.MainPage.TabIndex = 0;
            this.MainPage.Text = "Main";
            this.MainPage.UseVisualStyleBackColor = true;
            // 
            // AutoSpamChatToggle
            // 
            this.AutoSpamChatToggle.BackColor = System.Drawing.Color.Transparent;
            this.AutoSpamChatToggle.Checked = false;
            this.AutoSpamChatToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoSpamChatToggle.Enabled = false;
            this.AutoSpamChatToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoSpamChatToggle.Location = new System.Drawing.Point(169, 218);
            this.AutoSpamChatToggle.Name = "AutoSpamChatToggle";
            this.AutoSpamChatToggle.Options = League_All_in_One.FlatToggle._Options.Style3;
            this.AutoSpamChatToggle.Size = new System.Drawing.Size(76, 33);
            this.AutoSpamChatToggle.TabIndex = 11;
            this.AutoSpamChatToggle.CheckedChanged += new League_All_in_One.FlatToggle.CheckedChangedEventHandler(this.AutoSpamChatToggle_CheckedChanged);
            // 
            // AutoChampSelectToggle
            // 
            this.AutoChampSelectToggle.BackColor = System.Drawing.Color.Transparent;
            this.AutoChampSelectToggle.Checked = false;
            this.AutoChampSelectToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoChampSelectToggle.Enabled = false;
            this.AutoChampSelectToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoChampSelectToggle.Location = new System.Drawing.Point(169, 179);
            this.AutoChampSelectToggle.Name = "AutoChampSelectToggle";
            this.AutoChampSelectToggle.Options = League_All_in_One.FlatToggle._Options.Style3;
            this.AutoChampSelectToggle.Size = new System.Drawing.Size(76, 33);
            this.AutoChampSelectToggle.TabIndex = 10;
            this.AutoChampSelectToggle.CheckedChanged += new League_All_in_One.FlatToggle.CheckedChangedEventHandler(this.AutoChampSelectToggle_CheckedChanged);
            // 
            // AutoAcceptToggle
            // 
            this.AutoAcceptToggle.BackColor = System.Drawing.Color.Transparent;
            this.AutoAcceptToggle.Checked = false;
            this.AutoAcceptToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoAcceptToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoAcceptToggle.Location = new System.Drawing.Point(169, 140);
            this.AutoAcceptToggle.Name = "AutoAcceptToggle";
            this.AutoAcceptToggle.Options = League_All_in_One.FlatToggle._Options.Style3;
            this.AutoAcceptToggle.Size = new System.Drawing.Size(76, 33);
            this.AutoAcceptToggle.TabIndex = 9;
            this.AutoAcceptToggle.CheckedChanged += new League_All_in_One.FlatToggle.CheckedChangedEventHandler(this.AutoAcceptToggle_CheckedChanged);
            // 
            // CreateMatchToggle
            // 
            this.CreateMatchToggle.BackColor = System.Drawing.Color.Transparent;
            this.CreateMatchToggle.Checked = false;
            this.CreateMatchToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateMatchToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateMatchToggle.Location = new System.Drawing.Point(169, 101);
            this.CreateMatchToggle.Name = "CreateMatchToggle";
            this.CreateMatchToggle.Options = League_All_in_One.FlatToggle._Options.Style3;
            this.CreateMatchToggle.Size = new System.Drawing.Size(76, 33);
            this.CreateMatchToggle.TabIndex = 8;
            this.CreateMatchToggle.CheckedChanged += new League_All_in_One.FlatToggle.CheckedChangedEventHandler(this.CreateMatchToggle_CheckedChanged);
            // 
            // AutoLoginToggle
            // 
            this.AutoLoginToggle.BackColor = System.Drawing.Color.Transparent;
            this.AutoLoginToggle.Checked = false;
            this.AutoLoginToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoLoginToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoLoginToggle.Location = new System.Drawing.Point(169, 62);
            this.AutoLoginToggle.Name = "AutoLoginToggle";
            this.AutoLoginToggle.Options = League_All_in_One.FlatToggle._Options.Style3;
            this.AutoLoginToggle.Size = new System.Drawing.Size(76, 33);
            this.AutoLoginToggle.TabIndex = 7;
            this.AutoLoginToggle.CheckedChanged += new League_All_in_One.FlatToggle.CheckedChangedEventHandler(this.AutoLoginToggle_CheckedChanged);
            // 
            // AutoStartLeagueToggle
            // 
            this.AutoStartLeagueToggle.BackColor = System.Drawing.Color.Transparent;
            this.AutoStartLeagueToggle.Checked = false;
            this.AutoStartLeagueToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoStartLeagueToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoStartLeagueToggle.Location = new System.Drawing.Point(169, 23);
            this.AutoStartLeagueToggle.Name = "AutoStartLeagueToggle";
            this.AutoStartLeagueToggle.Options = League_All_in_One.FlatToggle._Options.Style3;
            this.AutoStartLeagueToggle.Size = new System.Drawing.Size(76, 33);
            this.AutoStartLeagueToggle.TabIndex = 6;
            this.AutoStartLeagueToggle.CheckedChanged += new League_All_in_One.FlatToggle.CheckedChangedEventHandler(this.AutoStartLeagueToggle_CheckedChanged);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(41, 223);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(122, 19);
            this.materialLabel6.TabIndex = 5;
            this.materialLabel6.Text = "Auto Spam Chat:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(21, 184);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(142, 19);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Auto Champ Select:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(67, 145);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(96, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Auto Accept:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(60, 106);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(103, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Create Match:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(77, 67);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(86, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Auto Login:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(30, 28);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(133, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Auto Start League:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(818, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.materialTabSelector1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(826, 45);
            this.TopPanel.TabIndex = 1;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(826, 45);
            this.materialTabSelector1.TabIndex = 2;
            this.materialTabSelector1.Text = "``";
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.LiveStatusLabel);
            this.BottomPanel.Controls.Add(this.LiveStatusColorPanel);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 559);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Padding = new System.Windows.Forms.Padding(3);
            this.BottomPanel.Size = new System.Drawing.Size(826, 20);
            this.BottomPanel.TabIndex = 0;
            // 
            // LiveStatusLabel
            // 
            this.LiveStatusLabel.AutoSize = true;
            this.LiveStatusLabel.Depth = 0;
            this.LiveStatusLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LiveStatusLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.LiveStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LiveStatusLabel.Location = new System.Drawing.Point(13, 3);
            this.LiveStatusLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.LiveStatusLabel.Name = "LiveStatusLabel";
            this.LiveStatusLabel.Size = new System.Drawing.Size(0, 19);
            this.LiveStatusLabel.TabIndex = 2;
            // 
            // LiveStatusColorPanel
            // 
            this.LiveStatusColorPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LiveStatusColorPanel.Location = new System.Drawing.Point(3, 3);
            this.LiveStatusColorPanel.Name = "LiveStatusColorPanel";
            this.LiveStatusColorPanel.Size = new System.Drawing.Size(10, 14);
            this.LiveStatusColorPanel.TabIndex = 3;
            // 
            // MainOperationsBackgroundWorker
            // 
            this.MainOperationsBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.MainOperationsBackgroundWorker_DoWork);
            // 
            // LeagueAIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 643);
            this.Controls.Add(this.MainPanel);
            this.MaximizeBox = false;
            this.Name = "LeagueAIO";
            this.Text = "All For One - League";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LeagueAIO_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainPanel.ResumeLayout(false);
            this.TabControllerPanel.ResumeLayout(false);
            this.materialTabControl1.ResumeLayout(false);
            this.MainPage.ResumeLayout(false);
            this.MainPage.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel TabControllerPanel;
        private System.Windows.Forms.Panel TopPanel;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.Panel BottomPanel;
        private MaterialSkin.Controls.MaterialLabel LiveStatusLabel;
        private System.Windows.Forms.Panel LiveStatusColorPanel;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage MainPage;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private FlatToggle AutoStartLeagueToggle;
        private FlatToggle AutoSpamChatToggle;
        private FlatToggle AutoChampSelectToggle;
        private FlatToggle AutoAcceptToggle;
        private FlatToggle CreateMatchToggle;
        private FlatToggle AutoLoginToggle;
        private System.ComponentModel.BackgroundWorker MainOperationsBackgroundWorker;
    }
}

