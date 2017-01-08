using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using M15_PA01_N02.Classes;

namespace M15_PA01_N02.Forms
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
            lblName.Text = Utils.Instance.User.GetName();
            imgProfile.Image = File.Exists("../../images/Funcionarios/" + Utils.Instance.User.GetPhoto() + ".png") ? Image.FromFile("../../images/Funcionarios/" + Utils.Instance.User.GetPhoto() + ".png") : Image.FromFile("../../images/default.png");
            string day;
            switch (DateTime.Now.DayOfWeek.ToString())
            {
                case "Monday":
                    day = "Segunda-Feira";
                    break;
                case "Tuesday":
                    day = "Terça-Feira";
                    break;
                case "Wednesday":
                    day = "Quarta-Feira";
                    break;
                case "Thursday":
                    day = "Quinta-Feira";
                    break;
                case "Friday":
                    day = "Sexta-Feira";
                    break;
                case "Saturday":
                    day = "Sábado";
                    break;
                default:
                    day = "Domingo";
                    break;
            }
            lblDiaSemana.Text = day + @"," + "\n" + DateTime.Now.ToString("d");

            lblMediaAssistencias.Text += @" " + Database.Instance.SqlQuery($"SELECT AVG(CAST(a AS FLOAT)) AS med FROM(SELECT COUNT(*) AS a FROM Assistencias INNER JOIN Clientes ON Assistencias.idCliente = Clientes.idCliente WHERE Assistencias.idFuncionario = {Utils.Instance.User.GetEmployeeId()} GROUP BY Assistencias.dataInicio) src").Rows[0][0];

            lblAssistenciasAcabadas.Text += @" " + Database.Instance.SqlQuery($"SELECT COUNT(*) FROM Assistencias WHERE concluida = 1 AND idFuncionario = {Utils.Instance.User.GetEmployeeId()}").Rows[0][0];

            lblAssistenciasInacabadas.Text += @" " + Database.Instance.SqlQuery($"SELECT COUNT(*) FROM Assistencias WHERE concluida = 0 AND idFuncionario = {Utils.Instance.User.GetEmployeeId()}").Rows[0][0];

            lblTotalAssistenciasUltimos7Dias.Text += @" " + Database.Instance.SqlQuery($"SELECT COUNT(*) FROM Assistencias WHERE DATEDIFF(day, dataInicio, getDate()) < 7 AND idFuncionario = {Utils.Instance.User.GetEmployeeId()} ").Rows[0][0];

            lblTotalAssistencias.Text += @" " + Database.Instance.SqlQuery($"SELECT COUNT(*) FROM Assistencias WHERE idFuncionario = {Utils.Instance.User.GetEmployeeId()}").Rows[0][0];

            lblClienteMaisAssistido.Text += @" " + Database.Instance.SqlQuery($"SELECT nome FROM Clientes WHERE idCliente = (SELECT TOP 1 idCliente FROM Assistencias WHERE idFuncionario = {Utils.Instance.User.GetEmployeeId()} GROUP BY idCliente ORDER BY COUNT(idCliente) DESC)").Rows[0][0];
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAbout().Show();
        }

        private void addAssistanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAddAssistance().Show();
        }

        private void listAssistancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmListAssists().Show();
        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAddClient().Show();
        }

        private void listClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmListCustomers().Show();
        }

        private void addMachineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAddMachine().Show();
        }

        private void listMachinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmListMachines().Show();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAddEmployee().Show();
        }

        private void listEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmListEmployees().Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Utils.Instance.User = new Employee(0, null, null, null, new DateTime(), null, null, null, null, new DateTime(), null, new DateTime(), false);
            Hide();
            var frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void terminarAssistênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAssistenciasInacabadas.CurrentRow == null) return;
            Database.Instance.ConcludeAssistance(dgvAssistenciasInacabadas.CurrentRow.Cells[0].Value.ToString(), "true");
            UpdateList();
        }

        private void UpdateList()
        {
            dgvAssistenciasInacabadas.DataSource = Database.Instance.SqlQuery("SELECT Assistencias.idAssistencia AS \'Código da Assistencia\', Clientes.nome AS \'Cliente\', Maquinas.descricao AS \'Máquina\', horaInicio AS \'Hora\', Assistencias.observacoes AS \'Observações\' FROM Assistencias INNER JOIN Clientes ON Clientes.idCliente = Assistencias.idCliente INNER JOIN Maquinas ON Maquinas.idMaquina = Assistencias.idMaquina WHERE Assistencias.concluida = 0");
        }

        private void dgvAssistenciasInacabadas_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1 || e.Button != MouseButtons.Right) return;
            var dataGridView = sender as DataGridView;
            if (dataGridView == null) return;
            var c = dataGridView[e.ColumnIndex, e.RowIndex];
            if (c.Selected) return;
            c.DataGridView.ClearSelection();
            c.DataGridView.CurrentCell = c;
            c.Selected = true;
            dgvAssistenciasInacabadas.CurrentCell.ContextMenuStrip = contextMenuStrip1;
        }

        private void FrmDashboard_Activated(object sender, EventArgs e)
        {
            dgvAssistenciasHoje.DataSource = Database.Instance.SqlQuery($"SELECT Clientes.nome AS \'Cliente\', Maquinas.descricao AS \'Máquina\', horaInicio AS \'Hora\', Assistencias.observacoes AS \'Observações\' FROM Assistencias INNER JOIN Clientes ON Clientes.idCliente = Assistencias.idCliente INNER JOIN Maquinas ON Maquinas.idMaquina = Assistencias.idMaquina WHERE Assistencias.idFuncionario={Utils.Instance.User.GetEmployeeId()} AND Assistencias.dataInicio LIKE '%" + DateTime.Now.ToString("yyyy-MM-dd") + "'");

            UpdateList();
        }
    }
}
