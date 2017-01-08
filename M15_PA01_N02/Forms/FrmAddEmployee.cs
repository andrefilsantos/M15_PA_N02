using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using M15_PA01_N02.Classes;

namespace M15_PA01_N02.Forms
{
    public partial class FrmAddEmployee : Form
    {
        private string _fileName;
        private bool _edit, _changeImage;
        private Employee _employee;
        public FrmAddEmployee()
        {
            InitializeComponent();
            _edit = false;
        }
        public FrmAddEmployee(Employee employee)
        {
            InitializeComponent();
            Text = @"Now Assist > Editar Funcionário";
            _edit = true;
            _changeImage = false;
            _employee = employee;
            txtName.Text = _employee.GetName();
            txtUsername.Text = _employee.GetUsername();
            txtPassword.Text = _employee.GetPassword();
            txtBirthday.Text = _employee.GetBirthday().ToString("d");
            txtNCC.Text = _employee.GetNCc();
            txtPhone.Text = _employee.GetPhone();
            txtMail.Text = _employee.GetEmail();
            txtObservations.Text = _employee.GetComments();
            imgProfilePhoto.Image = Image.FromFile("../../" + _employee.GetPhoto() + ".png");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_edit)
                {
                    var id = Guid.NewGuid();
                    File.Copy(_fileName, "../../images/Funcionarios/" + id + ".png");
                    Database.Instance.InsertEmloyee(txtName.Text, Utils.Instance.Md5(txtUsername.Text), txtPassword.Text, txtBirthday.Text,
                        $"images/Funcionarios/{id}", txtNCC.Text, txtPhone.Text, txtMail.Text, txtObservations.Text);
                    MessageBox.Show(@"Funcionário adicionado com sucesso", @"Successo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Hide();
                    Utils.Instance.GetEmployeesList("active");
                }
                else
                {
                    var id = Guid.NewGuid();
                    if (_changeImage)
                    {
                        Database.Instance.UpdateEmloyee(_employee.GetEmployeeId(), txtName.Text, txtUsername.Text, Utils.Instance.Md5(txtPassword.Text), txtBirthday.Text, $"images/Funcionarios/{id}", txtNCC.Text, txtPhone.Text, txtMail.Text, txtObservations.Text);
                        File.Copy(_fileName, "../../images/Funcionarios/" + id + ".png");
                    }
                    else
                    {
                        Database.Instance.UpdateEmloyee(_employee.GetEmployeeId(), txtName.Text, txtUsername.Text, Utils.Instance.Md5(txtPassword.Text), txtBirthday.Text, _employee.GetPhoto(), txtNCC.Text, txtPhone.Text, txtMail.Text, txtObservations.Text);
                    }
                    MessageBox.Show(@"Funcionário editado com sucesso!", @"Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(@"Erro: \n" + f.Message, @"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChoosePhoto_Click(object sender, EventArgs e)
        {
            var changeImg = new OpenFileDialog
            {
                Title = @"Editar > Foto de Perfil",
                Filter = @"Apenas Imagens. |*jpg; *jpeg; *.png"
            };
            var dr = changeImg.ShowDialog();
            if (dr == DialogResult.Cancel) return;
            imgProfilePhoto.Image = Image.FromFile(changeImg.FileName);
            _fileName = changeImg.FileName;
            _changeImage = true;
        }

        private void txtUsername_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Dados para aceder à plataforma.", txtUsername);
        }
        private void txtPassword_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Dados para aceder à plataforma.", txtPassword);
        }
    }
}
