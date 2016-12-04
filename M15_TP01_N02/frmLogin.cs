using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M15_TP01_N02
{
    public partial class frmLogin : Form
    {
        private string _username, _password;
        public frmLogin()
        {
            InitializeComponent();
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
                MessageBox.Show(@"Please, fill username and password", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            else
            {
                if (Database.Instance.Login(_username, _password))
                {
                    Hide();
                    var frmDashboard = new frmDashboard();
                    frmDashboard.Show();
                }
                else
                    MessageBox.Show(@"Incorrect username or password", @"Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
    }
}
