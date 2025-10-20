namespace Taller_2_Gestor.Features.Clientes
{
    partial class ClientesView : UserControl
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
            tlpViews = new TableLayoutPanel();
            label1 = new Label();
            rpFiltro = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            cbFiltro = new ComboBox();
            lFiltro = new Label();
            rpBarraBusqueda = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            lBusqueda = new Label();
            roundedPanel1 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            dgvClientes = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colApellido = new DataGridViewTextBoxColumn();
            colRol = new DataGridViewTextBoxColumn();
            colActivo = new DataGridViewTextBoxColumn();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pNuevoUsuario = new Panel();
            bNuevoCliente = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            bGuardarNuevo = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            pEditarUsuario = new Panel();
            bGuardarExistente = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            bEditar = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            panel10 = new Panel();
            bCancelar = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel1 = new Panel();
            lIdContenido = new Label();
            lId = new Label();
            roundedPanel2 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            panel2 = new Panel();
            roundedPanel3 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            tbMail = new TextBox();
            lMail = new Label();
            panel3 = new Panel();
            roundedPanel4 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            tbNombre = new TextBox();
            lNombre = new Label();
            panel4 = new Panel();
            roundedPanel5 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            tbApellido = new TextBox();
            lApellido = new Label();
            panel7 = new Panel();
            pContrasena = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            tbTelefono = new TextBox();
            lContrasena = new Label();
            panel5 = new Panel();
            roundedPanel6 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            tbDni = new TextBox();
            label2 = new Label();
            label3 = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            roundedPanel7 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            dgvEquipos = new DataGridView();
            bAgregarEquipo = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            dgvEquiposCId = new DataGridViewButtonColumn();
            Nombre = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            tlpViews.SuspendLayout();
            rpFiltro.SuspendLayout();
            rpBarraBusqueda.SuspendLayout();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            pNuevoUsuario.SuspendLayout();
            pEditarUsuario.SuspendLayout();
            panel10.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            roundedPanel3.SuspendLayout();
            panel3.SuspendLayout();
            roundedPanel4.SuspendLayout();
            panel4.SuspendLayout();
            roundedPanel5.SuspendLayout();
            panel7.SuspendLayout();
            pContrasena.SuspendLayout();
            panel5.SuspendLayout();
            roundedPanel6.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            roundedPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).BeginInit();
            SuspendLayout();
            // 
            // tlpViews
            // 
            tlpViews.AllowDrop = true;
            tlpViews.ColumnCount = 1;
            tlpViews.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpViews.Controls.Add(label1, 0, 0);
            tlpViews.Controls.Add(rpFiltro, 0, 1);
            tlpViews.Controls.Add(rpBarraBusqueda, 0, 2);
            tlpViews.Controls.Add(roundedPanel1, 0, 3);
            tlpViews.Controls.Add(flowLayoutPanel1, 0, 4);
            tlpViews.Controls.Add(flowLayoutPanel2, 0, 5);
            tlpViews.Controls.Add(label3, 0, 6);
            tlpViews.Controls.Add(flowLayoutPanel3, 0, 7);
            tlpViews.Dock = DockStyle.Fill;
            tlpViews.Location = new Point(0, 0);
            tlpViews.Name = "tlpViews";
            tlpViews.RowCount = 8;
            tlpViews.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpViews.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpViews.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpViews.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            tlpViews.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tlpViews.RowStyles.Add(new RowStyle(SizeType.Absolute, 137F));
            tlpViews.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tlpViews.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpViews.Size = new Size(1235, 900);
            tlpViews.TabIndex = 1;
            tlpViews.Paint += tlpViews_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(172, 54);
            label1.TabIndex = 0;
            label1.Text = "Clientes";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // rpFiltro
            // 
            rpFiltro.BackColor = Color.FromArgb(33, 33, 33);
            rpFiltro.Controls.Add(cbFiltro);
            rpFiltro.Controls.Add(lFiltro);
            rpFiltro.Location = new Point(30, 63);
            rpFiltro.Margin = new Padding(30, 3, 3, 3);
            rpFiltro.Name = "rpFiltro";
            rpFiltro.Size = new Size(258, 34);
            rpFiltro.TabIndex = 2;
            // 
            // cbFiltro
            // 
            cbFiltro.BackColor = Color.FromArgb(33, 33, 33);
            cbFiltro.FlatStyle = FlatStyle.Flat;
            cbFiltro.ForeColor = SystemColors.InactiveCaption;
            cbFiltro.FormattingEnabled = true;
            cbFiltro.Location = new Point(118, 0);
            cbFiltro.Name = "cbFiltro";
            cbFiltro.Size = new Size(137, 33);
            cbFiltro.TabIndex = 1;
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
            // rpBarraBusqueda
            // 
            rpBarraBusqueda.BackColor = Color.DarkGray;
            rpBarraBusqueda.BorderColor = Color.DarkGray;
            rpBarraBusqueda.Controls.Add(lBusqueda);
            rpBarraBusqueda.Location = new Point(25, 103);
            rpBarraBusqueda.Margin = new Padding(25, 3, 3, 3);
            rpBarraBusqueda.Name = "rpBarraBusqueda";
            rpBarraBusqueda.Size = new Size(950, 34);
            rpBarraBusqueda.TabIndex = 3;
            // 
            // lBusqueda
            // 
            lBusqueda.AutoSize = true;
            lBusqueda.ForeColor = SystemColors.ControlDarkDark;
            lBusqueda.Location = new Point(24, 5);
            lBusqueda.Name = "lBusqueda";
            lBusqueda.Size = new Size(318, 25);
            lBusqueda.TabIndex = 0;
            lBusqueda.Text = "Ingrese un dato del cliente para buscar";
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BorderSize = 3F;
            roundedPanel1.Controls.Add(dgvClientes);
            roundedPanel1.Location = new Point(25, 147);
            roundedPanel1.Margin = new Padding(25, 7, 3, 3);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(950, 290);
            roundedPanel1.TabIndex = 4;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { colId, colEmail, colNombre, colApellido, colRol, colActivo });
            dgvClientes.Dock = DockStyle.Fill;
            dgvClientes.Location = new Point(0, 0);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 62;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(950, 290);
            dgvClientes.TabIndex = 0;
            dgvClientes.SelectionChanged += dgvClientes_SelectionChanged;
            // 
            // colId
            // 
            colId.DataPropertyName = "IdCliente";
            colId.HeaderText = "ID";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "Mail";
            colEmail.HeaderText = "Correo";
            colEmail.MinimumWidth = 8;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.DataPropertyName = "Nombre";
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 8;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colApellido
            // 
            colApellido.DataPropertyName = "Apellido";
            colApellido.HeaderText = "Apellido";
            colApellido.MinimumWidth = 8;
            colApellido.Name = "colApellido";
            colApellido.ReadOnly = true;
            // 
            // colRol
            // 
            colRol.DataPropertyName = "Telefono";
            colRol.HeaderText = "Telefono";
            colRol.MinimumWidth = 8;
            colRol.Name = "colRol";
            colRol.ReadOnly = true;
            // 
            // colActivo
            // 
            colActivo.DataPropertyName = "Dni";
            colActivo.HeaderText = "DNI";
            colActivo.MinimumWidth = 8;
            colActivo.Name = "colActivo";
            colActivo.ReadOnly = true;
            colActivo.Resizable = DataGridViewTriState.True;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pNuevoUsuario);
            flowLayoutPanel1.Controls.Add(pEditarUsuario);
            flowLayoutPanel1.Controls.Add(panel10);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 443);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1229, 39);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // pNuevoUsuario
            // 
            pNuevoUsuario.Controls.Add(bNuevoCliente);
            pNuevoUsuario.Controls.Add(bGuardarNuevo);
            pNuevoUsuario.Location = new Point(35, 3);
            pNuevoUsuario.Margin = new Padding(35, 3, 3, 3);
            pNuevoUsuario.Name = "pNuevoUsuario";
            pNuevoUsuario.Size = new Size(182, 32);
            pNuevoUsuario.TabIndex = 0;
            // 
            // bNuevoCliente
            // 
            bNuevoCliente.BackColor = Color.FromArgb(40, 40, 40);
            bNuevoCliente.Dock = DockStyle.Fill;
            bNuevoCliente.FlatAppearance.BorderSize = 0;
            bNuevoCliente.FlatStyle = FlatStyle.Flat;
            bNuevoCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bNuevoCliente.ForeColor = Color.Gainsboro;
            bNuevoCliente.Location = new Point(0, 0);
            bNuevoCliente.Name = "bNuevoCliente";
            bNuevoCliente.Size = new Size(182, 32);
            bNuevoCliente.TabIndex = 0;
            bNuevoCliente.Text = "Nuevo Cliente";
            bNuevoCliente.UseVisualStyleBackColor = false;
            bNuevoCliente.Click += bNuevoCliente_Click;
            // 
            // bGuardarNuevo
            // 
            bGuardarNuevo.BackColor = Color.FromArgb(40, 40, 40);
            bGuardarNuevo.FlatAppearance.BorderSize = 0;
            bGuardarNuevo.FlatStyle = FlatStyle.Flat;
            bGuardarNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bGuardarNuevo.ForeColor = Color.Gainsboro;
            bGuardarNuevo.Location = new Point(0, -3);
            bGuardarNuevo.Name = "bGuardarNuevo";
            bGuardarNuevo.Size = new Size(182, 32);
            bGuardarNuevo.TabIndex = 3;
            bGuardarNuevo.Text = "Guardar";
            bGuardarNuevo.UseVisualStyleBackColor = false;
            bGuardarNuevo.Visible = false;
            bGuardarNuevo.Click += bGuardarNuevo_Click_1;
            // 
            // pEditarUsuario
            // 
            pEditarUsuario.Controls.Add(bGuardarExistente);
            pEditarUsuario.Controls.Add(bEditar);
            pEditarUsuario.Location = new Point(223, 3);
            pEditarUsuario.Name = "pEditarUsuario";
            pEditarUsuario.Size = new Size(182, 32);
            pEditarUsuario.TabIndex = 1;
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
            bGuardarExistente.Name = "bGuardarExistente";
            bGuardarExistente.Size = new Size(182, 32);
            bGuardarExistente.TabIndex = 2;
            bGuardarExistente.Text = "Guardar";
            bGuardarExistente.UseVisualStyleBackColor = false;
            bGuardarExistente.Visible = false;
            bGuardarExistente.Click += bGuardarExistente_Click_1;
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
            bEditar.Name = "bEditar";
            bEditar.Size = new Size(182, 32);
            bEditar.TabIndex = 3;
            bEditar.Text = "Editar Cliente";
            bEditar.UseVisualStyleBackColor = false;
            bEditar.Click += bEditar_Click_1;
            // 
            // panel10
            // 
            panel10.Controls.Add(bCancelar);
            panel10.Location = new Point(411, 3);
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
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(panel1);
            flowLayoutPanel2.Controls.Add(panel2);
            flowLayoutPanel2.Controls.Add(panel3);
            flowLayoutPanel2.Controls.Add(panel4);
            flowLayoutPanel2.Controls.Add(panel7);
            flowLayoutPanel2.Controls.Add(panel5);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(35, 500);
            flowLayoutPanel2.Margin = new Padding(35, 15, 3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1197, 119);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(lIdContenido);
            panel1.Controls.Add(lId);
            panel1.Controls.Add(roundedPanel2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(104, 67);
            panel1.TabIndex = 0;
            // 
            // lIdContenido
            // 
            lIdContenido.AutoSize = true;
            lIdContenido.Location = new Point(20, 25);
            lIdContenido.Name = "lIdContenido";
            lIdContenido.Size = new Size(0, 25);
            lIdContenido.TabIndex = 0;
            // 
            // lId
            // 
            lId.AutoSize = true;
            lId.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lId.Location = new Point(3, 0);
            lId.Name = "lId";
            lId.Size = new Size(30, 25);
            lId.TabIndex = 0;
            lId.Text = "Id";
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel2.BorderSize = 4F;
            roundedPanel2.Location = new Point(3, 25);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(74, 39);
            roundedPanel2.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(roundedPanel3);
            panel2.Controls.Add(lMail);
            panel2.Location = new Point(113, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(297, 67);
            panel2.TabIndex = 2;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel3.BorderSize = 4F;
            roundedPanel3.Controls.Add(tbMail);
            roundedPanel3.Location = new Point(3, 25);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(291, 39);
            roundedPanel3.TabIndex = 1;
            // 
            // tbMail
            // 
            tbMail.BackColor = Color.FromArgb(51, 77, 53);
            tbMail.BorderStyle = BorderStyle.None;
            tbMail.Location = new Point(5, 7);
            tbMail.Name = "tbMail";
            tbMail.ReadOnly = true;
            tbMail.Size = new Size(283, 24);
            tbMail.TabIndex = 0;
            // 
            // lMail
            // 
            lMail.AutoSize = true;
            lMail.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lMail.Location = new Point(3, 0);
            lMail.Name = "lMail";
            lMail.Size = new Size(52, 25);
            lMail.TabIndex = 0;
            lMail.Text = "Mail";
            // 
            // panel3
            // 
            panel3.Controls.Add(roundedPanel4);
            panel3.Controls.Add(lNombre);
            panel3.Location = new Point(416, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(171, 67);
            panel3.TabIndex = 3;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel4.BorderSize = 4F;
            roundedPanel4.Controls.Add(tbNombre);
            roundedPanel4.Location = new Point(3, 25);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(151, 39);
            roundedPanel4.TabIndex = 1;
            // 
            // tbNombre
            // 
            tbNombre.BackColor = Color.FromArgb(51, 77, 53);
            tbNombre.BorderStyle = BorderStyle.None;
            tbNombre.Location = new Point(5, 7);
            tbNombre.Name = "tbNombre";
            tbNombre.ReadOnly = true;
            tbNombre.Size = new Size(132, 24);
            tbNombre.TabIndex = 0;
            // 
            // lNombre
            // 
            lNombre.AutoSize = true;
            lNombre.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lNombre.Location = new Point(3, 0);
            lNombre.Name = "lNombre";
            lNombre.Size = new Size(85, 25);
            lNombre.TabIndex = 0;
            lNombre.Text = "Nombre";
            // 
            // panel4
            // 
            panel4.Controls.Add(roundedPanel5);
            panel4.Controls.Add(lApellido);
            panel4.Location = new Point(593, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(201, 67);
            panel4.TabIndex = 4;
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel5.BorderSize = 4F;
            roundedPanel5.Controls.Add(tbApellido);
            roundedPanel5.Location = new Point(3, 25);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(188, 39);
            roundedPanel5.TabIndex = 1;
            // 
            // tbApellido
            // 
            tbApellido.BackColor = Color.FromArgb(51, 77, 53);
            tbApellido.BorderStyle = BorderStyle.None;
            tbApellido.Location = new Point(5, 7);
            tbApellido.Name = "tbApellido";
            tbApellido.ReadOnly = true;
            tbApellido.Size = new Size(180, 24);
            tbApellido.TabIndex = 0;
            // 
            // lApellido
            // 
            lApellido.AutoSize = true;
            lApellido.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lApellido.Location = new Point(3, 0);
            lApellido.Name = "lApellido";
            lApellido.Size = new Size(89, 25);
            lApellido.TabIndex = 0;
            lApellido.Text = "Apellido";
            // 
            // panel7
            // 
            panel7.Controls.Add(pContrasena);
            panel7.Controls.Add(lContrasena);
            panel7.Location = new Point(800, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(243, 67);
            panel7.TabIndex = 3;
            // 
            // pContrasena
            // 
            pContrasena.BackColor = Color.FromArgb(51, 77, 53);
            pContrasena.BorderSize = 4F;
            pContrasena.Controls.Add(tbTelefono);
            pContrasena.Location = new Point(3, 25);
            pContrasena.Name = "pContrasena";
            pContrasena.Size = new Size(234, 39);
            pContrasena.TabIndex = 1;
            // 
            // tbTelefono
            // 
            tbTelefono.BackColor = Color.FromArgb(51, 77, 53);
            tbTelefono.BorderStyle = BorderStyle.None;
            tbTelefono.Location = new Point(5, 7);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(189, 24);
            tbTelefono.TabIndex = 0;
            tbTelefono.KeyPress += txtSoloNumeros_KeyPress;
            // 
            // lContrasena
            // 
            lContrasena.AutoSize = true;
            lContrasena.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lContrasena.Location = new Point(3, 0);
            lContrasena.Name = "lContrasena";
            lContrasena.Size = new Size(90, 25);
            lContrasena.TabIndex = 0;
            lContrasena.Text = "Telefono";
            lContrasena.Click += lContrasena_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(roundedPanel6);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(3, 76);
            panel5.Name = "panel5";
            panel5.Size = new Size(243, 67);
            panel5.TabIndex = 4;
            // 
            // roundedPanel6
            // 
            roundedPanel6.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel6.BorderSize = 4F;
            roundedPanel6.Controls.Add(tbDni);
            roundedPanel6.Location = new Point(3, 25);
            roundedPanel6.Name = "roundedPanel6";
            roundedPanel6.Size = new Size(234, 39);
            roundedPanel6.TabIndex = 1;
            // 
            // tbDni
            // 
            tbDni.BackColor = Color.FromArgb(51, 77, 53);
            tbDni.BorderStyle = BorderStyle.None;
            tbDni.Location = new Point(5, 7);
            tbDni.Name = "tbDni";
            tbDni.Size = new Size(189, 24);
            tbDni.TabIndex = 0;
            tbDni.KeyPress += txtSoloNumeros_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 30);
            label2.TabIndex = 0;
            label2.Text = "DNI";
            label2.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label3.Location = new Point(25, 622);
            label3.Margin = new Padding(25, 0, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(310, 45);
            label3.TabIndex = 8;
            label3.Text = "Equipos del cliente:";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(roundedPanel7);
            flowLayoutPanel3.Controls.Add(bAgregarEquipo);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(3, 670);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(1229, 227);
            flowLayoutPanel3.TabIndex = 9;
            // 
            // roundedPanel7
            // 
            roundedPanel7.BackColor = Color.White;
            roundedPanel7.BorderSize = 3F;
            roundedPanel7.Controls.Add(dgvEquipos);
            roundedPanel7.Location = new Point(25, 7);
            roundedPanel7.Margin = new Padding(25, 7, 3, 3);
            roundedPanel7.Name = "roundedPanel7";
            roundedPanel7.Size = new Size(950, 223);
            roundedPanel7.TabIndex = 7;
            // 
            // dgvEquipos
            // 
            dgvEquipos.AllowUserToAddRows = false;
            dgvEquipos.AllowUserToDeleteRows = false;
            dgvEquipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipos.Columns.AddRange(new DataGridViewColumn[] { dgvEquiposCId, Nombre, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dgvEquipos.Dock = DockStyle.Fill;
            dgvEquipos.Location = new Point(0, 0);
            dgvEquipos.MultiSelect = false;
            dgvEquipos.Name = "dgvEquipos";
            dgvEquipos.ReadOnly = true;
            dgvEquipos.RowHeadersWidth = 62;
            dgvEquipos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEquipos.Size = new Size(950, 223);
            dgvEquipos.TabIndex = 0;
            dgvEquipos.CellContentClick += dgvEquipos_CellContentClick;
            // 
            // bAgregarEquipo
            // 
            bAgregarEquipo.BackColor = Color.FromArgb(40, 40, 40);
            bAgregarEquipo.FlatAppearance.BorderSize = 0;
            bAgregarEquipo.FlatStyle = FlatStyle.Flat;
            bAgregarEquipo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bAgregarEquipo.ForeColor = Color.Gainsboro;
            bAgregarEquipo.Location = new Point(981, 8);
            bAgregarEquipo.Margin = new Padding(3, 8, 3, 3);
            bAgregarEquipo.Name = "bAgregarEquipo";
            bAgregarEquipo.Size = new Size(230, 45);
            bAgregarEquipo.TabIndex = 8;
            bAgregarEquipo.Text = "Agregar equipo";
            bAgregarEquipo.UseVisualStyleBackColor = false;
            bAgregarEquipo.Click += bAgregarEquipo_Click;
            // 
            // dgvEquiposCId
            // 
            dgvEquiposCId.DataPropertyName = "IdEquipo";
            dgvEquiposCId.HeaderText = "ID";
            dgvEquiposCId.MinimumWidth = 8;
            dgvEquiposCId.Name = "dgvEquiposCId";
            dgvEquiposCId.ReadOnly = true;
            dgvEquiposCId.Resizable = DataGridViewTriState.True;
            dgvEquiposCId.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Descripcion";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "NombreMarca";
            dataGridViewTextBoxColumn2.HeaderText = "Marca";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "NombreTipo";
            dataGridViewTextBoxColumn3.HeaderText = "Tipo";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "NombreEstado";
            dataGridViewTextBoxColumn4.HeaderText = "Estado";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // ClientesView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 77, 53);
            Controls.Add(tlpViews);
            Name = "ClientesView";
            Size = new Size(1235, 900);
            tlpViews.ResumeLayout(false);
            tlpViews.PerformLayout();
            rpFiltro.ResumeLayout(false);
            rpFiltro.PerformLayout();
            rpBarraBusqueda.ResumeLayout(false);
            rpBarraBusqueda.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            pNuevoUsuario.ResumeLayout(false);
            pEditarUsuario.ResumeLayout(false);
            panel10.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            roundedPanel5.ResumeLayout(false);
            roundedPanel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            pContrasena.ResumeLayout(false);
            pContrasena.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            roundedPanel6.ResumeLayout(false);
            roundedPanel6.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            roundedPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpViews;
        private Label label1;
        private Shared.Controls.RoundedPanel rpFiltro;
        private ComboBox cbFiltro;
        private Label lFiltro;
        private Shared.Controls.RoundedPanel rpBarraBusqueda;
        private Label lBusqueda;
        private Shared.Controls.RoundedPanel roundedPanel1;
        private DataGridView dgvClientes;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pNuevoUsuario;
        private Shared.Controls.RoundedButton bNuevoCliente;
        private Panel pEditarUsuario;
        private Shared.Controls.RoundedButton bEditar;
        private Shared.Controls.RoundedButton bGuardarExistente;
        private Panel pEliminarUsuario;
        private Shared.Controls.RoundedButton bEliminar;
        private Panel panel10;
        private Shared.Controls.RoundedButton bCancelar;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel1;
        private Label lId;
        private Shared.Controls.RoundedPanel roundedPanel2;
        private Label lIdContenido;
        private Panel panel2;
        private Shared.Controls.RoundedPanel roundedPanel3;
        private TextBox tbMail;
        private Label lMail;
        private Panel panel3;
        private Shared.Controls.RoundedPanel roundedPanel4;
        private TextBox tbNombre;
        private Label lNombre;
        private Panel panel4;
        private Shared.Controls.RoundedPanel roundedPanel5;
        private TextBox tbApellido;
        private Label lApellido;
        private Panel panel7;
        private Shared.Controls.RoundedPanel pContrasena;
        private TextBox tbTelefono;
        private Label lContrasena;
        private Panel panel5;
        private Shared.Controls.RoundedPanel roundedPanel6;
        private TextBox tbDni;
        private Label label2;
        private Shared.Controls.RoundedPanel roundedPanel7;
        private DataGridView dgvEquipos;
        private Shared.Controls.RoundedButton bGuardarNuevo;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colApellido;
        private DataGridViewTextBoxColumn colRol;
        private DataGridViewTextBoxColumn colActivo;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel3;
        private Shared.Controls.RoundedButton bAgregarEquipo;
        private DataGridViewButtonColumn dgvEquiposCId;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}