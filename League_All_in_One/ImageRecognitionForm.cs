using League_All_in_One.Properties;

using MaterialSkin;
using MaterialSkin.Controls;

using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace League_All_in_One
{
    public partial class LeagueAIO : MaterialForm
    {
        private Thread MainImageRecognitionManagerThread;
        private Thread ImageRecognitionLoginThread;
        private Thread ImageRecognitionCreateSummonersRiftThread;
        private Thread ImageRecognitionARAMThread;
        private Thread ImageRecognitionAcceptMatchThread;
        private Thread ImageRecognitionSelectChampionThread;
        private Thread ImageRecognitionLockChampionThread;

        private bool AutoLogin = false;
        private bool AutoAcceptMatch = false;
        private bool AutoCreateSummonerRift = false;
        private bool AutoCreateARAM = false;
        private bool AutoSelectChampion = false;
        private bool AutoLockChampion = false;

        private bool CancelAutoLogin = false;
        private bool CancelAutoAcceptMatch = false;
        private bool CancelAutoCreateMatch = false;
        private bool CancelAutoSelectChampion = false;
        private bool CancelAutoLockChampion = false;

        private Size AutomaticMainPanelSize = new Size(466, 402);
        private Size AutomaticFormSize = new Size(466, 466);

        private Size ManualMainPanelSize = new Size(466, 360);
        private Size ManualFormSize = new Size(466, 418);

        private Size PingMainPanelSize = new Size(466, 314);
        private Size PingFormSize = new Size(466, 380);

        public LeagueAIO()
        {
            InitializeComponent();
            LoadMaterialColors();
            LoadMaterialSkin();
        }

        private void LoadMaterialSkin()
        {
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Options.PrimaryColor, Options.PrimaryDarkColor, Options.PrimaryLightColor, Options.AccentColor, TextShade.BLACK);
        }

        private void LoadMaterialColors()
        {
            Options.PrimaryColor = Settings.Default.PrimaryColor;
            Options.PrimaryDarkColor = Settings.Default.PrimaryDarkColor;
            Options.PrimaryLightColor = Settings.Default.PrimaryLightColor;
            Options.AccentColor = Settings.Default.AccentColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HelpFile.StartAppLog();
            LoadOptions();
        }

        private void LeagueAIO_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveOptions();
            HelpFile.EndAppLog();
            HelpFile.WriteLogToText();
        }

        private void LoadOptions()
        {
            Options.LoadOptions();
        }

        private void SaveOptions()
        {
            Options.SaveOptions();
        }

        private void StartAutoImageRecognitionButton_Click(object sender, EventArgs e)
        {
            SetupImageRecognitionThreads();
            MainImageRecognitionManagerThread.Start();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(this);
            settingsForm.StartPosition = FormStartPosition.CenterParent;
            settingsForm.Show();
            this.Hide();
        }

        #region "Coordinates Methods"

        private void CoordiantesStartLeagueClient_Click(object sender, EventArgs e)
        {
            StartLeagueClient();
        }

        private void CoordinatesLoginToLeagueButton_Click(object sender, EventArgs e)
        {
            CoordinatesLoginToLeague();
        }

        private void CoordinatesCreateSummonersRiftLobbyButton_Click(object sender, EventArgs e)
        {
            CoordinatesCreateSummonersRiftLobby();
        }

        private void CoordinatesCreateARAMLobbyButton_Click(object sender, EventArgs e)
        {
            CoordinatesCreateARAMLobby();
        }

        private void AutoAcceptMatchButton_Click(object sender, EventArgs e)
        {
            CoordinatesAcceptMatchButton();
        }

        private void CoordinatesSelectChampionButton_Click(object sender, EventArgs e)
        {
            CoordinatesSelectChampion();
        }

        private void CoordinatesLockChampionButton_Click(object sender, EventArgs e)
        {
            CoordinatesLockChampion();
        }

        private void CoordinatesSelectAndLockChampionButton_Click(object sender, EventArgs e)
        {
            CoordinatesSelectAndLockChampion();
        }

        private void CoordinatesLoginToLeague()
        {
            Console.WriteLine("Loggging Into League Client");

            if (!UsernamePasswordIsValid())
            {
                ShowMessageBox(@"Please make sure you've added your Username and Password.\r\nPlease check the Auto Login tab.", "Unable To Login", MessageBoxIcon.Error);
                SetLiveStatusText("Please double check the Username and Password.", Color.Green);
                return;
            }

            Actions.EnterNewUsername();
            Actions.EnterPassword();
            KeyboardEvents.PressEnter();
        }

        private void CoordinatesCreateSummonersRiftLobby()
        {
            Console.WriteLine("Creating Summoner's Match.");

            Actions.ClickPlayButton();
            Actions.ClickSummonersMatch();

            if (Options.SummonerType.Equals("Blind Pick"))
            {
                Actions.ClickBlindPick();
            }

            if (Options.SummonerType.Equals("Draft Pick"))
            {
                Actions.ClickDraftPick();
            }

            if (Options.SummonerType.Equals("Ranked Solo/Duo"))
            {
                Actions.ClickSoloDuoRanked();
            }

            Actions.ClickConfirmButton();

            SetLiveStatusText("Created Summoner's Rift: " + Options.SummonerType + " room.", Color.Green);
        }

        private void CoordinatesCreateARAMLobby()
        {
            Console.WriteLine("Creating ARAM Match.");

            Actions.ClickPlayButton();
            Actions.ClickARAMMatch();
            Actions.ClickConfirmButton();

            SetLiveStatusText("Created an ARAM room.", Color.Green);
        }

        private async void CoordinatesAcceptMatchButton()
        {
            bool championSearchbox = false;
            bool acceptButton = false;

            while (!championSearchbox)
            {
                TakeFullDesktopScreenShot();
                if (!championSearchbox) championSearchbox = await ImageRecognition.AutoFindChampionSearchTextboxImageRecognition();

                TakeFullDesktopScreenShot();
                if (!acceptButton) acceptButton = await ImageRecognition.AutoAcceptImageRecognition();
                if (acceptButton)
                {
                    Actions.ClickAcceptButton();
                    SetLiveStatusText("Accepted Match", Color.Green);
                }
            }
        }

        private void CoordinatesSelectChampion()
        {
            Actions.ClickChamptionSearchTextbox();
            Actions.PasteChampionName();
            Actions.ClickFirstChamptionBox();

            SetLiveStatusText(Options.ChampionName + " was selected.", Color.Green);
        }

        private void CoordinatesLockChampion()
        {
            Actions.ClickLockButton();

            SetLiveStatusText("Champion has been locked.", Color.Green);
        }

        private void CoordinatesSelectAndLockChampion()
        {
            CoordinatesSelectChampion();
            CoordinatesLockChampion();
        }

        #endregion

        private void StartLeagueClient()
        {
            if (string.IsNullOrWhiteSpace(Options.LeagueExeDirectory))
            {
                ShowMessageBox("League path directory is not selected! Please select league.exe", "Error 404: League.exe not found", MessageBoxIcon.Error);
                SetLiveStatusText("Error 404: League.exe not found. Please choose league.exe directory.", Color.Red);
                HelpFile.Log("Error 404: League.exe Not Found. Please Choose League.exe Directory.");

                AutoStartLeagueToggle.Checked = false;
                return;
            }

            Process.Start(Options.LeagueExeDirectory);
            SetLiveStatusText("Started the league client.", Color.Green);
            HelpFile.Log("League Client: Started The League.exe Client.");


        }

        private bool UsernamePasswordIsValid()
        {
            return !string.IsNullOrWhiteSpace(Options.Username) && !string.IsNullOrWhiteSpace(Options.Password);
        }

        #region "Image Recognition Methods"

        private void SetupImageRecognitionThreads()
        {
            MainImageRecognitionManagerThread = new Thread(() => ImageRecognitionOperationManager());
            MainImageRecognitionManagerThread.Name = "Image Recognition Main Operations Thread";
            MainImageRecognitionManagerThread.SetApartmentState(ApartmentState.STA);

            ImageRecognitionLoginThread = new Thread(() => ImageRecognitionLoginToLeague());
            ImageRecognitionLoginThread.Name = "Image Recognition Login Thread";
            ImageRecognitionLoginThread.SetApartmentState(ApartmentState.STA);

            ImageRecognitionCreateSummonersRiftThread = new Thread(() => ImageRecognitionCreateSummonersRiftLobby());
            ImageRecognitionCreateSummonersRiftThread.Name = "Image Recognition Create Summoner's Rift Thread";
            ImageRecognitionCreateSummonersRiftThread.SetApartmentState(ApartmentState.STA);

            ImageRecognitionARAMThread = new Thread(() => ImageRecognitionCreateARAMLobby());
            ImageRecognitionARAMThread.Name = "Image Recognition Create ARAM Thread";
            ImageRecognitionARAMThread.SetApartmentState(ApartmentState.STA);

            ImageRecognitionAcceptMatchThread = new Thread(() => ImageRecognitionAcceptMatchButton());
            ImageRecognitionAcceptMatchThread.Name = "Image Recognition Accept Match Thread";
            ImageRecognitionAcceptMatchThread.SetApartmentState(ApartmentState.STA);

            ImageRecognitionSelectChampionThread = new Thread(() => ImageRecognitionSelectChampion());
            ImageRecognitionSelectChampionThread.Name = "Image Recognition Select Champion Thread";
            ImageRecognitionSelectChampionThread.SetApartmentState(ApartmentState.STA);

            ImageRecognitionLockChampionThread = new Thread(() => ImageRecognitionLockChampion());
            ImageRecognitionLockChampionThread.Name = "Image Recognition Lock Champion Thread";
            ImageRecognitionLockChampionThread.SetApartmentState(ApartmentState.STA);
        }
        
        private async void ImageRecognitionOperationManager()
        {
            if (AutoStartLeagueToggle.Checked)
            {
                StartLeagueClient();
                UncheckToggle_FromRunningThread(AutoStartLeagueToggle);
            }

            if (AutoLoginToggle.Checked)
            {
                HelpFile.Log("Starting Thread: " + ImageRecognitionLoginThread.Name);

                ImageRecognitionLoginThread.Start();
                ImageRecognitionLoginThread.Join();
                UncheckToggle_FromRunningThread(AutoLoginToggle);
            }

            if (AutoCreateMatchToggle.Checked)
            {
                if (Options.MatchType.Equals("Summoners Rift"))
                {
                    HelpFile.Log("Starting Thread: " + ImageRecognitionCreateSummonersRiftThread.Name);

                    ImageRecognitionCreateSummonersRiftThread.Start();
                    ImageRecognitionCreateSummonersRiftThread.Join();
                    UncheckToggle_FromRunningThread(AutoCreateMatchToggle);
                }

                if (Options.MatchType.Equals("ARAM"))
                {
                    HelpFile.Log("Starting Thread: " + ImageRecognitionARAMThread.Name);

                    ImageRecognitionARAMThread.Start();
                    ImageRecognitionARAMThread.Join();
                    UncheckToggle_FromRunningThread(AutoCreateMatchToggle);
                }
            }

            if (AutoAcceptToggle.Checked)
            {
                HelpFile.Log("Starting Thread: " + ImageRecognitionAcceptMatchThread.Name);

                ImageRecognitionAcceptMatchThread.Start();
                ImageRecognitionAcceptMatchThread.Join();
                UncheckToggle_FromRunningThread(AutoAcceptToggle);
            }

            if (AutoSelectChampionToggle.Checked)
            {
                HelpFile.Log("Starting Thread: " + ImageRecognitionSelectChampionThread.Name);

                ImageRecognitionSelectChampionThread.Start();
                ImageRecognitionSelectChampionThread.Join();
                UncheckToggle_FromRunningThread(AutoSelectChampionToggle);
            }

            if (AutoLockChampionToggle.Checked)
            {
                HelpFile.Log("Starting Thread: " + ImageRecognitionLockChampionThread.Name);

                ImageRecognitionLockChampionThread.Start();
                ImageRecognitionLockChampionThread.Join();
                UncheckToggle_FromRunningThread(AutoLockChampionToggle);
            }
        }

        private void TakeFullDesktopScreenShot()
        {
            ScreenCapture screenCapsture = new ScreenCapture();
            ImageRecognition.desktopScreenshot = screenCapsture.CaptureScreen();
        }

        

        private async Task<bool> ImageRecognitionCheckIfLeagueLoaded()
        {
            bool leagueFullyLoadedWithRiotLogo = false;

            while (!leagueFullyLoadedWithRiotLogo)
            {
                TakeFullDesktopScreenShot();
                leagueFullyLoadedWithRiotLogo = await ImageRecognition.CheckLeagueRiotLogoImageRecognition();
            }

            if (leagueFullyLoadedWithRiotLogo)
            {
                SetLiveStatusText("League client fully loaded. Attemping to log-in.", Color.Green);
                return true;
            }
            else
            {
                return false;
            }
        }

        private async void ImageRecognitionLoginToLeague()
        {
            bool leagueFullyLoaded = false;
            bool rememberMeChecked = false;
            bool addedUsername = false;
            bool addedPassword = false;
            bool clickedSignIn = false;
            bool failLoggedIn = false;

            if (!UsernamePasswordIsValid())
            {
                ShowMessageBox(@"Please make sure you've added your Username and Password.\r\nPlease check the Auto Login tab.", "Unable To Login", MessageBoxIcon.Error);
                SetLiveStatusText("Please double check the Username and Password.", Color.Green);
                return;
            }

            while (!leagueFullyLoaded)
            {
                leagueFullyLoaded = await ImageRecognitionCheckIfLeagueLoaded();
            }

            TakeFullDesktopScreenShot();
            rememberMeChecked = await ImageRecognition.RememberMeCheckedImageRecognition();

            while (!clickedSignIn || !failLoggedIn)
            {
                if (rememberMeChecked)
                {
                    TakeFullDesktopScreenShot();
                    if (!addedPassword) addedPassword = await ImageRecognition.LoginPasswordImageRecognition();

                    TakeFullDesktopScreenShot();
                    if (!addedPassword) addedPassword = await ImageRecognition.LoginPasswordFocusedImageRecognition();

                    if (addedPassword)
                    {
                        Actions.EnterPassword();
                    }
                }
                else
                {
                    TakeFullDesktopScreenShot();
                    if (!addedUsername) addedUsername = await ImageRecognition.LoginUsernameImageRecognition();

                    TakeFullDesktopScreenShot();
                    if (!addedUsername) addedUsername = await ImageRecognition.LoginUsernameFocusedImageRecognition();

                    if (addedUsername)
                    {
                        Actions.EnterUsername();
                    }

                    TakeFullDesktopScreenShot();
                    if (!addedPassword) addedPassword = await ImageRecognition.LoginPasswordImageRecognition();

                    TakeFullDesktopScreenShot();
                    if (!addedPassword) addedPassword = await ImageRecognition.LoginPasswordFocusedImageRecognition();

                    if (addedPassword)
                    {
                        Actions.EnterPassword();
                    }
                }

                if (addedPassword)
                {
                    KeyboardEvents.PressEnter();
                    clickedSignIn = true;
                    AutoLogin = true;
                    return;
                }

                TakeFullDesktopScreenShot();
                if (!failLoggedIn) failLoggedIn = await ImageRecognition.LoginFailedImageRecognition();
            }

            if (clickedSignIn)
            {
                SetLiveStatusText("Successfully logged into league.", Color.Green);
                AutoLogin = true;
                return;
            }

            if (failLoggedIn)
            {
                AutoLoginToggle.Checked = false;
                ShowMessageBox(@"Please make sure your Username and Password is correct.", "Unable To Login", MessageBoxIcon.Error);
                SetLiveStatusText("Please double check the Username and Password.", Color.Green);
                return;
            }
        }

        private async void ImageRecognitionCreateSummonersRiftLobby()
        {
            bool clickedPlayButton = false;
            bool selectedSummonersRift = false;
            bool selectSummonerType = false;
            bool clickedConfirmButton = false;

            if (!string.IsNullOrWhiteSpace(Options.SummonerType))
            {
                ShowMessageBox(@"Please make sure you've selected summoner type. \r\nPlease check the Auto Login / Match tab in settings.", "Unable To Create Lobby", MessageBoxIcon.Error);
                SetLiveStatusText("Please double check the Username and Password.", Color.Green);
                return;
            }
            
            while (!clickedConfirmButton)
            {
                TakeFullDesktopScreenShot();
                if (!clickedPlayButton) clickedPlayButton = await ImageRecognition.AutoClickPlayButtonImageRecognition();
                if (clickedPlayButton)
                {
                    Actions.ClickPlayButton();
                }

                TakeFullDesktopScreenShot();
                if (!selectedSummonersRift) selectedSummonersRift = await ImageRecognition.AutoChooseSummerRiftModeImageRecognition();
                if (selectedSummonersRift)
                {
                    Actions.ClickSummonersMatch();
                }
                
                if (Options.SummonerType.Equals("Blind Pick"))
                {
                    TakeFullDesktopScreenShot();
                    if (!selectSummonerType) selectSummonerType = await ImageRecognition.AutoChooseSummersBlindPickImageRecognition();
                    if (selectSummonerType)
                    {
                        Actions.ClickBlindPick();
                    }
                }

                if (Options.SummonerType.Equals("Draft Pick"))
                {
                    TakeFullDesktopScreenShot();
                    if (!selectSummonerType) selectSummonerType = await ImageRecognition.AutoChooseSummersDraftPickImageRecognition();
                    if (selectSummonerType)
                    {
                        Actions.ClickDraftPick();
                    }
                }                

                if (Options.SummonerType.Equals("Ranked Solo/Duo"))
                {
                    TakeFullDesktopScreenShot();
                    if (!selectSummonerType) selectSummonerType = await ImageRecognition.AutoChooseSummersRankedImageRecognition();
                    if (selectSummonerType)
                    {
                        Actions.ClickSoloDuoRanked();
                    }
                }

                TakeFullDesktopScreenShot();
                if (!clickedConfirmButton) clickedConfirmButton = await ImageRecognition.AutoClickConfirmButtonImageRecognition();
                if (clickedConfirmButton)
                {
                    Actions.ClickConfirmButton();

                    AutoCreateSummonerRift = true;
                    SetLiveStatusText("Created Summoner's Rift: " + Options.SummonerType + " room.", Color.Green);
                }
            }
        }

        private async void ImageRecognitionCreateARAMLobby()
        {
            bool clickedPlayButton = false;
            bool selectedARAM = false;
            bool clickedConfirmButton = false;

            while (!clickedConfirmButton)
            {
                TakeFullDesktopScreenShot();
                if (!clickedPlayButton) clickedPlayButton = await ImageRecognition.AutoClickPlayButtonImageRecognition();
                if (clickedPlayButton)
                {
                    Actions.ClickPlayButton();
                }

                TakeFullDesktopScreenShot();
                if (!selectedARAM) selectedARAM = await ImageRecognition.AutoChooseARAMModeImageRecognition();
                if (selectedARAM)
                {
                    Actions.ClickARAMMatch();
                }

                TakeFullDesktopScreenShot();
                if (!clickedConfirmButton) clickedConfirmButton = await ImageRecognition.AutoClickConfirmButtonImageRecognition();
                if (clickedConfirmButton)
                {
                    Actions.ClickConfirmButton();

                    AutoCreateSummonerRift = true;
                    SetLiveStatusText("Created an ARAM room.", Color.Green);
                }
            }
        }

        private async void ImageRecognitionAcceptMatchButton()
        {
            bool championSearchbox = false;
            bool acceptButton = false;

            while (!championSearchbox)
            {
                TakeFullDesktopScreenShot();
                if (!championSearchbox) championSearchbox = await ImageRecognition.AutoFindChampionSearchTextboxImageRecognition();

                TakeFullDesktopScreenShot();
                if (!acceptButton) acceptButton = await ImageRecognition.AutoAcceptImageRecognition();
                if (acceptButton)
                {
                    Actions.ClickAcceptButton();

                    SetLiveStatusText("Accepted Match", Color.Green);
                }
            }
        }

        private async void ImageRecognitionSelectChampion()
        {
            bool selectChampion = false;
            bool randomChampionBox = false;

            while (!selectChampion)
            {
                TakeFullDesktopScreenShot();
                if (!randomChampionBox) randomChampionBox = await ImageRecognition.AutoFindRandomChampionBoxImageRecognition();
                if (randomChampionBox)
                {
                    Actions.ClickChamptionSearchTextbox();

                    Actions.PasteChampionName();

                    Actions.ClickFirstChamptionBox();

                    selectChampion = true;

                    AutoSelectChampion = true;
                    SetLiveStatusText(Options.ChampionName + " was selected.", Color.Green);
                }
            }
        }

        private async void ImageRecognitionLockChampion()
        {
            bool lockChampion = false;

            while (!lockChampion)
            {
                TakeFullDesktopScreenShot();
                if (!lockChampion) lockChampion = await ImageRecognition.AutoLockChampionImageRecognition();
                if (lockChampion)
                {
                    Actions.ClickLockButton();

                    AutoLockChampion = true;
                    SetLiveStatusText("Champion has been locked.", Color.Green);
                }
            }
        }
        #endregion

        private void ShowMessageBox(string title, string message, MessageBoxIcon icon)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
                });
            }
            else
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
                });
            }
        }

        private void SetLiveStatusText(string message, Color color)
        {
            if (LiveStatusLabel.InvokeRequired)
            {
                LiveStatusLabel.BeginInvoke((MethodInvoker)delegate ()
                {
                    LiveStatusLabel.Text = message;
                    LiveStatusLabel.Refresh();
                });

                LiveStatusColorPanel.BeginInvoke((MethodInvoker)delegate ()
                {
                    LiveStatusColorPanel.BackColor = color;
                    LiveStatusColorPanel.Refresh();
                });
            }
            else
            {
                LiveStatusLabel.Invoke((MethodInvoker)delegate ()
                {
                    LiveStatusLabel.Text = message;
                    LiveStatusLabel.Refresh();
                });

                LiveStatusColorPanel.Invoke((MethodInvoker)delegate ()
                {
                    LiveStatusColorPanel.BackColor = color;
                    LiveStatusColorPanel.Refresh();
                });
            }
        }

        private void AutoStartLeagueToggle_CheckedChanged(object sender)
        {
            if (AutoStartLeagueToggle.Checked)
            {
                Console.WriteLine(Options.LeagueExeDirectory);
                if (string.IsNullOrWhiteSpace(Options.LeagueExeDirectory))
                {
                    ShowMessageBox("Error 404: League.exe not found", "League path directory is not selected! Please select league.exe", MessageBoxIcon.Error);
                    AutoStartLeagueToggle.Checked = false;
                    return;
                }
            }
        }

        private void AutoLoginToggle_CheckedChanged(object sender)
        {
            if (AutoLoginToggle.Checked)
            {
                if (string.IsNullOrWhiteSpace(Options.Username))
                {
                    ShowMessageBox("League All-For-One", "Please enter your username in the settings.", MessageBoxIcon.Error);
                    AutoLoginToggle.Checked = false;
                    return;
                }

                if (string.IsNullOrWhiteSpace(Options.Password))
                {
                    ShowMessageBox("League All-For-One", "Please enter your password in the settings.", MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                CancelAutoLogin = true;
            }
        }

        private void AutoCreateMatchToggle_CheckedChanged(object sender)
        {
            if (AutoCreateMatchToggle.Checked)
            {
                if (string.IsNullOrWhiteSpace(Options.MatchType))
                {
                    ShowMessageBox("League All-For-One", "Please select match type from settings.", MessageBoxIcon.Error);
                    AutoCreateMatchToggle.Checked = false;
                    return;
                }

                if (string.IsNullOrWhiteSpace(Options.SummonerType))
                {
                    ShowMessageBox("League All-For-One", "Please select summoner game type from settings.", MessageBoxIcon.Error);
                    AutoCreateMatchToggle.Checked = false;
                    return;
                }
            }
            else
            {
                CancelAutoCreateMatch = true;
            }
        }

        private void AutoAcceptToggle_CheckedChanged(object sender)
        {
            if (!AutoAcceptToggle.Checked) CancelAutoAcceptMatch = true;
        }

        private void AutoSelectChampionToggle_CheckedChanged(object sender)
        {
            if (AutoSelectChampionToggle.Checked)
            {
                if (string.IsNullOrWhiteSpace(Options.ChampionName))
                {
                    ShowMessageBox("League All-For-One", "Please enter your champion name in the settings.", MessageBoxIcon.Error);
                    AutoSelectChampionToggle.Checked = false;
                    return;
                }
            }
            else
            {
                CancelAutoSelectChampion = true;
            }
        }

        private void AutoLockChampionToggle_CheckedChanged(object sender)
        {
            if (!AutoLockChampionToggle.Checked) CancelAutoLockChampion = true;
        }

        private void UncheckToggle_FromRunningThread(FlatToggle toggle)
        {
            toggle.BeginInvoke((MethodInvoker)delegate ()
            {
                toggle.Checked = false;
                toggle.Refresh();
            });
        }

        private void TestPingButton_Click(object sender, EventArgs e)
        {
            if (NAPingTestCheckbox.Checked)
            {
                PingLabel.Text = "Ping: " + Networking.PingNaServer();
            }

            if (EUWPingTestCheckbox.Checked)
            {
                PingLabel.Text = "Ping: " + Networking.PingEUWServer();
            }

            if (EUNEPingTestCheckbox.Checked)
            {
                PingLabel.Text = "Ping: " + Networking.PingEUNEServer();
            }

            if (OCEPingTestCheckbox.Checked)
            {
                PingLabel.Text = "Ping: " + Networking.PingOCEServer();
            }

            if (LANPingTestCheckbox.Checked)
            {
                PingLabel.Text = "Ping: " + Networking.PingLANServer();
            }
        }

        private void MainTabController_Selected(object sender, TabControlEventArgs e)
        {
            if (MainTabController.SelectedTab == MainTabController.TabPages["AutomaticPage"])
            {
                MainPanel.Size = AutomaticMainPanelSize;
                this.Size = AutomaticFormSize;
            }
            else if (MainTabController.SelectedTab == MainTabController.TabPages["ManualPage"])
            {
                MainPanel.Size = ManualMainPanelSize;
                this.Size = ManualFormSize;
            }
            else if (MainTabController.SelectedTab == MainTabController.TabPages["PingTestPage"])
            {
                MainPanel.Size = PingMainPanelSize;
                this.Size = PingFormSize;
            }
        }
    }

    public static class Actions
    {
        public static void EnterNewUsername()
        {
            int[] coordinates = HelpFile.GetXYCoordinatesRegex(Options.LoginUsernameCoordinates);

            KeyboardEvents.SetClipboardText(Options.Username);
            HelpFile.Log("Login Username: Copied Username To Clipboard.");
            Thread.Sleep(Options.ImageRecognitionInterval);

            MouseEvent.MoveMouseXYToAndClick(coordinates[0], coordinates[1]);
            HelpFile.Log("Login Username: Moved Mouse To And Clicked Username Textbox X:" + coordinates[0] + ", Y:" + coordinates[1] + ".");
            Thread.Sleep(Options.ImageRecognitionInterval);

            KeyboardEvents.PressControlA();
            HelpFile.Log("Login Username: Pressed Control+A To Hightlight Current Username.");
            Thread.Sleep(Options.ImageRecognitionInterval);

            KeyboardEvents.PressControlV();
            HelpFile.Log("Login Username: Pressed Control+V To Paste Username.");
            Thread.Sleep(Options.ImageRecognitionInterval);

            KeyboardEvents.ClearClipboard();
            HelpFile.Log("Login Username: Cleared Clipboard Of Username.");
            Thread.Sleep(Options.ImageRecognitionInterval);
        }

        public static void EnterUsername()
        {
            int[] coordinates = HelpFile.GetXYCoordinatesRegex(Options.LoginUsernameCoordinates);

            KeyboardEvents.SetClipboardText(Options.Username);
            HelpFile.Log("Login Username: Copied Username To Clipboard.");
            Thread.Sleep(Options.ImageRecognitionInterval);

            MouseEvent.MoveMouseXYToAndClick(coordinates[0], coordinates[1]);
            HelpFile.Log("Login Username: Moved Mouse To And Clicked Username Textbox X:" + coordinates[0] + ", Y:" + coordinates[1] + ".");
            Thread.Sleep(Options.ImageRecognitionInterval);

            KeyboardEvents.PressControlV();
            HelpFile.Log("Login Username: Pressed Control+V To Paste Username.");
            Thread.Sleep(Options.ImageRecognitionInterval);

            KeyboardEvents.ClearClipboard();
            HelpFile.Log("Login Username: Cleared Clipboard Of Username.");
            Thread.Sleep(Options.ImageRecognitionInterval);
        }

        public static void EnterPassword()
        {
            string password = Options.IsPasswordEncrypted ? Encryption.Decrypt(Options.Password, Encryption.ConvertRijndaelKeyToByte(Options.EncryptedKey), Encryption.ConvertRijndaelIVToByte(Options.EncryptedIV)) : Options.Password;
            int[] coordinates = HelpFile.GetXYCoordinatesRegex(Options.LoginPasswordCoordinates);

            KeyboardEvents.SetClipboardText(password);
            HelpFile.Log("Login Password: Copied Text To Clipboard.");
            Thread.Sleep(Options.ImageRecognitionInterval);

            MouseEvent.MoveMouseXYToAndClick(coordinates[0], coordinates[1]);
            HelpFile.Log("Login Password: Moved Mouse To Textbox And Clicked X:" + coordinates[0] + ", Y:" + coordinates[1] + ".");
            Thread.Sleep(Options.ImageRecognitionInterval);

            KeyboardEvents.PressControlV();
            HelpFile.Log("Login Password: Pressed Control+V To Paste Password.");
            Thread.Sleep(Options.ImageRecognitionInterval);

            KeyboardEvents.ClearClipboard();
            HelpFile.Log("Login Password: Cleared Clipboard Of Password.");
            Thread.Sleep(Options.ImageRecognitionInterval);
        }

        public static void ClickSignIn()
        {
            //Currently pressing enter to sign in. No need for this a the moment.
        }

        public static void ClickPlayButton()
        {
            int[] coordinates = HelpFile.GetXYCoordinatesRegex(Options.PlayButtonCoordinates);
            MouseEvent.MoveMouseXYToAndClick(coordinates[0], coordinates[1]);
            HelpFile.Log("Click Play Button: Clicked Play Button X:" + coordinates[0] + ", Y:" + coordinates[1] + ".");
            Thread.Sleep(Options.ImageRecognitionInterval);
        }

        public static void ClickSummonersMatch()
        {
            int[] coordinates = HelpFile.GetXYCoordinatesRegex(Options.SummonersRiftCoordinates);
            MouseEvent.MoveMouseXYToAndClick(coordinates[0], coordinates[1]);
            HelpFile.Log("Pick Summoner Mode: Picked Summoner Rift X:" + coordinates[0] + ", Y:" + coordinates[1] + ".");
            Thread.Sleep(Options.ImageRecognitionInterval);
        }

        public static void ClickBlindPick()
        {
            int[] coordinates = HelpFile.GetXYCoordinatesRegex(Options.BlindPickCoordinates);
            MouseEvent.MoveMouseXYToAndClick(coordinates[0], coordinates[1]);
            HelpFile.Log("Summoner Mode: Blind Pick X:" + coordinates[0] + ", Y:" + coordinates[1] + ".");
            Thread.Sleep(Options.ImageRecognitionInterval);
        }

        public static void ClickDraftPick()
        {
            int[] coordinates = HelpFile.GetXYCoordinatesRegex(Options.DraftPickCoordinates);
            MouseEvent.MoveMouseXYToAndClick(coordinates[0], coordinates[1]);
            HelpFile.Log("Summoner Mode: Draft Pick X:" + coordinates[0] + ", Y:" + coordinates[1] + ".");
            Thread.Sleep(Options.ImageRecognitionInterval);
        }

        public static void ClickSoloDuoRanked()
        {
            int[] coordinates = HelpFile.GetXYCoordinatesRegex(Options.RankedSoloDuoCoordinates);
            MouseEvent.MoveMouseXYToAndClick(coordinates[0], coordinates[1]);
            HelpFile.Log("Summoner Mode: Ranked Pick X:" + coordinates[0] + ", Y:" + coordinates[1] + ".");
            Thread.Sleep(Options.ImageRecognitionInterval);
        }

        public static void ClickARAMMatch()
        {
            int[] coordinates = HelpFile.GetXYCoordinatesRegex(Options.ARAMMatchCoordinates);
            MouseEvent.MoveMouseXYToAndClick(coordinates[0], coordinates[1]);
            HelpFile.Log("Pick ARAM Mode X:" + coordinates[0] + ", Y:" + coordinates[1] + ".");
            Thread.Sleep(Options.ImageRecognitionInterval);
        }

        public static void ClickConfirmButton()
        {
            int[] coordinates = HelpFile.GetXYCoordinatesRegex(Options.ConfirmButtonCoordinates);
            MouseEvent.MoveMouseXYToAndClick(coordinates[0], coordinates[1]);
            HelpFile.Log("Confirm Button: Clicked Confirm Button X:" + coordinates[0] + ", Y:" + coordinates[1] + ".");
            Thread.Sleep(Options.ImageRecognitionInterval);
        }

        public static void ClickAcceptButton()
        {
            int[] coordinates = HelpFile.GetXYCoordinatesRegex(Options.AutoAcceptButtonCoordinates);
            MouseEvent.MoveMouseXYToAndClick(coordinates[0], coordinates[1]);
            HelpFile.Log("Auto Accept: Clicked Accept Button X:" + coordinates[0] + ", Y:" + coordinates[1] + ".");
            Thread.Sleep(Options.ImageRecognitionInterval);
        }

        public static void ClickChamptionSearchTextbox()
        {
            int[] coordinatesChampionSearchTextbox = HelpFile.GetXYCoordinatesRegex(Options.ChampionSearchTextboxCoordinates);
            MouseEvent.MoveMouseXYToAndClick(coordinatesChampionSearchTextbox[0], coordinatesChampionSearchTextbox[1]);
            HelpFile.Log("Select Champ: Search Text Box Clicked X:" + coordinatesChampionSearchTextbox[0] + ", Y:" + coordinatesChampionSearchTextbox[1] + ".");
            Thread.Sleep(Options.ImageRecognitionInterval);
        }

        public static void PasteChampionName()
        {
            KeyboardEvents.SetClipboardText(Options.ChampionName);
            HelpFile.Log("Select Champ: Copied Champion Name To Clipboard.");
            Thread.Sleep(Options.ImageRecognitionInterval);

            KeyboardEvents.PressControlV();
            HelpFile.Log("Select Champ: Pressed Control+V To Paste Champion Name.");
            Thread.Sleep(Options.ImageRecognitionInterval);
        }

        public static void ClickFirstChamptionBox()
        {
            int[] coordinatesFirstChampionBox = HelpFile.GetXYCoordinatesRegex(Options.FirstChampionBoxCoordinates);
            MouseEvent.MoveMouseXYToAndClick(coordinatesFirstChampionBox[0], coordinatesFirstChampionBox[1]);
            HelpFile.Log("Select Champ: Moved Mouse To First Champion In List And Clicked X:" + coordinatesFirstChampionBox[0] + ", Y:" + coordinatesFirstChampionBox[1] + ".");
            Thread.Sleep(Options.ImageRecognitionInterval);
        }

        public static void ClickLockButton()
        {
            int[] coordinates = HelpFile.GetXYCoordinatesRegex(Options.LockButtonCoodinates);
            MouseEvent.MoveMouseXYToAndClick(coordinates[0], coordinates[1]);
            HelpFile.Log("Lock Button: Moved Mouse To Lock Button And Clicked X:" + coordinates[0] + ", Y:" + coordinates[1] + ".");
        }
    }
}
