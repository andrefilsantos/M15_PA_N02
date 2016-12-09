using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

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

        public bool Login(string username, string password)
        {
            var sqlQuery =
                new SqlCommand(
                    $@"SELECT * FROM Funcionarios WHERE username LIKE '{username}' AND password LIKE '{password}'",
                    _ligacaoBd);
            var employee = new DataTable();

            var user = sqlQuery.ExecuteReader();
            employee.Load(user);
            if (employee.Rows.Count <= 0) return employee.Rows.Count > 0;
            string nome,
                userUsername,
                userPassword,
                foto,
                nCc,
                telefone,
                email,
                observacoes;
            DateTime dataNascimento, dataCriacao;
            bool ativo;

            try { nome = (string)employee.Rows[0][1]; } catch (Exception) { nome = ""; }
            try { userUsername = (string)employee.Rows[0][2]; } catch (Exception) { userUsername = ""; }
            try { userPassword = (string)employee.Rows[0][3]; } catch (Exception) { userPassword = ""; }
            try { dataNascimento = DateTime.Parse(employee.Rows[0][4].ToString()); } catch (Exception) { dataNascimento = new DateTime(); }
            try { foto = (string)employee.Rows[0][5]; } catch (Exception) { foto = ""; }
            try { nCc = (string)employee.Rows[0][6]; } catch (Exception) { nCc = ""; }
            try { telefone = (string)employee.Rows[0][7]; } catch (Exception) { telefone = ""; }
            try { email = (string)employee.Rows[0][8]; } catch (Exception) { email = ""; }
            try { observacoes = (string)employee.Rows[0][9]; } catch (Exception) { observacoes = ""; }
            try { dataCriacao = DateTime.Parse(employee.Rows[0][10].ToString()); } catch (Exception) { dataCriacao = new DateTime(); }
            try { ativo = (bool)employee.Rows[0][12]; } catch (Exception) { ativo = false; }

            Util.Instance.User = new Funcionario(Convert.ToUInt32(employee.Rows[0][0]),
                nome,
                userUsername,
                userPassword,
                dataNascimento,
                foto,
                nCc,
                telefone,
                email,
                observacoes,
                dataCriacao,
                ativo);
            return employee.Rows.Count > 0;
        }
    }
}
