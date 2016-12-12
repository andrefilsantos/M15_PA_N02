using System;
using System.Drawing;
using System.Windows.Forms;

namespace M15_TP01_N02
{
    public partial class FrmAddEmployee : Form
    {
        public FrmAddEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var changeImg = new OpenFileDialog
            {
                Title = "Editar > Foto de Perfil",
                Filter = "Apenas Imagens. |*jpg; *jpeg; *.png"
            };
            var dr = changeImg.ShowDialog();
            if (dr != DialogResult.Cancel)
            {
                imgProfilePhoto.Image = Image.FromFile(changeImg.FileName);
            }
        }

        private void txtUsername_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Dados para aceder à plataforma", txtUsername);
        }

        private void txtPassword_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Dados para aceder à plataforma", txtPassword);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
