using System;
using System.Windows.Forms;
using M15_PA01_N02.Classes;

namespace M15_PA01_N02.Forms
{
    public partial class FrmListMachines : Form
    {
        public FrmListMachines()
        {
            InitializeComponent();
            Utils.Instance.GetClientsList("active");
            cboContent.SelectedIndex = 0;
            cboCliente.Items.Add("Todos");
            foreach (var c in Utils.Instance.ClientsListActive)
                cboCliente.Items.Add(c);
            cboCliente.SelectedIndex = 0;
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCliente.SelectedIndex <= 0)
            {
                var sql =
                    "SELECT Maquinas.idMaquina AS \'ID\', Clientes.Nome AS \'Cliente\', Maquinas.descricao AS \'Máquina\', Maquinas.ip AS IP, Maquinas.loginAcesso AS \'Login\', Maquinas.passwordAcesso AS \'Password\', Maquinas.ativo AS \'Ativa\' FROM Maquinas INNER JOIN Clientes ON Clientes.idCliente = Maquinas.idCliente";
                if (cboContent.SelectedIndex == 0)
                    sql += " WHERE Maquinas.ativo = 1";
                else if (cboContent.SelectedIndex == 1)
                    sql += " WHERE Maquinas.ativo = 0";
                sql += " ORDER BY Clientes.Nome";
                dgvMachines.DataSource =
                    Database.Instance.SqlQuery(sql);
            }
            else
            {
                var sql =
                    "SELECT Maquinas.idMaquina AS \'ID\', descricao AS \'Máquina\', ip AS IP, loginAcesso AS \'Login\', passwordAcesso AS \'Password \' FROM Maquinas WHERE idCliente=" +
                    Utils.Instance.ClientsListActive[cboCliente.SelectedIndex - 1].GetClientId();
                if (cboContent.SelectedIndex == 0)
                    sql += " AND ativo = 1";
                else if (cboContent.SelectedIndex == 1)
                    sql += " AND ativo = 0";
                dgvMachines.DataSource =
                    Database.Instance.SqlQuery(sql);
            }
        }

        private void cboContent_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCliente_SelectedIndexChanged(this, new EventArgs());
            if (cboContent.SelectedIndex == 1)
                btnEliminar.Text = @"Recuperar";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvMachines.CurrentRow != null)
                Database.Instance.DeleteItem("Maquinas", Convert.ToUInt32(dgvMachines.CurrentRow.Cells[0].Value), btnEliminar.Text == @"Eliminar" ? "0" : "1");
            cboCliente_SelectedIndexChanged(this, new EventArgs());
        }

        private void dgvMachines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cboCliente.SelectedIndex >= 0)
            {
                if (dgvMachines.CurrentRow != null && !Convert.ToBoolean(dgvMachines.CurrentRow.Cells[6].Value))
                    btnEliminar.Text = @"Recuperar";
                else
                    btnEliminar.Text = @"Eliminar";
            }
            else
            {
                if (cboContent.SelectedIndex == 1)
                    btnEliminar.Text = @"Eliminar";
                else
                    btnEliminar.Text = @"Recuperar";
            }
        }

        private void lblMPC_Click(object sender, EventArgs e)
        {
            new FrmMachinesByCustomers().Show();
        }

        private void lblMPC_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvMachines.CurrentRow != null)
                new FrmAddMachine(Convert.ToUInt32(dgvMachines.CurrentRow.Cells[0].Value)).Show();
        }
    }
}
