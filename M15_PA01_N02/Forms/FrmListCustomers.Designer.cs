namespace M15_PA01_N02.Forms
{
    partial class FrmListCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListCustomers));
            this.cboContent = new System.Windows.Forms.ComboBox();
            this.lstClients = new System.Windows.Forms.ListBox();
            this.tbcDadosPessoais = new System.Windows.Forms.TabControl();
            this.tpDadosPessoais = new System.Windows.Forms.TabPage();
            this.lblTelemovel = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblRepresentante = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblFax = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCodPostal = new System.Windows.Forms.Label();
            this.lblLocalidade = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblSite = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.tbcDadosPessoais.SuspendLayout();
            this.tpDadosPessoais.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboContent
            // 
            this.cboContent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboContent.FormattingEnabled = true;
            this.cboContent.Items.AddRange(new object[] {
            "Ativos",
            "Inativos",
            "Todos"});
            this.cboContent.Location = new System.Drawing.Point(433, 37);
            this.cboContent.Name = "cboContent";
            this.cboContent.Size = new System.Drawing.Size(149, 21);
            this.cboContent.TabIndex = 27;
            this.cboContent.SelectedIndexChanged += new System.EventHandler(this.cboContent_SelectedIndexChanged);
            // 
            // lstClients
            // 
            this.lstClients.FormattingEnabled = true;
            this.lstClients.Location = new System.Drawing.Point(432, 63);
            this.lstClients.Name = "lstClients";
            this.lstClients.Size = new System.Drawing.Size(150, 355);
            this.lstClients.TabIndex = 22;
            this.lstClients.SelectedIndexChanged += new System.EventHandler(this.lstClients_SelectedIndexChanged);
            // 
            // tbcDadosPessoais
            // 
            this.tbcDadosPessoais.Controls.Add(this.tpDadosPessoais);
            this.tbcDadosPessoais.Location = new System.Drawing.Point(13, 15);
            this.tbcDadosPessoais.Name = "tbcDadosPessoais";
            this.tbcDadosPessoais.SelectedIndex = 0;
            this.tbcDadosPessoais.Size = new System.Drawing.Size(417, 444);
            this.tbcDadosPessoais.TabIndex = 21;
            // 
            // tpDadosPessoais
            // 
            this.tpDadosPessoais.Controls.Add(this.lblTelemovel);
            this.tpDadosPessoais.Controls.Add(this.lblEmail);
            this.tpDadosPessoais.Controls.Add(this.lblObservacoes);
            this.tpDadosPessoais.Controls.Add(this.lblTelefone);
            this.tpDadosPessoais.Controls.Add(this.lblRepresentante);
            this.tpDadosPessoais.Controls.Add(this.lblNome);
            this.tpDadosPessoais.Controls.Add(this.lblFax);
            this.tpDadosPessoais.Controls.Add(this.groupBox1);
            this.tpDadosPessoais.Controls.Add(this.lblSite);
            this.tpDadosPessoais.Controls.Add(this.btnEditar);
            this.tpDadosPessoais.Controls.Add(this.btnEliminar);
            this.tpDadosPessoais.Location = new System.Drawing.Point(4, 22);
            this.tpDadosPessoais.Name = "tpDadosPessoais";
            this.tpDadosPessoais.Padding = new System.Windows.Forms.Padding(3);
            this.tpDadosPessoais.Size = new System.Drawing.Size(409, 418);
            this.tpDadosPessoais.TabIndex = 0;
            this.tpDadosPessoais.Text = "Dados Pessoais";
            this.tpDadosPessoais.UseVisualStyleBackColor = true;
            // 
            // lblTelemovel
            // 
            this.lblTelemovel.AutoSize = true;
            this.lblTelemovel.Location = new System.Drawing.Point(62, 120);
            this.lblTelemovel.Name = "lblTelemovel";
            this.lblTelemovel.Size = new System.Drawing.Size(52, 13);
            this.lblTelemovel.TabIndex = 55;
            this.lblTelemovel.Text = "Telefone:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(79, 172);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 53;
            this.lblEmail.Text = "Email:";
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Location = new System.Drawing.Point(41, 306);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(73, 13);
            this.lblObservacoes.TabIndex = 51;
            this.lblObservacoes.Text = "Observações:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(62, 94);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 50;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblRepresentante
            // 
            this.lblRepresentante.AutoSize = true;
            this.lblRepresentante.Location = new System.Drawing.Point(34, 42);
            this.lblRepresentante.Name = "lblRepresentante";
            this.lblRepresentante.Size = new System.Drawing.Size(80, 13);
            this.lblRepresentante.TabIndex = 49;
            this.lblRepresentante.Text = "Representante:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(76, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 47;
            this.lblNome.Text = "Nome:";
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(87, 146);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(27, 13);
            this.lblFax.TabIndex = 54;
            this.lblFax.Text = "Fax:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCodPostal);
            this.groupBox1.Controls.Add(this.lblLocalidade);
            this.groupBox1.Controls.Add(this.lblRua);
            this.groupBox1.Location = new System.Drawing.Point(14, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 100);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Morada ";
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.Location = new System.Drawing.Point(22, 72);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(75, 13);
            this.lblCodPostal.TabIndex = 2;
            this.lblCodPostal.Text = "Código Postal:";
            // 
            // lblLocalidade
            // 
            this.lblLocalidade.AutoSize = true;
            this.lblLocalidade.Location = new System.Drawing.Point(35, 46);
            this.lblLocalidade.Name = "lblLocalidade";
            this.lblLocalidade.Size = new System.Drawing.Size(62, 13);
            this.lblLocalidade.TabIndex = 1;
            this.lblLocalidade.Text = "Localidade:";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(67, 20);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(30, 13);
            this.lblRua.TabIndex = 0;
            this.lblRua.Text = "Rua:";
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(86, 67);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(28, 13);
            this.lblSite.TabIndex = 48;
            this.lblSite.Text = "Site:";
            // 
            // btnEditar
            // 
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(203, 376);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(97, 36);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(306, 376);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(97, 36);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "E&liminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(510, 424);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(35, 35);
            this.btnProximo.TabIndex = 25;
            this.btnProximo.Text = ">";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(472, 424);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(35, 35);
            this.btnAnterior.TabIndex = 24;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Location = new System.Drawing.Point(432, 424);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(35, 35);
            this.btnPrimeiro.TabIndex = 23;
            this.btnPrimeiro.Text = "|<";
            this.btnPrimeiro.UseVisualStyleBackColor = true;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(547, 424);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(35, 35);
            this.btnUltimo.TabIndex = 26;
            this.btnUltimo.Text = ">|";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // FrmListCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 471);
            this.Controls.Add(this.cboContent);
            this.Controls.Add(this.lstClients);
            this.Controls.Add(this.tbcDadosPessoais);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimeiro);
            this.Controls.Add(this.btnUltimo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Now Assist > Ver Clientes";
            this.tbcDadosPessoais.ResumeLayout(false);
            this.tpDadosPessoais.ResumeLayout(false);
            this.tpDadosPessoais.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboContent;
        private System.Windows.Forms.ListBox lstClients;
        private System.Windows.Forms.TabControl tbcDadosPessoais;
        private System.Windows.Forms.TabPage tpDadosPessoais;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Label lblTelemovel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblObservacoes;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblRepresentante;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCodPostal;
        private System.Windows.Forms.Label lblLocalidade;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblSite;
    }
}