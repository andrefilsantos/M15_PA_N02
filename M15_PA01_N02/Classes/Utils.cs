using System;
using System.Collections.Generic;
using System.Text;

namespace M15_PA01_N02.Classes
{
    public class Utils
    {

        private uint _idCliente, _idFuncionario;
        private string _nomeCliente, _moradaCliente, _codigoPostalCliente, _localidadeCliente, _telefoneCliente, _faxCliente, _telemovelCliente, _emailCliente, _siteCliente, _representanteCliente, _observacoesCliente;
        private DateTime _dataCriacaoCliente, _ultimoUpdateCliente;
        private bool _ativoCliente;

        private string _nomeFuncionario, _usernameFuncionario, _passwordFuncionario, _fotoFuncionario, _nCcFuncionario, _telefoneFuncionario, _emailFuncionario, _observacoesFuncionario;

        private DateTime _dataNascimentoFuncionario, _dataCriacaoFuncionario, _ultimoUpdateFuncionario;
        private bool _ativoFuncionario;

        private static Utils _instance;

        public Employee User;

        public List<Client> ClientsListAll, ClientsListActive, ClientsListInactive;
        public List<Employee> EmployeeListAll, EmployeeListActive, EmployeeListInactive;


        public static Utils Instance => _instance ?? (_instance = new Utils());

        public void GetClientsList(string state)
        {
            ClientsListActive = new List<Client>();
            ClientsListInactive = new List<Client>();
            ClientsListAll = new List<Client>();

            ClientsListActive.Clear();
            ClientsListInactive.Clear();
            ClientsListAll.Clear();

            var sql = "SELECT * FROM Clientes";
            if (state == "active")
            {
                sql += " WHERE ativo = 1";
            }
            else if (state == "inactive")
            {
                sql += " WHERE ativo = 0";
            }

            var data = Database.Instance.SqlQuery(sql);
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
                switch (state)
                {
                    case "active":
                        ClientsListActive.Add(new Client(_idCliente, _nomeCliente, _moradaCliente, _codigoPostalCliente, _localidadeCliente, _telefoneCliente, _faxCliente, _telemovelCliente, _emailCliente, _siteCliente, _representanteCliente, _observacoesCliente, _dataCriacaoCliente, _ultimoUpdateCliente, _ativoCliente));
                        break;
                    case "inactive":
                        ClientsListInactive.Add(new Client(_idCliente, _nomeCliente, _moradaCliente, _codigoPostalCliente, _localidadeCliente, _telefoneCliente, _faxCliente, _telemovelCliente, _emailCliente, _siteCliente, _representanteCliente, _observacoesCliente, _dataCriacaoCliente, _ultimoUpdateCliente, _ativoCliente));
                        break;
                    default:
                        ClientsListAll.Add(new Client(_idCliente, _nomeCliente, _moradaCliente, _codigoPostalCliente, _localidadeCliente, _telefoneCliente, _faxCliente, _telemovelCliente, _emailCliente, _siteCliente, _representanteCliente, _observacoesCliente, _dataCriacaoCliente, _ultimoUpdateCliente, _ativoCliente));
                        break;
                }
            }
        }

        public void GetEmployeesList(string state)
        {
            EmployeeListAll = new List<Employee>();
            EmployeeListActive = new List<Employee>();
            EmployeeListInactive = new List<Employee>();

            EmployeeListAll.Clear();
            EmployeeListActive.Clear();
            EmployeeListInactive.Clear();

            var sql = "SELECT * FROM Funcionarios";
            if (state == "active")
            {
                sql += " WHERE ativo = 1";
            }
            else if (state == "inactive")
            {
                sql += " WHERE ativo = 0";
            }

            var data = Database.Instance.SqlQuery(sql);

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
                switch (state)
                {
                    case "active":
                        EmployeeListActive.Add(new Employee(_idFuncionario,
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
                        break;
                    case "inactive":
                        EmployeeListInactive.Add(new Employee(_idFuncionario,
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
                        break;
                    default:
                        EmployeeListAll.Add(new Employee(_idFuncionario,
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
                        break;
                }
            }
        }

        public string Md5(string str)
        {
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                var inputBytes = Encoding.ASCII.GetBytes(str);
                var hashBytes = md5.ComputeHash(inputBytes);
                var sb = new StringBuilder();
                foreach (var t in hashBytes)
                    sb.Append(t.ToString("X2"));
                return sb.ToString();
            }
        }
    }
}