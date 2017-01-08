using System;
using System.Windows.Forms;
using M15_PA01_N02.Classes;

namespace M15_PA01_N02.Forms
{
    public partial class FrmLogin : Form
    {
        private string _username, _password;
        public FrmLogin()
        {
            InitializeComponent();
            if (System.IO.File.Exists(@"M15_TP01_N02.mdf") == false)
                Database.CreateDataBase(@"M15_TP01_N02.mdf");
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(this, new EventArgs());
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(this, new EventArgs());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _username = txtUsername.Text;
            _password = txtPassword.Text;

            if (_username == string.Empty || _password == string.Empty)
                MessageBox.Show(@"Por favor, preencha o username e a password", @"Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                if (Database.Instance.Login(_username, Utils.Instance.Md5(_password)))
                {
                    Hide();
                    new FrmDashboard().Show();
                }
                else
                    MessageBox.Show(@"Username ou passoword incorretos", @"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
