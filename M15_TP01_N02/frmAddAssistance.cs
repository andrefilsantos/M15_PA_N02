using System;
using System.Windows.Forms;

namespace M15_TP01_N02
{
    public partial class frmAddAssistance : Form
    {
        public frmAddAssistance()
        {
            InitializeComponent();
        }

        private void frmAddAssistance_Load(object sender, EventArgs e)
        {
            var data = Util.Instance.DataTableToListView(Database.Instance.SqlQuery("SELECT nome FROM Clientes"));
            foreach (var t in data)
                lstClients.Items.Add(t);
        }

        private void lstClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(lstClients.SelectedItems[0].Text);
        }
    }
}
