namespace M15_PA01_N02.Forms
{
    partial class FrmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            this.dgvAssistenciasAmanha = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvAssistenciasHoje = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvAssistenciasInacabadas = new System.Windows.Forms.DataGridView();
            this.lblClienteMaisAssistido = new System.Windows.Forms.Label();
            this.lblMediaAssistencias = new System.Windows.Forms.Label();
            this.lblTotalAssistencias = new System.Windows.Forms.Label();
            this.lblTotalAssistenciasUltimos7Dias = new System.Windows.Forms.Label();
            this.lblAssistenciasInacabadas = new System.Windows.Forms.Label();
            this.lblAssistenciasAcabadas = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imgProfile = new System.Windows.Forms.PictureBox();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.assistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAssistanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listAssistancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.machinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMachineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listMachinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.terminarAssistênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvAssistenciasAmanha.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssistenciasHoje)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssistenciasInacabadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfile)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAssistenciasAmanha
            // 
            this.dgvAssistenciasAmanha.Controls.Add(this.tabPage1);
            this.dgvAssistenciasAmanha.Controls.Add(this.tabPage3);
            this.dgvAssistenciasAmanha.Location = new System.Drawing.Point(12, 108);
            this.dgvAssistenciasAmanha.Name = "dgvAssistenciasAmanha";
            this.dgvAssistenciasAmanha.SelectedIndex = 0;
            this.dgvAssistenciasAmanha.Size = new System.Drawing.Size(645, 340);
            this.dgvAssistenciasAmanha.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvAssistenciasHoje);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(637, 314);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hoje";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvAssistenciasHoje
            // 
            this.dgvAssistenciasHoje.AllowUserToAddRows = false;
            this.dgvAssistenciasHoje.AllowUserToDeleteRows = false;
            this.dgvAssistenciasHoje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssistenciasHoje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAssistenciasHoje.Location = new System.Drawing.Point(3, 3);
            this.dgvAssistenciasHoje.Name = "dgvAssistenciasHoje";
            this.dgvAssistenciasHoje.ReadOnly = true;
            this.dgvAssistenciasHoje.Size = new System.Drawing.Size(631, 308);
            this.dgvAssistenciasHoje.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvAssistenciasInacabadas);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(637, 314);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Inacabadas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvAssistenciasInacabadas
            // 
            this.dgvAssistenciasInacabadas.AllowUserToAddRows = false;
            this.dgvAssistenciasInacabadas.AllowUserToDeleteRows = false;
            this.dgvAssistenciasInacabadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssistenciasInacabadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAssistenciasInacabadas.Location = new System.Drawing.Point(0, 0);
            this.dgvAssistenciasInacabadas.Name = "dgvAssistenciasInacabadas";
            this.dgvAssistenciasInacabadas.ReadOnly = true;
            this.dgvAssistenciasInacabadas.Size = new System.Drawing.Size(637, 314);
            this.dgvAssistenciasInacabadas.TabIndex = 0;
            this.dgvAssistenciasInacabadas.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAssistenciasInacabadas_CellMouseDown);
            // 
            // lblClienteMaisAssistido
            // 
            this.lblClienteMaisAssistido.AutoSize = true;
            this.lblClienteMaisAssistido.Location = new System.Drawing.Point(6, 138);
            this.lblClienteMaisAssistido.Name = "lblClienteMaisAssistido";
            this.lblClienteMaisAssistido.Size = new System.Drawing.Size(109, 13);
            this.lblClienteMaisAssistido.TabIndex = 13;
            this.lblClienteMaisAssistido.Text = "Cliente mais assistido:";
            // 
            // lblMediaAssistencias
            // 
            this.lblMediaAssistencias.AutoSize = true;
            this.lblMediaAssistencias.Location = new System.Drawing.Point(6, 26);
            this.lblMediaAssistencias.Name = "lblMediaAssistencias";
            this.lblMediaAssistencias.Size = new System.Drawing.Size(150, 13);
            this.lblMediaAssistencias.TabIndex = 8;
            this.lblMediaAssistencias.Text = "Média de Assistências por dia:";
            // 
            // lblTotalAssistencias
            // 
            this.lblTotalAssistencias.AutoSize = true;
            this.lblTotalAssistencias.Location = new System.Drawing.Point(6, 116);
            this.lblTotalAssistencias.Name = "lblTotalAssistencias";
            this.lblTotalAssistencias.Size = new System.Drawing.Size(110, 13);
            this.lblTotalAssistencias.TabIndex = 12;
            this.lblTotalAssistencias.Text = "Total de Assistências:";
            // 
            // lblTotalAssistenciasUltimos7Dias
            // 
            this.lblTotalAssistenciasUltimos7Dias.AutoSize = true;
            this.lblTotalAssistenciasUltimos7Dias.Location = new System.Drawing.Point(6, 48);
            this.lblTotalAssistenciasUltimos7Dias.Name = "lblTotalAssistenciasUltimos7Dias";
            this.lblTotalAssistenciasUltimos7Dias.Size = new System.Drawing.Size(154, 13);
            this.lblTotalAssistenciasUltimos7Dias.TabIndex = 9;
            this.lblTotalAssistenciasUltimos7Dias.Text = "Assistências nos últimos 7 dias:";
            // 
            // lblAssistenciasInacabadas
            // 
            this.lblAssistenciasInacabadas.AutoSize = true;
            this.lblAssistenciasInacabadas.Location = new System.Drawing.Point(6, 95);
            this.lblAssistenciasInacabadas.Name = "lblAssistenciasInacabadas";
            this.lblAssistenciasInacabadas.Size = new System.Drawing.Size(143, 13);
            this.lblAssistenciasInacabadas.TabIndex = 11;
            this.lblAssistenciasInacabadas.Text = "Assistências não concluidas:";
            // 
            // lblAssistenciasAcabadas
            // 
            this.lblAssistenciasAcabadas.AutoSize = true;
            this.lblAssistenciasAcabadas.Location = new System.Drawing.Point(6, 72);
            this.lblAssistenciasAcabadas.Name = "lblAssistenciasAcabadas";
            this.lblAssistenciasAcabadas.Size = new System.Drawing.Size(124, 13);
            this.lblAssistenciasAcabadas.TabIndex = 10;
            this.lblAssistenciasAcabadas.Text = "Assistências concluídas:";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(94, 68);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 34;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "Bem Vindo,";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(94, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 16);
            this.lblName.TabIndex = 32;
            this.lblName.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::M15_PA01_N02.Properties.Resources.Pie_chart_icon;
            this.pictureBox1.Location = new System.Drawing.Point(135, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblClienteMaisAssistido);
            this.groupBox1.Controls.Add(this.lblMediaAssistencias);
            this.groupBox1.Controls.Add(this.lblTotalAssistencias);
            this.groupBox1.Controls.Add(this.lblTotalAssistenciasUltimos7Dias);
            this.groupBox1.Controls.Add(this.lblAssistenciasInacabadas);
            this.groupBox1.Controls.Add(this.lblAssistenciasAcabadas);
            this.groupBox1.Location = new System.Drawing.Point(675, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 320);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " As minhas estatísticas ";
            // 
            // imgProfile
            // 
            this.imgProfile.Image = ((System.Drawing.Image)(resources.GetObject("imgProfile.Image")));
            this.imgProfile.Location = new System.Drawing.Point(12, 26);
            this.imgProfile.Name = "imgProfile";
            this.imgProfile.Size = new System.Drawing.Size(76, 76);
            this.imgProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgProfile.TabIndex = 31;
            this.imgProfile.TabStop = false;
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.AutoSize = true;
            this.lblDiaSemana.Location = new System.Drawing.Point(859, 52);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(30, 13);
            this.lblDiaSemana.TabIndex = 36;
            this.lblDiaSemana.Text = "Data";
            this.lblDiaSemana.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assistsToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(954, 24);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // assistsToolStripMenuItem
            // 
            this.assistsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAssistanceToolStripMenuItem,
            this.listAssistancesToolStripMenuItem});
            this.assistsToolStripMenuItem.Name = "assistsToolStripMenuItem";
            this.assistsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.A)));
            this.assistsToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.assistsToolStripMenuItem.Text = "Assistências";
            // 
            // addAssistanceToolStripMenuItem
            // 
            this.addAssistanceToolStripMenuItem.Name = "addAssistanceToolStripMenuItem";
            this.addAssistanceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.addAssistanceToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.addAssistanceToolStripMenuItem.Text = "Adicionar Assistência";
            this.addAssistanceToolStripMenuItem.Click += new System.EventHandler(this.addAssistanceToolStripMenuItem_Click);
            // 
            // listAssistancesToolStripMenuItem
            // 
            this.listAssistancesToolStripMenuItem.Name = "listAssistancesToolStripMenuItem";
            this.listAssistancesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.listAssistancesToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.listAssistancesToolStripMenuItem.Text = "Listar Assistências";
            this.listAssistancesToolStripMenuItem.Click += new System.EventHandler(this.listAssistancesToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClientToolStripMenuItem,
            this.listClientsToolStripMenuItem,
            this.toolStripSeparator4,
            this.machinesToolStripMenuItem});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientsToolStripMenuItem.Text = "Clientes";
            // 
            // addClientToolStripMenuItem
            // 
            this.addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            this.addClientToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.addClientToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.addClientToolStripMenuItem.Text = "Adicionar Clientes";
            this.addClientToolStripMenuItem.Click += new System.EventHandler(this.addClientToolStripMenuItem_Click);
            // 
            // listClientsToolStripMenuItem
            // 
            this.listClientsToolStripMenuItem.Name = "listClientsToolStripMenuItem";
            this.listClientsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.listClientsToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.listClientsToolStripMenuItem.Text = "Listar Clientes";
            this.listClientsToolStripMenuItem.Click += new System.EventHandler(this.listClientsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(209, 6);
            // 
            // machinesToolStripMenuItem
            // 
            this.machinesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMachineToolStripMenuItem,
            this.listMachinesToolStripMenuItem});
            this.machinesToolStripMenuItem.Name = "machinesToolStripMenuItem";
            this.machinesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.machinesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.machinesToolStripMenuItem.Text = "Máquinas";
            // 
            // addMachineToolStripMenuItem
            // 
            this.addMachineToolStripMenuItem.Name = "addMachineToolStripMenuItem";
            this.addMachineToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.addMachineToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.addMachineToolStripMenuItem.Text = "Adicionar Máquinas";
            this.addMachineToolStripMenuItem.Click += new System.EventHandler(this.addMachineToolStripMenuItem_Click);
            // 
            // listMachinesToolStripMenuItem
            // 
            this.listMachinesToolStripMenuItem.Name = "listMachinesToolStripMenuItem";
            this.listMachinesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.listMachinesToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.listMachinesToolStripMenuItem.Text = "Listar Máquinas";
            this.listMachinesToolStripMenuItem.Click += new System.EventHandler(this.listMachinesToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.listEmployeesToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F)));
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.employeeToolStripMenuItem.Text = "Funcionários";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.addEmployeeToolStripMenuItem.Text = "Adicionar Funcionário";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // listEmployeesToolStripMenuItem
            // 
            this.listEmployeesToolStripMenuItem.Name = "listEmployeesToolStripMenuItem";
            this.listEmployeesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.listEmployeesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.listEmployeesToolStripMenuItem.Text = "Listar Funcionários";
            this.listEmployeesToolStripMenuItem.Click += new System.EventHandler(this.listEmployeesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.aboutToolStripMenuItem.Text = "Sobre";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F4)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.terminarAssistênciaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(183, 26);
            this.contextMenuStrip1.Text = "Eliminar";
            // 
            // terminarAssistênciaToolStripMenuItem
            // 
            this.terminarAssistênciaToolStripMenuItem.Name = "terminarAssistênciaToolStripMenuItem";
            this.terminarAssistênciaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.terminarAssistênciaToolStripMenuItem.Text = "Terminar Assistência";
            this.terminarAssistênciaToolStripMenuItem.Click += new System.EventHandler(this.terminarAssistênciaToolStripMenuItem_Click);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 461);
            this.Controls.Add(this.dgvAssistenciasAmanha);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imgProfile);
            this.Controls.Add(this.lblDiaSemana);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Now Assist > Dashboard";
            this.Activated += new System.EventHandler(this.FrmDashboard_Activated);
            this.dgvAssistenciasAmanha.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssistenciasHoje)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssistenciasInacabadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfile)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl dgvAssistenciasAmanha;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvAssistenciasHoje;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvAssistenciasInacabadas;
        private System.Windows.Forms.Label lblClienteMaisAssistido;
        private System.Windows.Forms.Label lblMediaAssistencias;
        private System.Windows.Forms.Label lblTotalAssistencias;
        private System.Windows.Forms.Label lblTotalAssistenciasUltimos7Dias;
        private System.Windows.Forms.Label lblAssistenciasInacabadas;
        private System.Windows.Forms.Label lblAssistenciasAcabadas;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox imgProfile;
        private System.Windows.Forms.Label lblDiaSemana;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem assistsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAssistanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listAssistancesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem machinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMachineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listMachinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem terminarAssistênciaToolStripMenuItem;
    }
}