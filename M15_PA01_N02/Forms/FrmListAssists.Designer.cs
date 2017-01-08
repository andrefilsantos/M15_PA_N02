namespace M15_PA01_N02.Forms
{
    partial class FrmListAssists
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListAssists));
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.mskFim = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkBetween = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskInicio = new System.Windows.Forms.MaskedTextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cboMaquina = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEmployee = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConclude = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(289, 87);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(21, 20);
            this.btnPesquisar.TabIndex = 31;
            this.btnPesquisar.Text = ">";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // mskFim
            // 
            this.mskFim.Location = new System.Drawing.Point(308, 87);
            this.mskFim.Mask = "0000-00-00";
            this.mskFim.Name = "mskFim";
            this.mskFim.Size = new System.Drawing.Size(144, 20);
            this.mskFim.TabIndex = 30;
            this.mskFim.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "e";
            this.label4.Visible = false;
            // 
            // chkBetween
            // 
            this.chkBetween.AutoSize = true;
            this.chkBetween.Location = new System.Drawing.Point(76, 89);
            this.chkBetween.Name = "chkBetween";
            this.chkBetween.Size = new System.Drawing.Size(51, 17);
            this.chkBetween.TabIndex = 28;
            this.chkBetween.Text = "Entre";
            this.chkBetween.UseVisualStyleBackColor = true;
            this.chkBetween.CheckedChanged += new System.EventHandler(this.chkBetween_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Data:";
            // 
            // mskInicio
            // 
            this.mskInicio.Location = new System.Drawing.Point(139, 87);
            this.mskInicio.Mask = "0000-00-00";
            this.mskInicio.Name = "mskInicio";
            this.mskInicio.Size = new System.Drawing.Size(144, 20);
            this.mskInicio.TabIndex = 26;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(1171, 400);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 34);
            this.btnOk.TabIndex = 25;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(68, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1182, 282);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cboMaquina
            // 
            this.cboMaquina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaquina.Enabled = false;
            this.cboMaquina.FormattingEnabled = true;
            this.cboMaquina.Location = new System.Drawing.Point(68, 33);
            this.cboMaquina.Name = "cboMaquina";
            this.cboMaquina.Size = new System.Drawing.Size(1182, 21);
            this.cboMaquina.TabIndex = 23;
            this.cboMaquina.SelectedIndexChanged += new System.EventHandler(this.cboMaquina_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Máquina:";
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(68, 6);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(1182, 21);
            this.cboCliente.TabIndex = 21;
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cliente:";
            // 
            // cboEmployee
            // 
            this.cboEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmployee.FormattingEnabled = true;
            this.cboEmployee.Location = new System.Drawing.Point(68, 60);
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.Size = new System.Drawing.Size(1182, 21);
            this.cboEmployee.TabIndex = 33;
            this.cboEmployee.SelectedIndexChanged += new System.EventHandler(this.cboEmployee_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Funcionário:";
            // 
            // btnConclude
            // 
            this.btnConclude.Enabled = false;
            this.btnConclude.Location = new System.Drawing.Point(1090, 400);
            this.btnConclude.Name = "btnConclude";
            this.btnConclude.Size = new System.Drawing.Size(75, 34);
            this.btnConclude.TabIndex = 34;
            this.btnConclude.Text = "Concluida";
            this.btnConclude.UseVisualStyleBackColor = true;
            this.btnConclude.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmListAssists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 441);
            this.Controls.Add(this.btnConclude);
            this.Controls.Add(this.cboEmployee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.mskFim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkBetween);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskInicio);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboMaquina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListAssists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Now Assist > Ver Assistências";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.MaskedTextBox mskFim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkBetween;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskInicio;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cboMaquina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEmployee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConclude;
    }
}