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
            this.components = new System.ComponentModel.Container();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TabControllerPanel = new System.Windows.Forms.Panel();
            this.MainTabController = new MaterialSkin.Controls.MaterialTabControl();
            this.MainPageTabPage = new System.Windows.Forms.TabPage();
            this.LocateLeagueButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.LeagueLocationTextbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.AutoRunesSelectStatusLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AutoRunesSelectLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AutoChatSpamStatusLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AutoChatSpamLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AutoChampSelectStatusLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AutoChampSelectLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AutoAcceptStatusLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AutoAcceptLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AutoLoginStatusLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.AutoLoginLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LiveStatusLabel = new MaterialSkin.Controls.MaterialLabel();
            this.StatusLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.AutoLoginAutoAcceptTabPage = new System.Windows.Forms.TabPage();
            this.RememberMeTickedLabel = new MaterialSkin.Controls.MaterialLabel();
            this.MatchFoundPicturebox = new System.Windows.Forms.PictureBox();
            this.EncryptPasswordLabel = new MaterialSkin.Controls.MaterialLabel();
            this.RememberLoginDetailsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SaveLoginDetailsButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.passwordLabel = new MaterialSkin.Controls.MaterialLabel();
            this.PasswordTextbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.usernameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.UsernameTextbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.RememberMeIsTickedToggle = new FlatUI.FlatToggle();
            this.EncryptPasswordToggle = new FlatUI.FlatToggle();
            this.RememberLoginDetailsToggle = new FlatUI.FlatToggle();
            this.ChampSelectChampChatSpamTabPage = new System.Windows.Forms.TabPage();
            this.ChangeRunesTabPage = new System.Windows.Forms.TabPage();
            this.CheckBuildsTabPage = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.AutoAcceptTimer = new System.Windows.Forms.Timer(this.components);
            this.AutoLoginTimer = new System.Windows.Forms.Timer(this.components);
            this.TakeScreenshotTimer = new System.Windows.Forms.Timer(this.components);
            this.AutoChampSelectTimer = new System.Windows.Forms.Timer(this.components);
            this.AutoChatSpamTimer = new System.Windows.Forms.Timer(this.components);
            this.AutoRuneSelectTimer = new System.Windows.Forms.Timer(this.components);
            this.MainPanel.SuspendLayout();
            this.TabControllerPanel.SuspendLayout();
            this.MainTabController.SuspendLayout();
            this.MainPageTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.AutoLoginAutoAcceptTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MatchFoundPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.Controls.Add(this.TabControllerPanel);
            this.MainPanel.Controls.Add(this.materialTabSelector1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainPanel.ForeColor = System.Drawing.Color.Transparent;
            this.MainPanel.Location = new System.Drawing.Point(0, 53);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(826, 590);
            this.MainPanel.TabIndex = 1;
            // 
            // TabControllerPanel
            // 
            this.TabControllerPanel.Controls.Add(this.MainTabController);
            this.TabControllerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControllerPanel.Location = new System.Drawing.Point(0, 43);
            this.TabControllerPanel.Name = "TabControllerPanel";
            this.TabControllerPanel.Size = new System.Drawing.Size(826, 547);
            this.TabControllerPanel.TabIndex = 2;
            // 
            // MainTabController
            // 
            this.MainTabController.Controls.Add(this.MainPageTabPage);
            this.MainTabController.Controls.Add(this.AutoLoginAutoAcceptTabPage);
            this.MainTabController.Controls.Add(this.ChampSelectChampChatSpamTabPage);
            this.MainTabController.Controls.Add(this.ChangeRunesTabPage);
            this.MainTabController.Controls.Add(this.CheckBuildsTabPage);
            this.MainTabController.Depth = 0;
            this.MainTabController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabController.Location = new System.Drawing.Point(0, 0);
            this.MainTabController.MouseState = MaterialSkin.MouseState.HOVER;
            this.MainTabController.Name = "MainTabController";
            this.MainTabController.SelectedIndex = 0;
            this.MainTabController.Size = new System.Drawing.Size(826, 547);
            this.MainTabController.TabIndex = 0;
            // 
            // MainPageTabPage
            // 
            this.MainPageTabPage.BackColor = System.Drawing.Color.White;
            this.MainPageTabPage.Controls.Add(this.LocateLeagueButton);
            this.MainPageTabPage.Controls.Add(this.LeagueLocationTextbox);
            this.MainPageTabPage.Controls.Add(this.materialLabel1);
            this.MainPageTabPage.Controls.Add(this.pictureBox3);
            this.MainPageTabPage.Controls.Add(this.AutoRunesSelectStatusLabel);
            this.MainPageTabPage.Controls.Add(this.AutoRunesSelectLabel);
            this.MainPageTabPage.Controls.Add(this.AutoChatSpamStatusLabel);
            this.MainPageTabPage.Controls.Add(this.AutoChatSpamLabel);
            this.MainPageTabPage.Controls.Add(this.AutoChampSelectStatusLabel);
            this.MainPageTabPage.Controls.Add(this.AutoChampSelectLabel);
            this.MainPageTabPage.Controls.Add(this.AutoAcceptStatusLabel);
            this.MainPageTabPage.Controls.Add(this.AutoAcceptLabel);
            this.MainPageTabPage.Controls.Add(this.AutoLoginStatusLabel);
            this.MainPageTabPage.Controls.Add(this.materialDivider1);
            this.MainPageTabPage.Controls.Add(this.AutoLoginLabel);
            this.MainPageTabPage.Controls.Add(this.materialLabel3);
            this.MainPageTabPage.Controls.Add(this.panel1);
            this.MainPageTabPage.Controls.Add(this.materialLabel2);
            this.MainPageTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MainPageTabPage.Location = new System.Drawing.Point(4, 22);
            this.MainPageTabPage.Name = "MainPageTabPage";
            this.MainPageTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainPageTabPage.Size = new System.Drawing.Size(818, 521);
            this.MainPageTabPage.TabIndex = 0;
            this.MainPageTabPage.Text = "Main Page";
            // 
            // LocateLeagueButton
            // 
            this.LocateLeagueButton.AutoSize = true;
            this.LocateLeagueButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LocateLeagueButton.Depth = 0;
            this.LocateLeagueButton.Icon = null;
            this.LocateLeagueButton.Location = new System.Drawing.Point(653, 332);
            this.LocateLeagueButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LocateLeagueButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LocateLeagueButton.Name = "LocateLeagueButton";
            this.LocateLeagueButton.Primary = false;
            this.LocateLeagueButton.Size = new System.Drawing.Size(154, 36);
            this.LocateLeagueButton.TabIndex = 48;
            this.LocateLeagueButton.Text = "Locate League.exe";
            this.LocateLeagueButton.UseVisualStyleBackColor = true;
            this.LocateLeagueButton.Click += new System.EventHandler(this.LocateLeagueButton_Click);
            // 
            // LeagueLocationTextbox
            // 
            this.LeagueLocationTextbox.BackColor = System.Drawing.Color.White;
            this.LeagueLocationTextbox.Depth = 0;
            this.LeagueLocationTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.LeagueLocationTextbox.Hint = "";
            this.LeagueLocationTextbox.Location = new System.Drawing.Point(140, 339);
            this.LeagueLocationTextbox.MaxLength = 32767;
            this.LeagueLocationTextbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.LeagueLocationTextbox.Name = "LeagueLocationTextbox";
            this.LeagueLocationTextbox.PasswordChar = '\0';
            this.LeagueLocationTextbox.SelectedText = "";
            this.LeagueLocationTextbox.SelectionLength = 0;
            this.LeagueLocationTextbox.SelectionStart = 0;
            this.LeagueLocationTextbox.Size = new System.Drawing.Size(506, 23);
            this.LeagueLocationTextbox.TabIndex = 2;
            this.LeagueLocationTextbox.TabStop = false;
            this.LeagueLocationTextbox.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 340);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(126, 19);
            this.materialLabel1.TabIndex = 47;
            this.materialLabel1.Text = "League Directory:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(327, 48);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(480, 270);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 46;
            this.pictureBox3.TabStop = false;
            // 
            // AutoRunesSelectStatusLabel
            // 
            this.AutoRunesSelectStatusLabel.AutoSize = true;
            this.AutoRunesSelectStatusLabel.Depth = 0;
            this.AutoRunesSelectStatusLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.AutoRunesSelectStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AutoRunesSelectStatusLabel.Location = new System.Drawing.Point(168, 255);
            this.AutoRunesSelectStatusLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.AutoRunesSelectStatusLabel.Name = "AutoRunesSelectStatusLabel";
            this.AutoRunesSelectStatusLabel.Size = new System.Drawing.Size(0, 19);
            this.AutoRunesSelectStatusLabel.TabIndex = 35;
            // 
            // AutoRunesSelectLabel
            // 
            this.AutoRunesSelectLabel.AutoSize = true;
            this.AutoRunesSelectLabel.Depth = 0;
            this.AutoRunesSelectLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.AutoRunesSelectLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AutoRunesSelectLabel.Location = new System.Drawing.Point(26, 255);
            this.AutoRunesSelectLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.AutoRunesSelectLabel.Name = "AutoRunesSelectLabel";
            this.AutoRunesSelectLabel.Size = new System.Drawing.Size(136, 19);
            this.AutoRunesSelectLabel.TabIndex = 34;
            this.AutoRunesSelectLabel.Text = "Auto Runes Select:";
            // 
            // AutoChatSpamStatusLabel
            // 
            this.AutoChatSpamStatusLabel.AutoSize = true;
            this.AutoChatSpamStatusLabel.Depth = 0;
            this.AutoChatSpamStatusLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.AutoChatSpamStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AutoChatSpamStatusLabel.Location = new System.Drawing.Point(168, 216);
            this.AutoChatSpamStatusLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.AutoChatSpamStatusLabel.Name = "AutoChatSpamStatusLabel";
            this.AutoChatSpamStatusLabel.Size = new System.Drawing.Size(0, 19);
            this.AutoChatSpamStatusLabel.TabIndex = 33;
            // 
            // AutoChatSpamLabel
            // 
            this.AutoChatSpamLabel.AutoSize = true;
            this.AutoChatSpamLabel.Depth = 0;
            this.AutoChatSpamLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.AutoChatSpamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AutoChatSpamLabel.Location = new System.Drawing.Point(40, 216);
            this.AutoChatSpamLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.AutoChatSpamLabel.Name = "AutoChatSpamLabel";
            this.AutoChatSpamLabel.Size = new System.Drawing.Size(122, 19);
            this.AutoChatSpamLabel.TabIndex = 32;
            this.AutoChatSpamLabel.Text = "Auto Chat Spam:";
            // 
            // AutoChampSelectStatusLabel
            // 
            this.AutoChampSelectStatusLabel.AutoSize = true;
            this.AutoChampSelectStatusLabel.Depth = 0;
            this.AutoChampSelectStatusLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.AutoChampSelectStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AutoChampSelectStatusLabel.Location = new System.Drawing.Point(168, 177);
            this.AutoChampSelectStatusLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.AutoChampSelectStatusLabel.Name = "AutoChampSelectStatusLabel";
            this.AutoChampSelectStatusLabel.Size = new System.Drawing.Size(0, 19);
            this.AutoChampSelectStatusLabel.TabIndex = 31;
            // 
            // AutoChampSelectLabel
            // 
            this.AutoChampSelectLabel.AutoSize = true;
            this.AutoChampSelectLabel.Depth = 0;
            this.AutoChampSelectLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.AutoChampSelectLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AutoChampSelectLabel.Location = new System.Drawing.Point(20, 177);
            this.AutoChampSelectLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.AutoChampSelectLabel.Name = "AutoChampSelectLabel";
            this.AutoChampSelectLabel.Size = new System.Drawing.Size(142, 19);
            this.AutoChampSelectLabel.TabIndex = 30;
            this.AutoChampSelectLabel.Text = "Auto Champ Select:";
            // 
            // AutoAcceptStatusLabel
            // 
            this.AutoAcceptStatusLabel.AutoSize = true;
            this.AutoAcceptStatusLabel.Depth = 0;
            this.AutoAcceptStatusLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.AutoAcceptStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AutoAcceptStatusLabel.Location = new System.Drawing.Point(168, 138);
            this.AutoAcceptStatusLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.AutoAcceptStatusLabel.Name = "AutoAcceptStatusLabel";
            this.AutoAcceptStatusLabel.Size = new System.Drawing.Size(0, 19);
            this.AutoAcceptStatusLabel.TabIndex = 29;
            // 
            // AutoAcceptLabel
            // 
            this.AutoAcceptLabel.AutoSize = true;
            this.AutoAcceptLabel.Depth = 0;
            this.AutoAcceptLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.AutoAcceptLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AutoAcceptLabel.Location = new System.Drawing.Point(66, 138);
            this.AutoAcceptLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.AutoAcceptLabel.Name = "AutoAcceptLabel";
            this.AutoAcceptLabel.Size = new System.Drawing.Size(96, 19);
            this.AutoAcceptLabel.TabIndex = 28;
            this.AutoAcceptLabel.Text = "Auto Accept:";
            // 
            // AutoLoginStatusLabel
            // 
            this.AutoLoginStatusLabel.AutoSize = true;
            this.AutoLoginStatusLabel.Depth = 0;
            this.AutoLoginStatusLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.AutoLoginStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AutoLoginStatusLabel.Location = new System.Drawing.Point(168, 99);
            this.AutoLoginStatusLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.AutoLoginStatusLabel.Name = "AutoLoginStatusLabel";
            this.AutoLoginStatusLabel.Size = new System.Drawing.Size(0, 19);
            this.AutoLoginStatusLabel.TabIndex = 27;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(22, 40);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(765, 2);
            this.materialDivider1.TabIndex = 26;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // AutoLoginLabel
            // 
            this.AutoLoginLabel.AutoSize = true;
            this.AutoLoginLabel.Depth = 0;
            this.AutoLoginLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.AutoLoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AutoLoginLabel.Location = new System.Drawing.Point(80, 99);
            this.AutoLoginLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.AutoLoginLabel.Name = "AutoLoginLabel";
            this.AutoLoginLabel.Size = new System.Drawing.Size(86, 19);
            this.AutoLoginLabel.TabIndex = 25;
            this.AutoLoginLabel.Text = "Auto Login:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(18, 19);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(69, 19);
            this.materialLabel3.TabIndex = 24;
            this.materialLabel3.Text = "STATUS:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LiveStatusLabel);
            this.panel1.Controls.Add(this.StatusLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 499);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 19);
            this.panel1.TabIndex = 23;
            // 
            // LiveStatusLabel
            // 
            this.LiveStatusLabel.AutoSize = true;
            this.LiveStatusLabel.Depth = 0;
            this.LiveStatusLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LiveStatusLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.LiveStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LiveStatusLabel.Location = new System.Drawing.Point(51, 0);
            this.LiveStatusLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.LiveStatusLabel.Name = "LiveStatusLabel";
            this.LiveStatusLabel.Size = new System.Drawing.Size(0, 19);
            this.LiveStatusLabel.TabIndex = 22;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Depth = 0;
            this.StatusLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.StatusLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.StatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StatusLabel.Location = new System.Drawing.Point(0, 0);
            this.StatusLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(51, 19);
            this.StatusLabel.TabIndex = 21;
            this.StatusLabel.Text = "Staus:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(18, 60);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(221, 19);
            this.materialLabel2.TabIndex = 20;
            this.materialLabel2.Text = "Auto Start League On App Start:";
            // 
            // AutoLoginAutoAcceptTabPage
            // 
            this.AutoLoginAutoAcceptTabPage.BackColor = System.Drawing.Color.White;
            this.AutoLoginAutoAcceptTabPage.Controls.Add(this.RememberMeTickedLabel);
            this.AutoLoginAutoAcceptTabPage.Controls.Add(this.MatchFoundPicturebox);
            this.AutoLoginAutoAcceptTabPage.Controls.Add(this.EncryptPasswordLabel);
            this.AutoLoginAutoAcceptTabPage.Controls.Add(this.RememberLoginDetailsLabel);
            this.AutoLoginAutoAcceptTabPage.Controls.Add(this.SaveLoginDetailsButton);
            this.AutoLoginAutoAcceptTabPage.Controls.Add(this.passwordLabel);
            this.AutoLoginAutoAcceptTabPage.Controls.Add(this.PasswordTextbox);
            this.AutoLoginAutoAcceptTabPage.Controls.Add(this.usernameLabel);
            this.AutoLoginAutoAcceptTabPage.Controls.Add(this.UsernameTextbox);
            this.AutoLoginAutoAcceptTabPage.Controls.Add(this.RememberMeIsTickedToggle);
            this.AutoLoginAutoAcceptTabPage.Controls.Add(this.EncryptPasswordToggle);
            this.AutoLoginAutoAcceptTabPage.Controls.Add(this.RememberLoginDetailsToggle);
            this.AutoLoginAutoAcceptTabPage.Location = new System.Drawing.Point(4, 22);
            this.AutoLoginAutoAcceptTabPage.Name = "AutoLoginAutoAcceptTabPage";
            this.AutoLoginAutoAcceptTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AutoLoginAutoAcceptTabPage.Size = new System.Drawing.Size(818, 521);
            this.AutoLoginAutoAcceptTabPage.TabIndex = 1;
            this.AutoLoginAutoAcceptTabPage.Text = "Auto Login/Auto Accept";
            // 
            // RememberMeTickedLabel
            // 
            this.RememberMeTickedLabel.AutoSize = true;
            this.RememberMeTickedLabel.Depth = 0;
            this.RememberMeTickedLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.RememberMeTickedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RememberMeTickedLabel.Location = new System.Drawing.Point(26, 106);
            this.RememberMeTickedLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.RememberMeTickedLabel.Name = "RememberMeTickedLabel";
            this.RememberMeTickedLabel.Size = new System.Drawing.Size(171, 19);
            this.RememberMeTickedLabel.TabIndex = 15;
            this.RememberMeTickedLabel.Text = "Remember me is ticked:";
            // 
            // MatchFoundPicturebox
            // 
            this.MatchFoundPicturebox.Location = new System.Drawing.Point(309, 17);
            this.MatchFoundPicturebox.Name = "MatchFoundPicturebox";
            this.MatchFoundPicturebox.Size = new System.Drawing.Size(460, 227);
            this.MatchFoundPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MatchFoundPicturebox.TabIndex = 11;
            this.MatchFoundPicturebox.TabStop = false;
            // 
            // EncryptPasswordLabel
            // 
            this.EncryptPasswordLabel.AutoSize = true;
            this.EncryptPasswordLabel.Depth = 0;
            this.EncryptPasswordLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.EncryptPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EncryptPasswordLabel.Location = new System.Drawing.Point(64, 186);
            this.EncryptPasswordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.EncryptPasswordLabel.Name = "EncryptPasswordLabel";
            this.EncryptPasswordLabel.Size = new System.Drawing.Size(133, 19);
            this.EncryptPasswordLabel.TabIndex = 10;
            this.EncryptPasswordLabel.Text = "Encrypt Password:";
            // 
            // RememberLoginDetailsLabel
            // 
            this.RememberLoginDetailsLabel.AutoSize = true;
            this.RememberLoginDetailsLabel.Depth = 0;
            this.RememberLoginDetailsLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.RememberLoginDetailsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RememberLoginDetailsLabel.Location = new System.Drawing.Point(20, 147);
            this.RememberLoginDetailsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.RememberLoginDetailsLabel.Name = "RememberLoginDetailsLabel";
            this.RememberLoginDetailsLabel.Size = new System.Drawing.Size(177, 19);
            this.RememberLoginDetailsLabel.TabIndex = 8;
            this.RememberLoginDetailsLabel.Text = "Remember Login Details:";
            // 
            // SaveLoginDetailsButton
            // 
            this.SaveLoginDetailsButton.AutoSize = true;
            this.SaveLoginDetailsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveLoginDetailsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveLoginDetailsButton.Depth = 0;
            this.SaveLoginDetailsButton.Icon = null;
            this.SaveLoginDetailsButton.Location = new System.Drawing.Point(82, 233);
            this.SaveLoginDetailsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveLoginDetailsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveLoginDetailsButton.Name = "SaveLoginDetailsButton";
            this.SaveLoginDetailsButton.Primary = false;
            this.SaveLoginDetailsButton.Size = new System.Drawing.Size(159, 36);
            this.SaveLoginDetailsButton.TabIndex = 6;
            this.SaveLoginDetailsButton.Text = "Save Login  Details";
            this.SaveLoginDetailsButton.UseVisualStyleBackColor = true;
            this.SaveLoginDetailsButton.Click += new System.EventHandler(this.SaveLoginDetailsButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Depth = 0;
            this.passwordLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.passwordLabel.Location = new System.Drawing.Point(20, 55);
            this.passwordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(79, 19);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password:";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Depth = 0;
            this.PasswordTextbox.Hint = "";
            this.PasswordTextbox.Location = new System.Drawing.Point(105, 55);
            this.PasswordTextbox.MaxLength = 32767;
            this.PasswordTextbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '\0';
            this.PasswordTextbox.SelectedText = "";
            this.PasswordTextbox.SelectionLength = 0;
            this.PasswordTextbox.SelectionStart = 0;
            this.PasswordTextbox.Size = new System.Drawing.Size(174, 23);
            this.PasswordTextbox.TabIndex = 2;
            this.PasswordTextbox.TabStop = false;
            this.PasswordTextbox.UseSystemPasswordChar = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Depth = 0;
            this.usernameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.usernameLabel.Location = new System.Drawing.Point(18, 16);
            this.usernameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(81, 19);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username:";
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Depth = 0;
            this.UsernameTextbox.Hint = "";
            this.UsernameTextbox.Location = new System.Drawing.Point(105, 16);
            this.UsernameTextbox.MaxLength = 32767;
            this.UsernameTextbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.PasswordChar = '\0';
            this.UsernameTextbox.SelectedText = "";
            this.UsernameTextbox.SelectionLength = 0;
            this.UsernameTextbox.SelectionStart = 0;
            this.UsernameTextbox.Size = new System.Drawing.Size(174, 23);
            this.UsernameTextbox.TabIndex = 0;
            this.UsernameTextbox.TabStop = false;
            this.UsernameTextbox.UseSystemPasswordChar = false;
            // 
            // RememberMeIsTickedToggle
            // 
            this.RememberMeIsTickedToggle.BackColor = System.Drawing.Color.Transparent;
            this.RememberMeIsTickedToggle.Checked = false;
            this.RememberMeIsTickedToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RememberMeIsTickedToggle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RememberMeIsTickedToggle.Location = new System.Drawing.Point(203, 100);
            this.RememberMeIsTickedToggle.Name = "RememberMeIsTickedToggle";
            this.RememberMeIsTickedToggle.Options = FlatUI.FlatToggle._Options.Style2;
            this.RememberMeIsTickedToggle.Size = new System.Drawing.Size(76, 33);
            this.RememberMeIsTickedToggle.TabIndex = 14;
            this.RememberMeIsTickedToggle.Text = "flatToggle1";
            // 
            // EncryptPasswordToggle
            // 
            this.EncryptPasswordToggle.BackColor = System.Drawing.Color.Transparent;
            this.EncryptPasswordToggle.Checked = false;
            this.EncryptPasswordToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EncryptPasswordToggle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EncryptPasswordToggle.Location = new System.Drawing.Point(203, 180);
            this.EncryptPasswordToggle.Name = "EncryptPasswordToggle";
            this.EncryptPasswordToggle.Options = FlatUI.FlatToggle._Options.Style3;
            this.EncryptPasswordToggle.Size = new System.Drawing.Size(76, 33);
            this.EncryptPasswordToggle.TabIndex = 9;
            this.EncryptPasswordToggle.Text = "flatToggle2";
            // 
            // RememberLoginDetailsToggle
            // 
            this.RememberLoginDetailsToggle.BackColor = System.Drawing.Color.Transparent;
            this.RememberLoginDetailsToggle.Checked = false;
            this.RememberLoginDetailsToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RememberLoginDetailsToggle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RememberLoginDetailsToggle.Location = new System.Drawing.Point(203, 141);
            this.RememberLoginDetailsToggle.Name = "RememberLoginDetailsToggle";
            this.RememberLoginDetailsToggle.Options = FlatUI.FlatToggle._Options.Style3;
            this.RememberLoginDetailsToggle.Size = new System.Drawing.Size(76, 33);
            this.RememberLoginDetailsToggle.TabIndex = 7;
            this.RememberLoginDetailsToggle.Text = "flatToggle1";
            // 
            // ChampSelectChampChatSpamTabPage
            // 
            this.ChampSelectChampChatSpamTabPage.Location = new System.Drawing.Point(4, 22);
            this.ChampSelectChampChatSpamTabPage.Name = "ChampSelectChampChatSpamTabPage";
            this.ChampSelectChampChatSpamTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ChampSelectChampChatSpamTabPage.Size = new System.Drawing.Size(818, 521);
            this.ChampSelectChampChatSpamTabPage.TabIndex = 2;
            this.ChampSelectChampChatSpamTabPage.Text = "Champ Select/Chat Spam";
            this.ChampSelectChampChatSpamTabPage.UseVisualStyleBackColor = true;
            // 
            // ChangeRunesTabPage
            // 
            this.ChangeRunesTabPage.Location = new System.Drawing.Point(4, 22);
            this.ChangeRunesTabPage.Name = "ChangeRunesTabPage";
            this.ChangeRunesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ChangeRunesTabPage.Size = new System.Drawing.Size(818, 521);
            this.ChangeRunesTabPage.TabIndex = 4;
            this.ChangeRunesTabPage.Text = "Change Runes";
            this.ChangeRunesTabPage.UseVisualStyleBackColor = true;
            // 
            // CheckBuildsTabPage
            // 
            this.CheckBuildsTabPage.Location = new System.Drawing.Point(4, 22);
            this.CheckBuildsTabPage.Name = "CheckBuildsTabPage";
            this.CheckBuildsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CheckBuildsTabPage.Size = new System.Drawing.Size(818, 521);
            this.CheckBuildsTabPage.TabIndex = 5;
            this.CheckBuildsTabPage.Text = "Check Builds";
            this.CheckBuildsTabPage.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.MainTabController;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(826, 43);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // AutoAcceptTimer
            // 
            this.AutoAcceptTimer.Interval = 500;
            this.AutoAcceptTimer.Tick += new System.EventHandler(this.AutoAcceptTimer_Tick);
            // 
            // AutoLoginTimer
            // 
            this.AutoLoginTimer.Interval = 500;
            this.AutoLoginTimer.Tick += new System.EventHandler(this.AutoLoginTimer_Tick);
            // 
            // TakeScreenshotTimer
            // 
            this.TakeScreenshotTimer.Interval = 500;
            this.TakeScreenshotTimer.Tick += new System.EventHandler(this.TakeScreenshotTimer_Tick);
            // 
            // AutoChampSelectTimer
            // 
            this.AutoChampSelectTimer.Tick += new System.EventHandler(this.AutoChampSelectTimer_Tick);
            // 
            // AutoChatSpamTimer
            // 
            this.AutoChatSpamTimer.Tick += new System.EventHandler(this.AutoChatSpamTimer_Tick);
            // 
            // AutoRuneSelectTimer
            // 
            this.AutoRuneSelectTimer.Tick += new System.EventHandler(this.AutoRuneSelectTimer_Tick);
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
            this.MainTabController.ResumeLayout(false);
            this.MainPageTabPage.ResumeLayout(false);
            this.MainPageTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.AutoLoginAutoAcceptTabPage.ResumeLayout(false);
            this.AutoLoginAutoAcceptTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MatchFoundPicturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.Panel TabControllerPanel;
        private MaterialSkin.Controls.MaterialTabControl MainTabController;
        private System.Windows.Forms.TabPage MainPageTabPage;
        private System.Windows.Forms.TabPage AutoLoginAutoAcceptTabPage;
        private System.Windows.Forms.TabPage ChampSelectChampChatSpamTabPage;
        private System.Windows.Forms.TabPage ChangeRunesTabPage;
        private System.Windows.Forms.Timer AutoAcceptTimer;
        private System.Windows.Forms.TabPage CheckBuildsTabPage;
        private MaterialSkin.Controls.MaterialLabel passwordLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField PasswordTextbox;
        private MaterialSkin.Controls.MaterialLabel usernameLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField UsernameTextbox;
        private MaterialSkin.Controls.MaterialFlatButton SaveLoginDetailsButton;
        private System.Windows.Forms.Timer AutoLoginTimer;
        private FlatUI.FlatToggle RememberLoginDetailsToggle;
        private MaterialSkin.Controls.MaterialLabel EncryptPasswordLabel;
        private FlatUI.FlatToggle EncryptPasswordToggle;
        private MaterialSkin.Controls.MaterialLabel RememberLoginDetailsLabel;
        private MaterialSkin.Controls.MaterialLabel RememberMeTickedLabel;
        private FlatUI.FlatToggle RememberMeIsTickedToggle;
        private System.Windows.Forms.Timer TakeScreenshotTimer;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel LiveStatusLabel;
        private MaterialSkin.Controls.MaterialLabel StatusLabel;
        private MaterialSkin.Controls.MaterialLabel AutoRunesSelectStatusLabel;
        private MaterialSkin.Controls.MaterialLabel AutoRunesSelectLabel;
        private MaterialSkin.Controls.MaterialLabel AutoChatSpamStatusLabel;
        private MaterialSkin.Controls.MaterialLabel AutoChatSpamLabel;
        private MaterialSkin.Controls.MaterialLabel AutoChampSelectStatusLabel;
        private MaterialSkin.Controls.MaterialLabel AutoChampSelectLabel;
        private MaterialSkin.Controls.MaterialLabel AutoAcceptStatusLabel;
        private MaterialSkin.Controls.MaterialLabel AutoAcceptLabel;
        private MaterialSkin.Controls.MaterialLabel AutoLoginStatusLabel;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel AutoLoginLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.Timer AutoChampSelectTimer;
        private System.Windows.Forms.Timer AutoChatSpamTimer;
        private System.Windows.Forms.Timer AutoRuneSelectTimer;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialFlatButton LocateLeagueButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField LeagueLocationTextbox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox MatchFoundPicturebox;
    }
}

