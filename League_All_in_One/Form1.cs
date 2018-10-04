using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

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
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber500, Primary.Amber800, Primary.Amber300, Accent.Green700, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void CloseButtonPanel_Click(object sender, EventArgs e)
        {

        }

        private void MinimizeButtonPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
