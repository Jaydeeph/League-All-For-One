using MaterialSkin;
using MaterialSkin.Controls;

using System;
using System.Drawing;
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

        private Size othersPageMainFormPanelSize = new Size(459, 236);
        private Size othersPageFormSize = new Size(459, 300);

        private Size coloursPageMainFormPanelSize = new Size(459, 431);
        private Size coloursPageMainFormSiz = new Size(459, 494);

        public SettingsForm(LeagueAIO main)
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Options.PrimaryColor, Options.PrimaryDarkColor, Options.PrimaryLightColor, Options.AccentColor, Options.TextShadeColour);

            mainForm = main;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            LoadPrimiaryColorToDropbox();
            LoadDarkPrimaryColourToDropbox();
            LoadLightPrimaryColourToDropbox();
            LoadAccentColourToDropbox();
            LoadTextshadeColourToDropbox();

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
            InteractionIntervalTextbox.Text = Options.InteractionInterval.ToString();

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

            ContiuouslyMonitorAcceptMatchCheckbox.Checked = Options.ContiuouslyMonitorAcceptMatch;

            PrimaryColourDropbox.SelectedItem = Enum.GetName(typeof(Primary), Options.PrimaryColor);
            DarkPrimaryColourDropdownbox.SelectedItem = Enum.GetName(typeof(Primary), Options.PrimaryDarkColor);
            LightPrimaryColourDropdownbox.SelectedItem = Enum.GetName(typeof(Primary), Options.PrimaryLightColor);
            AccentColourDropdownbox.SelectedItem = Enum.GetName(typeof(Accent), Options.AccentColor);
            TextshadeColourDropdownbox.SelectedItem = Enum.GetName(typeof(TextShade), Options.TextShadeColour);
        }

        private void SaveOptions()
        {
            Options.SummonerName = SummonerNameTextbox.Text;
            Options.Username = UsernameTextbox.Text;
            if (EncryptPasswordToggle.Checked)
            {
                if (Encryption.IsBase64String(PasswordTextbox.Text))
                {
                    Options.Password = PasswordTextbox.Text;
                }
                else
                {
                    Options.Password = Encryption.ConvertToBase64(PasswordTextbox.Text);
                }
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
            if (HelpFile.IsTextNumeric(InteractionIntervalTextbox.Text)) Options.InteractionInterval = int.Parse(InteractionIntervalTextbox.Text);

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

            Options.ContiuouslyMonitorAcceptMatch = ContiuouslyMonitorAcceptMatchCheckbox.Checked;
                        
            Options.PrimaryColor = (Primary)Enum.Parse(typeof(Primary), PrimaryColourDropbox.SelectedItem.ToString());
            Options.PrimaryDarkColor = (Primary)Enum.Parse(typeof(Primary), DarkPrimaryColourDropdownbox.SelectedItem.ToString());
            Options.PrimaryLightColor = (Primary)Enum.Parse(typeof(Primary), LightPrimaryColourDropdownbox.SelectedItem.ToString());
            Options.AccentColor = (Accent)Enum.Parse(typeof(Accent), AccentColourDropdownbox.SelectedItem.ToString());
            Options.TextShadeColour = (TextShade)Enum.Parse(typeof(TextShade), TextshadeColourDropdownbox.SelectedItem.ToString());
        }

        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            SaveOptions();
            Options.SaveOptions();

            SaveSettingsButton.Enabled = false;
            MessageBox.Show("Your settings are now saved.", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            mainForm.Show();
        }

        private void ShowPassword()
        {
            if (Options.IsPasswordEncrypted)
            {
                if (Encryption.IsBase64String(PasswordTextbox.Text))
                {
                    PasswordTextbox.Text = Encryption.ConvertFromBase64(PasswordTextbox.Text);
                }
            }
            PasswordTextbox.UseSystemPasswordChar = false;
        }

        private void HidePassword()
        {
            if (Options.IsPasswordEncrypted)
            {
                if (Encryption.IsBase64String(PasswordTextbox.Text))
                {
                    PasswordTextbox.Text = Encryption.ConvertToBase64(PasswordTextbox.Text);
                }
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
            tempTextBox.Text = "Right Click On It.";
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
            if (MainTabController.SelectedTab == MainTabController.TabPages["DetailsPage"])
            {
                MainFormPanel.Size = autoLoginPageMatchMainFormPanelSize;
                this.Size = autoLoginPageMatchFormSize;
            }
            else if (MainTabController.SelectedTab == MainTabController.TabPages["CoordinatesPage"])
            {
                MainFormPanel.Size = coordinatesPageMainFormPanelSize;
                this.Size = coordinatesFormSize;
            }
            else if (MainTabController.SelectedTab == MainTabController.TabPages["OtherPage"])
            {
                MainFormPanel.Size = othersPageMainFormPanelSize;
                this.Size = othersPageFormSize;
            }
            else if (MainTabController.SelectedTab == MainTabController.TabPages["ColoursPage"])
            {
                MainFormPanel.Size = coloursPageMainFormPanelSize;
                this.Size = coloursPageMainFormSiz;
            }
        }

        private void ResetLoginMatchButton_Click(object sender, EventArgs e)
        {
            Options.ClearUserAndMatchDetails();
            MessageBox.Show("The details were successfully removed.", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ResetCoordinatesButton_Click(object sender, EventArgs e)
        {
            Options.ClearCoordinates();
            MessageBox.Show("The coordinates were successfully removed.", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ResetEverythingButton_Click(object sender, EventArgs e)
        {
            Options.ClearEverything();
            MessageBox.Show("Everything was successfully reset.", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadPrimiaryColorToDropbox()
        {
            string[] primaryColours = Enum.GetNames(typeof(Primary));
            PrimaryColourDropbox.DataSource = primaryColours;

        }

        private void LoadDarkPrimaryColourToDropbox()
        {
            string[] primaryColours = Enum.GetNames(typeof(Primary));
            DarkPrimaryColourDropdownbox.DataSource = primaryColours;
        }

        private void LoadLightPrimaryColourToDropbox()
        {
            string[] primaryColours = Enum.GetNames(typeof(Primary));
            LightPrimaryColourDropdownbox.DataSource = primaryColours;
        }

        private void LoadAccentColourToDropbox()
        {
            string[] primaryColours = Enum.GetNames(typeof(Accent));
            AccentColourDropdownbox.DataSource = primaryColours;
        }

        private void LoadTextshadeColourToDropbox()
        {
            string[] primaryColours = Enum.GetNames(typeof(TextShade));
            TextshadeColourDropdownbox.DataSource = primaryColours;
        }

        private void RestColoursToDefaultButton_Click(object sender, EventArgs e)
        {
            Options.PrimaryColor = Options.DefaultPrimaryColour;
            Options.PrimaryDarkColor = Options.DefaultPrimaryDarkColour;
            Options.PrimaryLightColor = Options.DefaultPrimaryLightColour;
            Options.AccentColor = Options.DefaultAccentColour;
            Options.TextShadeColour = Options.DefaultTextShadeColour;

            MessageBox.Show("Colours reset to default. App restard required.", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
