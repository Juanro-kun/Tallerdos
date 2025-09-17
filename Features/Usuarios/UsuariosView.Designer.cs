using Taller_2_Gestor.Domain.Entities;
using Taller_2_Gestor.Features.Shared.Controls;

namespace Taller_2_Gestor.Views
{
    partial class UsuariosView
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
            rpFiltro = new RoundedPanel();
            comboBox1 = new ComboBox();
            lFiltro = new Label();
            rpBarraBusqueda = new RoundedPanel();
            lBusqueda = new Label();
            roundedPanel1 = new RoundedPanel();
            dgvUsuarios = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colApellido = new DataGridViewTextBoxColumn();
            colRol = new DataGridViewTextBoxColumn();
            colActivo = new DataGridViewCheckBoxColumn();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pNuevoUsuario = new Panel();
            bGuardarNuevo = new RoundedButton();
            bNuevoUsuario = new RoundedButton();
            pEditarUsuario = new Panel();
            bEditar = new RoundedButton();
            bGuardarExistente = new RoundedButton();
            panel9 = new Panel();
            bCambiarContrasena = new RoundedButton();
            bGuardarContrasena = new RoundedButton();
            pEliminarUsuario = new Panel();
            bEliminar = new RoundedButton();
            panel10 = new Panel();
            bCancelar = new RoundedButton();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel1 = new Panel();
            lId = new Label();
            roundedPanel2 = new RoundedPanel();
            lIdContenido = new Label();
            panel2 = new Panel();
            roundedPanel3 = new RoundedPanel();
            tbMail = new TextBox();
            lMail = new Label();
            panel3 = new Panel();
            roundedPanel4 = new RoundedPanel();
            tbNombre = new TextBox();
            lNombre = new Label();
            panel4 = new Panel();
            roundedPanel5 = new RoundedPanel();
            tbApellido = new TextBox();
            lApellido = new Label();
            panel5 = new Panel();
            roundedPanel6 = new RoundedPanel();
            cbRol = new ComboBox();
            lRol = new Label();
            panel6 = new Panel();
            lActivo = new Label();
            chbActivo = new CheckBox();
            panel7 = new Panel();
            pContrasena = new RoundedPanel();
            tbContrasena = new TextBox();
            lContrasena = new Label();
            panel8 = new Panel();
            pCContrasena = new RoundedPanel();
            tbCContrasena = new TextBox();
            lCContrasena = new Label();
            tlpViews.SuspendLayout();
            rpFiltro.SuspendLayout();
            rpBarraBusqueda.SuspendLayout();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            pNuevoUsuario.SuspendLayout();
            pEditarUsuario.SuspendLayout();
            panel9.SuspendLayout();
            pEliminarUsuario.SuspendLayout();
            panel10.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            panel2.SuspendLayout();
            roundedPanel3.SuspendLayout();
            panel3.SuspendLayout();
            roundedPanel4.SuspendLayout();
            panel4.SuspendLayout();
            roundedPanel5.SuspendLayout();
            panel5.SuspendLayout();
            roundedPanel6.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            pContrasena.SuspendLayout();
            panel8.SuspendLayout();
            pCContrasena.SuspendLayout();
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
            tlpViews.Dock = DockStyle.Fill;
            tlpViews.Location = new Point(0, 0);
            tlpViews.Name = "tlpViews";
            tlpViews.RowCount = 6;
            tlpViews.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tlpViews.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tlpViews.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tlpViews.RowStyles.Add(new RowStyle(SizeType.Percent, 36F));
            tlpViews.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tlpViews.RowStyles.Add(new RowStyle(SizeType.Percent, 39F));
            tlpViews.Size = new Size(1016, 688);
            tlpViews.TabIndex = 0;
            tlpViews.Paint += tableLayoutPanel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(185, 48);
            label1.TabIndex = 0;
            label1.Text = "Usuarios";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rpFiltro
            // 
            rpFiltro.BackColor = Color.FromArgb(33, 33, 33);
            rpFiltro.Controls.Add(comboBox1);
            rpFiltro.Controls.Add(lFiltro);
            rpFiltro.Location = new Point(30, 51);
            rpFiltro.Margin = new Padding(30, 3, 3, 3);
            rpFiltro.Name = "rpFiltro";
            rpFiltro.Size = new Size(258, 35);
            rpFiltro.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(33, 33, 33);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(118, 0);
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
            lFiltro.Click += label2_Click;
            // 
            // rpBarraBusqueda
            // 
            rpBarraBusqueda.BackColor = Color.DarkGray;
            rpBarraBusqueda.BorderColor = Color.DarkGray;
            rpBarraBusqueda.Controls.Add(lBusqueda);
            rpBarraBusqueda.Location = new Point(25, 92);
            rpBarraBusqueda.Margin = new Padding(25, 3, 3, 3);
            rpBarraBusqueda.Name = "rpBarraBusqueda";
            rpBarraBusqueda.Size = new Size(950, 35);
            rpBarraBusqueda.TabIndex = 3;
            // 
            // lBusqueda
            // 
            lBusqueda.AutoSize = true;
            lBusqueda.ForeColor = SystemColors.ControlDarkDark;
            lBusqueda.Location = new Point(24, 5);
            lBusqueda.Name = "lBusqueda";
            lBusqueda.Size = new Size(326, 25);
            lBusqueda.TabIndex = 0;
            lBusqueda.Text = "Ingrese un dato del usuario para buscar";
            lBusqueda.Click += label2_Click_1;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BorderSize = 3F;
            roundedPanel1.Controls.Add(dgvUsuarios);
            roundedPanel1.Location = new Point(25, 137);
            roundedPanel1.Margin = new Padding(25, 7, 3, 3);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(950, 237);
            roundedPanel1.TabIndex = 4;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { colId, colEmail, colNombre, colApellido, colRol, colActivo });
            dgvUsuarios.Dock = DockStyle.Fill;
            dgvUsuarios.Location = new Point(0, 0);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersWidth = 62;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(950, 237);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // colId
            // 
            colId.DataPropertyName = "idUsuario";
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
            colRol.DataPropertyName = "RolNombre";
            colRol.HeaderText = "Rol";
            colRol.MinimumWidth = 8;
            colRol.Name = "colRol";
            colRol.ReadOnly = true;
            // 
            // colActivo
            // 
            colActivo.DataPropertyName = "Active";
            colActivo.HeaderText = "Activo";
            colActivo.MinimumWidth = 8;
            colActivo.Name = "colActivo";
            colActivo.ReadOnly = true;
            colActivo.Resizable = DataGridViewTriState.True;
            colActivo.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pNuevoUsuario);
            flowLayoutPanel1.Controls.Add(pEditarUsuario);
            flowLayoutPanel1.Controls.Add(panel9);
            flowLayoutPanel1.Controls.Add(pEliminarUsuario);
            flowLayoutPanel1.Controls.Add(panel10);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 380);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1010, 35);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // pNuevoUsuario
            // 
            pNuevoUsuario.Controls.Add(bGuardarNuevo);
            pNuevoUsuario.Controls.Add(bNuevoUsuario);
            pNuevoUsuario.Location = new Point(35, 3);
            pNuevoUsuario.Margin = new Padding(35, 3, 3, 3);
            pNuevoUsuario.Name = "pNuevoUsuario";
            pNuevoUsuario.Size = new Size(182, 32);
            pNuevoUsuario.TabIndex = 0;
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
            bGuardarNuevo.Size = new Size(182, 32);
            bGuardarNuevo.TabIndex = 1;
            bGuardarNuevo.Text = "Guardar";
            bGuardarNuevo.UseVisualStyleBackColor = false;
            bGuardarNuevo.Visible = false;
            bGuardarNuevo.Click += bGuardarNuevo_Click;
            // 
            // bNuevoUsuario
            // 
            bNuevoUsuario.BackColor = Color.FromArgb(40, 40, 40);
            bNuevoUsuario.Dock = DockStyle.Fill;
            bNuevoUsuario.FlatAppearance.BorderSize = 0;
            bNuevoUsuario.FlatStyle = FlatStyle.Flat;
            bNuevoUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bNuevoUsuario.ForeColor = Color.Gainsboro;
            bNuevoUsuario.Location = new Point(0, 0);
            bNuevoUsuario.Name = "bNuevoUsuario";
            bNuevoUsuario.Size = new Size(182, 32);
            bNuevoUsuario.TabIndex = 0;
            bNuevoUsuario.Text = "Nuevo Usuario";
            bNuevoUsuario.UseVisualStyleBackColor = false;
            bNuevoUsuario.Click += bNuevoUsuario_Click;
            // 
            // pEditarUsuario
            // 
            pEditarUsuario.Controls.Add(bEditar);
            pEditarUsuario.Controls.Add(bGuardarExistente);
            pEditarUsuario.Location = new Point(223, 3);
            pEditarUsuario.Name = "pEditarUsuario";
            pEditarUsuario.Size = new Size(182, 32);
            pEditarUsuario.TabIndex = 1;
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
            bEditar.Text = "Editar Usuario";
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
            bGuardarExistente.Name = "bGuardarExistente";
            bGuardarExistente.Size = new Size(182, 32);
            bGuardarExistente.TabIndex = 2;
            bGuardarExistente.Text = "Guardar";
            bGuardarExistente.UseVisualStyleBackColor = false;
            bGuardarExistente.Visible = false;
            bGuardarExistente.Click += bGuardarExistente_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(bCambiarContrasena);
            panel9.Controls.Add(bGuardarContrasena);
            panel9.Location = new Point(411, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(189, 31);
            panel9.TabIndex = 3;
            // 
            // bCambiarContrasena
            // 
            bCambiarContrasena.BackColor = Color.FromArgb(40, 40, 40);
            bCambiarContrasena.Dock = DockStyle.Fill;
            bCambiarContrasena.FlatAppearance.BorderSize = 0;
            bCambiarContrasena.FlatStyle = FlatStyle.Flat;
            bCambiarContrasena.ForeColor = Color.Gainsboro;
            bCambiarContrasena.Location = new Point(0, 0);
            bCambiarContrasena.Name = "bCambiarContrasena";
            bCambiarContrasena.Size = new Size(189, 31);
            bCambiarContrasena.TabIndex = 0;
            bCambiarContrasena.Text = "Cambiar Contraseña";
            bCambiarContrasena.UseVisualStyleBackColor = false;
            bCambiarContrasena.Click += bCambiarContrasena_Click;
            // 
            // bGuardarContrasena
            // 
            bGuardarContrasena.BackColor = Color.FromArgb(40, 40, 40);
            bGuardarContrasena.Dock = DockStyle.Fill;
            bGuardarContrasena.FlatAppearance.BorderSize = 0;
            bGuardarContrasena.FlatStyle = FlatStyle.Flat;
            bGuardarContrasena.ForeColor = Color.Gainsboro;
            bGuardarContrasena.Location = new Point(0, 0);
            bGuardarContrasena.Name = "bGuardarContrasena";
            bGuardarContrasena.Size = new Size(189, 31);
            bGuardarContrasena.TabIndex = 4;
            bGuardarContrasena.Text = "Guardar";
            bGuardarContrasena.UseVisualStyleBackColor = false;
            bGuardarContrasena.Visible = false;
            bGuardarContrasena.Click += bGuardarContrasena_Click;
            // 
            // pEliminarUsuario
            // 
            pEliminarUsuario.Controls.Add(bEliminar);
            pEliminarUsuario.Location = new Point(606, 3);
            pEliminarUsuario.Name = "pEliminarUsuario";
            pEliminarUsuario.Size = new Size(182, 32);
            pEliminarUsuario.TabIndex = 2;
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
            bEliminar.Size = new Size(182, 32);
            bEliminar.TabIndex = 4;
            bEliminar.Text = "Eliminar Usuario";
            bEliminar.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            panel10.Controls.Add(bCancelar);
            panel10.Location = new Point(794, 3);
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
            flowLayoutPanel2.Controls.Add(panel5);
            flowLayoutPanel2.Controls.Add(panel6);
            flowLayoutPanel2.Controls.Add(panel7);
            flowLayoutPanel2.Controls.Add(panel8);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(35, 433);
            flowLayoutPanel2.Margin = new Padding(35, 15, 3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(978, 252);
            flowLayoutPanel2.TabIndex = 6;
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
            lId.Size = new Size(30, 25);
            lId.TabIndex = 0;
            lId.Text = "Id";
            lId.Click += label2_Click_2;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel2.BorderSize = 4F;
            roundedPanel2.Controls.Add(lIdContenido);
            roundedPanel2.Location = new Point(3, 25);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(74, 39);
            roundedPanel2.TabIndex = 1;
            // 
            // lIdContenido
            // 
            lIdContenido.AutoSize = true;
            lIdContenido.Location = new Point(8, 7);
            lIdContenido.Name = "lIdContenido";
            lIdContenido.Size = new Size(62, 25);
            lIdContenido.TabIndex = 0;
            lIdContenido.Text = "12345";
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
            // panel5
            // 
            panel5.Controls.Add(roundedPanel6);
            panel5.Controls.Add(lRol);
            panel5.Location = new Point(3, 76);
            panel5.Name = "panel5";
            panel5.Size = new Size(201, 67);
            panel5.TabIndex = 5;
            // 
            // roundedPanel6
            // 
            roundedPanel6.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel6.BorderSize = 4F;
            roundedPanel6.Controls.Add(cbRol);
            roundedPanel6.Location = new Point(3, 25);
            roundedPanel6.Name = "roundedPanel6";
            roundedPanel6.Size = new Size(191, 39);
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
            cbRol.Size = new Size(182, 33);
            cbRol.TabIndex = 0;
            // 
            // lRol
            // 
            lRol.AutoSize = true;
            lRol.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lRol.Location = new Point(3, 0);
            lRol.Name = "lRol";
            lRol.Size = new Size(41, 25);
            lRol.TabIndex = 0;
            lRol.Text = "Rol";
            // 
            // panel6
            // 
            panel6.Controls.Add(lActivo);
            panel6.Controls.Add(chbActivo);
            panel6.Location = new Point(210, 76);
            panel6.Name = "panel6";
            panel6.Size = new Size(77, 67);
            panel6.TabIndex = 6;
            // 
            // lActivo
            // 
            lActivo.AutoSize = true;
            lActivo.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lActivo.Location = new Point(3, 0);
            lActivo.Name = "lActivo";
            lActivo.Size = new Size(71, 25);
            lActivo.TabIndex = 0;
            lActivo.Text = "Activo";
            // 
            // chbActivo
            // 
            chbActivo.AutoSize = true;
            chbActivo.Enabled = false;
            chbActivo.Location = new Point(23, 28);
            chbActivo.Name = "chbActivo";
            chbActivo.Size = new Size(22, 21);
            chbActivo.TabIndex = 6;
            chbActivo.UseVisualStyleBackColor = true;
            chbActivo.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // panel7
            // 
            panel7.Controls.Add(pContrasena);
            panel7.Controls.Add(lContrasena);
            panel7.Location = new Point(293, 76);
            panel7.Name = "panel7";
            panel7.Size = new Size(243, 67);
            panel7.TabIndex = 3;
            // 
            // pContrasena
            // 
            pContrasena.BackColor = Color.FromArgb(51, 77, 53);
            pContrasena.BorderSize = 4F;
            pContrasena.Controls.Add(tbContrasena);
            pContrasena.Location = new Point(3, 25);
            pContrasena.Name = "pContrasena";
            pContrasena.Size = new Size(234, 39);
            pContrasena.TabIndex = 1;
            pContrasena.Visible = false;
            // 
            // tbContrasena
            // 
            tbContrasena.BackColor = Color.FromArgb(51, 77, 53);
            tbContrasena.BorderStyle = BorderStyle.None;
            tbContrasena.Location = new Point(5, 7);
            tbContrasena.Name = "tbContrasena";
            tbContrasena.Size = new Size(189, 24);
            tbContrasena.TabIndex = 0;
            tbContrasena.Visible = false;
            // 
            // lContrasena
            // 
            lContrasena.AutoSize = true;
            lContrasena.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lContrasena.Location = new Point(3, 0);
            lContrasena.Name = "lContrasena";
            lContrasena.Size = new Size(111, 25);
            lContrasena.TabIndex = 0;
            lContrasena.Text = "Contraseña";
            lContrasena.Visible = false;
            lContrasena.Click += label2_Click_3;
            // 
            // panel8
            // 
            panel8.Controls.Add(pCContrasena);
            panel8.Controls.Add(lCContrasena);
            panel8.Location = new Point(542, 76);
            panel8.Name = "panel8";
            panel8.Size = new Size(243, 67);
            panel8.TabIndex = 3;
            // 
            // pCContrasena
            // 
            pCContrasena.BackColor = Color.FromArgb(51, 77, 53);
            pCContrasena.BorderSize = 4F;
            pCContrasena.Controls.Add(tbCContrasena);
            pCContrasena.Location = new Point(3, 25);
            pCContrasena.Name = "pCContrasena";
            pCContrasena.Size = new Size(234, 39);
            pCContrasena.TabIndex = 1;
            pCContrasena.Visible = false;
            // 
            // tbCContrasena
            // 
            tbCContrasena.BackColor = Color.FromArgb(51, 77, 53);
            tbCContrasena.BorderStyle = BorderStyle.None;
            tbCContrasena.Location = new Point(5, 7);
            tbCContrasena.Name = "tbCContrasena";
            tbCContrasena.Size = new Size(189, 24);
            tbCContrasena.TabIndex = 0;
            tbCContrasena.Visible = false;
            // 
            // lCContrasena
            // 
            lCContrasena.AutoSize = true;
            lCContrasena.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lCContrasena.Location = new Point(3, 0);
            lCContrasena.Name = "lCContrasena";
            lCContrasena.Size = new Size(206, 25);
            lCContrasena.TabIndex = 0;
            lCContrasena.Text = "Confirmar Contraseña";
            lCContrasena.Visible = false;
            // 
            // UsuariosView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 77, 53);
            Controls.Add(tlpViews);
            Name = "UsuariosView";
            Size = new Size(1016, 688);
            Load += UsuariosView_Load;
            tlpViews.ResumeLayout(false);
            tlpViews.PerformLayout();
            rpFiltro.ResumeLayout(false);
            rpFiltro.PerformLayout();
            rpBarraBusqueda.ResumeLayout(false);
            rpBarraBusqueda.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            pNuevoUsuario.ResumeLayout(false);
            pEditarUsuario.ResumeLayout(false);
            panel9.ResumeLayout(false);
            pEliminarUsuario.ResumeLayout(false);
            panel10.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
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
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            roundedPanel6.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            pContrasena.ResumeLayout(false);
            pContrasena.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            pCContrasena.ResumeLayout(false);
            pCContrasena.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private TableLayoutPanel tlpViews;
        private Label label1;
        private RoundedPanel rpFiltro;
        private Label lFiltro;
        private ComboBox comboBox1;
        private RoundedPanel rpBarraBusqueda;
        private Label lBusqueda;
        private RoundedPanel roundedPanel1;
        private DataGridView dgvUsuarios;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pNuevoUsuario;
        private RoundedButton bGuardarNuevo;
        private RoundedButton bNuevoUsuario;
        private Panel pEditarUsuario;
        private RoundedButton bEditar;
        private RoundedButton bGuardarExistente;
        private Panel pEliminarUsuario;
        private RoundedButton bEliminar;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel1;
        private Label lId;
        private RoundedPanel roundedPanel2;
        private Panel panel2;
        private RoundedPanel roundedPanel3;
        private Label lMail;
        private Label lIdContenido;
        private TextBox tbMail;
        private Panel panel3;
        private RoundedPanel roundedPanel4;
        private TextBox tbNombre;
        private Label lNombre;
        private Panel panel4;
        private RoundedPanel roundedPanel5;
        private TextBox tbApellido;
        private Label lApellido;
        private Panel panel5;
        private RoundedPanel roundedPanel6;
        private ComboBox cbRol;
        private Label lRol;
        private DataGridViewTextBoxColumn rolDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colApellido;
        private DataGridViewTextBoxColumn colRol;
        private DataGridViewCheckBoxColumn colActivo;
        private CheckBox chbActivo;
        private Panel panel6;
        private Label lActivo;
        private Panel panel7;
        private RoundedPanel pContrasena;
        private TextBox tbContrasena;
        private Label lContrasena;
        private Panel panel8;
        private RoundedPanel pCContrasena;
        private TextBox tbCContrasena;
        private Label lCContrasena;
        private Panel panel9;
        private RoundedButton bCambiarContrasena;
        private RoundedButton bGuardarContrasena;
        private Panel panel10;
        private RoundedButton bCancelar;
    }
}
