using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace M15_TP01_N02
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            label2.Text = Util.Instance.User.GetNome();
            imgProfile.Image = File.Exists("../../images/Funcionarios/" + Util.Instance.User.GetIdFuncionario() + ".png") ? Image.FromFile("../../images/Funcionarios/" + Util.Instance.User.GetIdFuncionario() + ".png") : Image.FromFile("../../images/default.png");
            dataGridView1.DataSource = Database.Instance.SqlQuery($@"SELECT * FROM Assistencias WHERE idFuncionario={Util.Instance.User.GetIdFuncionario()} AND dataInicio = getDate()");
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAbout = new FrmAbout();
            frmAbout.Show();
        }

        private void adicionarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAdd = new FrmAddEmployee();
            frmAdd.Show();
        }

        private void adicionarAssistênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAddAssistance = new FrmAddAssistance();
            frmAddAssistance.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Util.Instance.User = new Funcionario(0, null, null, null, new DateTime(), null, null, null, null, new DateTime(), null, new DateTime(), false);
            Hide();
            var frmLogin = new FrmLogin();
            frmLogin.Show();
        }
    }
}
