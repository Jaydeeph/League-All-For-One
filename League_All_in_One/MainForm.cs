using Emgu.CV;
using Emgu.CV.Structure;
using League_All_in_One.Properties;
using MaterialSkin;
using MaterialSkin.Controls;

using System;
using System.Drawing;

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

        #region "Auto Accept"
        private void ScreenshotTimer_Tick(object sender, EventArgs e)
        {
            TakeScreenShot();
            ImageRecognition();
        }

        private void TakeScreenShot()
        {
            ScreenCapture screenCapsture = new ScreenCapture();
            Image image = screenCapsture.CaptureScreen();
            image.Save(HelpFile.GetScreenShotDirectory());
        }

        private void ImageRecognition()
        {
            string screenShotPath = HelpFile.GetScreenShotDirectory();
            Bitmap leagueAcceptButton = Resources.LeagueAccpetButton;

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
                    //Drawing rect is only for testing purposes. Remember to remove it later please!
                    Rectangle match = new Rectangle(maxLocations[0], template.Size);
                    imageToShow.Draw(match, new Bgr(Color.Red), 3);

                    int x = match.X + (match.Width / 2);
                    int y = match.Y + (match.Height / 2);

                    MouseEvent.MoveCursorTo(x, y);
                    MouseEvent.LeftClick();

                    ScreenshotTimer.Stop();
                }
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            ScreenshotTimer.Start();
        }
    }
}
