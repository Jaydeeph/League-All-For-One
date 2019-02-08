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
        private Thread MainOperationsManagerThread;
        private Thread AutoLoginThread;
        private Thread AutoCreateSummonersRiftThread;
        private Thread AutoCreateARAMThread;
        private Thread AutoAcceptMatchThread;
        private Thread AutoSelectChampionThread;
        private Thread AutoLockChampionThread;

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

        private void SetupImageRecognitionThreads()
        {
            MainOperationsManagerThread = new Thread(() => ImageRecognitionOperationManager());
            MainOperationsManagerThread.Name = "Main Operations Thread";
            MainOperationsManagerThread.SetApartmentState(ApartmentState.STA);

            AutoLoginThread = new Thread(() => LoginToLeague());
            AutoLoginThread.Name = "Login Thread";
            AutoLoginThread.SetApartmentState(ApartmentState.STA);

            AutoCreateSummonersRiftThread = new Thread(() => CreateSummonersRiftLobby());
            AutoCreateSummonersRiftThread.Name = "Create Summoner's Rift Thread";
            AutoCreateSummonersRiftThread.SetApartmentState(ApartmentState.STA);

            AutoCreateARAMThread = new Thread(() => CreateARAMLobby());
            AutoCreateARAMThread.Name = "Create ARAM Thread";
            AutoCreateARAMThread.SetApartmentState(ApartmentState.STA);

            AutoAcceptMatchThread = new Thread(() => AcceptMatchButton());
            AutoAcceptMatchThread.Name = "Accept Match Thread";
            AutoAcceptMatchThread.SetApartmentState(ApartmentState.STA);

            AutoSelectChampionThread = new Thread(() => SelectChampion());
            AutoSelectChampionThread.Name = "Select Champion Thread";
            AutoSelectChampionThread.SetApartmentState(ApartmentState.STA);

            AutoLockChampionThread = new Thread(() => LockChampion());
            AutoLockChampionThread.Name = "Lock Champion Thread";
            AutoLockChampionThread.SetApartmentState(ApartmentState.STA);
        }

        private async void ImageRecognitionOperationManager()
        {
            if (AutoStartLeagueToggle.Checked)
            {
                AutoStartLeagueClient();
                UncheckToggle_FromRunningThread(AutoStartLeagueToggle);
            }

            if (AutoLoginToggle.Checked)
            {
                HelpFile.Log("Starting Thread: " + AutoLoginThread.Name);

                AutoLoginThread.Start();
                AutoLoginThread.Join();
                UncheckToggle_FromRunningThread(AutoLoginToggle);
            }

            if (AutoCreateMatchToggle.Checked)
            {
                if (Options.MatchType.Equals("Summoners Rift"))
                {
                    HelpFile.Log("Starting Thread: " + AutoCreateSummonersRiftThread.Name);

                    AutoCreateSummonersRiftThread.Start();
                    AutoCreateSummonersRiftThread.Join();
                    UncheckToggle_FromRunningThread(AutoCreateMatchToggle);
                }

                if (Options.MatchType.Equals("ARAM"))
                {
                    HelpFile.Log("Starting Thread: " + AutoCreateARAMThread.Name);

                    AutoCreateARAMThread.Start();
                    AutoCreateARAMThread.Join();
                    UncheckToggle_FromRunningThread(AutoCreateMatchToggle);
                }
            }

            if (AutoAcceptToggle.Checked)
            {
                HelpFile.Log("Starting Thread: " + AutoAcceptMatchThread.Name);

                AutoAcceptMatchThread.Start();
                AutoAcceptMatchThread.Join();
                UncheckToggle_FromRunningThread(AutoAcceptToggle);
            }

            if (AutoSelectChampionToggle.Checked)
            {
                HelpFile.Log("Starting Thread: " + AutoSelectChampionThread.Name);

                AutoSelectChampionThread.Start();
                AutoSelectChampionThread.Join();
                UncheckToggle_FromRunningThread(AutoSelectChampionToggle);
            }

            if (AutoLockChampionToggle.Checked)
            {
                HelpFile.Log("Starting Thread: " + AutoLockChampionThread.Name);

                AutoLockChampionThread.Start();
                AutoLockChampionThread.Join();
                UncheckToggle_FromRunningThread(AutoLockChampionToggle);
            }
        }

        private void TakeFullDesktopScreenShot()
        {
            ScreenCapture screenCapsture = new ScreenCapture();
            ImageRecognition.desktopScreenshot = screenCapsture.CaptureScreen();
        }

        private void AutoStartLeagueClient()
        {
            if (string.IsNullOrWhiteSpace(Options.LeagueExeDirectory))
            {
                MessageBox.Show("League path directory is not selected! Please select league.exe", "Error 404: League.exe not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetLiveStatusText("Error 404: League.exe not found. Please choose league.exe directory.", Color.Red);
                HelpFile.Log("Error 404: League.exe Not Found. Please Choose League.exe Directory.");

                AutoStartLeagueToggle.Checked = false;
                return;
            }

            Process.Start(Options.LeagueExeDirectory);
            SetLiveStatusText("Started the league client.", Color.Green);
            HelpFile.Log("League Client: Started The League.exe Client.");
        }

        private async Task<bool> CheckIfLeagueLoaded()
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

        private bool CheckUsernamePasswordTextIsValid()
        {
            return !string.IsNullOrWhiteSpace(Options.Username) && !string.IsNullOrWhiteSpace(Options.Password);
        }

        private async void LoginToLeague()
        {
            bool leagueFullyLoaded = false;
            bool rememberMeChecked = false;
            bool addedUsername = false;
            bool addedPassword = false;
            bool clickedSignIn = false;
            bool failLoggedIn = false;

            if (!CheckUsernamePasswordTextIsValid())
            {
                MessageBox.Show(@"Please make sure you've added your Username and Password.\r\nPlease check the Auto Login tab.", "Unable To Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetLiveStatusText("Please double check the Username and Password.", Color.Green);
                return;
            }

            while (!leagueFullyLoaded)
            {
                leagueFullyLoaded = await CheckIfLeagueLoaded();
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
                    }

                    TakeFullDesktopScreenShot();
                    if (!addedPassword) addedPassword = await ImageRecognition.LoginPasswordImageRecognition();

                    TakeFullDesktopScreenShot();
                    if (!addedPassword) addedPassword = await ImageRecognition.LoginPasswordFocusedImageRecognition();

                    if (addedPassword)
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

            if (failLoggedIn)
            {
                AutoLoginToggle.Checked = false;
                MessageBox.Show(@"Please make sure your Username and Password is correct.", "Unable To Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetLiveStatusText("Please double check the Username and Password.", Color.Green);
                return;
            }

            if (clickedSignIn)
            {
                SetLiveStatusText("Successfully logged into league.", Color.Green);
                AutoLogin = true;
                return;
            }
        }

        private async void CreateSummonersRiftLobby()
        {
            bool clickedPlayButton = false;
            bool selectedSummonersRift = false;
            bool selectSummonerType = false;
            bool clickedConfirmButton = false;
            
            while (!clickedConfirmButton)
            {
                TakeFullDesktopScreenShot();
                if (!clickedPlayButton) clickedPlayButton = await ImageRecognition.AutoClickPlayButtonImageRecognition();
                if (clickedPlayButton)
                {
                    int[] coordinates = HelpFile.GetXYCoordinatesRegex(Options.PlayButtonCoordinates);
                    MouseEvent.MoveMouseXYToAndClick(coordinates[0], coordinates[1]);
                    HelpFile.Log("Click Play Button: Clicked Play Button X:" + coordinates[0] + ", Y:" + coordinates[1] + ".");
                }

                TakeFullDesktopScreenShot();
                if (!selectedSummonersRift) selectedSummonersRift = await ImageRecognition.AutoChooseSummerRiftModeImageRecognition();
                if (selectedSummonersRift)
                {
                    int[] coordinates = HelpFile.GetXYCoordinatesRegex(Options.SummonersRiftCoordinates);
                    MouseEvent.MoveMouseXYToAndClick(coordinates[0], coordinates[1]);
                    HelpFile.Log("Pick Summoner Mode: Picked Summoner Rift X:" + coordinates[0] + ", Y:" + coordinates[1] + ".");
                }

                Console.WriteLine(Options.SummonerType);

                if (Options.SummonerType.Equals("Draft Pick"))
                {
                    TakeFullDesktopScreenShot();
                    if (!selectSummonerType) selectSummonerType = await ImageRecognition.AutoChooseSummersDraftPickImageRecognition();
                    if (selectSummonerType)
                    {
                        int[] coordinates = HelpFile.GetXYCoordinatesRegex(Options.DraftPickCoordinates);
                        MouseEvent.MoveMouseXYToAndClick(coordinates[0], coordinates[1]);
                        HelpFile.Log("Summoner Mode: Draft Pick X:" + coordinates[0] + ", Y:" + coordinates[1] + ".");
                    }
                }

                if (Options.SummonerType.Equals("Blind Pick"))
                {
                    TakeFullDesktopScreenShot();
                    if (!selectSummonerType) selectSummonerType = await ImageRecognition.AutoChooseSummersBlindPickImageRecognition();
                    if (selectSummonerType)
                    {
                        int[] coordinates = HelpFile.GetXYCoordinatesRegex(Options.BlindPickCoordinates);
                        MouseEvent.MoveMouseXYToAndClick(coordinates[0], coordinates[1]);
                        HelpFile.Log("Summoner Mode: Blind Pick X:" + coordinates[0] + ", Y:" + coordinates[1] + ".");
                    }
                }

                if (Options.SummonerType.Equals("Ranked Solo/Duo"))
                {
                    TakeFullDesktopScreenShot();
                    if (!selectSummonerType) selectSummonerType = await ImageRecognition.AutoChooseSummersRankedImageRecognition();
                    if (selectSummonerType)
                    {
                        int[] coordinates = HelpFile.GetXYCoordinatesRegex(Options.RankedSoloDuoCoordinates);
                        MouseEvent.MoveMouseXYToAndClick(coordinates[0], coordinates[1]);
                        HelpFile.Log("Summoner Mode: Ranked Pick X:" + coordinates[0] + ", Y:" + coordinates[1] + ".");
                    }
                }

                TakeFullDesktopScreenShot();
                if (!clickedConfirmButton) clickedConfirmButton = await ImageRecognition.AutoClickConfirmButtonImageRecognition();
                if (clickedConfirmButton)
                {
                    int[] coordinates = HelpFile.GetXYCoordinatesRegex(Options.PlayButtonCoordinates);
                    MouseEvent.MoveMouseXYToAndClick(coordinates[0], coordinates[1]);
                    HelpFile.Log("Confirm Button: Clicked Confirm Button X:" + coordinates[0] + ", Y:" + coordinates[1] + ".");

                    AutoCreateSummonerRift = true;
                    SetLiveStatusText("Created Summoner's Rift: " + Options.SummonerType + " room.", Color.Green);
                }
            }
        }

        private async void CreateARAMLobby()
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
                    int[] coordinates = HelpFile.GetXYCoordinatesRegex(Options.PlayButtonCoordinates);
                    MouseEvent.MoveMouseXYToAndClick(coordinates[0], coordinates[1]);
                    HelpFile.Log("Click Play Button: Clicked Play Button X:" + coordinates[0] + ", Y:" + coordinates[1] + ".");
                }

                TakeFullDesktopScreenShot();
                if (!selectedARAM) selectedARAM = await ImageRecognition.AutoChooseARAMModeImageRecognition();
                if (selectedARAM)
                {
                    int[] coordinates = HelpFile.GetXYCoordinatesRegex(Options.ARAMMatchCoordinates);
                    MouseEvent.MoveMouseXYToAndClick(coordinates[0], coordinates[1]);
                    HelpFile.Log("Pick ARAM Mode X:" + coordinates[0] + ", Y:" + coordinates[1] + ".");
                }

                TakeFullDesktopScreenShot();
                if (!clickedConfirmButton) clickedConfirmButton = await ImageRecognition.AutoClickConfirmButtonImageRecognition();
                if (clickedConfirmButton)
                {
                    int[] coordinates = HelpFile.GetXYCoordinatesRegex(Options.ConfirmButtonCoordinates);
                    MouseEvent.MoveMouseXYToAndClick(coordinates[0], coordinates[1]);
                    HelpFile.Log("Confirm Button: Clicked Confirm Button X:" + coordinates[0] + ", Y:" + coordinates[1] + ".");

                    AutoCreateSummonerRift = true;
                    SetLiveStatusText("Created an ARAM room.", Color.Green);
                }
            }
        }

        private async void AcceptMatchButton()
        {
            bool championSearchbox = false;
            bool accepted = false;

            while (!championSearchbox)
            {
                TakeFullDesktopScreenShot();
                if (!championSearchbox) championSearchbox = await ImageRecognition.AutoFindChampionSearchTextboxImageRecognition();

                TakeFullDesktopScreenShot();
                if (!accepted) accepted = await ImageRecognition.AutoAcceptImageRecognition();
                if (accepted)
                {
                    int[] coordinates = HelpFile.GetXYCoordinatesRegex(Options.AutoAcceptButtonCoordinates);
                    MouseEvent.MoveMouseXYToAndClick(coordinates[0], coordinates[1]);
                    HelpFile.Log("Auto Accept: Clicked Accept Button X:" + coordinates[0] + ", Y:" + coordinates[1] + ".");

                    SetLiveStatusText("Accepted Match", Color.Green);
                }
            }
        }

        private async void SelectChampion()
        {
            bool selectChampion = false;
            bool randomChampionBox = false;

            while (!selectChampion)
            {
                TakeFullDesktopScreenShot();
                if (!randomChampionBox) randomChampionBox = await ImageRecognition.AutoFindRandomChampionBoxImageRecognition();
                if (randomChampionBox)
                {
                    KeyboardEvents.SetClipboardText(Options.ChampionName);
                    HelpFile.Log("Select Champ: Copied Champion Name To Clipboard.");
                    Thread.Sleep(Options.ImageRecognitionInterval);

                    int[] coordinatesChampionSearchTextbox = HelpFile.GetXYCoordinatesRegex(Options.ChampionSearchTextboxCoordinates);
                    MouseEvent.MoveMouseXYToAndClick(coordinatesChampionSearchTextbox[0], coordinatesChampionSearchTextbox[1]);
                    HelpFile.Log("Select Champ: Search Text Box Clicked X:" + coordinatesChampionSearchTextbox[0] + ", Y:" + coordinatesChampionSearchTextbox[1] + ".");
                    Thread.Sleep(Options.ImageRecognitionInterval);

                    KeyboardEvents.PressControlV();
                    HelpFile.Log("Select Champ: Pressed Control+V To Paste Champion Name.");
                    Thread.Sleep(Options.ImageRecognitionInterval);

                    int[] coordinatesFirstChampionBox = HelpFile.GetXYCoordinatesRegex(Options.FirstChampionBoxCoordinates);
                    MouseEvent.MoveMouseXYToAndClick(coordinatesFirstChampionBox[0], coordinatesFirstChampionBox[1]);
                    HelpFile.Log("Select Champ: Moved Mouse To First Champion In List And Clicked X:" + coordinatesFirstChampionBox[0]+ ", Y:" + coordinatesFirstChampionBox[1] + ".");
                    Thread.Sleep(Options.ImageRecognitionInterval);

                    selectChampion = true;

                    AutoSelectChampion = true;
                    SetLiveStatusText(Options.ChampionName + " was selected.", Color.Green);
                }
            }
        }

        private async void LockChampion()
        {
            bool lockChampion = false;

            while (!lockChampion)
            {
                TakeFullDesktopScreenShot();
                if (!lockChampion) lockChampion = await ImageRecognition.AutoLockChampionImageRecognition();
                if (lockChampion)
                {
                    int[] coordinates = HelpFile.GetXYCoordinatesRegex(Options.LockButtonCoodinates);
                    MouseEvent.MoveMouseXYToAndClick(coordinates[0], coordinates[1]);
                    HelpFile.Log("Lock Button: Moved Mouse To Lock Button And Clicked X:" + coordinates[0] + ", Y:" + coordinates[1] + ".");

                    AutoLockChampion = true;
                    SetLiveStatusText("Champion has been locked.", Color.Green);
                }
            }
        }

        private void ShowMessageBox(string title, string message, MessageBoxIcon icon)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
            });
        }

        private void SetLiveStatusText(string message, Color color)
        {
            LiveStatusLabel.BeginInvoke((MethodInvoker) delegate ()
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

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(this);
            settingsForm.Show();
            this.Hide();
        }

        private void StartAutoImageRecognitionButton_Click(object sender, EventArgs e)
        {
            SetupImageRecognitionThreads();
            MainOperationsManagerThread.Start();
        }
    }
}
