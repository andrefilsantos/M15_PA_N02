namespace M15_TP01_N02
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.picLogoESEN = new System.Windows.Forms.PictureBox();
            this.picLogosCP = new System.Windows.Forms.PictureBox();
            this.lblSobreAutores = new System.Windows.Forms.Label();
            this.lblSobre = new System.Windows.Forms.Label();
            this.lblSobreCopyrights = new System.Windows.Forms.Label();
            this.btnSobreOK = new System.Windows.Forms.Button();
            this.pnlSobreHeader = new System.Windows.Forms.Panel();
            this.lblSobreVersao = new System.Windows.Forms.Label();
            this.lblSobreNomeProg = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoESEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogosCP)).BeginInit();
            this.pnlSobreHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogoESEN
            // 
            this.picLogoESEN.BackColor = System.Drawing.Color.White;
            this.picLogoESEN.Image = ((System.Drawing.Image)(resources.GetObject("picLogoESEN.Image")));
            this.picLogoESEN.Location = new System.Drawing.Point(322, 280);
            this.picLogoESEN.Name = "picLogoESEN";
            this.picLogoESEN.Size = new System.Drawing.Size(63, 35);
            this.picLogoESEN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoESEN.TabIndex = 14;
            this.picLogoESEN.TabStop = false;
            // 
            // picLogosCP
            // 
            this.picLogosCP.Image = ((System.Drawing.Image)(resources.GetObject("picLogosCP.Image")));
            this.picLogosCP.Location = new System.Drawing.Point(384, 280);
            this.picLogosCP.Name = "picLogosCP";
            this.picLogosCP.Size = new System.Drawing.Size(343, 35);
            this.picLogosCP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogosCP.TabIndex = 13;
            this.picLogosCP.TabStop = false;
            // 
            // lblSobreAutores
            // 
            this.lblSobreAutores.AutoSize = true;
            this.lblSobreAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblSobreAutores.Location = new System.Drawing.Point(17, 328);
            this.lblSobreAutores.Name = "lblSobreAutores";
            this.lblSobreAutores.Size = new System.Drawing.Size(106, 17);
            this.lblSobreAutores.TabIndex = 12;
            this.lblSobreAutores.Text = "André Santos";
            // 
            // lblSobre
            // 
            this.lblSobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobre.Location = new System.Drawing.Point(17, 186);
            this.lblSobre.Name = "lblSobre";
            this.lblSobre.Size = new System.Drawing.Size(710, 57);
            this.lblSobre.TabIndex = 11;
            this.lblSobre.Text = resources.GetString("lblSobre.Text");
            // 
            // lblSobreCopyrights
            // 
            this.lblSobreCopyrights.AutoSize = true;
            this.lblSobreCopyrights.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobreCopyrights.Location = new System.Drawing.Point(18, 163);
            this.lblSobreCopyrights.Name = "lblSobreCopyrights";
            this.lblSobreCopyrights.Size = new System.Drawing.Size(408, 15);
            this.lblSobreCopyrights.TabIndex = 10;
            this.lblSobreCopyrights.Text = "Copyright © 2016-2017 Ahiru Productions. All Rights Reserved.";
            // 
            // btnSobreOK
            // 
            this.btnSobreOK.Location = new System.Drawing.Point(627, 321);
            this.btnSobreOK.Name = "btnSobreOK";
            this.btnSobreOK.Size = new System.Drawing.Size(100, 35);
            this.btnSobreOK.TabIndex = 9;
            this.btnSobreOK.Text = "OK";
            this.btnSobreOK.UseVisualStyleBackColor = true;
            this.btnSobreOK.Click += new System.EventHandler(this.btnSobreOK_Click);
            // 
            // pnlSobreHeader
            // 
            this.pnlSobreHeader.BackColor = System.Drawing.Color.White;
            this.pnlSobreHeader.Controls.Add(this.lblSobreVersao);
            this.pnlSobreHeader.Controls.Add(this.lblSobreNomeProg);
            this.pnlSobreHeader.Controls.Add(this.pictureBox1);
            this.pnlSobreHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSobreHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlSobreHeader.Name = "pnlSobreHeader";
            this.pnlSobreHeader.Size = new System.Drawing.Size(745, 150);
            this.pnlSobreHeader.TabIndex = 8;
            // 
            // lblSobreVersao
            // 
            this.lblSobreVersao.AutoSize = true;
            this.lblSobreVersao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblSobreVersao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(180)))), ((int)(((byte)(29)))));
            this.lblSobreVersao.Location = new System.Drawing.Point(26, 96);
            this.lblSobreVersao.Name = "lblSobreVersao";
            this.lblSobreVersao.Size = new System.Drawing.Size(63, 17);
            this.lblSobreVersao.TabIndex = 2;
            this.lblSobreVersao.Text = "2.12.12";
            // 
            // lblSobreNomeProg
            // 
            this.lblSobreNomeProg.AutoSize = true;
            this.lblSobreNomeProg.Font = new System.Drawing.Font("Microsoft Sans Serif", 39F, System.Drawing.FontStyle.Bold);
            this.lblSobreNomeProg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.lblSobreNomeProg.Location = new System.Drawing.Point(13, 19);
            this.lblSobreNomeProg.Name = "lblSobreNomeProg";
            this.lblSobreNomeProg.Size = new System.Drawing.Size(292, 59);
            this.lblSobreNomeProg.TabIndex = 1;
            this.lblSobreNomeProg.Text = "Now Assist";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(571, -39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 363);
            this.Controls.Add(this.picLogoESEN);
            this.Controls.Add(this.picLogosCP);
            this.Controls.Add(this.lblSobreAutores);
            this.Controls.Add(this.lblSobre);
            this.Controls.Add(this.lblSobreCopyrights);
            this.Controls.Add(this.btnSobreOK);
            this.Controls.Add(this.pnlSobreHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre";
            ((System.ComponentModel.ISupportInitialize)(this.picLogoESEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogosCP)).EndInit();
            this.pnlSobreHeader.ResumeLayout(false);
            this.pnlSobreHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogoESEN;
        private System.Windows.Forms.PictureBox picLogosCP;
        private System.Windows.Forms.Label lblSobreAutores;
        private System.Windows.Forms.Label lblSobre;
        private System.Windows.Forms.Label lblSobreCopyrights;
        private System.Windows.Forms.Button btnSobreOK;
        private System.Windows.Forms.Panel pnlSobreHeader;
        private System.Windows.Forms.Label lblSobreVersao;
        private System.Windows.Forms.Label lblSobreNomeProg;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}