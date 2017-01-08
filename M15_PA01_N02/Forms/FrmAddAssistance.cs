using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using M15_PA01_N02.Classes;

namespace M15_PA01_N02.Forms
{
    public partial class FrmAddAssistance : Form
    {
        private readonly List<Client> _clients;
        private List<Machine> _machines;
        private uint _selectedClient, _selectedMachine;

        private uint _idMaquina, _idClienteMaquina;

        private string _descricaoMaquina, _ipMaquina, _loginAcessoMaquina, _passwordAcessoMaquina;

        private DateTime _dataCriacaoMaquina, _ultimoUpdateMaquina;

        private bool _ativoMaquina;

        public FrmAddAssistance()
        {
            InitializeComponent();
            Utils.Instance.GetClientsList("active");
            _clients = Utils.Instance.ClientsListActive;
            foreach (var t in Utils.Instance.ClientsListActive)
                lstClients.Items.Add(t.ToString());
            lstClients.SelectedIndex = 0;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 1:
                    label1.Text = @"Selecionar Máquina:";
                    lstClients.Enabled = true;
                    label1.Enabled = true;
                    label1.Visible = true;
                    lstClients.Visible = true;
                    Size = new Size(736, 412);
                    tabControl1.Location = new Point(154, 28);
                    lstClients.Items.Clear();
                    var data = Database.Instance.SqlQuery($@"SELECT * FROM Maquinas WHERE idCliente = {_selectedClient} AND ativo = 1");
                    _machines = new List<Machine>();
                    for (var i = 0; i < data.Rows.Count; i++)
                    {
                        try { _idMaquina = Convert.ToUInt32(data.Rows[i][0]); } catch (Exception) { _idMaquina = 0; }
                        try { _idClienteMaquina = Convert.ToUInt32(data.Rows[i][1]); } catch (Exception) { _idClienteMaquina = 0; }
                        try { _descricaoMaquina = (string)data.Rows[i][2]; } catch (Exception) { _descricaoMaquina = ""; }
                        try { _ipMaquina = (string)data.Rows[i][3]; } catch (Exception) { _ipMaquina = ""; }
                        try { _loginAcessoMaquina = (string)data.Rows[i][4]; } catch (Exception) { _loginAcessoMaquina = ""; }
                        try { _passwordAcessoMaquina = (string)data.Rows[i][5]; } catch (Exception) { _passwordAcessoMaquina = ""; }
                        try { _dataCriacaoMaquina = DateTime.Parse(data.Rows[i][6].ToString()); } catch (Exception) { _dataCriacaoMaquina = new DateTime(); }
                        try { _ultimoUpdateMaquina = DateTime.Parse(data.Rows[i][7].ToString()); } catch (Exception) { _ultimoUpdateMaquina = new DateTime(); }
                        try { _ativoMaquina = (bool)data.Rows[i][8]; } catch (Exception) { _ativoMaquina = false; }
                        _machines.Add(new Machine(_idMaquina,
                            _idClienteMaquina,
                            _descricaoMaquina,
                            _ipMaquina,
                            _loginAcessoMaquina,
                            _passwordAcessoMaquina,
                            _dataCriacaoMaquina,
                            _ultimoUpdateMaquina,
                            _ativoMaquina));
                        lstClients.Items.Add(_machines[i].ToString());
                    }
                    if (_machines.Count <= 0)
                    {
                        MessageBox.Show(
                            @"Este cliente não tem nenhuma máquina associada.\nPara adicionar assistência, tem de adicionar primeiro uma máquina.", @"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tabControl1.SelectedIndex = 0;
                    }
                    else
                        lstClients.SelectedIndex = 0;
                    break;
                case 2:
                    lstClients.Enabled = false;
                    label1.Enabled = false;
                    lstClients.Visible = false;
                    label1.Visible = false;
                    lstClients.Items.Clear();
                    Size = new Size(590, 390);
                    tabControl1.Location = new Point(10, 9);
                    cboEmployees.Items.Clear();
                    Utils.Instance.GetEmployeesList("active");
                    foreach (var t in Utils.Instance.EmployeeListActive)
                        cboEmployees.Items.Add(t.ToString());
                    cboEmployees.SelectedIndex = 0;
                    break;
                default:
                    label1.Text = @"Selecionar Cliente:";
                    lstClients.Enabled = true;
                    label1.Enabled = true;
                    lstClients.Visible = true;
                    label1.Visible = true;
                    Size = new Size(736, 412);
                    tabControl1.Location = new Point(154, 28);
                    lstClients.Items.Clear();
                    Utils.Instance.GetClientsList("active");
                    foreach (var t in Utils.Instance.ClientsListActive)
                        lstClients.Items.Add(t.ToString());
                    lstClients.SelectedIndex = 0;
                    break;
            }
        }

        private void lstClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    txtName.Text = _clients[lstClients.SelectedIndex].GetName();
                    txtStreet.Text = _clients[lstClients.SelectedIndex].GetStreet();
                    txtCity.Text = _clients[lstClients.SelectedIndex].GetCity();
                    txtCP.Text = _clients[lstClients.SelectedIndex].GetCep();
                    txtEmail.Text = _clients[lstClients.SelectedIndex].GetEmail();
                    txtPhone.Text = _clients[lstClients.SelectedIndex].GetPhone();
                    txtComments.Text = _clients[lstClients.SelectedIndex].GetComments();
                    _selectedClient = _clients[lstClients.SelectedIndex].GetClientId();
                    break;
                case 1:
                    txtDescricaoMaquina.Text = _descricaoMaquina;
                    txtIpMaquina.Text = _ipMaquina;
                    txtLoginMaquina.Text = _loginAcessoMaquina;
                    txtPasswordMaquina.Text = _passwordAcessoMaquina;
                    _selectedMachine = _machines[lstClients.SelectedIndex].GetMachineId();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e) => tabControl1.SelectedIndex = 1;

        private void button2_Click(object sender, EventArgs e) => tabControl1.SelectedIndex = 2;

        private void button5_Click(object sender, EventArgs e) => tabControl1.SelectedIndex = 1;

        private void button3_Click(object sender, EventArgs e) => tabControl1.SelectedIndex = 0;

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedClient > 0 && _selectedMachine > 0)
                {
                    Database.Instance.InsertAssistance(Convert.ToInt32(_selectedClient),
                        Convert.ToInt32(_selectedMachine),
                        Convert.ToInt32(Utils.Instance.EmployeeListActive[cboEmployees.SelectedIndex].GetEmployeeId()),
                        mclDate.SelectionStart.ToString(CultureInfo.InvariantCulture),
                        chkEnded.Checked ? DateTime.Now.ToString("yyyy-MM-dd") : "", mskHour.Text,
                        chkEnded.Checked ? DateTime.Now.Hour + ":" + DateTime.Now.Minute : "", chkEnded.Checked,
                        Convert.ToDecimal(txtPreco.Text), txtObservacoes.Text);
                    MessageBox.Show(@"Assistência inserida com sucesso", @"Successo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Hide();
                }
                else
                {
                    MessageBox.Show(@"Selecione um cliente e uma máquina", @"Erro", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
                Clipboard.SetText(f.Message);
            }
        }
    }
}
