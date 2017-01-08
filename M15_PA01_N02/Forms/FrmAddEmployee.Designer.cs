namespace M15_PA01_N02.Forms
{
    partial class FrmAddEmployee
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddEmployee));
            this.txtBirthday = new System.Windows.Forms.MaskedTextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnChoosePhoto = new System.Windows.Forms.Button();
            this.imgProfilePhoto = new System.Windows.Forms.PictureBox();
            this.txtObservations = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtNCC = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgProfilePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBirthday
            // 
            this.txtBirthday.Location = new System.Drawing.Point(166, 89);
            this.txtBirthday.Mask = "00/00/0000";
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(213, 20);
            this.txtBirthday.TabIndex = 29;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(166, 167);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(213, 20);
            this.txtMail.TabIndex = 34;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(479, 315);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 34);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "&Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Email:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(398, 315);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 34);
            this.btnOk.TabIndex = 39;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnChoosePhoto
            // 
            this.btnChoosePhoto.Location = new System.Drawing.Point(397, 167);
            this.btnChoosePhoto.Name = "btnChoosePhoto";
            this.btnChoosePhoto.Size = new System.Drawing.Size(155, 20);
            this.btnChoosePhoto.TabIndex = 38;
            this.btnChoosePhoto.Text = "&Escolher Foto";
            this.btnChoosePhoto.UseVisualStyleBackColor = true;
            this.btnChoosePhoto.Click += new System.EventHandler(this.btnChoosePhoto_Click);
            // 
            // imgProfilePhoto
            // 
            this.imgProfilePhoto.Location = new System.Drawing.Point(397, 11);
            this.imgProfilePhoto.Name = "imgProfilePhoto";
            this.imgProfilePhoto.Size = new System.Drawing.Size(155, 150);
            this.imgProfilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgProfilePhoto.TabIndex = 41;
            this.imgProfilePhoto.TabStop = false;
            // 
            // txtObservations
            // 
            this.txtObservations.Location = new System.Drawing.Point(166, 195);
            this.txtObservations.Multiline = true;
            this.txtObservations.Name = "txtObservations";
            this.txtObservations.Size = new System.Drawing.Size(213, 76);
            this.txtObservations.TabIndex = 37;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(166, 141);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(213, 20);
            this.txtPhone.TabIndex = 32;
            // 
            // txtNCC
            // 
            this.txtNCC.Location = new System.Drawing.Point(166, 115);
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(213, 20);
            this.txtNCC.TabIndex = 30;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(166, 63);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(213, 20);
            this.txtPassword.TabIndex = 28;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.MouseHover += new System.EventHandler(this.txtPassword_MouseHover);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(166, 37);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(213, 20);
            this.txtUsername.TabIndex = 26;
            this.txtUsername.MouseHover += new System.EventHandler(this.txtUsername_MouseHover);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(166, 11);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 20);
            this.txtName.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(88, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Observações:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Telefone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Número de Cartão de Cidadão:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Data de Nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nome:";
            // 
            // FrmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 361);
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnChoosePhoto);
            this.Controls.Add(this.imgProfilePhoto);
            this.Controls.Add(this.txtObservations);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtNCC);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Now Assist > Adicionar Funcionário";
            ((System.ComponentModel.ISupportInitialize)(this.imgProfilePhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtBirthday;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnChoosePhoto;
        private System.Windows.Forms.PictureBox imgProfilePhoto;
        private System.Windows.Forms.TextBox txtObservations;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtNCC;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}