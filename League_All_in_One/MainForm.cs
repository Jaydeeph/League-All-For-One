using Emgu.CV;
using Emgu.CV.Structure;
using League_All_in_One.Properties;
using MaterialSkin;
using MaterialSkin.Controls;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace League_All_in_One
{
    public partial class LeagueAIO : MaterialForm
    {
        #region "Public Getters"
        public Label GetLiveStatusLabel
        {
            get { return LiveStatusLabel; }
        }

        public Timer GetAutoLoginTimer
        {
            get { return AutoLoginTimer; }
        }

        public Timer GetAutoAcceptTimer
        {
            get { return AutoAcceptTimer; }
        }

        public Timer GetAutoChampSelectTimer
        {
            get { return AutoChampSelectTimer; }
        }

        public Timer GetAutoChatSpamTimer
        {
            get { return AutoChatSpamTimer; }
        }

        public Timer GetAutoRunesSelectTimer
        {
            get { return AutoRuneSelectTimer; }
        }
        #endregion

        public LeagueAIO()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber500, Primary.Amber800, Primary.Amber300, Accent.LightBlue400, TextShade.BLACK);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //LoadSettingsAndUserDetails();
            //StartTakeScreenshotTimer();
        }

        private void LeagueAIO_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Options.SaveOptions();
        }
        private void LoadSettingsAndUserDetails()
        {
            LiveStatusLabel.Text = "Loading User Settings...";

            Options.LoadOptions();

            List<Label> statusLabels = new List<Label>
            {
                AutoLoginStatusLabel,
                AutoAcceptStatusLabel,
                AutoChampSelectStatusLabel,
                AutoChatSpamStatusLabel,
                AutoRunesSelectStatusLabel
            };

            List<bool> optionsStatusBool = new List<bool>
            {
                Options.AutoLoginStatus,
                Options.AutoAcceptStatus,
                Options.AutoChampSelectStatus,
                Options.AutoChatSpamStatus,
                Options.AutoRuneSelectStatus
            };

            Options.CreateAutoStatusDictionary(statusLabels, optionsStatusBool);
            Options.LoadLabelStatusFromOptionsVariables();
        }
        
        private void SaveSettingsAndUserDetails()
        {
            Options.SaveOptions();
        }

        #region "Start/Stop Timer Voids"
        public void StartTakeScreenshotTimer()
        {
            TakeScreenshotTimer.Start();
        }

        public void StopTakeScreenshotTimer()
        {
            TakeScreenshotTimer.Stop();
        }

        public void StartAutoLoginTimer()
        {
            AutoLoginTimer.Start();
        }

        public void StopAuoLoginTimer()
        {
            AutoLoginTimer.Stop();
        }

        public void StartAutoAcceptTimer()
        {
            AutoAcceptTimer.Start();
        }

        public void StopAutoAcceptTimer()
        {
            AutoAcceptTimer.Stop();
        }

        public void StartAutoChampSelectTimer()
        {
            AutoChampSelectTimer.Start();
        }

        public void StopAutoChampSelectTimer()
        {
            AutoChampSelectTimer.Stop();
        }

        public void StartAutoChatSpamTimer()
        {
            AutoChatSpamTimer.Start();
        }

        public void StopAutoChatSpamTimer()
        {
            AutoChatSpamTimer.Stop();
        }

        public void StartAutoRunesSelectTimer()
        {
            AutoRuneSelectTimer.Start();
        }

        public void StopAutoRunesSelectTimer()
        {
            AutoRuneSelectTimer.Stop();
        }
        #endregion

        #region "Timers"
        private void TakeScreenshotTimer_Tick(object sender, EventArgs e)
        {
            TakeActiveWindowScreenshot();
        }

        private void AutoAcceptTimer_Tick(object sender, EventArgs e)
        {
            AutoAcceptImageRecognition();
        }

        private void AutoLoginTimer_Tick(object sender, EventArgs e)
        {
            if (!CheckUsernamePasswordTextboxIsValid())
            {
                MessageBox.Show(@"Please make sure you've added your Username and Password.\r\nPlease check the Auto Login tab.", "Unable To Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LiveStatusLabel.Text = "Please double check the Username and Password.";
                AutoLoginTimer.Stop();
                return;
            }

            AutoLoginImageRecognition();
        }

        private void AutoChampSelectTimer_Tick(object sender, EventArgs e)
        {

        }

        private void AutoChatSpamTimer_Tick(object sender, EventArgs e)
        {

        }

        private void AutoRuneSelectTimer_Tick(object sender, EventArgs e)
        {

        }
        #endregion

        private void TakeFullDesktopScreenShot()
        {
            ScreenCapture screenCapsture = new ScreenCapture();
            Image image = screenCapsture.CaptureScreen();
            image.Save(HelpFile.GetScreenShotDirectory());

            MatchFoundPicturebox.Image = image;
        }

        private void TakeActiveWindowScreenshot()
        {
            Bitmap image = ScreenCapture.CaptureActiveWindow();
            image.Save(HelpFile.GetScreenShotDirectory(), ImageFormat.Png);

            MatchFoundPicturebox.Image = image;
        }

        private void AutoStartLeagueClient()
        {
            if (string.IsNullOrWhiteSpace(Options.LeagueEXELocation))
            {
                MessageBox.Show("League path directory is not selected! Please select league.exe", "Error 404: League.exe not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LiveStatusLabel.Text = "Error 404: League.exe not found. Please choose league.exe directory.";
                return;
            }

            Process.Start(Options.LeagueEXELocation);
        }

        private void AutoAcceptImageRecognition()
        {
            string screenShotPath = HelpFile.GetScreenShotDirectory();
            Bitmap leagueAcceptButton = Resources.LeagueAcceptButton;

            Image<Bgr, byte> source = new Image<Bgr, byte>(screenShotPath);
            Image<Bgr, byte> template = new Image<Bgr, byte>(leagueAcceptButton);
            Image<Bgr, byte> imageToShow = source.Copy();

            using (Image<Gray, float> result = source.MatchTemplate(template, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                if (maxValues[0] > 0.9)
                {
                    Rectangle match = new Rectangle(maxLocations[0], template.Size);
                    imageToShow.Draw(match, new Bgr(Color.Red), 3);

                    int x = match.X + (match.Width / 2);
                    int y = match.Y + (match.Height / 2);

                    MouseToAndClickAcceptButton(x, y);

                    AutoAcceptTimer.Stop();
                }
            }
        }

        private void MouseToAndClickAcceptButton(int x, int y)
        {
            MouseEvent.MoveCursorTo(x, y);
            MouseEvent.LeftClick();
        }

        private void SaveLoginDetailsButton_Click(object sender, EventArgs e)
        {
            if (RememberLoginDetailsToggle.Checked)
            {
                if (EncryptPasswordToggle.Checked)
                {
                    Settings.Default.EncryptedPassword = Encryption.Encrypt(PasswordTextbox.Text);
                    Settings.Default.EncryptedKey = Encryption.GetRijndaelKey();
                    Settings.Default.EncryptedIV = Encryption.GetRijndaelIV();
                }
                else
                {
                    Settings.Default.NotEncryptedPassword = PasswordTextbox.Text;
                }
                Settings.Default.RememberMeTicked = RememberMeIsTickedToggle.Checked;
            }
            Settings.Default.Save();
        }

        private bool CheckUsernamePasswordTextboxIsValid()
        {
            return !string.IsNullOrWhiteSpace(UsernameTextbox.Text) && !string.IsNullOrWhiteSpace(PasswordTextbox.Text);
        }

        private void AutoLoginImageRecognition()
        {
            if (RememberMeIsTickedToggle.Checked)
            {
                LoginPasswordImageRecognition(RememberMeIsTickedToggle.Checked);
            }
            else
            {
                LoginUsernameImageRecognition();
                LoginPasswordImageRecognition(RememberMeIsTickedToggle.Checked);
            }

            LoginSignInImageRecognition();
            LoginFailed();
        }

        private void LoginUsernameImageRecognition()
        {
            string screenShotPath = HelpFile.GetScreenShotDirectory();
            Bitmap leagueUsername = Resources.LeagueUsernameFocused;

            Image<Bgr, byte> source = new Image<Bgr, byte>(screenShotPath);
            Image<Bgr, byte> template = new Image<Bgr, byte>(leagueUsername);
            Image<Bgr, byte> imageToShow = source.Copy();

            using (Image<Gray, float> result = source.MatchTemplate(template, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                if (maxValues[0] > 0.9)
                {
                    Rectangle match = new Rectangle(maxLocations[0], template.Size);
                    imageToShow.Draw(match, new Bgr(Color.Red), 3);

                    int x = match.X + (match.Width / 2);
                    int y = match.Y + (match.Height / 2);

                    MouseEvent.MoveCursorTo(x, y);
                    MouseEvent.LeftClick();

                    KeyboardEvents.SetClipboardText(UsernameTextbox.Text);
                    KeyboardEvents.PasteFromClipboard();

                    MatchFoundPicturebox.Image = imageToShow.Bitmap;
                }
            }
        }

        private void LoginPasswordImageRecognition(bool rememberMeChecked)
        {
            string screenShotPath = HelpFile.GetScreenShotDirectory();
            Bitmap leaguePassword;

            if (rememberMeChecked)
            {
                leaguePassword = Resources.LeaguePasswordFocused;
            }
            else
            {
                leaguePassword = Resources.LeaguePassword;
            }

            Image<Bgr, byte> source = new Image<Bgr, byte>(screenShotPath);
            Image<Bgr, byte> template = new Image<Bgr, byte>(leaguePassword);
            Image<Bgr, byte> imageToShow = source.Copy();

            using (Image<Gray, float> result = source.MatchTemplate(template, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                if (maxValues[0] > 0.9)
                {
                    Rectangle match = new Rectangle(maxLocations[0], template.Size);
                    imageToShow.Draw(match, new Bgr(Color.Red), 3);

                    int x = match.X + (match.Width / 2);
                    int y = match.Y + (match.Height / 2);

                    MouseEvent.MoveCursorTo(x, y);
                    MouseEvent.LeftClick();

                    KeyboardEvents.SetClipboardText(PasswordTextbox.Text);
                    KeyboardEvents.PasteFromClipboard();

                    MatchFoundPicturebox.Image = imageToShow.Bitmap;
                }
            }
        }

        private void LoginSignInImageRecognition()
        {
            string screenShotPath = HelpFile.GetScreenShotDirectory();
            Bitmap leagueSignIn = Resources.LeagueSignInButton;

            Image<Bgr, byte> source = new Image<Bgr, byte>(screenShotPath);
            Image<Bgr, byte> template = new Image<Bgr, byte>(leagueSignIn);
            Image<Bgr, byte> imageToShow = source.Copy();

            using (Image<Gray, float> result = source.MatchTemplate(template, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                if (maxValues[0] > 0.9)
                {
                    Rectangle match = new Rectangle(maxLocations[0], template.Size);
                    imageToShow.Draw(match, new Bgr(Color.Red), 3);

                    int x = match.X + (match.Width / 2);
                    int y = match.Y + (match.Height / 2);

                    MouseEvent.MoveCursorTo(x, y);
                    MouseEvent.LeftClick();

                    MatchFoundPicturebox.Image = imageToShow.Bitmap;
                }
            }
        }

        private void LoginFailed()
        {
            string screenShotPath = HelpFile.GetScreenShotDirectory();
            Bitmap leagueSignIn = Resources.LeagueLoginFailed;

            Image<Bgr, byte> source = new Image<Bgr, byte>(screenShotPath);
            Image<Bgr, byte> template = new Image<Bgr, byte>(leagueSignIn);
            Image<Bgr, byte> imageToShow = source.Copy();

            using (Image<Gray, float> result = source.MatchTemplate(template, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                if (maxValues[0] > 0.9)
                {
                    AutoLoginTimer.Stop();

                    MatchFoundPicturebox.Image = imageToShow.Bitmap;
                }
            }
        }

        private void LocateLeagueButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "LeagueClient.exe (*.exe*)|*LeagueClient.exe*";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;

                LeagueLocationTextbox.Text = fileName;
                Options.LeagueEXELocation = fileName;
            }
        }
        
    }
}
