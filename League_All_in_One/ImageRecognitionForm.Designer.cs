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
            this.MainTabController = new MaterialSkin.Controls.MaterialTabControl();
            this.AutomaticPage = new System.Windows.Forms.TabPage();
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
            this.CoordinatesSelectAndLockChampionButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CoordinatesLockChampionButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.CoordinatesSelectChampionButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.AutoAcceptMatchButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.CoordinatesCreateARAMLobbyButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.CoordinatesCreateSummonersRiftLobbyButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.CoordinatesLoginToLeagueButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.CoordiantesStartLeagueClient = new MaterialSkin.Controls.MaterialFlatButton();
            this.PingTestPage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TestPingButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.PingLabel = new MaterialSkin.Controls.MaterialLabel();
            this.LANPingTestCheckbox = new MaterialSkin.Controls.MaterialRadioButton();
            this.OCEPingTestCheckbox = new MaterialSkin.Controls.MaterialRadioButton();
            this.EUNEPingTestCheckbox = new MaterialSkin.Controls.MaterialRadioButton();
            this.EUWPingTestCheckbox = new MaterialSkin.Controls.MaterialRadioButton();
            this.NAPingTestCheckbox = new MaterialSkin.Controls.MaterialRadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.LiveStatusLabel = new MaterialSkin.Controls.MaterialLabel();
            this.LiveStatusColorPanel = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            this.TabControllerPanel.SuspendLayout();
            this.MainTabController.SuspendLayout();
            this.AutomaticPage.SuspendLayout();
            this.ManualPage.SuspendLayout();
            this.PingTestPage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.TabControllerPanel.Controls.Add(this.MainTabController);
            this.TabControllerPanel.Controls.Add(this.TopPanel);
            this.TabControllerPanel.Controls.Add(this.BottomPanel);
            this.TabControllerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControllerPanel.Location = new System.Drawing.Point(0, 0);
            this.TabControllerPanel.Name = "TabControllerPanel";
            this.TabControllerPanel.Size = new System.Drawing.Size(466, 402);
            this.TabControllerPanel.TabIndex = 2;
            // 
            // MainTabController
            // 
            this.MainTabController.Controls.Add(this.AutomaticPage);
            this.MainTabController.Controls.Add(this.ManualPage);
            this.MainTabController.Controls.Add(this.PingTestPage);
            this.MainTabController.Depth = 0;
            this.MainTabController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabController.Location = new System.Drawing.Point(0, 45);
            this.MainTabController.MouseState = MaterialSkin.MouseState.HOVER;
            this.MainTabController.Name = "MainTabController";
            this.MainTabController.SelectedIndex = 0;
            this.MainTabController.Size = new System.Drawing.Size(466, 337);
            this.MainTabController.TabIndex = 2;
            this.MainTabController.Selected += new System.Windows.Forms.TabControlEventHandler(this.MainTabController_Selected);
            // 
            // AutomaticPage
            // 
            this.AutomaticPage.BackColor = System.Drawing.Color.White;
            this.AutomaticPage.Controls.Add(this.StartAutoImageRecognitionButton);
            this.AutomaticPage.Controls.Add(this.AutoLockChampionToggle);
            this.AutomaticPage.Controls.Add(this.materialLabel6);
            this.AutomaticPage.Controls.Add(this.AutoSelectChampionToggle);
            this.AutomaticPage.Controls.Add(this.AutoAcceptToggle);
            this.AutomaticPage.Controls.Add(this.AutoCreateMatchToggle);
            this.AutomaticPage.Controls.Add(this.AutoLoginToggle);
            this.AutomaticPage.Controls.Add(this.AutoStartLeagueToggle);
            this.AutomaticPage.Controls.Add(this.materialLabel5);
            this.AutomaticPage.Controls.Add(this.materialLabel4);
            this.AutomaticPage.Controls.Add(this.materialLabel3);
            this.AutomaticPage.Controls.Add(this.materialLabel2);
            this.AutomaticPage.Controls.Add(this.materialLabel1);
            this.AutomaticPage.Location = new System.Drawing.Point(4, 22);
            this.AutomaticPage.Name = "AutomaticPage";
            this.AutomaticPage.Padding = new System.Windows.Forms.Padding(3);
            this.AutomaticPage.Size = new System.Drawing.Size(458, 311);
            this.AutomaticPage.TabIndex = 0;
            this.AutomaticPage.Text = "Automatic";
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
            this.ManualPage.Controls.Add(this.CoordinatesSelectAndLockChampionButton);
            this.ManualPage.Controls.Add(this.CoordinatesLockChampionButton);
            this.ManualPage.Controls.Add(this.CoordinatesSelectChampionButton);
            this.ManualPage.Controls.Add(this.AutoAcceptMatchButton);
            this.ManualPage.Controls.Add(this.CoordinatesCreateARAMLobbyButton);
            this.ManualPage.Controls.Add(this.CoordinatesCreateSummonersRiftLobbyButton);
            this.ManualPage.Controls.Add(this.CoordinatesLoginToLeagueButton);
            this.ManualPage.Controls.Add(this.CoordiantesStartLeagueClient);
            this.ManualPage.Location = new System.Drawing.Point(4, 22);
            this.ManualPage.Name = "ManualPage";
            this.ManualPage.Padding = new System.Windows.Forms.Padding(3);
            this.ManualPage.Size = new System.Drawing.Size(458, 311);
            this.ManualPage.TabIndex = 3;
            this.ManualPage.Text = "Manual";
            this.ManualPage.UseVisualStyleBackColor = true;
            // 
            // CoordinatesSelectAndLockChampionButton
            // 
            this.CoordinatesSelectAndLockChampionButton.AutoSize = true;
            this.CoordinatesSelectAndLockChampionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CoordinatesSelectAndLockChampionButton.Depth = 0;
            this.CoordinatesSelectAndLockChampionButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CoordinatesSelectAndLockChampionButton.Icon = null;
            this.CoordinatesSelectAndLockChampionButton.Location = new System.Drawing.Point(3, 255);
            this.CoordinatesSelectAndLockChampionButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CoordinatesSelectAndLockChampionButton.Name = "CoordinatesSelectAndLockChampionButton";
            this.CoordinatesSelectAndLockChampionButton.Primary = true;
            this.CoordinatesSelectAndLockChampionButton.Size = new System.Drawing.Size(452, 36);
            this.CoordinatesSelectAndLockChampionButton.TabIndex = 13;
            this.CoordinatesSelectAndLockChampionButton.Text = "Select And Lock Champion";
            this.CoordinatesSelectAndLockChampionButton.UseVisualStyleBackColor = true;
            this.CoordinatesSelectAndLockChampionButton.Click += new System.EventHandler(this.CoordinatesSelectAndLockChampionButton_Click);
            // 
            // CoordinatesLockChampionButton
            // 
            this.CoordinatesLockChampionButton.AutoSize = true;
            this.CoordinatesLockChampionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CoordinatesLockChampionButton.Depth = 0;
            this.CoordinatesLockChampionButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CoordinatesLockChampionButton.Icon = null;
            this.CoordinatesLockChampionButton.Location = new System.Drawing.Point(3, 219);
            this.CoordinatesLockChampionButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CoordinatesLockChampionButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CoordinatesLockChampionButton.Name = "CoordinatesLockChampionButton";
            this.CoordinatesLockChampionButton.Primary = false;
            this.CoordinatesLockChampionButton.Size = new System.Drawing.Size(452, 36);
            this.CoordinatesLockChampionButton.TabIndex = 12;
            this.CoordinatesLockChampionButton.Text = "Lock Champion";
            this.CoordinatesLockChampionButton.UseVisualStyleBackColor = true;
            this.CoordinatesLockChampionButton.Click += new System.EventHandler(this.CoordinatesLockChampionButton_Click);
            // 
            // CoordinatesSelectChampionButton
            // 
            this.CoordinatesSelectChampionButton.AutoSize = true;
            this.CoordinatesSelectChampionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CoordinatesSelectChampionButton.Depth = 0;
            this.CoordinatesSelectChampionButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CoordinatesSelectChampionButton.Icon = null;
            this.CoordinatesSelectChampionButton.Location = new System.Drawing.Point(3, 183);
            this.CoordinatesSelectChampionButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CoordinatesSelectChampionButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CoordinatesSelectChampionButton.Name = "CoordinatesSelectChampionButton";
            this.CoordinatesSelectChampionButton.Primary = false;
            this.CoordinatesSelectChampionButton.Size = new System.Drawing.Size(452, 36);
            this.CoordinatesSelectChampionButton.TabIndex = 11;
            this.CoordinatesSelectChampionButton.Text = "Select Champion";
            this.CoordinatesSelectChampionButton.UseVisualStyleBackColor = true;
            this.CoordinatesSelectChampionButton.Click += new System.EventHandler(this.CoordinatesSelectChampionButton_Click);
            // 
            // AutoAcceptMatchButton
            // 
            this.AutoAcceptMatchButton.AutoSize = true;
            this.AutoAcceptMatchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoAcceptMatchButton.Depth = 0;
            this.AutoAcceptMatchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AutoAcceptMatchButton.Icon = null;
            this.AutoAcceptMatchButton.Location = new System.Drawing.Point(3, 147);
            this.AutoAcceptMatchButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AutoAcceptMatchButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AutoAcceptMatchButton.Name = "AutoAcceptMatchButton";
            this.AutoAcceptMatchButton.Primary = false;
            this.AutoAcceptMatchButton.Size = new System.Drawing.Size(452, 36);
            this.AutoAcceptMatchButton.TabIndex = 10;
            this.AutoAcceptMatchButton.Text = "Start Auto Accept Match";
            this.AutoAcceptMatchButton.UseVisualStyleBackColor = true;
            this.AutoAcceptMatchButton.Click += new System.EventHandler(this.AutoAcceptMatchButton_Click);
            // 
            // CoordinatesCreateARAMLobbyButton
            // 
            this.CoordinatesCreateARAMLobbyButton.AutoSize = true;
            this.CoordinatesCreateARAMLobbyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CoordinatesCreateARAMLobbyButton.Depth = 0;
            this.CoordinatesCreateARAMLobbyButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CoordinatesCreateARAMLobbyButton.Icon = null;
            this.CoordinatesCreateARAMLobbyButton.Location = new System.Drawing.Point(3, 111);
            this.CoordinatesCreateARAMLobbyButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CoordinatesCreateARAMLobbyButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CoordinatesCreateARAMLobbyButton.Name = "CoordinatesCreateARAMLobbyButton";
            this.CoordinatesCreateARAMLobbyButton.Primary = false;
            this.CoordinatesCreateARAMLobbyButton.Size = new System.Drawing.Size(452, 36);
            this.CoordinatesCreateARAMLobbyButton.TabIndex = 9;
            this.CoordinatesCreateARAMLobbyButton.Text = "Create ARAM Lobby";
            this.CoordinatesCreateARAMLobbyButton.UseVisualStyleBackColor = true;
            this.CoordinatesCreateARAMLobbyButton.Click += new System.EventHandler(this.CoordinatesCreateARAMLobbyButton_Click);
            // 
            // CoordinatesCreateSummonersRiftLobbyButton
            // 
            this.CoordinatesCreateSummonersRiftLobbyButton.AutoSize = true;
            this.CoordinatesCreateSummonersRiftLobbyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CoordinatesCreateSummonersRiftLobbyButton.Depth = 0;
            this.CoordinatesCreateSummonersRiftLobbyButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CoordinatesCreateSummonersRiftLobbyButton.Icon = null;
            this.CoordinatesCreateSummonersRiftLobbyButton.Location = new System.Drawing.Point(3, 75);
            this.CoordinatesCreateSummonersRiftLobbyButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CoordinatesCreateSummonersRiftLobbyButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CoordinatesCreateSummonersRiftLobbyButton.Name = "CoordinatesCreateSummonersRiftLobbyButton";
            this.CoordinatesCreateSummonersRiftLobbyButton.Primary = false;
            this.CoordinatesCreateSummonersRiftLobbyButton.Size = new System.Drawing.Size(452, 36);
            this.CoordinatesCreateSummonersRiftLobbyButton.TabIndex = 8;
            this.CoordinatesCreateSummonersRiftLobbyButton.Text = "Create Summoner\'s Rift Lobby";
            this.CoordinatesCreateSummonersRiftLobbyButton.UseVisualStyleBackColor = true;
            this.CoordinatesCreateSummonersRiftLobbyButton.Click += new System.EventHandler(this.CoordinatesCreateSummonersRiftLobbyButton_Click);
            // 
            // CoordinatesLoginToLeagueButton
            // 
            this.CoordinatesLoginToLeagueButton.AutoSize = true;
            this.CoordinatesLoginToLeagueButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CoordinatesLoginToLeagueButton.Depth = 0;
            this.CoordinatesLoginToLeagueButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CoordinatesLoginToLeagueButton.Icon = null;
            this.CoordinatesLoginToLeagueButton.Location = new System.Drawing.Point(3, 39);
            this.CoordinatesLoginToLeagueButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CoordinatesLoginToLeagueButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CoordinatesLoginToLeagueButton.Name = "CoordinatesLoginToLeagueButton";
            this.CoordinatesLoginToLeagueButton.Primary = false;
            this.CoordinatesLoginToLeagueButton.Size = new System.Drawing.Size(452, 36);
            this.CoordinatesLoginToLeagueButton.TabIndex = 7;
            this.CoordinatesLoginToLeagueButton.Text = "Login To League";
            this.CoordinatesLoginToLeagueButton.UseVisualStyleBackColor = true;
            this.CoordinatesLoginToLeagueButton.Click += new System.EventHandler(this.CoordinatesLoginToLeagueButton_Click);
            // 
            // CoordiantesStartLeagueClient
            // 
            this.CoordiantesStartLeagueClient.AutoSize = true;
            this.CoordiantesStartLeagueClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CoordiantesStartLeagueClient.Depth = 0;
            this.CoordiantesStartLeagueClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.CoordiantesStartLeagueClient.Icon = null;
            this.CoordiantesStartLeagueClient.Location = new System.Drawing.Point(3, 3);
            this.CoordiantesStartLeagueClient.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CoordiantesStartLeagueClient.MouseState = MaterialSkin.MouseState.HOVER;
            this.CoordiantesStartLeagueClient.Name = "CoordiantesStartLeagueClient";
            this.CoordiantesStartLeagueClient.Primary = false;
            this.CoordiantesStartLeagueClient.Size = new System.Drawing.Size(452, 36);
            this.CoordiantesStartLeagueClient.TabIndex = 0;
            this.CoordiantesStartLeagueClient.Text = "Start League Client";
            this.CoordiantesStartLeagueClient.UseVisualStyleBackColor = true;
            this.CoordiantesStartLeagueClient.Click += new System.EventHandler(this.CoordiantesStartLeagueClient_Click);
            // 
            // PingTestPage
            // 
            this.PingTestPage.Controls.Add(this.panel2);
            this.PingTestPage.Controls.Add(this.panel1);
            this.PingTestPage.Location = new System.Drawing.Point(4, 22);
            this.PingTestPage.Name = "PingTestPage";
            this.PingTestPage.Padding = new System.Windows.Forms.Padding(3);
            this.PingTestPage.Size = new System.Drawing.Size(458, 311);
            this.PingTestPage.TabIndex = 4;
            this.PingTestPage.Text = "Ping Test";
            this.PingTestPage.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TestPingButton);
            this.panel2.Controls.Add(this.PingLabel);
            this.panel2.Controls.Add(this.LANPingTestCheckbox);
            this.panel2.Controls.Add(this.OCEPingTestCheckbox);
            this.panel2.Controls.Add(this.EUNEPingTestCheckbox);
            this.panel2.Controls.Add(this.EUWPingTestCheckbox);
            this.panel2.Controls.Add(this.NAPingTestCheckbox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 265);
            this.panel2.TabIndex = 10;
            // 
            // TestPingButton
            // 
            this.TestPingButton.AutoSize = true;
            this.TestPingButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TestPingButton.Depth = 0;
            this.TestPingButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.TestPingButton.Icon = null;
            this.TestPingButton.Location = new System.Drawing.Point(0, 169);
            this.TestPingButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.TestPingButton.Name = "TestPingButton";
            this.TestPingButton.Primary = true;
            this.TestPingButton.Size = new System.Drawing.Size(452, 36);
            this.TestPingButton.TabIndex = 15;
            this.TestPingButton.Text = "Test Ping";
            this.TestPingButton.UseVisualStyleBackColor = true;
            this.TestPingButton.Click += new System.EventHandler(this.TestPingButton_Click);
            // 
            // PingLabel
            // 
            this.PingLabel.Depth = 0;
            this.PingLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PingLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.PingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PingLabel.Location = new System.Drawing.Point(0, 150);
            this.PingLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.PingLabel.Name = "PingLabel";
            this.PingLabel.Size = new System.Drawing.Size(452, 19);
            this.PingLabel.TabIndex = 14;
            this.PingLabel.Text = "Ping:";
            this.PingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LANPingTestCheckbox
            // 
            this.LANPingTestCheckbox.AutoSize = true;
            this.LANPingTestCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LANPingTestCheckbox.Depth = 0;
            this.LANPingTestCheckbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LANPingTestCheckbox.Font = new System.Drawing.Font("Roboto", 10F);
            this.LANPingTestCheckbox.Location = new System.Drawing.Point(0, 120);
            this.LANPingTestCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.LANPingTestCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.LANPingTestCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.LANPingTestCheckbox.Name = "LANPingTestCheckbox";
            this.LANPingTestCheckbox.Ripple = true;
            this.LANPingTestCheckbox.Size = new System.Drawing.Size(452, 30);
            this.LANPingTestCheckbox.TabIndex = 13;
            this.LANPingTestCheckbox.TabStop = true;
            this.LANPingTestCheckbox.Text = "LAN";
            this.LANPingTestCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LANPingTestCheckbox.UseVisualStyleBackColor = true;
            // 
            // OCEPingTestCheckbox
            // 
            this.OCEPingTestCheckbox.AutoSize = true;
            this.OCEPingTestCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OCEPingTestCheckbox.Depth = 0;
            this.OCEPingTestCheckbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.OCEPingTestCheckbox.Font = new System.Drawing.Font("Roboto", 10F);
            this.OCEPingTestCheckbox.Location = new System.Drawing.Point(0, 90);
            this.OCEPingTestCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.OCEPingTestCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.OCEPingTestCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.OCEPingTestCheckbox.Name = "OCEPingTestCheckbox";
            this.OCEPingTestCheckbox.Ripple = true;
            this.OCEPingTestCheckbox.Size = new System.Drawing.Size(452, 30);
            this.OCEPingTestCheckbox.TabIndex = 12;
            this.OCEPingTestCheckbox.TabStop = true;
            this.OCEPingTestCheckbox.Text = "OCE";
            this.OCEPingTestCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OCEPingTestCheckbox.UseVisualStyleBackColor = true;
            // 
            // EUNEPingTestCheckbox
            // 
            this.EUNEPingTestCheckbox.AutoSize = true;
            this.EUNEPingTestCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EUNEPingTestCheckbox.Depth = 0;
            this.EUNEPingTestCheckbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.EUNEPingTestCheckbox.Font = new System.Drawing.Font("Roboto", 10F);
            this.EUNEPingTestCheckbox.Location = new System.Drawing.Point(0, 60);
            this.EUNEPingTestCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.EUNEPingTestCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.EUNEPingTestCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.EUNEPingTestCheckbox.Name = "EUNEPingTestCheckbox";
            this.EUNEPingTestCheckbox.Ripple = true;
            this.EUNEPingTestCheckbox.Size = new System.Drawing.Size(452, 30);
            this.EUNEPingTestCheckbox.TabIndex = 11;
            this.EUNEPingTestCheckbox.TabStop = true;
            this.EUNEPingTestCheckbox.Text = "EUNE";
            this.EUNEPingTestCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EUNEPingTestCheckbox.UseVisualStyleBackColor = true;
            // 
            // EUWPingTestCheckbox
            // 
            this.EUWPingTestCheckbox.AutoSize = true;
            this.EUWPingTestCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EUWPingTestCheckbox.Depth = 0;
            this.EUWPingTestCheckbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.EUWPingTestCheckbox.Font = new System.Drawing.Font("Roboto", 10F);
            this.EUWPingTestCheckbox.Location = new System.Drawing.Point(0, 30);
            this.EUWPingTestCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.EUWPingTestCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.EUWPingTestCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.EUWPingTestCheckbox.Name = "EUWPingTestCheckbox";
            this.EUWPingTestCheckbox.Ripple = true;
            this.EUWPingTestCheckbox.Size = new System.Drawing.Size(452, 30);
            this.EUWPingTestCheckbox.TabIndex = 10;
            this.EUWPingTestCheckbox.TabStop = true;
            this.EUWPingTestCheckbox.Text = "EUW";
            this.EUWPingTestCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EUWPingTestCheckbox.UseVisualStyleBackColor = true;
            // 
            // NAPingTestCheckbox
            // 
            this.NAPingTestCheckbox.AutoSize = true;
            this.NAPingTestCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NAPingTestCheckbox.Depth = 0;
            this.NAPingTestCheckbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.NAPingTestCheckbox.Font = new System.Drawing.Font("Roboto", 10F);
            this.NAPingTestCheckbox.Location = new System.Drawing.Point(0, 0);
            this.NAPingTestCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.NAPingTestCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.NAPingTestCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.NAPingTestCheckbox.Name = "NAPingTestCheckbox";
            this.NAPingTestCheckbox.Ripple = true;
            this.NAPingTestCheckbox.Size = new System.Drawing.Size(452, 30);
            this.NAPingTestCheckbox.TabIndex = 9;
            this.NAPingTestCheckbox.TabStop = true;
            this.NAPingTestCheckbox.Text = "NA";
            this.NAPingTestCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NAPingTestCheckbox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialLabel7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 40);
            this.panel1.TabIndex = 9;
            // 
            // materialLabel7
            // 
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(0, 0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(452, 40);
            this.materialLabel7.TabIndex = 0;
            this.materialLabel7.Text = "Warning: May be inaccurate sometimes for some regions.\r\nOnly use it as a guidelin" +
    "e for making accounts on new regions.\r\n";
            this.materialLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.materialTabSelector1.BaseTabControl = this.MainTabController;
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
            this.LiveStatusLabel.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.MainTabController.ResumeLayout(false);
            this.AutomaticPage.ResumeLayout(false);
            this.AutomaticPage.PerformLayout();
            this.ManualPage.ResumeLayout(false);
            this.ManualPage.PerformLayout();
            this.PingTestPage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
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
        private MaterialSkin.Controls.MaterialTabControl MainTabController;
        private System.Windows.Forms.TabPage AutomaticPage;
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
        private MaterialSkin.Controls.MaterialRaisedButton CoordinatesSelectAndLockChampionButton;
        private MaterialSkin.Controls.MaterialFlatButton CoordinatesLockChampionButton;
        private MaterialSkin.Controls.MaterialFlatButton CoordinatesSelectChampionButton;
        private MaterialSkin.Controls.MaterialFlatButton AutoAcceptMatchButton;
        private MaterialSkin.Controls.MaterialFlatButton CoordinatesCreateARAMLobbyButton;
        private MaterialSkin.Controls.MaterialFlatButton CoordinatesCreateSummonersRiftLobbyButton;
        private MaterialSkin.Controls.MaterialFlatButton CoordinatesLoginToLeagueButton;
        private MaterialSkin.Controls.MaterialFlatButton CoordiantesStartLeagueClient;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialRaisedButton TestPingButton;
        private MaterialSkin.Controls.MaterialLabel PingLabel;
        private MaterialSkin.Controls.MaterialRadioButton LANPingTestCheckbox;
        private MaterialSkin.Controls.MaterialRadioButton OCEPingTestCheckbox;
        private MaterialSkin.Controls.MaterialRadioButton EUNEPingTestCheckbox;
        private MaterialSkin.Controls.MaterialRadioButton EUWPingTestCheckbox;
        private MaterialSkin.Controls.MaterialRadioButton NAPingTestCheckbox;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
    }
}

