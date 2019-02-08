using League_All_in_One.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace League_All_in_One
{
    static class HelpFile
    {
        private static readonly string _appDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static readonly string _folderName = "LeagueAIO";
        private static readonly string _logFileName = "League_AIO_Logs.txt";
        private static readonly string logPath = GetLeagueFolderDirectory() + _logFileName;
        private static StringBuilder stringBuilder = new StringBuilder();

        public static void StartAppLog()
        {
            DateTime date = DateTime.Now.Date;
            stringBuilder.Append("###### - App Started On: " + date + " - ######").AppendLine().AppendLine();
        }

        public static void EndAppLog()
        {
            DateTime date = DateTime.Now.Date;
            stringBuilder.Append("####################End-Of-Application####################").AppendLine().AppendLine().AppendLine();
        }

        public static void WriteLogToText()
        {
            using (StreamWriter streamWriter = File.AppendText(logPath))
            {
                streamWriter.Write(stringBuilder);
            }
        }

        public static void Log(string message)
        {
            DateTime now = DateTime.Now;
            stringBuilder.Append("DateTime: " + now).AppendLine();
            stringBuilder.Append("Log: " + message).AppendLine().AppendLine();
        }

        public static void CheckIfFirstTime()
        {
            Options.IsFirstTime = Settings.Default.IsFirstTime;
            if (!Options.IsFirstTime) Options.IsFirstTime = true;
        }

        public static bool IsTextNumeric(string input)
        {
            return Regex.IsMatch(input, @"^\d+$");
        }

        public static void CreateLeagueFolder()
        {
            Directory.CreateDirectory(GetLeagueFolderDirectory());
        }

        public static string GetLeagueFolderDirectory()
        {
            return _appDataDirectory + "\\" + _folderName + "\\";
        }

        public static int[] GetXYCoordinatesRegex(string longCoordinates)
        {
            string[] seperatingChars = { "X:", "Y:" };
            string[] coordinates = longCoordinates.Split(seperatingChars, StringSplitOptions.RemoveEmptyEntries);
            int[] intCoordinates = { int.Parse(coordinates[0]), int.Parse(coordinates[1]) };
            return intCoordinates;
        }

        //Few Testing Functions Below:
        //Reason for this is to automatically read all files in HDD and find League.exe file's directory.

        private static void SingleDriveTest()
        {
            string rootDirectory = DriveInfo.GetDrives()[1].RootDirectory.FullName;
            string[] files = { };

            try
            {
                files = Directory.GetFiles(rootDirectory, "LeagueClient.exe", SearchOption.AllDirectories);
            }
            catch (Exception ex)
            {
            }

            foreach (var league in files)
            {
                Console.WriteLine(league);
            }
        }

        private static void MultipleDrivesTest()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            string[] files = { };

            foreach (var drive in drives)
            {
                try
                {
                    files = Directory.GetFiles(drive.ToString(), "LeagueClient.exe", SearchOption.AllDirectories);
                }
                catch { }
            }

            foreach (var league in files)
            {
                Console.WriteLine(league);
            }
        }

        private static void TestingDirectorySearchDepthFirst()
        {
            string rootDirectory = DriveInfo.GetDrives()[1].RootDirectory.FullName;
            DriveInfo[] drives = DriveInfo.GetDrives();

            IEnumerable<string> found = Enumerable.Empty<string>();

            //foreach (DriveInfo drive in drives)
            //{
            //    found = GetFiles(drive.ToString(), "LeagueClient.exe");
            //}

            found = GetFiles(rootDirectory.ToString(), "LeagueClient.exe");

            foreach (var item in found)
            {
                Console.WriteLine(item);
            }
        }

        public static IEnumerable<string> GetFiles(string root, string searchPattern)
        {
            Stack<string> pending = new Stack<string>();
            pending.Push(root);
            while (pending.Count != 0)
            {
                var path = pending.Pop();
                string[] next = null;
                try
                {
                    next = Directory.GetFiles(path, searchPattern);
                }
                catch { }
                if (next != null && next.Length != 0)
                    foreach (var file in next) yield return file;
                try
                {
                    next = Directory.GetDirectories(path);
                    foreach (var subdir in next) pending.Push(subdir);
                }
                catch { }
            }
        }
    }
}
