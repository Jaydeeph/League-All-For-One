using Emgu.CV;
using Emgu.CV.Structure;
using League_All_in_One.Properties;
using MaterialSkin;
using MaterialSkin.Controls;

using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace League_All_in_One
{
    public partial class LeagueAIO : MaterialForm
    {
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
            
        }

        private void TakeScreenshotTimer_Tick(object sender, EventArgs e)
        {
            TakeActiveWindowScreenshot();
        }

        private void TakeFullDesktopScreenShot()
        {
            ScreenCapture screenCapsture = new ScreenCapture();
            Image image = screenCapsture.CaptureScreen();
            image.Save(HelpFile.GetScreenShotDirectory());

            pictureBox1.Image = image;
        }

        private void TakeActiveWindowScreenshot()
        {
            Bitmap image = ScreenCapture.CaptureActiveWindow();
            image.Save(HelpFile.GetScreenShotDirectory(), ImageFormat.Png);

            pictureBox1.Image = image;
        }

        #region "Auto Accept"

        private void AutoAcceptTimer_Tick(object sender, EventArgs e)
        {
            AutoAcceptImageRecognition();
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
                    //imageToShow.Draw(match, new Bgr(Color.Red), 3);

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

        #endregion


        private void SaveLoginDetailsButton_Click(object sender, EventArgs e)
        {
            if (RememberLoginDetailsToggle.Checked)
            {
                if (EncryptPasswordToggle.Checked)
                {
                    Settings.Default.encryptedPassword = Encryption.Encrypt(PasswordTextbox.Text);
                    Settings.Default.encryptedKey = Encryption.GetRijndaelKey();
                    Settings.Default.encryptedIV = Encryption.GetRijndaelIV();
                }
                else
                {
                    Settings.Default.notEncryptedPassword = PasswordTextbox.Text;
                }
            }
            Settings.Default.Save();
        }

        private void AutoLoginTimer_Tick(object sender, EventArgs e)
        {
            //Check if login details have been save or not.
            AutoLoginImageRecognition();
        }

        private void AutoLoginImageRecognition()
        {
            if (RememberMeIsTickedToggle.Checked)
            {
                LoginPasswordImageRecognition(RememberMeIsTickedToggle.Checked);
                LoginSignInImageRecognition();
            }
            else
            {
                LoginUsernameImageRecognition();
                LoginPasswordImageRecognition(RememberMeIsTickedToggle.Checked);
                LoginSignInImageRecognition();
            }
        }

        private void LoginUsernameImageRecognition()
        {
            string screenShotPath = HelpFile.GetScreenShotDirectory();
            string leagueUsername = "C:\\Users\\Jay\\Pictures\\Screenshots\\LeagueUsernameFocused.png";

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

                    pictureBox2.Image = imageToShow.Bitmap;
                }
            }
        }

        private void LoginPasswordImageRecognition(bool rememberMeChecked)
        {
            string screenShotPath = HelpFile.GetScreenShotDirectory();
            string leaguePassword = "";

            if (rememberMeChecked)
            {
                leaguePassword = "C:\\Users\\Jay\\Pictures\\Screenshots\\LeaguePasswordFocused.png";
            }
            else
            {
                leaguePassword = "C:\\Users\\Jay\\Pictures\\Screenshots\\LeaguePassword.png";
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

                    pictureBox2.Image = imageToShow.Bitmap;
                }
            }
        }

        private void LoginSignInImageRecognition()
        {
            string screenShotPath = HelpFile.GetScreenShotDirectory();
            string leagueSignIn = "C:\\Users\\Jay\\Pictures\\Screenshots\\LeagueSignInButton.png";

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

                    pictureBox2.Image = imageToShow.Bitmap;
                }
            }
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            TakeScreenshotTimer.Start();
            AutoLoginTimer.Start();
        }

        
    }
}
