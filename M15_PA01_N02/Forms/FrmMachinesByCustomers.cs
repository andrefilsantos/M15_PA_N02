using System.Windows.Forms;
using M15_PA01_N02.Classes;

namespace M15_PA01_N02.Forms
{
    public partial class FrmMachinesByCustomers : Form
    {
        public FrmMachinesByCustomers()
        {
            InitializeComponent();
            dgvMachines.DataSource =
                Database.Instance.SqlQuery(
                    "SELECT Clientes.nome AS \'Cliente\',COUNT(Maquinas.idCliente) AS \'Total de Máquinas\' FROM Maquinas LEFT JOIN Clientes ON Maquinas.idCliente=Clientes.idCliente GROUP BY Clientes.Nome"); 
        }

        private void FrmMachinesByCustomers_Load(object sender, System.EventArgs e)
        {

        }
    }
}
