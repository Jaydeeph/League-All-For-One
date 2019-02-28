using League_All_in_One.Properties;

using MaterialSkin;
using System;

namespace League_All_in_One
{
    static class Options
    {
        public static bool IsFirstTime { get; set; } //TODO: Check where its used.
        public static bool IsPasswordEncrypted { get; set; }
        
        public static bool ContiuouslyMonitorAcceptMatch { get; set; }

        public static string SummonerName { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string EncryptedKey { get; set; }
        public static string EncryptedIV { get; set; }
        public static string LeagueExeDirectory { get; set; }
        public static string MatchType { get; set; }
        public static string SummonerType { get; set; }
        public static string ChampionName { get; set; }

        public static int InteractionInterval { get; set; }

        public static readonly Primary DefaultPrimaryColour = Primary.Amber500;
        public static readonly Primary DefaultPrimaryDarkColour = Primary.Amber800;
        public static readonly Primary DefaultPrimaryLightColour = Primary.Amber300;
        public static readonly Accent DefaultAccentColour = Accent.LightBlue400;
        public static readonly TextShade DefaultTextShadeColour = TextShade.BLACK;

        public static Primary PrimaryColor { get; set; }
        public static Primary PrimaryDarkColor { get; set; }
        public static Primary PrimaryLightColor { get; set; }
        public static Accent AccentColor { get; set; }
        public static TextShade TextShadeColour { get; set; }

        public static string LoginUsernameCoordinates { get; set; }
        public static string LoginPasswordCoordinates { get; set; }
        public static string LoginButtonCoordinates { get; set; }
        public static string PlayButtonCoordinates { get; set; }
        public static string SummonersRiftCoordinates { get; set; }
        public static string ARAMMatchCoordinates { get; set; }
        public static string BlindPickCoordinates { get; set; }
        public static string DraftPickCoordinates { get; set; }
        public static string RankedSoloDuoCoordinates { get; set; }
        public static string AutoAcceptButtonCoordinates { get; set; }
        public static string BoostButtonCoordinates { get; set; }
        public static string ConfirmButtonCoordinates { get; set; }
        public static string ChampionSearchTextboxCoordinates { get; set; }
        public static string FirstChampionBoxCoordinates { get; set; }
        public static string LockButtonCoodinates { get; set; }

        public static void LoadOptions()
        {            
            PrimaryColor = Settings.Default.PrimaryColor;
            PrimaryDarkColor = Settings.Default.PrimaryDarkColor;
            PrimaryLightColor = Settings.Default.PrimaryLightColor;
            AccentColor = Settings.Default.AccentColor;
            TextShadeColour = Settings.Default.TextShadeColour;
                        
            Username = Settings.Default.Username;
            IsPasswordEncrypted = Settings.Default.IsPasswordEncrypted;
            //EncryptedKey = Settings.Default.EncryptedKey;
            //EncryptedIV = Settings.Default.EncryptedIV;
            Password = (Settings.Default.IsPasswordEncrypted == true) ? Settings.Default.EncryptedPassword : Settings.Default.NotEncryptedPassword;

            SummonerName = Settings.Default.SummonerName;
            LeagueExeDirectory = Settings.Default.LeagueExeDirectory;
            MatchType = Settings.Default.MatchType;
            SummonerType = Settings.Default.SummonerType;
            ChampionName = Settings.Default.ChamptionName;
            InteractionInterval = Settings.Default.InteractionInterval;
            ContiuouslyMonitorAcceptMatch = Settings.Default.ContiuouslyMonitorAcceptMatch;

            LoginUsernameCoordinates = Settings.Default.LoginUsernameCoordinates;
            LoginPasswordCoordinates = Settings.Default.LoginPasswordCoordinates;
            LoginButtonCoordinates = Settings.Default.LoginButtonCoordinates;
            PlayButtonCoordinates = Settings.Default.PlayButtonCoordinates;
            SummonersRiftCoordinates = Settings.Default.SummonersRiftCoordinates;
            ARAMMatchCoordinates = Settings.Default.ARAMCoordinates;
            BlindPickCoordinates = Settings.Default.BlindPickCoordinates;
            DraftPickCoordinates = Settings.Default.DraftPickCoordinates;
            RankedSoloDuoCoordinates = Settings.Default.RankedSoloDuoCoordinates;
            AutoAcceptButtonCoordinates = Settings.Default.AutoAcceptButtonCoordinates;
            ConfirmButtonCoordinates = Settings.Default.ConfirmButtonCoordinates;
            ChampionSearchTextboxCoordinates = Settings.Default.ChampionSearchTextboxCoordinates;
            FirstChampionBoxCoordinates = Settings.Default.FirstChampionSelectionCoordinates;
            LockButtonCoodinates = Settings.Default.LockButtonCoordinates;
        }

        public static void SaveOptions()
        {
            Settings.Default.PrimaryColor = PrimaryColor;
            Settings.Default.PrimaryDarkColor = PrimaryDarkColor;
            Settings.Default.PrimaryLightColor = PrimaryLightColor;
            Settings.Default.AccentColor = AccentColor;
            Settings.Default.TextShadeColour = TextShadeColour;
                        
            Settings.Default.Username = Username;
            Settings.Default.IsPasswordEncrypted = IsPasswordEncrypted;
            if (Settings.Default.IsPasswordEncrypted) Settings.Default.EncryptedPassword = Password; else Settings.Default.NotEncryptedPassword = Password;
            //if (Settings.Default.IsPasswordEncrypted) Settings.Default.EncryptedKey = Encryption.ConvertRijndaelKeyToBase64();
            //if (Settings.Default.IsPasswordEncrypted) Settings.Default.EncryptedIV = Encryption.ConvertRijndaelIVToBase64();

            Settings.Default.SummonerName = SummonerName;
            Settings.Default.LeagueExeDirectory = LeagueExeDirectory;
            Settings.Default.MatchType = MatchType;
            Settings.Default.SummonerType = SummonerType;
            Settings.Default.ChamptionName = ChampionName;
            Settings.Default.InteractionInterval = InteractionInterval;
            Settings.Default.ContiuouslyMonitorAcceptMatch = ContiuouslyMonitorAcceptMatch;

            Settings.Default.LoginUsernameCoordinates = LoginUsernameCoordinates;
            Settings.Default.LoginPasswordCoordinates = LoginPasswordCoordinates;
            Settings.Default.LoginButtonCoordinates = LoginButtonCoordinates;
            Settings.Default.PlayButtonCoordinates = PlayButtonCoordinates;
            Settings.Default.SummonersRiftCoordinates = SummonersRiftCoordinates;
            Settings.Default.ARAMCoordinates = ARAMMatchCoordinates;
            Settings.Default.BlindPickCoordinates = BlindPickCoordinates;
            Settings.Default.DraftPickCoordinates = DraftPickCoordinates;
            Settings.Default.RankedSoloDuoCoordinates = RankedSoloDuoCoordinates;
            Settings.Default.ConfirmButtonCoordinates = ConfirmButtonCoordinates;
            Settings.Default.AutoAcceptButtonCoordinates = AutoAcceptButtonCoordinates;
            Settings.Default.ChampionSearchTextboxCoordinates = ChampionSearchTextboxCoordinates;
            Settings.Default.FirstChampionSelectionCoordinates = FirstChampionBoxCoordinates;
            Settings.Default.LockButtonCoordinates = LockButtonCoodinates;

            Settings.Default.Save();
        }

        public static void ClearUserAndMatchDetails()
        {
            SummonerName = "";
            Username = "";
            IsPasswordEncrypted = false;
            EncryptedKey = "";
            EncryptedIV = "";
            Password = "";
            LeagueExeDirectory = "";
            MatchType = "";
            SummonerType = "";
            ChampionName = "";
            InteractionInterval = 0;
            ContiuouslyMonitorAcceptMatch = false;

            SaveOptions();
        }

        public static void ClearCoordinates()
        {
            LoginUsernameCoordinates = "";
            LoginPasswordCoordinates = "";
            LoginButtonCoordinates = "";
            PlayButtonCoordinates = "";
            SummonersRiftCoordinates = "";
            ARAMMatchCoordinates = "";
            BlindPickCoordinates = "";
            DraftPickCoordinates = "";
            RankedSoloDuoCoordinates = "";
            AutoAcceptButtonCoordinates = "";
            ConfirmButtonCoordinates = "";
            ChampionSearchTextboxCoordinates = "";
            FirstChampionBoxCoordinates = "";
            LockButtonCoodinates = "";

            SaveOptions();
        }

        public static void ClearEverything()
        {
            SummonerName = "";
            Username = "";
            IsPasswordEncrypted = false;
            EncryptedKey = "";
            EncryptedIV = "";
            Password = "";
            LeagueExeDirectory = "";
            MatchType = "";
            SummonerType = "";
            ChampionName = "";
            InteractionInterval = 0;
            ContiuouslyMonitorAcceptMatch = false;
            LoginUsernameCoordinates = "";
            LoginPasswordCoordinates = "";
            LoginButtonCoordinates = "";
            PlayButtonCoordinates = "";
            SummonersRiftCoordinates = "";
            ARAMMatchCoordinates = "";
            BlindPickCoordinates = "";
            DraftPickCoordinates = "";
            RankedSoloDuoCoordinates = "";
            AutoAcceptButtonCoordinates = "";
            ConfirmButtonCoordinates = "";
            ChampionSearchTextboxCoordinates = "";
            FirstChampionBoxCoordinates = "";
            LockButtonCoodinates = "";

            Settings.Default.Reset();
            Settings.Default.Save();
        }
    }
}
