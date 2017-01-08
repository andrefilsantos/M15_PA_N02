using System;
using System.Windows.Forms;
using M15_PA01_N02.Classes;

namespace M15_PA01_N02.Forms
{
    public partial class FrmAddMachine : Form
    {
        private readonly bool _edit;
        private Machine _machine;
        public FrmAddMachine()
        {
            InitializeComponent();
            _edit = false;
            Utils.Instance.GetClientsList("active");
            foreach (var t in Utils.Instance.ClientsListActive)
                cboClient.Items.Add(t.ToString());
            cboClient.SelectedIndex = 0;
        }

        public FrmAddMachine(uint id)
        {
            InitializeComponent();
            _edit = true;
            var data = Database.Instance.SqlQuery("SELECT * FROM Maquinas WHERE idMaquina=" + id);
            _machine = new Machine(Convert.ToUInt32(data.Rows[0][0]), Convert.ToUInt32(data.Rows[0][1]), data.Rows[0][2].ToString(), data.Rows[0][3].ToString(), data.Rows[0][4].ToString(), data.Rows[0][5].ToString(), DateTime.Parse(data.Rows[0][6].ToString()), DateTime.Parse(data.Rows[0][7].ToString()), Convert.ToBoolean(data.Rows[0][8]));
            Utils.Instance.GetClientsList("active");
            foreach (var t in Utils.Instance.ClientsListActive)
                cboClient.Items.Add(t.ToString());
            cboClient.SelectedItem = Database.Instance.SqlQuery("SELECT Nome FROM Clientes WHERE idCliente = " + _machine.GetClientId()).Rows[0][0];
            txtDescricao.Text = _machine.GetDescription();
            txtIp.Text = _machine.GetIp();
            txtLogin.Text = _machine.GetLogin();
            txtPassword.Text = _machine.GetPassword();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!_edit)
            {
                try
                {
                    if (txtDescricao.Text != string.Empty)
                    {
                        Database.Instance.InsertMachine(
                            Utils.Instance.ClientsListActive[cboClient.SelectedIndex].GetClientId().ToString(),
                            txtDescricao.Text, txtIp.Text, txtLogin.Text, txtPassword.Text);
                        MessageBox.Show(@"Máquina Adicionada com Sucesso", @"Successo", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Hide();
                    }
                    else
                        MessageBox.Show(@"Preencha todos os campos", @"Erro", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                }
                catch (Exception f)
                {
                    MessageBox.Show(@"Erro: " + f.Message, @"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    if (txtDescricao.Text != string.Empty)
                    {
                        Database.Instance.UpdateMachine(_machine.GetMachineId(),
                            Utils.Instance.ClientsListActive[cboClient.SelectedIndex].GetClientId().ToString(),
                            txtDescricao.Text, txtIp.Text, txtLogin.Text, txtPassword.Text);
                        MessageBox.Show(@"Máquina Editada com Sucesso", @"Successo", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Hide();
                    }
                    else
                        MessageBox.Show(@"Preencha todos os campos", @"Erro", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                }
                catch (Exception f)
                {
                    MessageBox.Show(@"Erro: " + f.Message, @"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
