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
