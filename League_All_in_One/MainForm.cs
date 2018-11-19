using League_All_in_One.Properties;

using MaterialSkin;
using MaterialSkin.Controls;

using System;
using System.Collections;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace League_All_in_One
{
    public partial class LeagueAIO : MaterialForm
    {
        private Thread MainOperationsManagerThread;
        private Thread IsClientFullyLoadedThread;
        private Thread AutoLoginThread;
        private Thread AutoCreateMatchThread;
        private Thread AutoAcceptMatchThread;
        private Thread AutoChampSelectThread;
        private Thread AutoChatSpamThread;

        private PriorityQueue PQ;

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
            //Load Options.

            PQ = new PriorityQueue();
        }

        private void LeagueAIO_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Save Options.
        }

        private void LoadOptions()
        {
            Options.AutoStartLeague = Settings.Default.AutoStartLeague;
            Options.AutoLogin = Settings.Default.AutoLogin;
            Options.AutoCreateLobby = Settings.Default.AutoCreateLobby;
            Options.AutoAccept = Settings.Default.AutoAccept;
            Options.AutoChampSelect = Settings.Default.AutoChampionSelect;
            Options.AutoChatSpam = Settings.Default.AutoChatSpam;
            Options.AutoRuneSelect = Settings.Default.AutoRunesSelect;

            Options.SummonerName = Settings.Default.SummonerName;
            Options.IsPasswordEncrypted = Settings.Default.IsPasswordEncrypted;
            Options.Username = Settings.Default.Username;
            Options.Password = (Options.IsPasswordEncrypted == true) ? Options.Password = Settings.Default.EncryptedPassword : Options.Password = Settings.Default.NotEncryptedPassword;
            Options.LeagueExeDirectory = Settings.Default.LeagueExeDirectory;
            Options.MatchType = Settings.Default.MatchType;
            Options.SummonerType = Settings.Default.SummonerType;
            Options.ChampionName = Settings.Default.ChamptionName;
            Options.ChatSpamText = Settings.Default.ChatSpamText;
            Options.NoTimesSpam = Settings.Default.NoTimesSpam;
        }

        private void SaveOptions()
        {
            Settings.Default.AutoStartLeague = Options.AutoStartLeague;
            Settings.Default.AutoLogin = Options.AutoLogin;
            Settings.Default.AutoCreateLobby = Options.AutoCreateLobby;
            Settings.Default.AutoAccept = Options.AutoAccept;
            Settings.Default.AutoChampionSelect = Options.AutoChampSelect;
            Settings.Default.AutoChatSpam = Options.AutoChatSpam;
            Settings.Default.AutoRunesSelect = Options.AutoRuneSelect;

            Settings.Default.SummonerName = Options.SummonerName;
            Settings.Default.IsPasswordEncrypted = Options.IsPasswordEncrypted;
            Settings.Default.Username = Options.Username;
            if (Options.IsPasswordEncrypted) Settings.Default.EncryptedPassword = Options.Password; else Settings.Default.NotEncryptedPassword = Options.Password;
            Settings.Default.LeagueExeDirectory = Options.LeagueExeDirectory;
            Settings.Default.MatchType = Options.MatchType;
            Settings.Default.SummonerType = Options.SummonerType;
            Settings.Default.ChamptionName = Options.ChampionName;
            Settings.Default.ChatSpamText = Options.ChatSpamText;
            Settings.Default.NoTimesSpam = Options.NoTimesSpam;
        }

        private void MainOperationsBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (!MainOperationsBackgroundWorker.CancellationPending)
            {

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
                LiveStatusLabel.Text = "Error 404: League.exe not found. Please choose league.exe directory.";
                AutoStartLeagueToggle.Checked = false;
                return;
            }

            Process.Start(Options.LeagueExeDirectory);
        }

        private async void CheckIfLeagueLoadedAsync()
        {
            bool leagueFullyLoadedWithRiotLogo = false;

            while (!leagueFullyLoadedWithRiotLogo)
            {
                TakeFullDesktopScreenShot();
                leagueFullyLoadedWithRiotLogo = await ImageRecognition.CheckLeagueRiotLogoImageRecognition();
            }

            if (leagueFullyLoadedWithRiotLogo)
            {
                Thread.Sleep(1000);
                //Start Login To League.
            }
        }

        private bool CheckUsernamePasswordTextIsValid()
        {
            return !string.IsNullOrWhiteSpace(Options.Username) && !string.IsNullOrWhiteSpace(Options.Password);
        }

        private async void LoginToLeagueAsync()
        {
            bool rememberMeChecked = false;
            bool addedUsername = false;
            bool addedPassword = false;
            bool clickedSignIn = false;
            bool failLoggedIn = false;

            if (!CheckUsernamePasswordTextIsValid())
            {
                MessageBox.Show(@"Please make sure you've added your Username and Password.\r\nPlease check the Auto Login tab.", "Unable To Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LiveStatusLabel.Text = "Please double check the Username and Password.";
                return;
            }

            TakeFullDesktopScreenShot();
            rememberMeChecked = await ImageRecognition.RememberMeCheckedImageRecognition();

            while (!clickedSignIn || !failLoggedIn)
            {
                if (rememberMeChecked)
                {
                    TakeFullDesktopScreenShot();
                    if (!addedPassword) addedPassword = await ImageRecognition.LoginPasswordImageRecognition(Options.Password);

                    TakeFullDesktopScreenShot();
                    if (!addedPassword) addedPassword = await ImageRecognition.LoginPasswordFocusedImageRecognition(Options.Password);
                }
                else
                {
                    TakeFullDesktopScreenShot();
                    if (!addedUsername) addedUsername = await ImageRecognition.LoginUsernameImageRecognition(Options.Username);

                    TakeFullDesktopScreenShot();
                    if (!addedUsername) addedUsername = await ImageRecognition.LoginUsernameFocusedImageRecognition(Options.Username);

                    TakeFullDesktopScreenShot();
                    if (!addedPassword) addedPassword = await ImageRecognition.LoginPasswordImageRecognition(Options.Password);

                    TakeFullDesktopScreenShot();
                    if (!addedPassword) addedPassword = await ImageRecognition.LoginPasswordFocusedImageRecognition(Options.Password);
                }

                if (addedPassword) KeyboardEvents.PressEnter();

                TakeFullDesktopScreenShot();
                if (!clickedSignIn) clickedSignIn = await ImageRecognition.LoginSignInImageRecognition();

                TakeFullDesktopScreenShot();
                if (!failLoggedIn) failLoggedIn = await ImageRecognition.LoginFailed();

                if (failLoggedIn)
                {
                    //stop thread.
                    AutoLoginToggle.Checked = false;
                    MessageBox.Show(@"Please make sure your Username and Password is correct.", "Unable To Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LiveStatusLabel.Text = "Please double check the Username and Password.";
                }
            }

            //if (clickedSignIn) acceptLeagueMatchThread.Start();
            //Dont start next thread straight away!
        }

        private async void CreateSummonersRiftLobby()
        {
            bool clickedPlayButton = false;
            bool selectedSummonersRift = false;
            bool clickedConfirmButton = false;
            
            while (!clickedConfirmButton)
            {
                TakeFullDesktopScreenShot();
                if (!clickedPlayButton) clickedPlayButton = await ImageRecognition.AutoClickPlayButton();

                TakeFullDesktopScreenShot();
                if (!selectedSummonersRift) selectedSummonersRift = await ImageRecognition.AutoChooseSummerRiftMode();

                TakeFullDesktopScreenShot();
                if (!clickedConfirmButton) clickedConfirmButton = await ImageRecognition.AutoClickConfirmButton();
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
                if (!clickedPlayButton) clickedPlayButton = await ImageRecognition.AutoClickPlayButton();

                TakeFullDesktopScreenShot();
                if (!selectedARAM) selectedARAM = await ImageRecognition.AutoChooseARAMtMode();

                TakeFullDesktopScreenShot();
                if (!clickedConfirmButton) clickedConfirmButton = await ImageRecognition.AutoClickConfirmButton();
            }
        }        

        private void AutoStartLeagueToggle_CheckedChanged(object sender)
        {
            if (AutoStartLeagueToggle.Checked)
            {
                if (string.IsNullOrWhiteSpace(Options.LeagueExeDirectory))
                {
                    MessageBox.Show("League AIO", "Please choose your League.exe directory in the settings.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AutoStartLeagueToggle.Checked = false;
                    return;
                }
            }
        }

        private void AutoLoginToggle_CheckedChanged(object sender)
        {
            if (AutoLoginToggle.Checked)
            {
                PQ.push(1, AutoLoginThread);
                PQ.PrintQueue();
            }
            else
            {
                PQ.PopFromKey(1);
            }
        }

        private void CreateMatchToggle_CheckedChanged(object sender)
        {
            if (CreateMatchToggle.Checked)
            {
                PQ.push(2, AutoCreateMatchThread);
                PQ.PrintQueue();
            }
            else
            {
                PQ.PopFromKey(2);
            }
        }

        private void AutoAcceptToggle_CheckedChanged(object sender)
        {
            if (AutoAcceptToggle.Checked)
            {
                PQ.push(3, AutoAcceptMatchThread);
                PQ.PrintQueue();
            }
            else
            {
                PQ.PopFromKey(3);
            }
        }

        private void AutoChampSelectToggle_CheckedChanged(object sender)
        {
            
        }

        private void AutoSpamChatToggle_CheckedChanged(object sender)
        {

        }
    }

    class PriorityQueue
    {
        private SortedList PseudoQueue;

        public bool Empty
        {
            get
            {
                return PseudoQueue.Count == 0;
            }
        }

        public PriorityQueue()
        {
            PseudoQueue = new SortedList();
        }

        public void push(object Priority, object Value)
        {
            PseudoQueue.Add(Priority, Value);
        }

        public void PopFromKey(object Priority)
        {
            PseudoQueue.Remove(Priority);
        }

        public object[] pop()
        {
            object[] ReturnValue = { null, null };
            if (PseudoQueue.Count > 0)
            {
                ReturnValue[0] = PseudoQueue.GetKey(0);
                ReturnValue[1] = PseudoQueue.GetByIndex(0);

                PseudoQueue.RemoveAt(0);
            }
            return ReturnValue;
        }
        
        public void PrintQueue()
        {
            foreach (DictionaryEntry item in PseudoQueue)
            {
                Console.WriteLine("key: {0}, value: {1}", item.Key, item.Value);
            }
        }
    }
}
