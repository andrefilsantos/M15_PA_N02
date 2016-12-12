using System;
using System.Windows.Forms;

namespace M15_TP01_N02
{
    public partial class FrmLogin : Form
    {
        private string _username, _password;
        public FrmLogin()
        {
            InitializeComponent();
            txtUsername.Text = "admin";
            txtPassword.Text = "admin";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _username = txtUsername.Text;
            _password = txtPassword.Text;

            if (_username == string.Empty || _password == string.Empty)
                MessageBox.Show(@"Please, fill username and password", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            else
            {
                if (Database.Instance.Login(_username, _password))
                {
                    Hide();
                    var frmDashboard = new FrmDashboard();
                    frmDashboard.Show();
                }
                else
                    MessageBox.Show(@"Incorrect username or password", @"Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
    }
}
