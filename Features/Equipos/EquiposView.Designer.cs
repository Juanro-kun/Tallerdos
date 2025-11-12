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
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel1 = new Panel();
            lId = new Label();
            roundedPanel2 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            lIdContenido = new Label();
            panel2 = new Panel();
            lIdCliente = new Label();
            roundedPanel3 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            tbIdCliente = new TextBox();
            panel7 = new Panel();
            label2 = new Label();
            roundedPanel8 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            label6 = new Label();
            label7 = new Label();
            tbDescripcion = new TextBox();
            panel5 = new Panel();
            roundedPanel6 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            cbMarca = new ComboBox();
            lRol = new Label();
            panel3 = new Panel();
            roundedPanel4 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            cbTipo = new ComboBox();
            label4 = new Label();
            panel4 = new Panel();
            roundedPanel5 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            cbEstado = new ComboBox();
            label5 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pNuevoUsuario = new Panel();
            bNuevoEquipo = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            bGuardarNuevo = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            panel6 = new Panel();
            bEditar = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            bGuardarExistente = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            panel10 = new Panel();
            bCancelar = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            roundedPanel1 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            dgvEquipos = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            NombreCompletoCliente = new DataGridViewButtonColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colApellido = new DataGridViewTextBoxColumn();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            roundedPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            panel2.SuspendLayout();
            roundedPanel3.SuspendLayout();
            panel7.SuspendLayout();
            roundedPanel8.SuspendLayout();
            panel5.SuspendLayout();
            roundedPanel6.SuspendLayout();
            panel3.SuspendLayout();
            roundedPanel4.SuspendLayout();
            panel4.SuspendLayout();
            roundedPanel5.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            pNuevoUsuario.SuspendLayout();
            panel6.SuspendLayout();
            panel10.SuspendLayout();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(roundedPanel7, 0, 4);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 3);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 2);
            tableLayoutPanel1.Controls.Add(roundedPanel1, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 180F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(804, 618);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // roundedPanel7
            // 
            roundedPanel7.BackColor = Color.White;
            roundedPanel7.BorderSize = 3F;
            roundedPanel7.Controls.Add(dgvItems);
            roundedPanel7.Location = new Point(18, 307);
            roundedPanel7.Margin = new Padding(18, 4, 2, 2);
            roundedPanel7.Name = "roundedPanel7";
            roundedPanel7.Size = new Size(760, 142);
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
            dgvItems.Margin = new Padding(2, 2, 2, 2);
            dgvItems.MultiSelect = false;
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersWidth = 62;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(760, 142);
            dgvItems.TabIndex = 0;
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
            dataGridViewTextBoxColumn3.DataPropertyName = "NombreServicio";
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
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(panel1);
            flowLayoutPanel2.Controls.Add(panel2);
            flowLayoutPanel2.Controls.Add(panel7);
            flowLayoutPanel2.Controls.Add(panel5);
            flowLayoutPanel2.Controls.Add(panel3);
            flowLayoutPanel2.Controls.Add(panel4);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(24, 252);
            flowLayoutPanel2.Margin = new Padding(24, 9, 2, 2);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(778, 49);
            flowLayoutPanel2.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(lId);
            panel1.Controls.Add(roundedPanel2);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(73, 40);
            panel1.TabIndex = 0;
            // 
            // lId
            // 
            lId.AutoSize = true;
            lId.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lId.Location = new Point(2, 0);
            lId.Margin = new Padding(2, 0, 2, 0);
            lId.Name = "lId";
            lId.Size = new Size(62, 15);
            lId.TabIndex = 0;
            lId.Text = "IdEquipo";
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel2.BorderSize = 4F;
            roundedPanel2.Controls.Add(lIdContenido);
            roundedPanel2.Location = new Point(2, 15);
            roundedPanel2.Margin = new Padding(2, 2, 2, 2);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(52, 23);
            roundedPanel2.TabIndex = 1;
            // 
            // lIdContenido
            // 
            lIdContenido.AutoSize = true;
            lIdContenido.Location = new Point(6, 4);
            lIdContenido.Margin = new Padding(2, 0, 2, 0);
            lIdContenido.Name = "lIdContenido";
            lIdContenido.Size = new Size(0, 15);
            lIdContenido.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(lIdCliente);
            panel2.Controls.Add(roundedPanel3);
            panel2.Location = new Point(79, 2);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(73, 40);
            panel2.TabIndex = 1;
            // 
            // lIdCliente
            // 
            lIdCliente.AutoSize = true;
            lIdCliente.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lIdCliente.Location = new Point(2, 0);
            lIdCliente.Margin = new Padding(2, 0, 2, 0);
            lIdCliente.Name = "lIdCliente";
            lIdCliente.Size = new Size(62, 15);
            lIdCliente.TabIndex = 0;
            lIdCliente.Text = "IdCliente";
            lIdCliente.Click += label2_Click;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel3.BorderSize = 4F;
            roundedPanel3.Controls.Add(tbIdCliente);
            roundedPanel3.Location = new Point(2, 15);
            roundedPanel3.Margin = new Padding(2, 2, 2, 2);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(52, 23);
            roundedPanel3.TabIndex = 1;
            roundedPanel3.Paint += roundedPanel3_Paint;
            // 
            // tbIdCliente
            // 
            tbIdCliente.BackColor = Color.FromArgb(51, 77, 53);
            tbIdCliente.BorderStyle = BorderStyle.None;
            tbIdCliente.Location = new Point(6, 3);
            tbIdCliente.Margin = new Padding(2, 2, 2, 2);
            tbIdCliente.Name = "tbIdCliente";
            tbIdCliente.Size = new Size(41, 16);
            tbIdCliente.TabIndex = 0;
            tbIdCliente.TextChanged += textBox1_TextChanged;
            // 
            // panel7
            // 
            panel7.Controls.Add(label2);
            panel7.Controls.Add(roundedPanel8);
            panel7.Location = new Point(156, 2);
            panel7.Margin = new Padding(2, 2, 2, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(154, 40);
            panel7.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(2, 0);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 0;
            label2.Text = "Descripcion";
            // 
            // roundedPanel8
            // 
            roundedPanel8.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel8.BorderSize = 4F;
            roundedPanel8.Controls.Add(label6);
            roundedPanel8.Controls.Add(label7);
            roundedPanel8.Controls.Add(tbDescripcion);
            roundedPanel8.Location = new Point(2, 17);
            roundedPanel8.Margin = new Padding(2, 2, 2, 2);
            roundedPanel8.Name = "roundedPanel8";
            roundedPanel8.Size = new Size(150, 23);
            roundedPanel8.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 4);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 4);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 0;
            // 
            // tbDescripcion
            // 
            tbDescripcion.BackColor = Color.FromArgb(51, 77, 53);
            tbDescripcion.BorderStyle = BorderStyle.None;
            tbDescripcion.Location = new Point(6, 2);
            tbDescripcion.Margin = new Padding(2, 2, 2, 2);
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(141, 16);
            tbDescripcion.TabIndex = 9;
            // 
            // panel5
            // 
            panel5.Controls.Add(roundedPanel6);
            panel5.Controls.Add(lRol);
            panel5.Location = new Point(314, 2);
            panel5.Margin = new Padding(2, 2, 2, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(141, 40);
            panel5.TabIndex = 6;
            // 
            // roundedPanel6
            // 
            roundedPanel6.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel6.BorderSize = 4F;
            roundedPanel6.Controls.Add(cbMarca);
            roundedPanel6.Location = new Point(2, 15);
            roundedPanel6.Margin = new Padding(2, 2, 2, 2);
            roundedPanel6.Name = "roundedPanel6";
            roundedPanel6.Size = new Size(134, 23);
            roundedPanel6.TabIndex = 1;
            // 
            // cbMarca
            // 
            cbMarca.BackColor = Color.FromArgb(51, 77, 53);
            cbMarca.Enabled = false;
            cbMarca.FlatStyle = FlatStyle.Flat;
            cbMarca.FormattingEnabled = true;
            cbMarca.Location = new Point(3, 2);
            cbMarca.Margin = new Padding(2, 2, 2, 2);
            cbMarca.Name = "cbMarca";
            cbMarca.Size = new Size(129, 23);
            cbMarca.TabIndex = 1;
            // 
            // lRol
            // 
            lRol.AutoSize = true;
            lRol.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lRol.Location = new Point(2, 0);
            lRol.Margin = new Padding(2, 0, 2, 0);
            lRol.Name = "lRol";
            lRol.Size = new Size(44, 15);
            lRol.TabIndex = 0;
            lRol.Text = "Marca";
            // 
            // panel3
            // 
            panel3.Controls.Add(roundedPanel4);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(459, 2);
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(141, 40);
            panel3.TabIndex = 7;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel4.BorderSize = 4F;
            roundedPanel4.Controls.Add(cbTipo);
            roundedPanel4.Location = new Point(2, 15);
            roundedPanel4.Margin = new Padding(2, 2, 2, 2);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(134, 23);
            roundedPanel4.TabIndex = 1;
            // 
            // cbTipo
            // 
            cbTipo.BackColor = Color.FromArgb(51, 77, 53);
            cbTipo.Enabled = false;
            cbTipo.FlatStyle = FlatStyle.Flat;
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(3, 2);
            cbTipo.Margin = new Padding(2, 2, 2, 2);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(129, 23);
            cbTipo.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(2, 0);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 0;
            label4.Text = "Tipo";
            // 
            // panel4
            // 
            panel4.Controls.Add(roundedPanel5);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(604, 2);
            panel4.Margin = new Padding(2, 2, 2, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(141, 40);
            panel4.TabIndex = 8;
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel5.BorderSize = 4F;
            roundedPanel5.Controls.Add(cbEstado);
            roundedPanel5.Location = new Point(2, 15);
            roundedPanel5.Margin = new Padding(2, 2, 2, 2);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(134, 23);
            roundedPanel5.TabIndex = 1;
            // 
            // cbEstado
            // 
            cbEstado.BackColor = Color.FromArgb(51, 77, 53);
            cbEstado.Enabled = false;
            cbEstado.FlatStyle = FlatStyle.Flat;
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(3, 2);
            cbEstado.Margin = new Padding(2, 2, 2, 2);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(129, 23);
            cbEstado.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(2, 0);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 0;
            label5.Text = "Estado";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pNuevoUsuario);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(panel10);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(2, 218);
            flowLayoutPanel1.Margin = new Padding(2, 2, 2, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 23);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // pNuevoUsuario
            // 
            pNuevoUsuario.Controls.Add(bNuevoEquipo);
            pNuevoUsuario.Controls.Add(bGuardarNuevo);
            pNuevoUsuario.Location = new Point(24, 2);
            pNuevoUsuario.Margin = new Padding(24, 2, 2, 2);
            pNuevoUsuario.Name = "pNuevoUsuario";
            pNuevoUsuario.Size = new Size(127, 19);
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
            bNuevoEquipo.Margin = new Padding(2, 2, 2, 2);
            bNuevoEquipo.Name = "bNuevoEquipo";
            bNuevoEquipo.Size = new Size(127, 19);
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
            bGuardarNuevo.Margin = new Padding(2, 2, 2, 2);
            bGuardarNuevo.Name = "bGuardarNuevo";
            bGuardarNuevo.Size = new Size(127, 19);
            bGuardarNuevo.TabIndex = 1;
            bGuardarNuevo.Text = "Guardar";
            bGuardarNuevo.UseVisualStyleBackColor = false;
            bGuardarNuevo.Visible = false;
            bGuardarNuevo.Click += bGuardarNuevo_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(bEditar);
            panel6.Controls.Add(bGuardarExistente);
            panel6.Location = new Point(155, 2);
            panel6.Margin = new Padding(2, 2, 2, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(127, 19);
            panel6.TabIndex = 5;
            // 
            // bEditar
            // 
            bEditar.BackColor = Color.FromArgb(40, 40, 40);
            bEditar.Dock = DockStyle.Fill;
            bEditar.FlatAppearance.BorderSize = 0;
            bEditar.FlatStyle = FlatStyle.Flat;
            bEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bEditar.ForeColor = Color.Gainsboro;
            bEditar.Location = new Point(0, 0);
            bEditar.Margin = new Padding(2, 2, 2, 2);
            bEditar.Name = "bEditar";
            bEditar.Size = new Size(127, 19);
            bEditar.TabIndex = 0;
            bEditar.Text = "Editar";
            bEditar.UseVisualStyleBackColor = false;
            bEditar.Click += bEditar_Click;
            // 
            // bGuardarExistente
            // 
            bGuardarExistente.BackColor = Color.FromArgb(40, 40, 40);
            bGuardarExistente.Dock = DockStyle.Fill;
            bGuardarExistente.FlatAppearance.BorderSize = 0;
            bGuardarExistente.FlatStyle = FlatStyle.Flat;
            bGuardarExistente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bGuardarExistente.ForeColor = Color.Gainsboro;
            bGuardarExistente.Location = new Point(0, 0);
            bGuardarExistente.Margin = new Padding(2, 2, 2, 2);
            bGuardarExistente.Name = "bGuardarExistente";
            bGuardarExistente.Size = new Size(127, 19);
            bGuardarExistente.TabIndex = 1;
            bGuardarExistente.Text = "Guardar";
            bGuardarExistente.UseVisualStyleBackColor = false;
            bGuardarExistente.Visible = false;
            bGuardarExistente.Click += bGuardarExistente_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(bCancelar);
            panel10.Location = new Point(286, 2);
            panel10.Margin = new Padding(2, 2, 2, 2);
            panel10.Name = "panel10";
            panel10.Size = new Size(111, 19);
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
            bCancelar.Margin = new Padding(2, 2, 2, 2);
            bCancelar.Name = "bCancelar";
            bCancelar.Size = new Size(111, 19);
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
            roundedPanel1.Location = new Point(18, 40);
            roundedPanel1.Margin = new Padding(18, 4, 2, 2);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(760, 167);
            roundedPanel1.TabIndex = 5;
            // 
            // dgvEquipos
            // 
            dgvEquipos.AllowUserToAddRows = false;
            dgvEquipos.AllowUserToDeleteRows = false;
            dgvEquipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipos.Columns.AddRange(new DataGridViewColumn[] { colId, NombreCompletoCliente, Descripcion, colEmail, colNombre, colApellido });
            dgvEquipos.Dock = DockStyle.Fill;
            dgvEquipos.Location = new Point(0, 0);
            dgvEquipos.Margin = new Padding(2, 2, 2, 2);
            dgvEquipos.MultiSelect = false;
            dgvEquipos.Name = "dgvEquipos";
            dgvEquipos.ReadOnly = true;
            dgvEquipos.RowHeadersWidth = 62;
            dgvEquipos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEquipos.Size = new Size(760, 167);
            dgvEquipos.TabIndex = 0;
            dgvEquipos.CellContentClick += dgvEquipos_CellContentClick;
            dgvEquipos.DataBindingComplete += dgvEquipos_DataBindingComplete;
            dgvEquipos.SelectionChanged += dgvEquipos_SelectionChanged;
            // 
            // colId
            // 
            colId.DataPropertyName = "IdEquipo";
            colId.HeaderText = "ID";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // NombreCompletoCliente
            // 
            NombreCompletoCliente.DataPropertyName = "NombreCompletoCliente";
            NombreCompletoCliente.HeaderText = "Nombre del Cliente";
            NombreCompletoCliente.MinimumWidth = 8;
            NombreCompletoCliente.Name = "NombreCompletoCliente";
            NombreCompletoCliente.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.DataPropertyName = "Nombre";
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 8;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "NombreMarca";
            colEmail.HeaderText = "Marca";
            colEmail.MinimumWidth = 8;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.DataPropertyName = "NombreTipo";
            colNombre.HeaderText = "Tipo";
            colNombre.MinimumWidth = 8;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colApellido
            // 
            colApellido.DataPropertyName = "NombreEstado";
            colApellido.HeaderText = "Estado";
            colApellido.MinimumWidth = 8;
            colApellido.Name = "colApellido";
            colApellido.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(2, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 36);
            label1.TabIndex = 1;
            label1.Text = "Equipos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EquiposView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 77, 53);
            Controls.Add(tableLayoutPanel1);
            Name = "EquiposView";
            Size = new Size(804, 618);
            Load += EquiposView_Load;
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
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            roundedPanel8.ResumeLayout(false);
            roundedPanel8.PerformLayout();
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
            panel6.ResumeLayout(false);
            panel10.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).EndInit();
            ResumeLayout(false);
        }

        private void dgvEquipos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
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
        private Label lIdCliente;
        private Shared.Controls.RoundedPanel roundedPanel3;
        private Panel panel5;
        private Shared.Controls.RoundedPanel roundedPanel6;
        private Label lRol;
        private Panel panel3;
        private Shared.Controls.RoundedPanel roundedPanel4;
        private Label label4;
        private Panel panel4;
        private Shared.Controls.RoundedPanel roundedPanel5;
        private Label label5;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewButtonColumn NombreCompletoCliente;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colApellido;
        private ComboBox cbMarca;
        private ComboBox cbTipo;
        private ComboBox cbEstado;
        private Panel panel7;
        private Label label2;
        private Shared.Controls.RoundedPanel roundedPanel8;
        private Label label6;
        private Label label7;
        private Panel panel6;
        private Shared.Controls.RoundedButton roundedButton1;
        private Shared.Controls.RoundedButton roundedButton2;
        private DataGridViewTextBoxColumn Descripcion;
        private TextBox tbDescripcion;
        private Shared.Controls.RoundedButton bGuardarExistente;
        private Shared.Controls.RoundedButton bEditar;
        private TextBox tbIdCliente;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
