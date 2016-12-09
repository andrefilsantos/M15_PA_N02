using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace M15_TP01_N02
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            label2.Text = Util.Instance.User.GetNome();
            imgProfile.Image = File.Exists("../../images/Funcionarios/" + Util.Instance.User.GetId() + ".png") ? Image.FromFile("../../images/Funcionarios/" + Util.Instance.User.GetId() + ".png") : Image.FromFile("../../images/default.png");
            dataGridView1.DataSource = Database.Instance.SqlQuery($@"SELECT * FROM Assistencias WHERE idFuncionario={Util.Instance.User.GetId()} AND dataInicio = getDate()");
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAbout = new frmAbout();
            frmAbout.Show();
        }

        private void adicionarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAdd = new frmAddEmployee();
            frmAdd.Show();
        }

        private void adicionarAssistênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAddAssistance = new frmAddAssistance();
            frmAddAssistance.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Util.Instance.User = new Funcionario(0, null, null, null, new DateTime(), null, null, null, null, null, new DateTime(), false);
            Hide();
            var frmLogin = new frmLogin();
            frmLogin.Show();
        }
    }
}
