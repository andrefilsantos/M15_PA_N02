using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public bool Login(string username, string password)
        {
            var sqlQuery = new SqlCommand($@"SELECT * FROM Funcionarios WHERE username LIKE '{username}' AND password LIKE '{password}'", _ligacaoBd);
            var employee = new DataTable();

            var user = sqlQuery.ExecuteReader();
            employee.Load(user);
            if (employee.Rows.Count > 0)
            {
                Util.Instance.User = new Funcionario(Convert.ToUInt32(employee.Rows[0][0]),
                                                     (string)employee.Rows[0][1],
                                                     (string)employee.Rows[0][2],
                                                     (string)employee.Rows[0][3],
                                                     DateTime.Parse(employee.Rows[0][4].ToString()),
                                                     (string)employee.Rows[0][5],
                                                     (string)employee.Rows[0][6],
                                                     (string)employee.Rows[0][7],
                                                     (string)employee.Rows[0][8],
                                                     (string)employee.Rows[0][9],
                                                     DateTime.Parse(employee.Rows[0][10].ToString()),
                                                     (bool)employee.Rows[0][12]);
            }
            return employee.Rows.Count > 0;
        }
    }
}
