namespace Taller_2_Gestor.Features.Presupuestos
{
    partial class PresupuestosView
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
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel1 = new Panel();
            lIDPresupuesto = new Label();
            roundedPanel2 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            lIdContenido = new Label();
            panel2 = new Panel();
            roundedPanel4 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            tbNombre = new TextBox();
            lIDTecnico = new Label();
            panel3 = new Panel();
            roundedPanel5 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            tbApellido = new TextBox();
            lIDAdministrador = new Label();
            panel4 = new Panel();
            roundedPanel3 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            textBox1 = new TextBox();
            lIDEquipo = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pNuevoUsuario = new Panel();
            bNuevoPresupuesto = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            roundedPanel1 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            dgvUsuarios = new DataGridView();
            IDPresupuesto = new DataGridViewTextBoxColumn();
            colId = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            rpBarraBusqueda = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            lBusqueda = new Label();
            rpFiltro = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            comboBox1 = new ComboBox();
            lFiltro = new Label();
            label1 = new Label();
            roundedPanel7 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            panel2.SuspendLayout();
            roundedPanel4.SuspendLayout();
            panel3.SuspendLayout();
            roundedPanel5.SuspendLayout();
            panel4.SuspendLayout();
            roundedPanel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            pNuevoUsuario.SuspendLayout();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            rpBarraBusqueda.SuspendLayout();
            rpFiltro.SuspendLayout();
            roundedPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 5);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 4);
            tableLayoutPanel1.Controls.Add(roundedPanel1, 0, 3);
            tableLayoutPanel1.Controls.Add(rpBarraBusqueda, 0, 2);
            tableLayoutPanel1.Controls.Add(rpFiltro, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(roundedPanel7, 0, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.37051773F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.78087664F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.772908F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.50996F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.9721117F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.9482069F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 38.2470131F));
            tableLayoutPanel1.Size = new Size(718, 502);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(panel1);
            flowLayoutPanel2.Controls.Add(panel2);
            flowLayoutPanel2.Controls.Add(panel3);
            flowLayoutPanel2.Controls.Add(panel4);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(24, 252);
            flowLayoutPanel2.Margin = new Padding(24, 9, 2, 2);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(692, 54);
            flowLayoutPanel2.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Controls.Add(lIDPresupuesto);
            panel1.Controls.Add(roundedPanel2);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(100, 40);
            panel1.TabIndex = 0;
            // 
            // lIDPresupuesto
            // 
            lIDPresupuesto.AutoSize = true;
            lIDPresupuesto.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lIDPresupuesto.Location = new Point(2, 0);
            lIDPresupuesto.Margin = new Padding(2, 0, 2, 0);
            lIDPresupuesto.Name = "lIDPresupuesto";
            lIDPresupuesto.Size = new Size(95, 15);
            lIDPresupuesto.TabIndex = 0;
            lIDPresupuesto.Text = "IdPresupuesto";
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel2.BorderSize = 4F;
            roundedPanel2.Controls.Add(lIdContenido);
            roundedPanel2.Location = new Point(2, 15);
            roundedPanel2.Margin = new Padding(2);
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
            lIdContenido.Size = new Size(37, 15);
            lIdContenido.TabIndex = 0;
            lIdContenido.Text = "12345";
            // 
            // panel2
            // 
            panel2.Controls.Add(roundedPanel4);
            panel2.Controls.Add(lIDTecnico);
            panel2.Location = new Point(106, 2);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(120, 40);
            panel2.TabIndex = 3;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel4.BorderSize = 4F;
            roundedPanel4.Controls.Add(tbNombre);
            roundedPanel4.Location = new Point(2, 15);
            roundedPanel4.Margin = new Padding(2);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(106, 23);
            roundedPanel4.TabIndex = 1;
            // 
            // tbNombre
            // 
            tbNombre.BackColor = Color.FromArgb(51, 77, 53);
            tbNombre.BorderStyle = BorderStyle.None;
            tbNombre.Location = new Point(4, 4);
            tbNombre.Margin = new Padding(2);
            tbNombre.Name = "tbNombre";
            tbNombre.ReadOnly = true;
            tbNombre.Size = new Size(92, 16);
            tbNombre.TabIndex = 0;
            // 
            // lIDTecnico
            // 
            lIDTecnico.AutoSize = true;
            lIDTecnico.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lIDTecnico.Location = new Point(2, 0);
            lIDTecnico.Margin = new Padding(2, 0, 2, 0);
            lIDTecnico.Name = "lIDTecnico";
            lIDTecnico.Size = new Size(67, 15);
            lIDTecnico.TabIndex = 0;
            lIDTecnico.Text = "IDTecnico";
            // 
            // panel3
            // 
            panel3.Controls.Add(roundedPanel5);
            panel3.Controls.Add(lIDAdministrador);
            panel3.Location = new Point(230, 2);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(141, 40);
            panel3.TabIndex = 4;
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel5.BorderSize = 4F;
            roundedPanel5.Controls.Add(tbApellido);
            roundedPanel5.Location = new Point(2, 15);
            roundedPanel5.Margin = new Padding(2);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(132, 23);
            roundedPanel5.TabIndex = 1;
            // 
            // tbApellido
            // 
            tbApellido.BackColor = Color.FromArgb(51, 77, 53);
            tbApellido.BorderStyle = BorderStyle.None;
            tbApellido.Location = new Point(4, 4);
            tbApellido.Margin = new Padding(2);
            tbApellido.Name = "tbApellido";
            tbApellido.ReadOnly = true;
            tbApellido.Size = new Size(126, 16);
            tbApellido.TabIndex = 0;
            // 
            // lIDAdministrador
            // 
            lIDAdministrador.AutoSize = true;
            lIDAdministrador.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lIDAdministrador.Location = new Point(2, 0);
            lIDAdministrador.Margin = new Padding(2, 0, 2, 0);
            lIDAdministrador.Name = "lIDAdministrador";
            lIDAdministrador.Size = new Size(108, 15);
            lIDAdministrador.TabIndex = 0;
            lIDAdministrador.Text = "IDAdministrador";
            // 
            // panel4
            // 
            panel4.Controls.Add(roundedPanel3);
            panel4.Controls.Add(lIDEquipo);
            panel4.Location = new Point(375, 2);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(141, 40);
            panel4.TabIndex = 5;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel3.BorderSize = 4F;
            roundedPanel3.Controls.Add(textBox1);
            roundedPanel3.Location = new Point(2, 15);
            roundedPanel3.Margin = new Padding(2);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(132, 23);
            roundedPanel3.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(51, 77, 53);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(4, 4);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(126, 16);
            textBox1.TabIndex = 0;
            // 
            // lIDEquipo
            // 
            lIDEquipo.AutoSize = true;
            lIDEquipo.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lIDEquipo.Location = new Point(2, 0);
            lIDEquipo.Margin = new Padding(2, 0, 2, 0);
            lIDEquipo.Name = "lIDEquipo";
            lIDEquipo.Size = new Size(63, 15);
            lIDEquipo.TabIndex = 0;
            lIDEquipo.Text = "IDEquipo";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pNuevoUsuario);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(2, 210);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(714, 31);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // pNuevoUsuario
            // 
            pNuevoUsuario.Controls.Add(bNuevoPresupuesto);
            pNuevoUsuario.Location = new Point(24, 2);
            pNuevoUsuario.Margin = new Padding(24, 2, 2, 2);
            pNuevoUsuario.Name = "pNuevoUsuario";
            pNuevoUsuario.Size = new Size(127, 19);
            pNuevoUsuario.TabIndex = 0;
            // 
            // bNuevoPresupuesto
            // 
            bNuevoPresupuesto.BackColor = Color.FromArgb(40, 40, 40);
            bNuevoPresupuesto.Dock = DockStyle.Fill;
            bNuevoPresupuesto.FlatAppearance.BorderSize = 0;
            bNuevoPresupuesto.FlatStyle = FlatStyle.Flat;
            bNuevoPresupuesto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bNuevoPresupuesto.ForeColor = Color.Gainsboro;
            bNuevoPresupuesto.Location = new Point(0, 0);
            bNuevoPresupuesto.Margin = new Padding(2);
            bNuevoPresupuesto.Name = "bNuevoPresupuesto";
            bNuevoPresupuesto.Size = new Size(127, 19);
            bNuevoPresupuesto.TabIndex = 0;
            bNuevoPresupuesto.Text = "Nuevo Presupuesto";
            bNuevoPresupuesto.UseVisualStyleBackColor = false;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BorderSize = 3F;
            roundedPanel1.Controls.Add(dgvUsuarios);
            roundedPanel1.Location = new Point(18, 99);
            roundedPanel1.Margin = new Padding(18, 4, 2, 2);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(664, 96);
            roundedPanel1.TabIndex = 6;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { IDPresupuesto, colId, colEmail, colNombre });
            dgvUsuarios.Dock = DockStyle.Fill;
            dgvUsuarios.Location = new Point(0, 0);
            dgvUsuarios.Margin = new Padding(2);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersWidth = 62;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(664, 96);
            dgvUsuarios.TabIndex = 0;
            // 
            // IDPresupuesto
            // 
            IDPresupuesto.HeaderText = "IDPresupuesto";
            IDPresupuesto.Name = "IDPresupuesto";
            IDPresupuesto.ReadOnly = true;
            // 
            // colId
            // 
            colId.DataPropertyName = "idUsuario";
            colId.HeaderText = "IDTecnico";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "Mail";
            colEmail.HeaderText = "IDAdministrador";
            colEmail.MinimumWidth = 8;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.DataPropertyName = "Nombre";
            colNombre.HeaderText = "IDEquipo";
            colNombre.MinimumWidth = 8;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // rpBarraBusqueda
            // 
            rpBarraBusqueda.BackColor = Color.DarkGray;
            rpBarraBusqueda.BorderColor = Color.DarkGray;
            rpBarraBusqueda.Controls.Add(lBusqueda);
            rpBarraBusqueda.Location = new Point(18, 63);
            rpBarraBusqueda.Margin = new Padding(18, 2, 2, 2);
            rpBarraBusqueda.Name = "rpBarraBusqueda";
            rpBarraBusqueda.Size = new Size(664, 18);
            rpBarraBusqueda.TabIndex = 5;
            // 
            // lBusqueda
            // 
            lBusqueda.AutoSize = true;
            lBusqueda.ForeColor = SystemColors.ControlDarkDark;
            lBusqueda.Location = new Point(17, 3);
            lBusqueda.Margin = new Padding(2, 0, 2, 0);
            lBusqueda.Name = "lBusqueda";
            lBusqueda.Size = new Size(240, 15);
            lBusqueda.TabIndex = 0;
            lBusqueda.Text = "Ingrese un dato del presupuesto para buscar";
            // 
            // rpFiltro
            // 
            rpFiltro.BackColor = Color.FromArgb(33, 33, 33);
            rpFiltro.Controls.Add(comboBox1);
            rpFiltro.Controls.Add(lFiltro);
            rpFiltro.Location = new Point(21, 39);
            rpFiltro.Margin = new Padding(21, 2, 2, 2);
            rpFiltro.Name = "rpFiltro";
            rpFiltro.Size = new Size(181, 17);
            rpFiltro.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(33, 33, 33);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(83, 0);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(97, 23);
            comboBox1.TabIndex = 1;
            // 
            // lFiltro
            // 
            lFiltro.AutoSize = true;
            lFiltro.ForeColor = SystemColors.ButtonHighlight;
            lFiltro.Location = new Point(13, 2);
            lFiltro.Margin = new Padding(2, 0, 2, 0);
            lFiltro.Name = "lFiltro";
            lFiltro.Size = new Size(61, 15);
            lFiltro.TabIndex = 0;
            lFiltro.Text = "Filtrar por:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(2, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(188, 37);
            label1.TabIndex = 2;
            label1.Text = "Presupuestos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // roundedPanel7
            // 
            roundedPanel7.BackColor = Color.White;
            roundedPanel7.BorderSize = 3F;
            roundedPanel7.Controls.Add(dataGridView1);
            roundedPanel7.Location = new Point(18, 312);
            roundedPanel7.Margin = new Padding(18, 4, 2, 2);
            roundedPanel7.Name = "roundedPanel7";
            roundedPanel7.Size = new Size(665, 130);
            roundedPanel7.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(665, 130);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "idUsuario";
            dataGridViewTextBoxColumn1.HeaderText = "IDPresupuesto";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Mail";
            dataGridViewTextBoxColumn2.HeaderText = "Precio";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Nombre";
            dataGridViewTextBoxColumn3.HeaderText = "Servicio";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Apellido";
            dataGridViewTextBoxColumn4.HeaderText = "IDOrden";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // PresupuestosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 77, 53);
            Controls.Add(tableLayoutPanel1);
            Name = "PresupuestosView";
            Size = new Size(718, 502);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            roundedPanel5.ResumeLayout(false);
            roundedPanel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            pNuevoUsuario.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            rpBarraBusqueda.ResumeLayout(false);
            rpBarraBusqueda.PerformLayout();
            rpFiltro.ResumeLayout(false);
            rpFiltro.PerformLayout();
            roundedPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pNuevoUsuario;
        private Shared.Controls.RoundedButton bNuevoPresupuesto;
        private Shared.Controls.RoundedPanel roundedPanel1;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn IDPresupuesto;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colNombre;
        private Shared.Controls.RoundedPanel roundedPanel7;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel1;
        private Label lIDPresupuesto;
        private Shared.Controls.RoundedPanel roundedPanel2;
        private Label lIdContenido;
        private Panel panel2;
        private Shared.Controls.RoundedPanel roundedPanel4;
        private TextBox tbNombre;
        private Label lIDTecnico;
        private Panel panel3;
        private Shared.Controls.RoundedPanel roundedPanel5;
        private TextBox tbApellido;
        private Label lIDAdministrador;
        private Panel panel4;
        private Shared.Controls.RoundedPanel roundedPanel3;
        private TextBox textBox1;
        private Label lIDEquipo;
    }
}
