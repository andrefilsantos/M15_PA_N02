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
    public partial class FrmAddClient : Form
    {
        public FrmAddClient()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Instance.InsertClient(txtName.Text, txtStreet.Text, txtCity.Text, txtCP.Text, txtPhone.Text, txtFax.Text, txtMobilePhone.Text, txtMail.Text, txtSite.Text, txtRepresentante.Text, txtObservations.Text);
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
            
        }
    }
}
