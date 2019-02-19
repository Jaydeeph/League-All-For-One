using League_All_in_One.Properties;

using MaterialSkin;

namespace League_All_in_One
{
    static class Options
    {
        public static bool IsFirstTime { get; set; }
        public static bool IsPasswordEncrypted { get; set; }

        public static bool AutoStartLeague { get; set; }
        public static bool AutoLogin { get; set; }
        public static bool AutoCreateLobby { get; set; }
        public static bool AutoAccept { get; set; }
        public static bool AutoChampSelect { get; set; }
        public static bool AutoLock { get; set; }
        public static bool AutoRuneSelect { get; set; }

        public static string SummonerName { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; } //only decrypt pass when user wants to view the password and copy pasting it. After pasting it clear clipboard.
        public static string EncryptedKey { get; set; }
        public static string EncryptedIV { get; set; }
        public static string LeagueExeDirectory { get; set; }
        public static string MatchType { get; set; }
        public static string SummonerType { get; set; }
        public static string ChampionName { get; set; }

        public static int ImageRecognitionInterval { get; set; }

        public static Primary PrimaryColor { get; set; }
        public static Primary PrimaryDarkColor { get; set; }
        public static Primary PrimaryLightColor { get; set; }
        public static Accent AccentColor { get; set; }

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
        public static string ConfirmButtonCoordinates { get; set; }
        public static string ChampionSearchTextboxCoordinates { get; set; }
        public static string FirstChampionBoxCoordinates { get; set; }
        public static string LockButtonCoodinates { get; set; }

        public static void LoadOptions()
        {
            SummonerName = Settings.Default.SummonerName;
            Username = Settings.Default.Username;
            Password = (Settings.Default.IsPasswordEncrypted == true) ? Settings.Default.EncryptedPassword : Settings.Default.NotEncryptedPassword;

            LeagueExeDirectory = Settings.Default.LeagueExeDirectory;
            MatchType = Settings.Default.MatchType;
            SummonerType = Settings.Default.SummonerType;
            ChampionName = Settings.Default.ChamptionName;

            AutoStartLeague = Settings.Default.AutoStartLeague;
            AutoLogin = Settings.Default.AutoLogin;
            AutoCreateLobby = Settings.Default.AutoCreateLobby;
            AutoAccept = Settings.Default.AutoAccept;
            AutoChampSelect = Settings.Default.AutoChampionSelect;
            AutoLock = Settings.Default.AutoLock;
            AutoRuneSelect = Settings.Default.AutoRunesSelect;

            IsPasswordEncrypted = Settings.Default.IsPasswordEncrypted;

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
            Settings.Default.SummonerName = SummonerName;
            Settings.Default.Username = Username;
            if (Settings.Default.IsPasswordEncrypted == true) Settings.Default.EncryptedPassword = Password; else Settings.Default.NotEncryptedPassword = Password;
            Settings.Default.LeagueExeDirectory = LeagueExeDirectory;
            Settings.Default.MatchType = MatchType;
            Settings.Default.SummonerType = SummonerType;
            Settings.Default.ChamptionName = ChampionName;

            Settings.Default.AutoStartLeague = AutoStartLeague;
            Settings.Default.AutoLogin = AutoLogin;
            Settings.Default.AutoCreateLobby = AutoCreateLobby;
            Settings.Default.AutoAccept = AutoAccept;
            Settings.Default.AutoChampionSelect = AutoChampSelect;
            Settings.Default.AutoLock = AutoLock;
            Settings.Default.AutoRunesSelect = AutoRuneSelect;

            Settings.Default.IsPasswordEncrypted = IsPasswordEncrypted;

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
    }
}
