namespace M15_PA01_N02.Forms
{
    partial class FrmListEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListEmployees));
            this.cboContent = new System.Windows.Forms.ComboBox();
            this.lstClients = new System.Windows.Forms.ListBox();
            this.tbcDadosPessoais = new System.Windows.Forms.TabControl();
            this.tpDadosPessoais = new System.Windows.Forms.TabPage();
            this.lblEmail = new System.Windows.Forms.Label();
            this.imgProfilePhoto = new System.Windows.Forms.PictureBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblNcc = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.tbcDadosPessoais.SuspendLayout();
            this.tpDadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfilePhoto)).BeginInit();
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
            this.cboContent.Location = new System.Drawing.Point(564, 37);
            this.cboContent.Name = "cboContent";
            this.cboContent.Size = new System.Drawing.Size(149, 21);
            this.cboContent.TabIndex = 34;
            this.cboContent.SelectedIndexChanged += new System.EventHandler(this.cboContent_SelectedIndexChanged);
            // 
            // lstClients
            // 
            this.lstClients.FormattingEnabled = true;
            this.lstClients.Location = new System.Drawing.Point(563, 63);
            this.lstClients.Name = "lstClients";
            this.lstClients.Size = new System.Drawing.Size(150, 212);
            this.lstClients.TabIndex = 29;
            this.lstClients.SelectedIndexChanged += new System.EventHandler(this.lstClients_SelectedIndexChanged);
            // 
            // tbcDadosPessoais
            // 
            this.tbcDadosPessoais.Controls.Add(this.tpDadosPessoais);
            this.tbcDadosPessoais.Location = new System.Drawing.Point(7, 15);
            this.tbcDadosPessoais.Name = "tbcDadosPessoais";
            this.tbcDadosPessoais.SelectedIndex = 0;
            this.tbcDadosPessoais.Size = new System.Drawing.Size(555, 301);
            this.tbcDadosPessoais.TabIndex = 28;
            // 
            // tpDadosPessoais
            // 
            this.tpDadosPessoais.Controls.Add(this.lblEmail);
            this.tpDadosPessoais.Controls.Add(this.imgProfilePhoto);
            this.tpDadosPessoais.Controls.Add(this.lblComments);
            this.tpDadosPessoais.Controls.Add(this.lblPhone);
            this.tpDadosPessoais.Controls.Add(this.lblNcc);
            this.tpDadosPessoais.Controls.Add(this.lblBirthday);
            this.tpDadosPessoais.Controls.Add(this.lblUsername);
            this.tpDadosPessoais.Controls.Add(this.lblName);
            this.tpDadosPessoais.Controls.Add(this.btnEditar);
            this.tpDadosPessoais.Controls.Add(this.btnEliminar);
            this.tpDadosPessoais.Location = new System.Drawing.Point(4, 22);
            this.tpDadosPessoais.Name = "tpDadosPessoais";
            this.tpDadosPessoais.Padding = new System.Windows.Forms.Padding(3);
            this.tpDadosPessoais.Size = new System.Drawing.Size(547, 275);
            this.tpDadosPessoais.TabIndex = 0;
            this.tpDadosPessoais.Text = "Dados Pessoais";
            this.tpDadosPessoais.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(124, 158);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 63;
            this.lblEmail.Text = "Email:";
            // 
            // imgProfilePhoto
            // 
            this.imgProfilePhoto.Location = new System.Drawing.Point(374, 22);
            this.imgProfilePhoto.Name = "imgProfilePhoto";
            this.imgProfilePhoto.Size = new System.Drawing.Size(155, 150);
            this.imgProfilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgProfilePhoto.TabIndex = 62;
            this.imgProfilePhoto.TabStop = false;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(86, 181);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(73, 13);
            this.lblComments.TabIndex = 56;
            this.lblComments.Text = "Observações:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(107, 132);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(52, 13);
            this.lblPhone.TabIndex = 54;
            this.lblPhone.Text = "Telefone:";
            // 
            // lblNcc
            // 
            this.lblNcc.AutoSize = true;
            this.lblNcc.Location = new System.Drawing.Point(6, 106);
            this.lblNcc.Name = "lblNcc";
            this.lblNcc.Size = new System.Drawing.Size(153, 13);
            this.lblNcc.TabIndex = 52;
            this.lblNcc.Text = "Número de Cartão de Cidadão:";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(52, 79);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(107, 13);
            this.lblBirthday.TabIndex = 48;
            this.lblBirthday.Text = "Data de Nascimento:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(101, 55);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 45;
            this.lblUsername.Text = "Username:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(121, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 43;
            this.lblName.Text = "Nome:";
            // 
            // btnEditar
            // 
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(341, 233);
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
            this.btnEliminar.Location = new System.Drawing.Point(444, 233);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(97, 36);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "E&liminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(641, 281);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(35, 35);
            this.btnProximo.TabIndex = 32;
            this.btnProximo.Text = ">";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(603, 281);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(35, 35);
            this.btnAnterior.TabIndex = 31;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Location = new System.Drawing.Point(563, 281);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(35, 35);
            this.btnPrimeiro.TabIndex = 30;
            this.btnPrimeiro.Text = "|<";
            this.btnPrimeiro.UseVisualStyleBackColor = true;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(678, 281);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(35, 35);
            this.btnUltimo.TabIndex = 33;
            this.btnUltimo.Text = ">|";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // FrmListEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 331);
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
            this.Name = "FrmListEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Now Assist > Ver Funcionários";
            this.Activated += new System.EventHandler(this.FrmListEmployees_Activated);
            this.tbcDadosPessoais.ResumeLayout(false);
            this.tpDadosPessoais.ResumeLayout(false);
            this.tpDadosPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfilePhoto)).EndInit();
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
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.PictureBox imgProfilePhoto;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblNcc;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblName;
    }
}