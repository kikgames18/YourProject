using System;
using MaterialSkin;
using MaterialSkin.Controls;

namespace YourProject.Forms
{
    public partial class HelpForm : MaterialForm
    {
        public HelpForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue700, Primary.Blue200, Accent.LightBlue200, TextShade.WHITE);
        }

        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();  // Закрывает форму
        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
