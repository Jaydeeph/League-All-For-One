using System;
using System.Windows.Forms;

namespace League_All_in_One
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            HelpFile.CreateLeagueFolder();
            HelpFile.CheckIfFirstTime();
            
            Application.Run(new LeagueAIO());
        }
    }
}
