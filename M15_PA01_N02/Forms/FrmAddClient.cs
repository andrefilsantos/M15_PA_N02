using System;
using System.Windows.Forms;
using M15_PA01_N02.Classes;

namespace M15_PA01_N02.Forms
{
    public partial class FrmAddClient : Form
    {
        private bool _edit;
        private uint _id;

        public FrmAddClient()
        {
            InitializeComponent();
            _edit = false;
        }

        public FrmAddClient(Client client)
        {
            InitializeComponent();
            Text = "Now Assist > Editar Cliente";
            _edit = true;
            _id = client.GetClientId();
            txtName.Text = client.GetName();
            txtRepresentante.Text = client.GetAgent();
            txtSite.Text = client.GetSite();
            txtPhone.Text = client.GetPhone();
            txtMobilePhone.Text = client.GetMobilePhone();
            txtFax.Text = client.GetFax();
            txtMail.Text = client.GetEmail();
            txtStreet.Text = client.GetStreet();
            txtCity.Text = client.GetCity();
            txtCP.Text = client.GetCep();
            txtObservations.Text = client.GetComments();

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!_edit)
            {
                try
                {
                    if (txtName.Text != string.Empty && txtStreet.Text != string.Empty && txtCity.Text != string.Empty &&
                        txtCP.Text != string.Empty && txtPhone.Text != string.Empty && txtFax.Text != string.Empty &&
                        txtMobilePhone.Text != string.Empty && txtMail.Text != string.Empty &&
                        txtSite.Text != string.Empty && txtRepresentante.Text != string.Empty &&
                        txtObservations.Text != string.Empty)
                    {
                        Database.Instance.InsertClient(txtName.Text, txtStreet.Text, txtCity.Text, txtCP.Text,
                            txtPhone.Text,
                            txtFax.Text, txtMobilePhone.Text, txtMail.Text, txtSite.Text, txtRepresentante.Text,
                            txtObservations.Text);
                        MessageBox.Show(@"Cliente adicionado com sucesso", @"Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Hide();
                    }
                    else
                        MessageBox.Show(@"Preencha todos os campos", @"Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception f)
                {
                    MessageBox.Show(@"Erro: " + f.Message, @"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    if (txtName.Text != string.Empty && txtStreet.Text != string.Empty && txtCity.Text != string.Empty &&
                        txtCP.Text != string.Empty && txtPhone.Text != string.Empty && txtMail.Text != string.Empty &&
                        txtSite.Text != string.Empty && txtRepresentante.Text != string.Empty)
                    {
                        Database.Instance.EditClient(txtName.Text, txtStreet.Text, txtCity.Text, txtCP.Text,
                            txtPhone.Text,
                            txtFax.Text, txtMobilePhone.Text, txtMail.Text, txtSite.Text, txtRepresentante.Text,
                            txtObservations.Text, _id);
                        MessageBox.Show(@"Cliente editado com sucesso", @"Successo", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Hide();
                        Utils.Instance.GetClientsList("active");
                    }
                    else
                        MessageBox.Show(@"Preencha todos os campos", @"Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception f)
                {
                    MessageBox.Show(@"Erro: " + f.Message, @"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
