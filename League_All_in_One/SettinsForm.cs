using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace League_All_in_One
{
    public partial class SettinsForm : MaterialForm
    {
        public SettinsForm()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber500, Primary.Amber800, Primary.Amber300, Accent.LightBlue400, TextShade.WHITE);
        }

        private void SettinsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
