using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace M15_TP01_N02
{
    public partial class FrmAddAssistance : Form
    {
        private List<Client> _clients;
        uint _idCliente;
        string _nome,
            _morada,
            _codigoPostal,
            _localidade,
            _telefone,
            _fax,
            _telemovel,
            _email,
            _site,
            _representante,
            _observacoes;
        DateTime _dataCriacao, _ultimoUpdate;
        bool _ativo;
        public FrmAddAssistance()
        {
            InitializeComponent();
        }

        private void frmAddAssistance_Load(object sender, EventArgs e)
        {
            var data = Database.Instance.SqlQuery("SELECT * FROM Clientes WHERE ativo = 1");
            _clients = new List<Client>();
            for (var i = 0; i < data.Rows.Count; i++)
            {
                try { _idCliente = (uint)data.Rows[i][0]; } catch (Exception) { _idCliente = 0; }
                try { _nome = (string)data.Rows[i][1]; } catch (Exception) { _nome = ""; }
                try { _morada = (string)data.Rows[i][2]; } catch (Exception) { _morada = ""; }
                try { _codigoPostal = (string)data.Rows[i][3]; } catch (Exception) { _codigoPostal = ""; }
                try { _localidade = (string)data.Rows[i][4]; } catch (Exception) { _localidade = ""; }
                try { _telefone = (string)data.Rows[i][5]; } catch (Exception) { _telefone = ""; }
                try { _fax = (string)data.Rows[i][6]; } catch (Exception) { _fax = ""; }
                try { _telemovel = (string)data.Rows[i][7]; } catch (Exception) { _telemovel = ""; }
                try { _email = (string)data.Rows[i][8]; } catch (Exception) { _email = ""; }
                try { _site = (string)data.Rows[i][9]; } catch (Exception) { _site = ""; }
                try { _representante = (string)data.Rows[i][10]; } catch (Exception) { _representante = ""; }
                try { _observacoes = (string)data.Rows[i][11]; } catch (Exception) { _observacoes = ""; }
                try { _dataCriacao = DateTime.Parse(data.Rows[i][12].ToString()); } catch (Exception) { _dataCriacao = new DateTime(); }
                try { _ultimoUpdate = DateTime.Parse(data.Rows[i][13].ToString()); } catch (Exception) { _ultimoUpdate = new DateTime(); }
                try { _ativo = (bool)data.Rows[i][14]; } catch (Exception) { _ativo = false; }

                _clients.Add(new Client(_idCliente,
                                        _nome,
                                        _morada,
                                        _codigoPostal,
                                        _localidade,
                                        _telefone,
                                        _fax,
                                        _telemovel,
                                        _email,
                                        _site,
                                        _representante,
                                        _observacoes,
                                        _dataCriacao,
                                        _ultimoUpdate,
                                        _ativo));
                lstClients.Items.Add(_clients[i].ToString());
            }
            lstClients.SelectedIndex = 0;
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(tabControl1.SelectedTab.Text);
        }

        private void lstClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtName.Text = _clients[lstClients.SelectedIndex].GetNome();
            txtStreet.Text = _clients[lstClients.SelectedIndex].GetMorada();
            txtCity.Text = _clients[lstClients.SelectedIndex].GetLocalidade();
            txtCP.Text = _clients[lstClients.SelectedIndex].GetCodigoPostal();
            txtEmail.Text = _clients[lstClients.SelectedIndex].GetEmail();
            txtPhone.Text = _clients[lstClients.SelectedIndex].GetTelefone();
            txtObservations.Text = _clients[lstClients.SelectedIndex].GetObservacoes();
        }
    }
}
