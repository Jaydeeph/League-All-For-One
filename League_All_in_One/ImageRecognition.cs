using Emgu.CV;
using Emgu.CV.Structure;

using League_All_in_One.Properties;
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

namespace League_All_in_One
{
    static class ImageRecognition
    {
        public static Image desktopScreenshot;

        public static async Task<bool> CheckLeagueRiotLogoImageRecognition()
        {
            Image<Bgr, byte> source = new Image<Bgr, byte>(new Bitmap(desktopScreenshot));
            Image<Bgr, byte> template = new Image<Bgr, byte>(Resources.LeagueRiotLogo);

            using (Image<Gray, float> result = source.MatchTemplate(template, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                if (maxValues[0] > 0.9)
                {
                    HelpFile.Log("League Client Fully Loaded. Returning True.");
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static async Task<bool> LoginUsernameImageRecognition()
        {
            Image<Bgr, byte> source = new Image<Bgr, byte>(new Bitmap(desktopScreenshot));
            Image<Bgr, byte> template = new Image<Bgr, byte>(Resources.LeagueUsername);

            using (Image<Gray, float> result = source.MatchTemplate(template, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                if (maxValues[0] > 0.9)
                {
                    Rectangle match = new Rectangle(maxLocations[0], template.Size);

                    int X = match.X + (match.Width / 2);
                    int Y = match.Y + (match.Height / 2);

                    Options.LoginUsernameCoordinates = "X:" + X + "Y:" + Y;
                    HelpFile.Log("Login Username: Returning True.");
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static async Task<bool> LoginUsernameFocusedImageRecognition()
        {
            Image<Bgr, byte> source = new Image<Bgr, byte>(new Bitmap(desktopScreenshot));
            Image<Bgr, byte> template = new Image<Bgr, byte>(Resources.LeagueUsernameFocused);

            using (Image<Gray, float> result = source.MatchTemplate(template, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                if (maxValues[0] > 0.9)
                {
                    Rectangle match = new Rectangle(maxLocations[0], template.Size);

                    int X = match.X + (match.Width / 2);
                    int Y = match.Y + (match.Height / 2);

                    Options.LoginUsernameCoordinates = "X:" + X + "Y:" + Y;
                    HelpFile.Log("Login Username: Returning True.");
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static async Task<bool> LoginPasswordImageRecognition()
        {
            Image<Bgr, byte> source = new Image<Bgr, byte>(new Bitmap(desktopScreenshot));
            Image<Bgr, byte> template = new Image<Bgr, byte>(Resources.LeaguePassword);

            using (Image<Gray, float> result = source.MatchTemplate(template, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                if (maxValues[0] > 0.9)
                {
                    Rectangle match = new Rectangle(maxLocations[0], template.Size);

                    int X = match.X + (match.Width / 2);
                    int Y = match.Y + (match.Height / 2);

                    Options.LoginPasswordCoordinates = "X:" + X + "Y:" + Y;
                    HelpFile.Log("Login Password: Returning True.");
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static async Task<bool> LoginPasswordFocusedImageRecognition()
        {
            Image<Bgr, byte> source = new Image<Bgr, byte>(new Bitmap(desktopScreenshot));
            Image<Bgr, byte> template = new Image<Bgr, byte>(Resources.LeaguePasswordFocused);

            using (Image<Gray, float> result = source.MatchTemplate(template, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                if (maxValues[0] > 0.9)
                {
                    Rectangle match = new Rectangle(maxLocations[0], template.Size);

                    int X = match.X + (match.Width / 2);
                    int Y = match.Y + (match.Height / 2);

                    Options.LoginPasswordCoordinates = "X:" + X + "Y:" + Y;
                    HelpFile.Log("Login Password: Returning True.");
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static async Task<bool> LoginSignInImageRecognition()
        {
            Image<Bgr, byte> source = new Image<Bgr, byte>(new Bitmap(desktopScreenshot));
            Image<Bgr, byte> template = new Image<Bgr, byte>(Resources.LeagueSignInButton);

            using (Image<Gray, float> result = source.MatchTemplate(template, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                if (maxValues[0] > 0.9)
                {
                    Rectangle match = new Rectangle(maxLocations[0], template.Size);

                    int X = match.X + (match.Width / 2);
                    int Y = match.Y + (match.Height / 2);

                    Options.LoginButtonCoordinates = "X:" + X + "Y:" + Y;
                    HelpFile.Log("Sign In Button: Returning True.");

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static async Task<bool>RememberMeCheckedImageRecognition()
        {
            Image<Bgr, byte> source = new Image<Bgr, byte>(new Bitmap(desktopScreenshot));
            Image<Bgr, byte> template = new Image<Bgr, byte>(Resources.LeagueRememberMeTicked);

            using (Image<Gray, float> result = source.MatchTemplate(template, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                if (maxValues[0] > 0.99)
                {
                    HelpFile.Log("Remember Me: Checked. Returning True.");
                    return true;
                }
                else
                {
                    HelpFile.Log("Remember Me: Not Checked.");
                    return false;
                }
            }
        }

        public static async Task<bool> RememberMeNotCheckedImageRecognition()
        {
            Image<Bgr, byte> source = new Image<Bgr, byte>(new Bitmap(desktopScreenshot));
            Image<Bgr, byte> template = new Image<Bgr, byte>(Resources.LeagueRememberMeNotTicked);

            using (Image<Gray, float> result = source.MatchTemplate(template, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                if (maxValues[0] > 0.99)
                {
                    HelpFile.Log("Remember Me: Not Checked. Returning True.");
                    return true;
                }
                else
                {
                    HelpFile.Log("Remember Me: Checked.");
                    return false;
                }
            }
        }

        public static async Task<bool> LoginFailedImageRecognition()
        {
            Image<Bgr, byte> source = new Image<Bgr, byte>(new Bitmap(desktopScreenshot));
            Image<Bgr, byte> template = new Image<Bgr, byte>(Resources.LeagueLoginFailed);

            using (Image<Gray, float> result = source.MatchTemplate(template, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                if (maxValues[0] > 0.9)
                {
                    HelpFile.Log("Login Has Failed. Returning True.");
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
                
        public static async Task<bool> AutoClickPlayButtonImageRecognition()
        {
            Image<Bgr, byte> source = new Image<Bgr, byte>(new Bitmap(desktopScreenshot));
            Image<Bgr, byte> template = new Image<Bgr, byte>(Resources.LeaguePlayButton);

            using (Image<Gray, float> result = source.MatchTemplate(template, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                if (maxValues[0] > 0.9)
                {
                    Rectangle match = new Rectangle(maxLocations[0], template.Size);

                    int X = match.X + (match.Width / 2);
                    int Y = match.Y + (match.Height / 2);

                    Options.PlayButtonCoordinates = "X:" + X + "Y:" + Y;
                    HelpFile.Log("Click Play Button: Returning True.");

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static async Task<bool> AutoChooseSummerRiftModeImageRecognition()
        {
            Image<Bgr, byte> source = new Image<Bgr, byte>(new Bitmap(desktopScreenshot));
            Image<Bgr, byte> template = new Image<Bgr, byte>(Resources.LeagueSelectSummonersRift);

            using (Image<Gray, float> result = source.MatchTemplate(template, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                if (maxValues[0] > 0.9)
                {
                    Rectangle match = new Rectangle(maxLocations[0], template.Size);

                    int X = match.X + (match.Width / 2);
                    int Y = match.Y + (match.Height / 2);

                    Options.SummonersRiftCoordinates = "X:" + X + "Y:" + Y;
                    HelpFile.Log("Choose Summoner Rift: Returning True.");

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static async Task<bool> AutoChooseSummersBlindPickImageRecognition()
        {
            Image<Bgr, byte> source = new Image<Bgr, byte>(new Bitmap(desktopScreenshot));
            Image<Bgr, byte> template = new Image<Bgr, byte>(Resources.LeagueBlindPickText);

            using (Image<Gray, float> result = source.MatchTemplate(template, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                if (maxValues[0] > 0.8)
                {
                    Rectangle match = new Rectangle(maxLocations[0], template.Size);

                    int X = match.X + (match.Width / 2);
                    int Y = match.Y + (match.Height / 2);

                    Options.BlindPickCoordinates = "X:" + X + "Y:" + Y;
                    HelpFile.Log("Choose Blind Pick: Returning True.");

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static async Task<bool> AutoChooseSummersDraftPickImageRecognition()
        {
            Image<Bgr, byte> source = new Image<Bgr, byte>(new Bitmap(desktopScreenshot));
            Image<Bgr, byte> template = new Image<Bgr, byte>(Resources.LeagueDraftPickText);

            using (Image<Gray, float> result = source.MatchTemplate(template, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                if (maxValues[0] > 0.8)
                {
                    Rectangle match = new Rectangle(maxLocations[0], template.Size);

                    int X = match.X + (match.Width / 2);
                    int Y = match.Y + (match.Height / 2);

                    Options.DraftPickCoordinates = "X:" + X + "Y:" + Y;
                    HelpFile.Log("Choose Draft Pick: Returning True.");

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static async Task<bool> AutoChooseSummersRankedImageRecognition()
        {
            Image<Bgr, byte> source = new Image<Bgr, byte>(new Bitmap(desktopScreenshot));
            Image<Bgr, byte> template = new Image<Bgr, byte>(Resources.LeagueRankedText);

            using (Image<Gray, float> result = source.MatchTemplate(template, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                if (maxValues[0] > 0.8)
                {
                    Rectangle match = new Rectangle(maxLocations[0], template.Size);

                    int X = match.X + (match.Width / 2);
                    int Y = match.Y + (match.Height / 2);

                    Options.RankedSoloDuoCoordinates = "X:" + X + "Y:" + Y;
                    HelpFile.Log("Choose Ranked: Returning True.");

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static async Task<bool> AutoChooseARAMModeImageRecognition()
        {
            Image<Bgr, byte> source = new Image<Bgr, byte>(new Bitmap(desktopScreenshot));
            Image<Bgr, byte> template = new Image<Bgr, byte>(Resources.LeagueSelectARAM);

            using (Image<Gray, float> result = source.MatchTemplate(template, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                if (maxValues[0] > 0.9)
                {
                    Rectangle match = new Rectangle(maxLocations[0], template.Size);

                    int X = match.X + (match.Width / 2);
                    int Y = match.Y + (match.Height / 2);

                    Options.ARAMMatchCoordinates = "X:" + X + "Y:" + Y;
                    HelpFile.Log("Choose ARAM: Returning True.");

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static async Task<bool> AutoClickConfirmButtonImageRecognition()
        {
            Image<Bgr, byte> source = new Image<Bgr, byte>(new Bitmap(desktopScreenshot));
            Image<Bgr, byte> template = new Image<Bgr, byte>(Resources.LeagueConfirmButton);

            using (Image<Gray, float> result = source.MatchTemplate(template, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                if (maxValues[0] > 0.9)
                {
                    Rectangle match = new Rectangle(maxLocations[0], template.Size);

                    int X = match.X + (match.Width / 2);
                    int Y = match.Y + (match.Height / 2);

                    Options.ConfirmButtonCoordinates = "X:" + X + "Y:" + Y;
                    HelpFile.Log("Confirm Button: Returning True.");

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static async Task<bool> AutoAcceptImageRecognition()
        {
            Image<Bgr, byte> source = new Image<Bgr, byte>(new Bitmap(desktopScreenshot));
            Image<Bgr, byte> template = new Image<Bgr, byte>(Resources.LeagueAcceptButton);

            using (Image<Gray, float> result = source.MatchTemplate(template, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                if (maxValues[0] > 0.9)
                {
                    Rectangle match = new Rectangle(maxLocations[0], template.Size);

                    int X = match.X + (match.Width / 2);
                    int Y = match.Y + (match.Height / 2);

                    Options.AutoAcceptButtonCoordinates = "X:" + X + "Y:" + Y;
                    HelpFile.Log("Auto Accept: Returning True.");

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static async Task<bool> AutoFindBoostButtonImageRecognition()
        {
            Image<Bgr, byte> source = new Image<Bgr, byte>(new Bitmap(desktopScreenshot));
            Image<Bgr, byte> template = new Image<Bgr, byte>(Resources.LeagueBoostButton);

            using (Image<Gray, float> result = source.MatchTemplate(template, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                if (maxValues[0] > 0.9)
                {
                    Rectangle match = new Rectangle(maxLocations[0], template.Size);

                    int X = match.X + (match.Width / 2);
                    int Y = match.Y + (match.Height / 2);

                    Options.BoostButtonCoordinates = "X:" + X + "Y:" + Y;
                    HelpFile.Log("Auto Accept: Boost Button Found.");

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static async Task<bool> AutoFindRandomChampionBoxImageRecognition()
        {
            Image<Bgr, byte> source = new Image<Bgr, byte>(new Bitmap(desktopScreenshot));
            Image<Bgr, byte> template = new Image<Bgr, byte>(Resources.LeagueRandomChampionBox);

            using (Image<Gray, float> result = source.MatchTemplate(template, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                if (maxValues[0] > 0.9)
                {
                    Rectangle match = new Rectangle(maxLocations[0], template.Size);

                    int X = match.X + (match.Width / 2);
                    int Y = match.Y + (match.Height / 2);

                    Options.FirstChampionBoxCoordinates = "X" + X + ", Y: " + Y;
                    HelpFile.Log("First Random Champion Box: Returning True.");

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static async Task<bool> AutoFindChampionSearchTextboxImageRecognition()
        {
            Image<Bgr, byte> source = new Image<Bgr, byte>(new Bitmap(desktopScreenshot));
            Image<Bgr, byte> template = new Image<Bgr, byte>(Resources.LeagueSearchTextbox);

            using (Image<Gray, float> result = source.MatchTemplate(template, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                if (maxValues[0] > 0.8)
                {
                    Rectangle match = new Rectangle(maxLocations[0], template.Size);

                    int X = match.X + (match.Width / 2);
                    int Y = match.Y + (match.Height / 2);

                    Options.ChampionSearchTextboxCoordinates = "X" + X + ", Y: " + Y;
                    HelpFile.Log("Champion Search Textbox: Returning True.");

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static async Task<bool> AutoLockChampionImageRecognition()
        {
            Image<Bgr, byte> source = new Image<Bgr, byte>(new Bitmap(desktopScreenshot));
            Image<Bgr, byte> template = new Image<Bgr, byte>(Resources.LeagueLockButton);

            using (Image<Gray, float> result = source.MatchTemplate(template, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                if (maxValues[0] > 0.9)
                {
                    Rectangle match = new Rectangle(maxLocations[0], template.Size);

                    int X = match.X + (match.Width / 2);
                    int Y = match.Y + (match.Height / 2);

                    Options.LockButtonCoodinates = "X" + X + ", Y: " + Y;
                    HelpFile.Log("Lock Button: Returning True.");

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
