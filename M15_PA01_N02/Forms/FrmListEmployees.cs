using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using M15_PA01_N02.Classes;

namespace M15_PA01_N02.Forms
{
    public partial class FrmListEmployees : Form
    {
        private bool _edit;
        private int _editedId;
        private List<Employee> _employees;
        public FrmListEmployees()
        {
            InitializeComponent();
            cboContent.SelectedIndex = 0;
            lstClients.SelectedIndex = 0;
            _edit = false;
        }

        private void cboContent_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        public void UpdateList()
        {
            if (cboContent.SelectedIndex == 0)
            {
                lstClients.Items.Clear();
                Utils.Instance.GetEmployeesList("active");
                _employees = Utils.Instance.EmployeeListActive;
                foreach (var client in _employees)
                    lstClients.Items.Add(client);
                btnEliminar.Text = @"&Eliminar";
            }
            else if (cboContent.SelectedIndex == 1)
            {
                lstClients.Items.Clear();
                Utils.Instance.GetEmployeesList("inactive");
                _employees = Utils.Instance.EmployeeListInactive;
                foreach (var client in _employees)
                    lstClients.Items.Add(client);
                btnEliminar.Text = @"&Recuperar";
            }
            else
            {
                lstClients.Items.Clear();
                Utils.Instance.GetEmployeesList("all");
                _employees = Utils.Instance.EmployeeListAll;
                foreach (var client in _employees)
                    lstClients.Items.Add(client);
            }
        }

        private void lstClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEliminar.Text = _employees[lstClients.SelectedIndex].GetActive() ? @"Eliminar" : @"Recuperar";
            lblName.Text = @"Nome: " + _employees[lstClients.SelectedIndex].GetName();
            lblUsername.Text = @"Username: " + _employees[lstClients.SelectedIndex].GetUsername();
            lblBirthday.Text = @"Data de Nascimento: " + _employees[lstClients.SelectedIndex].GetBirthday().ToString("d");
            lblNcc.Text = @"Número de Cartão de Cidadão: " + _employees[lstClients.SelectedIndex].GetNCc();
            lblPhone.Text = @"Telefone: " + _employees[lstClients.SelectedIndex].GetPhone();
            lblEmail.Text = @"Email: " + _employees[lstClients.SelectedIndex].GetEmail();
            lblComments.Text = @"Observações: " + _employees[lstClients.SelectedIndex].GetComments();
            imgProfilePhoto.Image = Image.FromFile("../../" + _employees[lstClients.SelectedIndex].GetPhoto() + ".png");
            Image.FromFile("../../" + _employees[lstClients.SelectedIndex].GetPhoto() + ".png").Dispose();
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
            if (lstClients.SelectedIndex < _employees.Count - 1)
                lstClients.SelectedIndex++;
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            lstClients.SelectedIndex = _employees.Count - 1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_employees[lstClients.SelectedIndex].GetActive())
            {
                Database.Instance.DeleteItem("Funcionarios", _employees[lstClients.SelectedIndex].GetEmployeeId(), "false");
                UpdateList();
            }
            else
            {
                Database.Instance.DeleteItem("Funcionarios", _employees[lstClients.SelectedIndex].GetEmployeeId(), "true");
                UpdateList();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _edit = true;
            Image.FromFile("../../" + _employees[lstClients.SelectedIndex].GetPhoto() + ".png").Dispose();
            GC.Collect();
            imgProfilePhoto.Image = null;
            _editedId = lstClients.SelectedIndex;
            var frmEditEmployee = new FrmAddEmployee(_employees[lstClients.SelectedIndex]);
            frmEditEmployee.Show();
        }

        private void FrmListEmployees_Activated(object sender, EventArgs e)
        {
            if (_edit)
            {
                UpdateList();
                lstClients.SelectedIndex = _editedId;
            }
            _edit = false;
        }
    }
}
