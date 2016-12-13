using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace M15_TP01_N02
{
    internal class Database
    {
        private static Database _instance;
        public static Database Instance => _instance ?? (_instance = new Database());
        private readonly SqlConnection _ligacaoBd;

        public Database()
        {
            var strLigacao = ConfigurationManager.ConnectionStrings["sql"].ToString();
            _ligacaoBd = new SqlConnection(strLigacao);
            _ligacaoBd.Open();
        }

        ~Database()
        {
            try
            {
                _ligacaoBd.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public DataTable SqlQuery(string query)
        {
            var queryResult = new DataTable();
            var sqlQuery = new SqlCommand(query, _ligacaoBd);
            var result = sqlQuery.ExecuteReader();
            queryResult.Load(result);
            return queryResult;
        }

        public void InsertClient(string nome, string morada, string localidade, string codigoPostal, string telefone, string fax, string telemovel, string email, string site, string representante, string observacoes)
        {

            var comando = new SqlCommand(@"INSERT INTO Clientes(nome, morada, localidade, codigoPostal, telefone, fax, telemovel, email, site, representante, observacoes, dataCriacao, ultimoUpdate, ativo) VALUES (@nome, @morada, @localidade, @codigoPostal, @telefone, @fax, @telemovel, @email, @site, @representante, @observacoes, getDate(), getDate(), 'true');", _ligacaoBd);
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@morada", morada);
            comando.Parameters.AddWithValue("@localidade", localidade);
            comando.Parameters.AddWithValue("@codigoPostal", codigoPostal);
            comando.Parameters.AddWithValue("@telefone", telefone);
            comando.Parameters.AddWithValue("@fax", fax);
            comando.Parameters.AddWithValue("@telemovel", telemovel);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@site", site);
            comando.Parameters.AddWithValue("@representante", representante);
            comando.Parameters.AddWithValue("@observacoes", observacoes);
            comando.ExecuteNonQuery();
        }

        public void InsertMachine(string idCliente, string descricao, string ip, string loginAcesso, string passwordAcesso)
        {

            var comando = new SqlCommand(@"INSERT INTO Maquinas(idCliente, descricao, ip, loginAcesso, passwordAcesso, dataCriacao, ultimoUpdate, ativo) VALUES (@idCliente, @descricao, @ip, @loginAcesso, @passwordAcesso, getDate(), getDate(), 'true');", _ligacaoBd);
            comando.Parameters.AddWithValue("@idCliente", idCliente);
            comando.Parameters.AddWithValue("@descricao", descricao);
            comando.Parameters.AddWithValue("@ip", ip);
            comando.Parameters.AddWithValue("@loginAcesso", loginAcesso);
            comando.Parameters.AddWithValue("@passwordAcesso", passwordAcesso);
            comando.ExecuteNonQuery();
        }

        public void InsertEmloyee(string nome, string username, string password, string dataNascimento, string foto, string nCc, string telefone, string email, string observacoes)
        {

            var comando = new SqlCommand(@"INSERT INTO Funcionarios(nome, username, password, dataNascimento, foto, nCc, telefone, email, observacoes, dataCriacao, ultimoUpdate, ativo) VALUES (@nome, @username, @password, @dataNascimento, @foto, @nCc, @telefone, @email, @observacoes, getDate(), getDate(), 'true');", _ligacaoBd);
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@username", username);
            comando.Parameters.AddWithValue("@password", password);
            comando.Parameters.AddWithValue("@dataNascimento", DateTime.Parse(dataNascimento).ToString("yyyy-MM-dd"));
            comando.Parameters.AddWithValue("@foto", foto);
            comando.Parameters.AddWithValue("@nCc", nCc);
            comando.Parameters.AddWithValue("@telefone", telefone);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@observacoes", observacoes);
            comando.ExecuteNonQuery();
        }

        public void InsertAssistance(int idCliente, int idMaquina, int idFuncionario, string dataInicio, string dataFim, string horaInicio, string horaFim, bool concluida, decimal preco, string observacoes)
        {
            var comando = new SqlCommand(@"INSERT INTO Assistencias(idMaquina, idCliente, idFuncionario, dataInicio, dataFim, horaInicio, horaFim, concluida, preco, observacoes, dataCriacao, ultimoUpdate, ativo) VALUES (@idMaquina, @idCliente, @idFuncionario, @dataInicio, @dataFim, @horaInicio, @horaFim, @concluida, @preco, @observacoes, getDate(), getDate(), 'true');", _ligacaoBd);
            comando.Parameters.AddWithValue("@idMaquina", idMaquina);
            comando.Parameters.AddWithValue("@idCliente", idCliente);
            comando.Parameters.AddWithValue("@idFuncionario", idFuncionario);
            comando.Parameters.AddWithValue("@dataInicio", dataInicio);
            comando.Parameters.AddWithValue("@dataFim", dataFim);
            comando.Parameters.AddWithValue("@horaInicio", horaInicio);
            comando.Parameters.AddWithValue("@horaFim", horaFim);
            comando.Parameters.AddWithValue("@concluida", concluida);
            comando.Parameters.AddWithValue("@preco", preco);
            comando.Parameters.AddWithValue("@observacoes", observacoes);
            comando.ExecuteNonQuery();
        }

        public bool Login(string username, string password)
        {
            var sqlQuery =
                new SqlCommand(
                    $@"SELECT * FROM Funcionarios WHERE username LIKE '{username}' AND password LIKE '{password}' AND ativo = 1",
                    _ligacaoBd);
            var employee = new DataTable();

            var user = sqlQuery.ExecuteReader();
            employee.Load(user);
            if (employee.Rows.Count <= 0) return employee.Rows.Count > 0;
            uint idFuncionario;
            string nome,
                userUsername,
                userPassword,
                foto,
                telefone,
                email,
                nCc,
                observacoes;
            DateTime dataNascimento, dataCriacao, ultimoUpdate;
            bool ativo;

            try { idFuncionario = Convert.ToUInt32(employee.Rows[0][0]); } catch { idFuncionario = 0; }
            try { nome = (string)employee.Rows[0][1]; } catch { nome = ""; }
            try { userUsername = (string)employee.Rows[0][2]; } catch { userUsername = ""; }
            try { userPassword = (string)employee.Rows[0][3]; } catch { userPassword = ""; }
            try { dataNascimento = DateTime.Parse(employee.Rows[0][4].ToString()); } catch { dataNascimento = new DateTime(); }
            try { foto = (string)employee.Rows[0][5]; } catch { foto = ""; }
            try { nCc = (string)employee.Rows[0][6]; } catch { nCc = ""; }
            try { telefone = (string)employee.Rows[0][7]; } catch { telefone = ""; }
            try { email = (string)employee.Rows[0][8]; } catch { email = ""; }
            try { observacoes = (string)employee.Rows[0][9]; } catch { observacoes = ""; }
            try { dataCriacao = DateTime.Parse(employee.Rows[0][10].ToString()); } catch { dataCriacao = new DateTime(); }
            try { ultimoUpdate = DateTime.Parse(employee.Rows[0][11].ToString()); } catch { ultimoUpdate = new DateTime(); }
            try { ativo = (bool)employee.Rows[0][12]; } catch { ativo = false; }


            Util.Instance.User = new Funcionario(idFuncionario,
                nome,
                userUsername,
                userPassword,
                dataNascimento,
                foto,
                nCc,
                telefone,
                email,
                dataCriacao,
                observacoes,
                ultimoUpdate,
                ativo);
            return employee.Rows.Count > 0;
        }
    }
}
