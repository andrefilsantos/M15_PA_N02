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
    public partial class FrmAddMachine : Form
    {
        private List<Client> _clients;
        private uint _idCliente;
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
        public FrmAddMachine()
        {
            InitializeComponent();
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
                cboClient.Items.Add(_clients[i].ToString());
            }
            cboClient.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database.Instance.InsertMachine(_clients[cboClient.SelectedIndex].GetIdCliente().ToString(), txtDescricao.Text, txtIp.Text, txtLogin.Text, txtPassword.Text);
        }
    }
}
