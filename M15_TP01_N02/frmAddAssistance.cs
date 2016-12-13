using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace M15_TP01_N02
{
    public partial class FrmAddAssistance : Form
    {
        private List<Client> _clients;
        private List<Machines> _machines;
        private List<Funcionario> _employees;
        private uint _idCliente;
        private uint _selectedMachine;
        private uint _selectedClient;
        private uint _selectedEmployee;
        private string _nomeCliente,
            _moradaCliente,
            _codigoPostalCliente,
            _localidadeCliente,
            _telefoneCliente,
            _faxCliente,
            _telemovelCliente,
            _emailCliente,
            _siteCliente,
            _representanteCliente,
            _observacoesCliente;

        private DateTime _dataCriacaoCliente, _ultimoUpdateCliente;
        private bool _ativoCliente;

        private uint _idMaquina, _idClienteMaquina;

        private string _descricaoMaquina, _ipMaquina, _loginAcessoMaquina, _passwordAcessoMaquina;

        private DateTime _dataCriacaoMaquina, _ultimoUpdateMaquina;
        private bool _ativoMaquina;

        private uint _idFuncionario;

        private string _nomeFuncionario,
            _usernameFuncionario,
            _passwordFuncionario,
            _fotoFuncionario,
            _nCcFuncionario,
            _telefoneFuncionario,
            _emailFuncionario,
            _observacoesFuncionario;

        private DateTime _dataNascimentoFuncionario, _dataCriacaoFuncionario, _ultimoUpdateFuncionario;
        private bool _ativoFuncionario;

        private void cboEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedEmployee = _employees[cboEmployees.SelectedIndex].GetIdFuncionario();
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(_selectedClient.ToString());
                Database.Instance.InsertAssistance(Convert.ToInt32(_selectedClient), Convert.ToInt32(_selectedMachine), Convert.ToInt32(_selectedEmployee),
                    DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.Hour + ":" + DateTime.Now.Minute,
                    chkEnded.Checked ? DateTime.Now.Hour + ":" + DateTime.Now.Minute : "", chkEnded.Checked,
                    Convert.ToDecimal(txtPreco.Text), txtObservacoes.Text);
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
                Clipboard.SetText(f.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e) => tabControl1.SelectedIndex = 2;

        private void button3_Click(object sender, EventArgs e) => tabControl1.SelectedIndex = 0;

        private void button1_Click(object sender, EventArgs e) => tabControl1.SelectedIndex = 1;

        private void button5_Click(object sender, EventArgs e) => tabControl1.SelectedIndex = 1;


        public FrmAddAssistance()
        {
            InitializeComponent();
        }

        private void frmAddAssistance_Load(object sender, EventArgs e)
        {
            label1.Text = "Selecione o cliente:";
            label1.Visible = true;
            lstClients.Visible = true;
            lstClients.Items.Clear();
            var data = Database.Instance.SqlQuery("SELECT * FROM Clientes WHERE ativo = 1");
            _clients = new List<Client>();
            for (var i = 0; i < data.Rows.Count; i++)
            {
                try { _idCliente = Convert.ToUInt32(data.Rows[i][0]); } catch (Exception) { _idCliente = 0; }
                try { _nomeCliente = (string)data.Rows[i][1]; } catch (Exception) { _nomeCliente = ""; }
                try { _moradaCliente = (string)data.Rows[i][2]; } catch (Exception) { _moradaCliente = ""; }
                try { _codigoPostalCliente = (string)data.Rows[i][3]; } catch (Exception) { _codigoPostalCliente = ""; }
                try { _localidadeCliente = (string)data.Rows[i][4]; } catch (Exception) { _localidadeCliente = ""; }
                try { _telefoneCliente = (string)data.Rows[i][5]; } catch (Exception) { _telefoneCliente = ""; }
                try { _faxCliente = (string)data.Rows[i][6]; } catch (Exception) { _faxCliente = ""; }
                try { _telemovelCliente = (string)data.Rows[i][7]; } catch (Exception) { _telemovelCliente = ""; }
                try { _emailCliente = (string)data.Rows[i][8]; } catch (Exception) { _emailCliente = ""; }
                try { _siteCliente = (string)data.Rows[i][9]; } catch (Exception) { _siteCliente = ""; }
                try { _representanteCliente = (string)data.Rows[i][10]; } catch (Exception) { _representanteCliente = ""; }
                try { _observacoesCliente = (string)data.Rows[i][11]; } catch (Exception) { _observacoesCliente = ""; }
                try { _dataCriacaoCliente = DateTime.Parse(data.Rows[i][12].ToString()); } catch (Exception) { _dataCriacaoCliente = new DateTime(); }
                try { _ultimoUpdateCliente = DateTime.Parse(data.Rows[i][13].ToString()); } catch (Exception) { _ultimoUpdateCliente = new DateTime(); }
                try { _ativoCliente = (bool)data.Rows[i][14]; } catch (Exception) { _ativoCliente = false; }
                _clients.Add(new Client(_idCliente,
                                        _nomeCliente,
                                        _moradaCliente,
                                        _codigoPostalCliente,
                                        _localidadeCliente,
                                        _telefoneCliente,
                                        _faxCliente,
                                        _telemovelCliente,
                                        _emailCliente,
                                        _siteCliente,
                                        _representanteCliente,
                                        _observacoesCliente,
                                        _dataCriacaoCliente,
                                        _ultimoUpdateCliente,
                                        _ativoCliente));
                lstClients.Items.Add(_clients[i].ToString());
            }
            lstClients.SelectedIndex = 0;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                label1.Text = "Selecione a máquina:";
                label1.Visible = true;
                lstClients.Visible = true;
                lstClients.Items.Clear();
                var data = Database.Instance.SqlQuery($@"SELECT * FROM Maquinas WHERE idCliente = {_selectedClient} AND ativo = 1");
                _machines = new List<Machines>();
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
                    _machines.Add(new Machines(_idMaquina,
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
                lstClients.SelectedIndex = 0;
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                label1.Visible = false;
                lstClients.Visible = false;
                lstClients.Items.Clear();
                var data = Database.Instance.SqlQuery("SELECT * FROM funcionarios WHERE ativo = 1");
                _employees = new List<Funcionario>();
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    try { _idFuncionario = Convert.ToUInt32(data.Rows[i][0]); } catch (Exception) { _idFuncionario = 0; }
                    try { _nomeFuncionario = (string)data.Rows[i][1]; } catch (Exception) { _nomeFuncionario = ""; }
                    try { _usernameFuncionario = (string)data.Rows[i][2]; } catch (Exception) { _usernameFuncionario = ""; }
                    try { _passwordFuncionario = (string)data.Rows[i][3]; } catch (Exception) { _passwordFuncionario = ""; }
                    try { _dataNascimentoFuncionario = DateTime.Parse(data.Rows[i][4].ToString()); } catch (Exception) { _dataNascimentoFuncionario = new DateTime(); }
                    try { _fotoFuncionario = (string)data.Rows[i][5]; } catch (Exception) { _fotoFuncionario = ""; }
                    try { _nCcFuncionario = (string)data.Rows[i][6]; } catch (Exception) { _nCcFuncionario = ""; }
                    try { _telefoneFuncionario = (string)data.Rows[i][7]; } catch (Exception) { _telefoneFuncionario = ""; }
                    try { _emailFuncionario = (string)data.Rows[i][8]; } catch (Exception) { _emailFuncionario = ""; }
                    try { _observacoesFuncionario = (string)data.Rows[i][9]; } catch (Exception) { _observacoesFuncionario = ""; }
                    try { _dataCriacaoFuncionario = DateTime.Parse(data.Rows[i][10].ToString()); } catch (Exception) { _dataCriacaoFuncionario = new DateTime(); }
                    try { _ultimoUpdateFuncionario = DateTime.Parse(data.Rows[i][11].ToString()); } catch (Exception) { _ultimoUpdateFuncionario = new DateTime(); }
                    try { _ativoFuncionario = (bool)data.Rows[i][12]; } catch (Exception) { _ativoFuncionario = false; }
                    _employees.Add(new Funcionario(_idFuncionario,
                                                    _nomeFuncionario,
                                                    _usernameFuncionario,
                                                    _passwordFuncionario,
                                                    _dataNascimentoFuncionario,
                                                    _fotoFuncionario,
                                                    _nCcFuncionario,
                                                    _telefoneFuncionario,
                                                    _emailFuncionario,
                                                    _dataCriacaoFuncionario,
                                                    _observacoesFuncionario,
                                                    _ultimoUpdateFuncionario,
                                                    _ativoFuncionario));
                }
                cboEmployees.DataSource = _employees;
                cboEmployees.SelectedIndex = 0;

            }
            else
            {
                frmAddAssistance_Load(this, new EventArgs());
            }
        }

        private void lstClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                txtName.Text = _clients[lstClients.SelectedIndex].GetNome();
                txtStreet.Text = _clients[lstClients.SelectedIndex].GetMorada();
                txtCity.Text = _clients[lstClients.SelectedIndex].GetLocalidade();
                txtCP.Text = _clients[lstClients.SelectedIndex].GetCodigoPostal();
                txtEmail.Text = _clients[lstClients.SelectedIndex].GetEmail();
                txtPhone.Text = _clients[lstClients.SelectedIndex].GetTelefone();
                txtObservations.Text = _clients[lstClients.SelectedIndex].GetObservacoes();
                _selectedClient = _clients[lstClients.SelectedIndex].GetIdCliente();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                txtDescricaoMaquina.Text = _descricaoMaquina;
                txtIpMaquina.Text = _ipMaquina;
                txtLoginMaquina.Text = _loginAcessoMaquina;
                txtPasswordMaquina.Text = _passwordAcessoMaquina;
                _selectedMachine = _machines[lstClients.SelectedIndex].GetIdMaquina();
            }
            else
            {

            }
        }
    }
}
