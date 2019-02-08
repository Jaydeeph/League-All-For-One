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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeagueAIO));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TabControllerPanel = new System.Windows.Forms.Panel();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.ImageRecognitionPage = new System.Windows.Forms.TabPage();
            this.StartAutoImageRecognitionButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.AutoLockChampionToggle = new League_All_in_One.FlatToggle();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.AutoSelectChampionToggle = new League_All_in_One.FlatToggle();
            this.AutoAcceptToggle = new League_All_in_One.FlatToggle();
            this.AutoCreateMatchToggle = new League_All_in_One.FlatToggle();
            this.AutoLoginToggle = new League_All_in_One.FlatToggle();
            this.AutoStartLeagueToggle = new League_All_in_One.FlatToggle();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.ManualPage = new System.Windows.Forms.TabPage();
            this.PingTestPage = new System.Windows.Forms.TabPage();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.LiveStatusLabel = new MaterialSkin.Controls.MaterialLabel();
            this.LiveStatusColorPanel = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            this.TabControllerPanel.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.ImageRecognitionPage.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsButton)).BeginInit();
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
            this.MainPanel.Size = new System.Drawing.Size(466, 402);
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
            this.TabControllerPanel.Size = new System.Drawing.Size(466, 402);
            this.TabControllerPanel.TabIndex = 2;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.ImageRecognitionPage);
            this.materialTabControl1.Controls.Add(this.ManualPage);
            this.materialTabControl1.Controls.Add(this.PingTestPage);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 45);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(466, 337);
            this.materialTabControl1.TabIndex = 2;
            // 
            // ImageRecognitionPage
            // 
            this.ImageRecognitionPage.BackColor = System.Drawing.Color.White;
            this.ImageRecognitionPage.Controls.Add(this.StartAutoImageRecognitionButton);
            this.ImageRecognitionPage.Controls.Add(this.AutoLockChampionToggle);
            this.ImageRecognitionPage.Controls.Add(this.materialLabel6);
            this.ImageRecognitionPage.Controls.Add(this.AutoSelectChampionToggle);
            this.ImageRecognitionPage.Controls.Add(this.AutoAcceptToggle);
            this.ImageRecognitionPage.Controls.Add(this.AutoCreateMatchToggle);
            this.ImageRecognitionPage.Controls.Add(this.AutoLoginToggle);
            this.ImageRecognitionPage.Controls.Add(this.AutoStartLeagueToggle);
            this.ImageRecognitionPage.Controls.Add(this.materialLabel5);
            this.ImageRecognitionPage.Controls.Add(this.materialLabel4);
            this.ImageRecognitionPage.Controls.Add(this.materialLabel3);
            this.ImageRecognitionPage.Controls.Add(this.materialLabel2);
            this.ImageRecognitionPage.Controls.Add(this.materialLabel1);
            this.ImageRecognitionPage.Location = new System.Drawing.Point(4, 22);
            this.ImageRecognitionPage.Name = "ImageRecognitionPage";
            this.ImageRecognitionPage.Padding = new System.Windows.Forms.Padding(3);
            this.ImageRecognitionPage.Size = new System.Drawing.Size(458, 311);
            this.ImageRecognitionPage.TabIndex = 0;
            this.ImageRecognitionPage.Text = "Automatic";
            // 
            // StartAutoImageRecognitionButton
            // 
            this.StartAutoImageRecognitionButton.AutoSize = true;
            this.StartAutoImageRecognitionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartAutoImageRecognitionButton.Depth = 0;
            this.StartAutoImageRecognitionButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StartAutoImageRecognitionButton.Icon = null;
            this.StartAutoImageRecognitionButton.Location = new System.Drawing.Point(3, 272);
            this.StartAutoImageRecognitionButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StartAutoImageRecognitionButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.StartAutoImageRecognitionButton.Name = "StartAutoImageRecognitionButton";
            this.StartAutoImageRecognitionButton.Primary = false;
            this.StartAutoImageRecognitionButton.Size = new System.Drawing.Size(452, 36);
            this.StartAutoImageRecognitionButton.TabIndex = 15;
            this.StartAutoImageRecognitionButton.Text = "Start";
            this.StartAutoImageRecognitionButton.UseVisualStyleBackColor = true;
            this.StartAutoImageRecognitionButton.Click += new System.EventHandler(this.StartAutoImageRecognitionButton_Click);
            // 
            // AutoLockChampionToggle
            // 
            this.AutoLockChampionToggle.BackColor = System.Drawing.Color.Transparent;
            this.AutoLockChampionToggle.Checked = false;
            this.AutoLockChampionToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoLockChampionToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoLockChampionToggle.Location = new System.Drawing.Point(230, 178);
            this.AutoLockChampionToggle.Name = "AutoLockChampionToggle";
            this.AutoLockChampionToggle.Options = League_All_in_One.FlatToggle._Options.Style3;
            this.AutoLockChampionToggle.Size = new System.Drawing.Size(76, 33);
            this.AutoLockChampionToggle.TabIndex = 14;
            this.AutoLockChampionToggle.CheckedChanged += new League_All_in_One.FlatToggle.CheckedChangedEventHandler(this.AutoLockChampionToggle_CheckedChanged);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(91, 183);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(133, 19);
            this.materialLabel6.TabIndex = 13;
            this.materialLabel6.Text = "Auto Lock Champ:";
            // 
            // AutoSelectChampionToggle
            // 
            this.AutoSelectChampionToggle.BackColor = System.Drawing.Color.Transparent;
            this.AutoSelectChampionToggle.Checked = false;
            this.AutoSelectChampionToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoSelectChampionToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoSelectChampionToggle.Location = new System.Drawing.Point(230, 139);
            this.AutoSelectChampionToggle.Name = "AutoSelectChampionToggle";
            this.AutoSelectChampionToggle.Options = League_All_in_One.FlatToggle._Options.Style3;
            this.AutoSelectChampionToggle.Size = new System.Drawing.Size(76, 33);
            this.AutoSelectChampionToggle.TabIndex = 10;
            this.AutoSelectChampionToggle.CheckedChanged += new League_All_in_One.FlatToggle.CheckedChangedEventHandler(this.AutoSelectChampionToggle_CheckedChanged);
            // 
            // AutoAcceptToggle
            // 
            this.AutoAcceptToggle.BackColor = System.Drawing.Color.Transparent;
            this.AutoAcceptToggle.Checked = false;
            this.AutoAcceptToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoAcceptToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoAcceptToggle.Location = new System.Drawing.Point(230, 217);
            this.AutoAcceptToggle.Name = "AutoAcceptToggle";
            this.AutoAcceptToggle.Options = League_All_in_One.FlatToggle._Options.Style3;
            this.AutoAcceptToggle.Size = new System.Drawing.Size(76, 33);
            this.AutoAcceptToggle.TabIndex = 9;
            this.AutoAcceptToggle.CheckedChanged += new League_All_in_One.FlatToggle.CheckedChangedEventHandler(this.AutoAcceptToggle_CheckedChanged);
            // 
            // AutoCreateMatchToggle
            // 
            this.AutoCreateMatchToggle.BackColor = System.Drawing.Color.Transparent;
            this.AutoCreateMatchToggle.Checked = false;
            this.AutoCreateMatchToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoCreateMatchToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoCreateMatchToggle.Location = new System.Drawing.Point(230, 100);
            this.AutoCreateMatchToggle.Name = "AutoCreateMatchToggle";
            this.AutoCreateMatchToggle.Options = League_All_in_One.FlatToggle._Options.Style3;
            this.AutoCreateMatchToggle.Size = new System.Drawing.Size(76, 33);
            this.AutoCreateMatchToggle.TabIndex = 8;
            this.AutoCreateMatchToggle.CheckedChanged += new League_All_in_One.FlatToggle.CheckedChangedEventHandler(this.AutoCreateMatchToggle_CheckedChanged);
            // 
            // AutoLoginToggle
            // 
            this.AutoLoginToggle.BackColor = System.Drawing.Color.Transparent;
            this.AutoLoginToggle.Checked = false;
            this.AutoLoginToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoLoginToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoLoginToggle.Location = new System.Drawing.Point(230, 61);
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
            this.AutoStartLeagueToggle.Location = new System.Drawing.Point(230, 22);
            this.AutoStartLeagueToggle.Name = "AutoStartLeagueToggle";
            this.AutoStartLeagueToggle.Options = League_All_in_One.FlatToggle._Options.Style3;
            this.AutoStartLeagueToggle.Size = new System.Drawing.Size(76, 33);
            this.AutoStartLeagueToggle.TabIndex = 6;
            this.AutoStartLeagueToggle.CheckedChanged += new League_All_in_One.FlatToggle.CheckedChangedEventHandler(this.AutoStartLeagueToggle_CheckedChanged);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(82, 144);
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
            this.materialLabel4.Location = new System.Drawing.Point(128, 222);
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
            this.materialLabel3.Location = new System.Drawing.Point(121, 105);
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
            this.materialLabel2.Location = new System.Drawing.Point(138, 66);
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
            this.materialLabel1.Location = new System.Drawing.Point(91, 27);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(133, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Auto Start League:";
            // 
            // ManualPage
            // 
            this.ManualPage.Location = new System.Drawing.Point(4, 22);
            this.ManualPage.Name = "ManualPage";
            this.ManualPage.Padding = new System.Windows.Forms.Padding(3);
            this.ManualPage.Size = new System.Drawing.Size(458, 311);
            this.ManualPage.TabIndex = 1;
            this.ManualPage.Text = "Manual";
            this.ManualPage.UseVisualStyleBackColor = true;
            // 
            // PingTestPage
            // 
            this.PingTestPage.Location = new System.Drawing.Point(4, 22);
            this.PingTestPage.Name = "PingTestPage";
            this.PingTestPage.Padding = new System.Windows.Forms.Padding(3);
            this.PingTestPage.Size = new System.Drawing.Size(458, 311);
            this.PingTestPage.TabIndex = 2;
            this.PingTestPage.Text = "Ping Test";
            this.PingTestPage.UseVisualStyleBackColor = true;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.materialTabSelector1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(466, 45);
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
            this.materialTabSelector1.Size = new System.Drawing.Size(466, 45);
            this.materialTabSelector1.TabIndex = 2;
            this.materialTabSelector1.Text = "``";
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.Transparent;
            this.BottomPanel.Controls.Add(this.LiveStatusLabel);
            this.BottomPanel.Controls.Add(this.LiveStatusColorPanel);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 382);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Padding = new System.Windows.Forms.Padding(3);
            this.BottomPanel.Size = new System.Drawing.Size(466, 20);
            this.BottomPanel.TabIndex = 0;
            // 
            // LiveStatusLabel
            // 
            this.LiveStatusLabel.AutoSize = true;
            this.LiveStatusLabel.Depth = 0;
            this.LiveStatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
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
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.Image = global::League_All_in_One.Properties.Resources.icons8_settings_50;
            this.SettingsButton.Location = new System.Drawing.Point(388, 6);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(15, 15);
            this.SettingsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SettingsButton.TabIndex = 2;
            this.SettingsButton.TabStop = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // LeagueAIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 466);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.MainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LeagueAIO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All For One - League of Legends";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LeagueAIO_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainPanel.ResumeLayout(false);
            this.TabControllerPanel.ResumeLayout(false);
            this.materialTabControl1.ResumeLayout(false);
            this.ImageRecognitionPage.ResumeLayout(false);
            this.ImageRecognitionPage.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsButton)).EndInit();
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
        private System.Windows.Forms.TabPage ImageRecognitionPage;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private FlatToggle AutoStartLeagueToggle;
        private FlatToggle AutoSelectChampionToggle;
        private FlatToggle AutoAcceptToggle;
        private FlatToggle AutoCreateMatchToggle;
        private FlatToggle AutoLoginToggle;
        private System.Windows.Forms.PictureBox SettingsButton;
        private FlatToggle AutoLockChampionToggle;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialFlatButton StartAutoImageRecognitionButton;
        private System.Windows.Forms.TabPage ManualPage;
        private System.Windows.Forms.TabPage PingTestPage;
    }
}

