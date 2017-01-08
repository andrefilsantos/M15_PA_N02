using System;
using System.Collections.Generic;
using System.Windows.Forms;
using M15_PA01_N02.Classes;

namespace M15_PA01_N02.Forms
{
    public partial class FrmListCustomers : Form
    {
        List<Client> _clients;
        public FrmListCustomers()
        {
            InitializeComponent();
            cboContent.SelectedIndex = 0;
            lstClients.SelectedIndex = 0;
        }

        private void cboContent_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            lstClients.SelectedIndex = 0;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (lstClients.SelectedIndex > 0)
                lstClients.SelectedIndex--;
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (lstClients.SelectedIndex < lstClients.Items.Count - 1)
                lstClients.SelectedIndex++;
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            lstClients.SelectedIndex = lstClients.Items.Count - 1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_clients[lstClients.SelectedIndex].GetActive())
            {
                Database.Instance.DeleteItem("Clientes", _clients[lstClients.SelectedIndex].GetClientId(), "false");
                UpdateList();
            }
            else
            {
                Database.Instance.DeleteItem("Clientes", _clients[lstClients.SelectedIndex].GetClientId(), "true");
                UpdateList();
            }
        }

        private void lstClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNome.Text = @"Nome: " + _clients[lstClients.SelectedIndex].GetName();
            lblRepresentante.Text = @"Representante: " + _clients[lstClients.SelectedIndex].GetAgent();
            lblSite.Text = @"Site: " + _clients[lstClients.SelectedIndex].GetSite();
            lblTelefone.Text = @"Telefone: " + _clients[lstClients.SelectedIndex].GetPhone();
            lblTelemovel.Text = @"Telemovel: " + _clients[lstClients.SelectedIndex].GetMobilePhone();
            lblFax.Text = @"Fax: " + _clients[lstClients.SelectedIndex].GetFax();
            lblEmail.Text = @"E-mail: " + _clients[lstClients.SelectedIndex].GetEmail();
            lblRua.Text = @"Rua: " + _clients[lstClients.SelectedIndex].GetStreet();
            lblLocalidade.Text = @"Localidade: " + _clients[lstClients.SelectedIndex].GetCity();
            lblCodPostal.Text = @"Código Postal: " + _clients[lstClients.SelectedIndex].GetCep();
            lblObservacoes.Text = @"Observações: " + _clients[lstClients.SelectedIndex].GetComments();
            btnEliminar.Text = _clients[lstClients.SelectedIndex].GetActive() ? "&Eliminar" : "&Recuperar";
        }

        public void UpdateList()
        {
            if (cboContent.SelectedIndex == 0)
            {
                lstClients.Items.Clear();
                Utils.Instance.GetClientsList("active");
                _clients = Utils.Instance.ClientsListActive;
                foreach (var client in _clients)
                    lstClients.Items.Add(client);
                btnEliminar.Text = @"&Eliminar";
            }
            else if (cboContent.SelectedIndex == 1)
            {
                lstClients.Items.Clear();
                Utils.Instance.GetClientsList("inactive");
                _clients = Utils.Instance.ClientsListInactive;
                foreach (var client in _clients)
                    lstClients.Items.Add(client);
                btnEliminar.Text = @"&Recuperar";
            }
            else
            {
                lstClients.Items.Clear();
                Utils.Instance.GetClientsList("all");
                _clients = Utils.Instance.ClientsListAll;
                foreach (var client in _clients)
                    lstClients.Items.Add(client);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var frmEditClient = new FrmAddClient(_clients[lstClients.SelectedIndex]);
            frmEditClient.Show();
        }
    }
}
