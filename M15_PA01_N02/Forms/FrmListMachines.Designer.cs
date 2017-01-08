namespace M15_PA01_N02.Forms
{
    partial class FrmListMachines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListMachines));
            this.cboContent = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.dgvMachines = new System.Windows.Forms.DataGridView();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblMPC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachines)).BeginInit();
            this.SuspendLayout();
            // 
            // cboContent
            // 
            this.cboContent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboContent.FormattingEnabled = true;
            this.cboContent.Items.AddRange(new object[] {
            "Máquinas Ativas",
            "Máquinas Inativas",
            "Máquinas Todas"});
            this.cboContent.Location = new System.Drawing.Point(664, 17);
            this.cboContent.Name = "cboContent";
            this.cboContent.Size = new System.Drawing.Size(203, 21);
            this.cboContent.TabIndex = 25;
            this.cboContent.SelectedIndexChanged += new System.EventHandler(this.cboContent_SelectedIndexChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(792, 338);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 34);
            this.btnOk.TabIndex = 24;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // dgvMachines
            // 
            this.dgvMachines.AllowUserToAddRows = false;
            this.dgvMachines.AllowUserToDeleteRows = false;
            this.dgvMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMachines.Location = new System.Drawing.Point(57, 44);
            this.dgvMachines.Name = "dgvMachines";
            this.dgvMachines.ReadOnly = true;
            this.dgvMachines.Size = new System.Drawing.Size(810, 282);
            this.dgvMachines.TabIndex = 23;
            this.dgvMachines.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMachines_CellClick);
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(56, 17);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(602, 21);
            this.cboCliente.TabIndex = 22;
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Cliente:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(630, 338);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 34);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(711, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 27;
            this.button2.Text = "E&ditar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblMPC
            // 
            this.lblMPC.AutoSize = true;
            this.lblMPC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMPC.Location = new System.Drawing.Point(461, 349);
            this.lblMPC.Name = "lblMPC";
            this.lblMPC.Size = new System.Drawing.Size(163, 13);
            this.lblMPC.TabIndex = 28;
            this.lblMPC.Text = "Ver total de Máquinas por Cliente";
            this.lblMPC.Click += new System.EventHandler(this.lblMPC_Click);
            this.lblMPC.MouseHover += new System.EventHandler(this.lblMPC_MouseHover);
            // 
            // FrmListMachines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 384);
            this.Controls.Add(this.lblMPC);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.cboContent);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dgvMachines);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListMachines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Now Assist > Ver Máquinas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboContent;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridView dgvMachines;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblMPC;
    }
}