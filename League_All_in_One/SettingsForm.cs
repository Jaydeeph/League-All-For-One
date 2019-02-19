using League_All_in_One.Properties;
using MaterialSkin;
using MaterialSkin.Controls;

using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace League_All_in_One
{
    public partial class SettingsForm : MaterialForm
    {
        LeagueAIO mainForm;

        private Size autoLoginPageMatchMainFormPanelSize = new Size(459, 600);
        private Size autoLoginPageMatchFormSize = new Size(459, 663);

        private Size coordinatesPageMainFormPanelSize = new Size(459, 447);
        private Size coordinatesFormSize = new Size(459, 505);

        private Size othersPageMainFormPanelSize = new Size(459, 140);
        private Size othersPageFormSize = new Size(459, 203);

        public SettingsForm(LeagueAIO main)
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber500, Primary.Amber800, Primary.Amber300, Accent.LightBlue400, TextShade.BLACK);

            mainForm = main;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            LoadOptions();
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        private void LoadOptions()
        {
            SummonerNameTextbox.Text = Options.SummonerName;
            UsernameTextbox.Text = Options.Username;
            PasswordTextbox.Text = Options.Password;
            EncryptPasswordToggle.Checked = Options.IsPasswordEncrypted;
            LeagueDirectoryTextbox.Text = Options.LeagueExeDirectory;
            MatchTypeCombobox.Text = Options.MatchType;
            SummonerTypeCombobox.Text = Options.SummonerType;
            ChampionNameTextbox.Text = Options.ChampionName;
            ImageRecognitionIntervalTextbox.Text = Options.ImageRecognitionInterval.ToString();

            CoordinatesLoginUsernameTextbox.Text = Options.LoginUsernameCoordinates;
            CoordinatesLoginPasswordTextbox.Text = Options.LoginPasswordCoordinates;
            CoordinatesLoginButtonTextbox.Text  = Options.LoginButtonCoordinates;
            CoordinatesPlayButtonTextbox.Text = Options.PlayButtonCoordinates;
            CoordinatesSummonersMatchTextbox.Text = Options.SummonersRiftCoordinates;
            CoordinatesARAMMatchTextbox.Text = Options.ARAMMatchCoordinates;
            CoordinatesBlindPickTextbox.Text = Options.BlindPickCoordinates;
            CoordinatesDraftPickTextbox.Text = Options.DraftPickCoordinates;
            CoordinatesRankedSoloDuoTextbox.Text = Options.RankedSoloDuoCoordinates;
            CoordinatesConfirmButtonTextbox.Text = Options.ConfirmButtonCoordinates;
            CoordinatesChampionSearchTextbox.Text = Options.ChampionSearchTextboxCoordinates;
            CoordinatesFirstChampionBoxTextbox.Text = Options.FirstChampionBoxCoordinates;
            CoordinatesLockButtonTextbox.Text = Options.LockButtonCoodinates;
        }

        private void SaveOptions()
        {
            Options.SummonerName = SummonerNameTextbox.Text;
            Options.Username = UsernameTextbox.Text;
            if (EncryptPasswordToggle.Checked)
            {
                Options.Password = Encryption.EncryptNewPassword(PasswordTextbox.Text);
                Options.EncryptedIV = Encryption.ConvertRijndaelIVToBase64();
                Options.EncryptedKey = Encryption.ConvertRijndaelKeyToBase64();
            }
            else
            {
                Options.Password = PasswordTextbox.Text;
            }
            Options.IsPasswordEncrypted = EncryptPasswordToggle.Checked;
            Options.LeagueExeDirectory = LeagueDirectoryTextbox.Text;
            Options.MatchType = MatchTypeCombobox.Text;
            Options.SummonerType = SummonerTypeCombobox.Text;
            Options.ChampionName = ChampionNameTextbox.Text;
            if (HelpFile.IsTextNumeric(ImageRecognitionIntervalTextbox.Text)) Options.ImageRecognitionInterval = int.Parse(ImageRecognitionIntervalTextbox.Text);

            Options.LoginUsernameCoordinates = CoordinatesLoginUsernameTextbox.Text;
            Options.LoginPasswordCoordinates = CoordinatesLoginPasswordTextbox.Text;
            Options.LoginButtonCoordinates = CoordinatesLoginButtonTextbox.Text;
            Options.PlayButtonCoordinates = CoordinatesPlayButtonTextbox.Text;
            Options.SummonersRiftCoordinates = CoordinatesSummonersMatchTextbox.Text;
            Options.ARAMMatchCoordinates = CoordinatesARAMMatchTextbox.Text;
            Options.BlindPickCoordinates = CoordinatesBlindPickTextbox.Text;
            Options.DraftPickCoordinates = CoordinatesDraftPickTextbox.Text;
            Options.RankedSoloDuoCoordinates = CoordinatesRankedSoloDuoTextbox.Text;
            Options.ConfirmButtonCoordinates = CoordinatesConfirmButtonTextbox.Text;
            Options.ChampionSearchTextboxCoordinates = CoordinatesChampionSearchTextbox.Text;
            Options.FirstChampionBoxCoordinates = CoordinatesFirstChampionBoxTextbox.Text;
            Options.LockButtonCoodinates = CoordinatesLockButtonTextbox.Text;
    }

        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            SaveOptions();
            SaveSettingsButton.Enabled = false;

            string originalText = SaveSettingsButton.Text;
            var backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += (s, ea) => Thread.Sleep(TimeSpan.FromSeconds(5));

            backgroundWorker.RunWorkerCompleted += (s, ea) =>
            {
                SaveSettingsButton.Text = originalText;
                SaveSettingsButton.Enabled = true;
            };

            SaveSettingsButton.Text = "Settings Saved!";
            backgroundWorker.RunWorkerAsync();
        }

        private void ShowPassword()
        {
            if (Options.IsPasswordEncrypted)
            {
                PasswordTextbox.Text = Encryption.Decrypt(Options.Password, Encryption.ConvertRijndaelKeyToByte(Options.EncryptedKey), Encryption.ConvertRijndaelIVToByte(Options.EncryptedIV));
            }
            PasswordTextbox.UseSystemPasswordChar = false;
        }

        private void HidePassword()
        {
            if (Options.IsPasswordEncrypted)
            {
                PasswordTextbox.Text = Encryption.EncryptCurrentPassword(Options.Password, Encryption.ConvertRijndaelKeyToByte(Options.EncryptedKey), Encryption.ConvertRijndaelIVToByte(Options.EncryptedIV));
            }
            PasswordTextbox.UseSystemPasswordChar = true;
        }

        private void LocateLeagueExe()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "LeagueClient.exe (*.exe*)|*LeagueClient.exe*",
                FilterIndex = 1
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                LeagueDirectoryTextbox.Text = fileName;
            }
        }

        private void LocateLeagueButton_Click(object sender, EventArgs e)
        {
            LocateLeagueExe();
        }

        private void ShowHidePasswordPicturebox_MouseDown(object sender, MouseEventArgs e)
        {
            ShowPassword();
        }

        private void ShowHidePasswordPicturebox_MouseUp(object sender, MouseEventArgs e)
        {
            HidePassword();
        }

        private TextBox tempTextBox;

        private void SelectCoordinates_TextBox(object sender, EventArgs e)
        {
            tempTextBox = (TextBox)sender;
            tempTextBox.Text = "Right Click To Select Coordinates.";
            PositionTimer.Start();
        }

        private void PositionTimer_Tick(object sender, EventArgs e)
        {
            if (KeyboardEvents.GetAsyncKeyState(Keys.RButton) != 0)
            {
                Point mousePosition = GetCurrentMousePosition();
                tempTextBox.Text = "X: " + mousePosition.X + " Y: " + mousePosition.Y;
                PositionTimer.Stop();
            }
        }

        private Point GetCurrentMousePosition()
        {
            return MousePosition;
        }

        private void MainTabController_Selected(object sender, TabControlEventArgs e)
        {
            if (MainTabController.SelectedTab == MainTabController.TabPages["AutoLoginMatchPage"])
            {
                MainFormPanel.Size = autoLoginPageMatchMainFormPanelSize;
                this.Size = autoLoginPageMatchFormSize;
            }
            else if (MainTabController.SelectedTab == MainTabController.TabPages["CoordinatesPage"])
            {
                MainFormPanel.Size = coordinatesPageMainFormPanelSize;
                this.Size = coordinatesFormSize;
            }
            else if (MainTabController.SelectedTab == MainTabController.TabPages["OthersPage"])
            {
                MainFormPanel.Size = othersPageMainFormPanelSize;
                this.Size = othersPageFormSize;
            }
        }
    }
}
