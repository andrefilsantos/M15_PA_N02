using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using M15_PA01_N02.Classes;

namespace M15_PA01_N02.Forms
{
    public partial class FrmListAssists : Form
    {
        private List<Machine> _machines;
        private uint _idMaquina, _idClienteMaquina;

        private string _descricaoMaquina, _ipMaquina, _loginAcessoMaquina, _passwordAcessoMaquina;
        private DateTime _dataCriacaoMaquina, _ultimoUpdateMaquina;
        private bool _ativoMaquina;
        public FrmListAssists()
        {
            InitializeComponent();
            Utils.Instance.GetClientsList("all");
            cboCliente.Items.Add("Todos");
            foreach (var item in Utils.Instance.ClientsListAll)
                cboCliente.Items.Add(item);
            cboCliente.SelectedIndex = 0;
            cboEmployee.Items.Clear();
            cboEmployee.Items.Add("Todos");
            Utils.Instance.GetEmployeesList("all");
            foreach (var item in Utils.Instance.EmployeeListAll)
                cboEmployee.Items.Add(item);
            cboEmployee.SelectedIndex = 0;
        }

        private void cboMaquina_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && Convert.ToBoolean(dataGridView1.CurrentRow.Cells[8].Value.ToString()))
                Database.Instance.ConcludeAssistance(dataGridView1.CurrentRow.Cells[0].Value.ToString(), "false");
            else if (dataGridView1.CurrentRow != null)
                Database.Instance.ConcludeAssistance(dataGridView1.CurrentRow.Cells[0].Value.ToString(), "true");
            UpdateDataGridView();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnConclude.Enabled = true;
            if (dataGridView1.CurrentRow != null && Convert.ToBoolean(dataGridView1.CurrentRow.Cells[8].Value.ToString()))
                btnConclude.Text = @"Não Concluida";
            else
                btnConclude.Text = @"Concluida";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void chkBetween_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBetween.Checked)
            {
                label4.Visible = true;
                mskFim.Visible = true;
                btnPesquisar.Location = new Point(458, 87);
            }
            else
            {
                label4.Visible = false;
                mskFim.Visible = false;
                btnPesquisar.Location = new Point(289, 87);
            }
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCliente.SelectedIndex != 0)
            {
                cboMaquina.Items.Clear();
                cboMaquina.Items.Add("Todas");
                GetMachines($"SELECT * FROM Maquinas WHERE idCliente = {Utils.Instance.ClientsListAll[cboCliente.SelectedIndex - 1].GetClientId()}");
                cboMaquina.Enabled = true;
                cboMaquina.SelectedIndex = 0;
            }
            else
            {
                cboMaquina.Items.Clear();
                cboMaquina.Enabled = false;
            }
            UpdateDataGridView();
        }

        private void cboEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            try
            {
                var sql =
                    "SELECT Assistencias.idAssistencia AS \'ID\', Clientes.nome AS \'Client\', Maquinas.descricao AS \'Machine\',  Funcionarios.nome AS \'Employee\',  Assistencias.dataInicio AS \'Start Date\',  Assistencias.dataFim AS \'End Date\',  Assistencias.horaInicio AS \'Start Time\',  Assistencias.horaFim AS \'End Time\',  Assistencias.concluida AS \'Concluded\',  Assistencias.preco AS \'Price\', Assistencias.observacoes AS \'Comments\' FROM Assistencias INNER JOIN Clientes ON Clientes.idCliente = Assistencias.idCliente INNER JOIN Maquinas ON Maquinas.idMaquina = Assistencias.idMaquina INNER JOIN Funcionarios ON Funcionarios.idFuncionario = Assistencias.idFuncionario";
                DateTime dateTime;
                if (chkBetween.Checked && DateTime.TryParse(mskInicio.Text, out dateTime) && DateTime.TryParse(mskFim.Text, out dateTime))
                {
                    if (cboCliente.SelectedIndex != 0 && cboEmployee.SelectedIndex == 0 && cboMaquina.SelectedIndex == 0)
                        sql +=
                            $" WHERE Assistencias.idCliente={Utils.Instance.ClientsListAll[cboCliente.SelectedIndex - 1].GetClientId()} AND Assistencias.dataInicio LIKE \'%{mskInicio.Text}%\'";
                    else if (cboCliente.SelectedIndex != 0 && cboMaquina.SelectedIndex != 0 &&
                             cboEmployee.SelectedIndex == 0)
                        sql +=
                            $" WHERE Assistencias.idCliente={Utils.Instance.ClientsListAll[cboCliente.SelectedIndex - 1].GetClientId()} AND Assistencias.idMaquina={_machines[cboMaquina.SelectedIndex - 1].GetMachineId()} AND Assistencias.dataInicio BETWEEN \'%{mskInicio.Text}%\' AND \'%{mskFim.Text}%\'";
                    else if (cboCliente.SelectedIndex != 0 && cboMaquina.SelectedIndex != 0 &&
                             cboEmployee.SelectedIndex != 0)
                        sql +=
                            $" WHERE Assistencias.idCliente={Utils.Instance.ClientsListAll[cboCliente.SelectedIndex - 1].GetClientId()} AND Assistencias.idMaquina={_machines[cboMaquina.SelectedIndex - 1].GetMachineId()} AND Assistencias.idFuncionario = {Utils.Instance.EmployeeListAll[cboEmployee.SelectedIndex - 1].GetEmployeeId()} AND Assistencias.dataInicio BETWEEN \'%{mskInicio.Text}%\' AND \'%{mskFim.Text}%\'";
                }
                else
                {
                    if (!DateTime.TryParse(mskInicio.Text, out dateTime))
                    {
                        if (cboCliente.SelectedIndex != 0 && cboEmployee.SelectedIndex == 0 &&
                            cboMaquina.SelectedIndex == 0)
                            sql +=
                                $" WHERE Assistencias.idCliente={Utils.Instance.ClientsListAll[cboCliente.SelectedIndex - 1].GetClientId()}";
                        else if (cboCliente.SelectedIndex != 0 && cboMaquina.SelectedIndex != 0 &&
                                 cboEmployee.SelectedIndex == 0)
                            sql +=
                                $" WHERE Assistencias.idCliente={Utils.Instance.ClientsListAll[cboCliente.SelectedIndex - 1].GetClientId()} AND Assistencias.idMaquina={_machines[cboMaquina.SelectedIndex - 1].GetMachineId()}";
                        else if (cboCliente.SelectedIndex != 0 && cboMaquina.SelectedIndex != 0 &&
                                 cboEmployee.SelectedIndex != 0)
                            sql +=
                                $" WHERE Assistencias.idCliente={Utils.Instance.ClientsListAll[cboCliente.SelectedIndex - 1].GetClientId()} AND Assistencias.idMaquina={_machines[cboMaquina.SelectedIndex - 1].GetMachineId()} AND Assistencias.idFuncionario = {Utils.Instance.EmployeeListAll[cboEmployee.SelectedIndex - 1].GetEmployeeId()}";
                    }
                    else
                    {
                        if (cboCliente.SelectedIndex != 0 && cboEmployee.SelectedIndex == 0 &&
                            cboMaquina.SelectedIndex == 0)
                            sql +=
                                $" WHERE Assistencias.idCliente={Utils.Instance.ClientsListAll[cboCliente.SelectedIndex - 1].GetClientId()} AND Assistencias.dataInicio LIKE \'%{mskInicio.Text}%\'";
                        else if (cboCliente.SelectedIndex != 0 && cboMaquina.SelectedIndex != 0 &&
                                 cboEmployee.SelectedIndex == 0)
                            sql +=
                                $" WHERE Assistencias.idCliente={Utils.Instance.ClientsListAll[cboCliente.SelectedIndex - 1].GetClientId()} AND Assistencias.idMaquina={_machines[cboMaquina.SelectedIndex - 1].GetMachineId()} AND Assistencias.dataInicio LIKE \'%{mskInicio.Text}%\'";
                        else if (cboCliente.SelectedIndex != 0 && cboMaquina.SelectedIndex != 0 &&
                                 cboEmployee.SelectedIndex != 0)
                            sql +=
                                $" WHERE Assistencias.idCliente={Utils.Instance.ClientsListAll[cboCliente.SelectedIndex - 1].GetClientId()} AND Assistencias.idMaquina={_machines[cboMaquina.SelectedIndex - 1].GetMachineId()} AND Assistencias.idFuncionario = {Utils.Instance.EmployeeListAll[cboEmployee.SelectedIndex - 1].GetEmployeeId()} AND Assistencias.dataInicio LIKE \'%{mskInicio.Text}%\'";
                        else
                            sql += $" WHERE Assistencias.dataInicio LIKE \'%{mskInicio.Text}%\'";
                    }
                }
                dataGridView1.DataSource = Database.Instance.SqlQuery(sql);
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }

        private void GetMachines(string sql)
        {
            var data = Database.Instance.SqlQuery(sql);
            _machines = new List<Machine>();
            for (var i = 0; i < data.Rows.Count; i++)
            {
                try { _idMaquina = Convert.ToUInt32(data.Rows[i][0]); } catch (Exception) { _idMaquina = 0; }
                try { _idClienteMaquina = Convert.ToUInt32(data.Rows[i][1]); } catch (Exception) { _idClienteMaquina = 0; }
                try { _descricaoMaquina = (string)data.Rows[i][2]; } catch (Exception) { _descricaoMaquina = ""; }
                try { _ipMaquina = (string)data.Rows[i][3]; } catch (Exception) { _ipMaquina = ""; }
                try { _loginAcessoMaquina = (string)data.Rows[i][4]; } catch (Exception) { _loginAcessoMaquina = ""; }
                try { _passwordAcessoMaquina = (string)data.Rows[i][5]; } catch (Exception) { _passwordAcessoMaquina = ""; }
                try { _dataCriacaoMaquina = DateTime.Parse(data.Rows[i][6].ToString()); } catch (Exception) { _dataCriacaoMaquina = new DateTime(); }
                try { _ultimoUpdateMaquina = DateTime.Parse(data.Rows[i][7].ToString()); } catch (Exception) { _ultimoUpdateMaquina = new DateTime(); }
                try { _ativoMaquina = (bool)data.Rows[i][8]; } catch (Exception) { _ativoMaquina = false; }
                _machines.Add(new Machine(_idMaquina,
                                            _idClienteMaquina,
                                            _descricaoMaquina,
                                            _ipMaquina,
                                            _loginAcessoMaquina,
                                            _passwordAcessoMaquina,
                                            _dataCriacaoMaquina,
                                            _ultimoUpdateMaquina,
                                            _ativoMaquina));
                cboMaquina.Items.Add(_machines[i].ToString());
            }
        }
    }
}