namespace Taller_2_Gestor.Features.Equipos
{
    partial class EquiposView
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            roundedPanel7 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            dgvItems = new DataGridView();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel1 = new Panel();
            lId = new Label();
            roundedPanel2 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            lIdContenido = new Label();
            panel2 = new Panel();
            label2 = new Label();
            roundedPanel3 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            label3 = new Label();
            panel5 = new Panel();
            roundedPanel6 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            cbRol = new ComboBox();
            lRol = new Label();
            panel3 = new Panel();
            roundedPanel4 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            comboBox2 = new ComboBox();
            label4 = new Label();
            panel4 = new Panel();
            roundedPanel5 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            comboBox3 = new ComboBox();
            label5 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pNuevoUsuario = new Panel();
            bNuevoEquipo = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            bGuardarNuevo = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            pEliminarEquipo = new Panel();
            bEliminar = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            panel10 = new Panel();
            bCancelar = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            roundedPanel1 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            dgvEquipos = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colApellido = new DataGridViewTextBoxColumn();
            rpBarraBusqueda = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            lBusqueda = new Label();
            rpFiltro = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            comboBox1 = new ComboBox();
            lFiltro = new Label();
            label1 = new Label();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            roundedPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            panel2.SuspendLayout();
            roundedPanel3.SuspendLayout();
            panel5.SuspendLayout();
            roundedPanel6.SuspendLayout();
            panel3.SuspendLayout();
            roundedPanel4.SuspendLayout();
            panel4.SuspendLayout();
            roundedPanel5.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            pNuevoUsuario.SuspendLayout();
            pEliminarEquipo.SuspendLayout();
            panel10.SuspendLayout();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).BeginInit();
            rpBarraBusqueda.SuspendLayout();
            rpFiltro.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(roundedPanel7, 0, 6);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 5);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 4);
            tableLayoutPanel1.Controls.Add(roundedPanel1, 0, 3);
            tableLayoutPanel1.Controls.Add(rpBarraBusqueda, 0, 2);
            tableLayoutPanel1.Controls.Add(rpFiltro, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 99.99999F));
            tableLayoutPanel1.Size = new Size(1010, 1030);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // roundedPanel7
            // 
            roundedPanel7.BackColor = Color.White;
            roundedPanel7.BorderSize = 3F;
            roundedPanel7.Controls.Add(dgvItems);
            roundedPanel7.Location = new Point(26, 592);
            roundedPanel7.Margin = new Padding(26, 7, 3, 3);
            roundedPanel7.Name = "roundedPanel7";
            roundedPanel7.Size = new Size(950, 237);
            roundedPanel7.TabIndex = 8;
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dgvItems.Dock = DockStyle.Fill;
            dgvItems.Location = new Point(0, 0);
            dgvItems.MultiSelect = false;
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersWidth = 62;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(950, 237);
            dgvItems.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(panel1);
            flowLayoutPanel2.Controls.Add(panel2);
            flowLayoutPanel2.Controls.Add(panel5);
            flowLayoutPanel2.Controls.Add(panel3);
            flowLayoutPanel2.Controls.Add(panel4);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(34, 500);
            flowLayoutPanel2.Margin = new Padding(34, 15, 3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(973, 82);
            flowLayoutPanel2.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(lId);
            panel1.Controls.Add(roundedPanel2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(104, 67);
            panel1.TabIndex = 0;
            // 
            // lId
            // 
            lId.AutoSize = true;
            lId.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lId.Location = new Point(3, 0);
            lId.Name = "lId";
            lId.Size = new Size(92, 25);
            lId.TabIndex = 0;
            lId.Text = "IdEquipo";
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel2.BorderSize = 4F;
            roundedPanel2.Controls.Add(lIdContenido);
            roundedPanel2.Location = new Point(3, 25);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(74, 38);
            roundedPanel2.TabIndex = 1;
            // 
            // lIdContenido
            // 
            lIdContenido.AutoSize = true;
            lIdContenido.Location = new Point(9, 7);
            lIdContenido.Name = "lIdContenido";
            lIdContenido.Size = new Size(0, 25);
            lIdContenido.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(roundedPanel3);
            panel2.Location = new Point(113, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(104, 67);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 0;
            label2.Text = "IdUsuario";
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel3.BorderSize = 4F;
            roundedPanel3.Controls.Add(label3);
            roundedPanel3.Location = new Point(3, 25);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(74, 38);
            roundedPanel3.TabIndex = 1;
            roundedPanel3.Paint += roundedPanel3_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 7);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(roundedPanel6);
            panel5.Controls.Add(lRol);
            panel5.Location = new Point(223, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(201, 67);
            panel5.TabIndex = 6;
            // 
            // roundedPanel6
            // 
            roundedPanel6.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel6.BorderSize = 4F;
            roundedPanel6.Controls.Add(cbRol);
            roundedPanel6.Location = new Point(3, 25);
            roundedPanel6.Name = "roundedPanel6";
            roundedPanel6.Size = new Size(191, 38);
            roundedPanel6.TabIndex = 1;
            // 
            // cbRol
            // 
            cbRol.BackColor = Color.FromArgb(51, 77, 53);
            cbRol.Enabled = false;
            cbRol.FlatStyle = FlatStyle.Flat;
            cbRol.FormattingEnabled = true;
            cbRol.Location = new Point(6, 3);
            cbRol.Name = "cbRol";
            cbRol.Size = new Size(183, 33);
            cbRol.TabIndex = 0;
            // 
            // lRol
            // 
            lRol.AutoSize = true;
            lRol.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lRol.Location = new Point(3, 0);
            lRol.Name = "lRol";
            lRol.Size = new Size(67, 25);
            lRol.TabIndex = 0;
            lRol.Text = "Marca";
            // 
            // panel3
            // 
            panel3.Controls.Add(roundedPanel4);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(430, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(201, 67);
            panel3.TabIndex = 7;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel4.BorderSize = 4F;
            roundedPanel4.Controls.Add(comboBox2);
            roundedPanel4.Location = new Point(3, 25);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(191, 38);
            roundedPanel4.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(51, 77, 53);
            comboBox2.Enabled = false;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(6, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(183, 33);
            comboBox2.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(52, 25);
            label4.TabIndex = 0;
            label4.Text = "Tipo";
            // 
            // panel4
            // 
            panel4.Controls.Add(roundedPanel5);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(637, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(201, 67);
            panel4.TabIndex = 8;
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel5.BorderSize = 4F;
            roundedPanel5.Controls.Add(comboBox3);
            roundedPanel5.Location = new Point(3, 25);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(191, 38);
            roundedPanel5.TabIndex = 1;
            // 
            // comboBox3
            // 
            comboBox3.BackColor = Color.FromArgb(51, 77, 53);
            comboBox3.Enabled = false;
            comboBox3.FlatStyle = FlatStyle.Flat;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(6, 3);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(183, 33);
            comboBox3.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(72, 25);
            label5.TabIndex = 0;
            label5.Text = "Estado";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pNuevoUsuario);
            flowLayoutPanel1.Controls.Add(pEliminarEquipo);
            flowLayoutPanel1.Controls.Add(panel10);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 443);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1004, 39);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // pNuevoUsuario
            // 
            pNuevoUsuario.Controls.Add(bNuevoEquipo);
            pNuevoUsuario.Controls.Add(bGuardarNuevo);
            pNuevoUsuario.Location = new Point(34, 3);
            pNuevoUsuario.Margin = new Padding(34, 3, 3, 3);
            pNuevoUsuario.Name = "pNuevoUsuario";
            pNuevoUsuario.Size = new Size(181, 32);
            pNuevoUsuario.TabIndex = 0;
            // 
            // bNuevoEquipo
            // 
            bNuevoEquipo.BackColor = Color.FromArgb(40, 40, 40);
            bNuevoEquipo.Dock = DockStyle.Fill;
            bNuevoEquipo.FlatAppearance.BorderSize = 0;
            bNuevoEquipo.FlatStyle = FlatStyle.Flat;
            bNuevoEquipo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bNuevoEquipo.ForeColor = Color.Gainsboro;
            bNuevoEquipo.Location = new Point(0, 0);
            bNuevoEquipo.Name = "bNuevoEquipo";
            bNuevoEquipo.Size = new Size(181, 32);
            bNuevoEquipo.TabIndex = 0;
            bNuevoEquipo.Text = "Nuevo Equipo";
            bNuevoEquipo.UseVisualStyleBackColor = false;
            bNuevoEquipo.Click += bNuevoEquipo_Click;
            // 
            // bGuardarNuevo
            // 
            bGuardarNuevo.BackColor = Color.FromArgb(40, 40, 40);
            bGuardarNuevo.Dock = DockStyle.Fill;
            bGuardarNuevo.FlatAppearance.BorderSize = 0;
            bGuardarNuevo.FlatStyle = FlatStyle.Flat;
            bGuardarNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bGuardarNuevo.ForeColor = Color.Gainsboro;
            bGuardarNuevo.Location = new Point(0, 0);
            bGuardarNuevo.Name = "bGuardarNuevo";
            bGuardarNuevo.Size = new Size(181, 32);
            bGuardarNuevo.TabIndex = 1;
            bGuardarNuevo.Text = "Guardar";
            bGuardarNuevo.UseVisualStyleBackColor = false;
            bGuardarNuevo.Visible = false;
            bGuardarNuevo.Click += bGuardarNuevo_Click;
            // 
            // pEliminarEquipo
            // 
            pEliminarEquipo.Controls.Add(bEliminar);
            pEliminarEquipo.Location = new Point(221, 3);
            pEliminarEquipo.Name = "pEliminarEquipo";
            pEliminarEquipo.Size = new Size(181, 32);
            pEliminarEquipo.TabIndex = 2;
            // 
            // bEliminar
            // 
            bEliminar.BackColor = Color.White;
            bEliminar.BackNormal = Color.FromArgb(162, 46, 46);
            bEliminar.Dock = DockStyle.Fill;
            bEliminar.FlatAppearance.BorderSize = 0;
            bEliminar.FlatStyle = FlatStyle.Flat;
            bEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bEliminar.ForeColor = Color.Gainsboro;
            bEliminar.Location = new Point(0, 0);
            bEliminar.Name = "bEliminar";
            bEliminar.Size = new Size(181, 32);
            bEliminar.TabIndex = 4;
            bEliminar.Text = "Eliminar Equipo";
            bEliminar.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            panel10.Controls.Add(bCancelar);
            panel10.Location = new Point(408, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(159, 32);
            panel10.TabIndex = 4;
            // 
            // bCancelar
            // 
            bCancelar.BackColor = Color.FromArgb(40, 40, 40);
            bCancelar.Dock = DockStyle.Fill;
            bCancelar.FlatAppearance.BorderSize = 0;
            bCancelar.FlatStyle = FlatStyle.Flat;
            bCancelar.ForeColor = Color.Gainsboro;
            bCancelar.Location = new Point(0, 0);
            bCancelar.Name = "bCancelar";
            bCancelar.Size = new Size(159, 32);
            bCancelar.TabIndex = 0;
            bCancelar.Text = "Cancelar";
            bCancelar.UseVisualStyleBackColor = false;
            bCancelar.Visible = false;
            bCancelar.Click += bCancelar_Click;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BorderSize = 3F;
            roundedPanel1.Controls.Add(dgvEquipos);
            roundedPanel1.Location = new Point(26, 147);
            roundedPanel1.Margin = new Padding(26, 7, 3, 3);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(949, 279);
            roundedPanel1.TabIndex = 5;
            // 
            // dgvEquipos
            // 
            dgvEquipos.AllowUserToAddRows = false;
            dgvEquipos.AllowUserToDeleteRows = false;
            dgvEquipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipos.Columns.AddRange(new DataGridViewColumn[] { colId, colEmail, colNombre, colApellido });
            dgvEquipos.Dock = DockStyle.Fill;
            dgvEquipos.Location = new Point(0, 0);
            dgvEquipos.MultiSelect = false;
            dgvEquipos.Name = "dgvEquipos";
            dgvEquipos.ReadOnly = true;
            dgvEquipos.RowHeadersWidth = 62;
            dgvEquipos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEquipos.Size = new Size(949, 279);
            dgvEquipos.TabIndex = 0;
            dgvEquipos.CellContentClick += dgvEquipos_CellContentClick;
            // 
            // colId
            // 
            colId.DataPropertyName = "ID";
            colId.HeaderText = "ID";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "Marca";
            colEmail.HeaderText = "Marca";
            colEmail.MinimumWidth = 8;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.DataPropertyName = "Tipo";
            colNombre.HeaderText = "Tipo";
            colNombre.MinimumWidth = 8;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colApellido
            // 
            colApellido.DataPropertyName = "Estado";
            colApellido.HeaderText = "Estado";
            colApellido.MinimumWidth = 8;
            colApellido.Name = "colApellido";
            colApellido.ReadOnly = true;
            // 
            // rpBarraBusqueda
            // 
            rpBarraBusqueda.BackColor = Color.DarkGray;
            rpBarraBusqueda.BorderColor = Color.DarkGray;
            rpBarraBusqueda.Controls.Add(lBusqueda);
            rpBarraBusqueda.Location = new Point(26, 103);
            rpBarraBusqueda.Margin = new Padding(26, 3, 3, 3);
            rpBarraBusqueda.Name = "rpBarraBusqueda";
            rpBarraBusqueda.Size = new Size(949, 33);
            rpBarraBusqueda.TabIndex = 4;
            // 
            // lBusqueda
            // 
            lBusqueda.AutoSize = true;
            lBusqueda.ForeColor = SystemColors.ControlDarkDark;
            lBusqueda.Location = new Point(24, 5);
            lBusqueda.Name = "lBusqueda";
            lBusqueda.Size = new Size(324, 25);
            lBusqueda.TabIndex = 0;
            lBusqueda.Text = "Ingrese un dato del equipo para buscar";
            // 
            // rpFiltro
            // 
            rpFiltro.BackColor = Color.FromArgb(33, 33, 33);
            rpFiltro.Controls.Add(comboBox1);
            rpFiltro.Controls.Add(lFiltro);
            rpFiltro.Location = new Point(30, 63);
            rpFiltro.Margin = new Padding(30, 3, 3, 3);
            rpFiltro.Name = "rpFiltro";
            rpFiltro.Size = new Size(259, 33);
            rpFiltro.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(33, 33, 33);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(119, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(137, 33);
            comboBox1.TabIndex = 1;
            // 
            // lFiltro
            // 
            lFiltro.AutoSize = true;
            lFiltro.ForeColor = SystemColors.ButtonHighlight;
            lFiltro.Location = new Point(19, 3);
            lFiltro.Name = "lFiltro";
            lFiltro.Size = new Size(93, 25);
            lFiltro.TabIndex = 0;
            lFiltro.Text = "Filtrar por:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 54);
            label1.TabIndex = 1;
            label1.Text = "Equipos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "IDpresupuesto";
            dataGridViewTextBoxColumn1.HeaderText = "IDPresupuesto";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Precio";
            dataGridViewTextBoxColumn2.HeaderText = "Precio";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Servicio";
            dataGridViewTextBoxColumn3.HeaderText = "Servicio";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "IDorden";
            dataGridViewTextBoxColumn4.HeaderText = "IDOrden";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // EquiposView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 77, 53);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "EquiposView";
            Size = new Size(1010, 1030);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            roundedPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            roundedPanel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            roundedPanel4.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            roundedPanel5.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            pNuevoUsuario.ResumeLayout(false);
            pEliminarEquipo.ResumeLayout(false);
            panel10.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).EndInit();
            rpBarraBusqueda.ResumeLayout(false);
            rpBarraBusqueda.PerformLayout();
            rpFiltro.ResumeLayout(false);
            rpFiltro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Shared.Controls.RoundedPanel rpFiltro;
        private ComboBox comboBox1;
        private Label lFiltro;
        private Shared.Controls.RoundedPanel rpBarraBusqueda;
        private Label lBusqueda;
        private Shared.Controls.RoundedPanel roundedPanel1;
        private DataGridView dgvEquipos;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pNuevoUsuario;
        private Shared.Controls.RoundedButton bGuardarNuevo;
        private Shared.Controls.RoundedButton bNuevoEquipo;
        private Panel pEliminarEquipo;
        private Shared.Controls.RoundedButton bEliminar;
        private Panel panel10;
        private Shared.Controls.RoundedButton bCancelar;
        private Shared.Controls.RoundedPanel roundedPanel7;
        private DataGridView dgvItems;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel1;
        private Label lId;
        private Shared.Controls.RoundedPanel roundedPanel2;
        private Label lIdContenido;
        private Panel panel2;
        private Label label2;
        private Shared.Controls.RoundedPanel roundedPanel3;
        private Label label3;
        private Panel panel5;
        private Shared.Controls.RoundedPanel roundedPanel6;
        private ComboBox cbRol;
        private Label lRol;
        private Panel panel3;
        private Shared.Controls.RoundedPanel roundedPanel4;
        private ComboBox comboBox2;
        private Label label4;
        private Panel panel4;
        private Shared.Controls.RoundedPanel roundedPanel5;
        private ComboBox comboBox3;
        private Label label5;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colApellido;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
