using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace M15_TP01_N02
{
    public partial class FrmAddEmployee : Form
    {
        private readonly uint _newId;
        private string _fileName;
        public FrmAddEmployee()
        {
            InitializeComponent();
            _newId = Convert.ToUInt32(Database.Instance.SqlQuery("SELECT TOP 1 idFuncionario FROM Funcionarios ORDER BY idFuncionario DESC").Rows[0][0]) + 1;
            MessageBox.Show(_newId.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var changeImg = new OpenFileDialog
            {
                Title = "Editar > Foto de Perfil",
                Filter = "Apenas Imagens. |*jpg; *jpeg; *.png"
            };
            var dr = changeImg.ShowDialog();
            if (dr == DialogResult.Cancel) return;
            imgProfilePhoto.Image = Image.FromFile(changeImg.FileName);
            _fileName = changeImg.FileName;
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
            try
            {
                File.Copy(_fileName, "../../images/Funcionarios/" + _newId + ".png");
                Database.Instance.InsertEmloyee(txtName.Text, txtUsername.Text, txtPassword.Text, txtBirthday.Text,
                    $"images/Funcionarios/{_newId}", txtNCC.Text, txtPhone.Text, txtMail.Text, txtObservations.Text);
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
            Hide();
        }
    }
}
