using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M15_TP01_N02
{
    internal class Util
    {
        private static Util _instance;
        public static Util Instance => _instance ?? (_instance = new Util());
        public Funcionario User;

        public List<string> DataTableToListView(DataTable data)
        {
            var dataList = new List<string>();
            for (var i = 0; i < data.Rows.Count; i++)
                dataList.Add(data.Rows[i][0].ToString());
            return dataList;
        }
    }
}
