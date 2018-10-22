using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace League_All_in_One
{
    public partial class SettinsForm : MaterialForm
    {
        private LeagueAIO mainForm;

        public SettinsForm(LeagueAIO mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber500, Primary.Amber800, Primary.Amber300, Accent.LightBlue400, TextShade.WHITE);
        }

        private void SettinsForm_Load(object sender, EventArgs e)
        {

        }

        private void AutoStartLeagueAppStartToggle_CheckedChanged(object sender)
        {
            Options.AutoStartLeague = AutoStartLeagueAppStartToggle.Checked;
            if (AutoStartLeagueAppStartToggle.Checked)
            {
                mainForm.GetLiveStatusLabel.Text = "League auto start enabled.";
            }
            else
            {
                mainForm.GetLiveStatusLabel.Text = "League auto start disabled.";
            }
        }

        private void AutoLoginToggle_CheckedChanged(object sender)
        {
            Options.AutoLoginStatus = AutoLoginToggle.Checked;
            if (AutoLoginToggle.Checked)
            {
                mainForm.StartAutoLoginTimer();
                mainForm.GetLiveStatusLabel.Text = "Auto login enabled.";
            }
            else
            {
                mainForm.StopAuoLoginTimer();
                mainForm.GetLiveStatusLabel.Text = "Auto login disabled.";
            }
        }

        private void AutoAcceptToggle_CheckedChanged(object sender)
        {
            Options.AutoAcceptStatus = AutoAcceptToggle.Checked;
            if (AutoAcceptToggle.Checked)
            {
                mainForm.GetLiveStatusLabel.Text = "Auto accept enabled.";
            }
            else
            {
                mainForm.GetLiveStatusLabel.Text = "Auto accept disabled.";

            }
        }

        private void AutoChampSelectToggle_CheckedChanged(object sender)
        {
            Options.AutoChampSelectStatus = AutoChampSelectToggle.Checked;
            if (AutoChampSelectToggle.Checked)
            {
                mainForm.GetLiveStatusLabel.Text = "Auto champion select enabled.";
            }
            else
            {
                mainForm.GetLiveStatusLabel.Text = "Auto champion select disabled.";
            }
        }

        private void AutoChatSpamToggle_CheckedChanged(object sender)
        {
            Options.AutoChatSpamStatus = AutoChatSpamToggle.Checked;
            if (AutoChatSpamToggle.Checked)
            {
                mainForm.GetLiveStatusLabel.Text = "Auto chat spamming enabled.";
            }
            else
            {
                mainForm.GetLiveStatusLabel.Text = "Auto chat spamming enabled.";
            }
        }

        private void AutoRunesSelectToggle_CheckedChanged(object sender)
        {
            Options.AutoRuneSelectStatus = AutoRunesSelectToggle.Checked;
            if (AutoRunesSelectToggle.Checked)
            {
                mainForm.GetLiveStatusLabel.Text = "Auto runes select enabled.";
            }
            else
            {
                mainForm.GetLiveStatusLabel.Text = "Auto runes select disabled.";
            }
        }
    }
}
