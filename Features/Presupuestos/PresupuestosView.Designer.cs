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
            dgvPresupuestos = new DataGridView();
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
            dgvItems = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dgvPresupuestos).BeginInit();
            rpBarraBusqueda.SuspendLayout();
            rpFiltro.SuspendLayout();
            roundedPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
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
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1026, 837);
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
            flowLayoutPanel2.Location = new Point(34, 500);
            flowLayoutPanel2.Margin = new Padding(34, 15, 3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(989, 82);
            flowLayoutPanel2.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Controls.Add(lIDPresupuesto);
            panel1.Controls.Add(roundedPanel2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(143, 67);
            panel1.TabIndex = 0;
            // 
            // lIDPresupuesto
            // 
            lIDPresupuesto.AutoSize = true;
            lIDPresupuesto.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lIDPresupuesto.Location = new Point(3, 0);
            lIDPresupuesto.Name = "lIDPresupuesto";
            lIDPresupuesto.Size = new Size(141, 25);
            lIDPresupuesto.TabIndex = 0;
            lIDPresupuesto.Text = "IdPresupuesto";
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
            panel2.Controls.Add(roundedPanel4);
            panel2.Controls.Add(lIDTecnico);
            panel2.Location = new Point(152, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(171, 67);
            panel2.TabIndex = 3;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel4.BorderSize = 4F;
            roundedPanel4.Controls.Add(tbNombre);
            roundedPanel4.Location = new Point(3, 25);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(151, 38);
            roundedPanel4.TabIndex = 1;
            // 
            // tbNombre
            // 
            tbNombre.BackColor = Color.FromArgb(51, 77, 53);
            tbNombre.BorderStyle = BorderStyle.None;
            tbNombre.Location = new Point(6, 7);
            tbNombre.Name = "tbNombre";
            tbNombre.ReadOnly = true;
            tbNombre.Size = new Size(131, 24);
            tbNombre.TabIndex = 0;
            // 
            // lIDTecnico
            // 
            lIDTecnico.AutoSize = true;
            lIDTecnico.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lIDTecnico.Location = new Point(3, 0);
            lIDTecnico.Name = "lIDTecnico";
            lIDTecnico.Size = new Size(99, 25);
            lIDTecnico.TabIndex = 0;
            lIDTecnico.Text = "IDTecnico";
            // 
            // panel3
            // 
            panel3.Controls.Add(roundedPanel5);
            panel3.Controls.Add(lIDAdministrador);
            panel3.Location = new Point(329, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(201, 67);
            panel3.TabIndex = 4;
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel5.BorderSize = 4F;
            roundedPanel5.Controls.Add(tbApellido);
            roundedPanel5.Location = new Point(3, 25);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(189, 38);
            roundedPanel5.TabIndex = 1;
            // 
            // tbApellido
            // 
            tbApellido.BackColor = Color.FromArgb(51, 77, 53);
            tbApellido.BorderStyle = BorderStyle.None;
            tbApellido.Location = new Point(6, 7);
            tbApellido.Name = "tbApellido";
            tbApellido.ReadOnly = true;
            tbApellido.Size = new Size(180, 24);
            tbApellido.TabIndex = 0;
            // 
            // lIDAdministrador
            // 
            lIDAdministrador.AutoSize = true;
            lIDAdministrador.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lIDAdministrador.Location = new Point(3, 0);
            lIDAdministrador.Name = "lIDAdministrador";
            lIDAdministrador.Size = new Size(164, 25);
            lIDAdministrador.TabIndex = 0;
            lIDAdministrador.Text = "IDAdministrador";
            // 
            // panel4
            // 
            panel4.Controls.Add(roundedPanel3);
            panel4.Controls.Add(lIDEquipo);
            panel4.Location = new Point(536, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(201, 67);
            panel4.TabIndex = 5;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel3.BorderSize = 4F;
            roundedPanel3.Controls.Add(textBox1);
            roundedPanel3.Location = new Point(3, 25);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(189, 38);
            roundedPanel3.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(51, 77, 53);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(6, 7);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(180, 24);
            textBox1.TabIndex = 0;
            // 
            // lIDEquipo
            // 
            lIDEquipo.AutoSize = true;
            lIDEquipo.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lIDEquipo.Location = new Point(3, 0);
            lIDEquipo.Name = "lIDEquipo";
            lIDEquipo.Size = new Size(94, 25);
            lIDEquipo.TabIndex = 0;
            lIDEquipo.Text = "IDEquipo";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pNuevoUsuario);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 443);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1020, 39);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // pNuevoUsuario
            // 
            pNuevoUsuario.Controls.Add(bNuevoPresupuesto);
            pNuevoUsuario.Location = new Point(34, 3);
            pNuevoUsuario.Margin = new Padding(34, 3, 3, 3);
            pNuevoUsuario.Name = "pNuevoUsuario";
            pNuevoUsuario.Size = new Size(181, 32);
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
            bNuevoPresupuesto.Name = "bNuevoPresupuesto";
            bNuevoPresupuesto.Size = new Size(181, 32);
            bNuevoPresupuesto.TabIndex = 0;
            bNuevoPresupuesto.Text = "Nuevo Presupuesto";
            bNuevoPresupuesto.UseVisualStyleBackColor = false;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BorderSize = 3F;
            roundedPanel1.Controls.Add(dgvPresupuestos);
            roundedPanel1.Location = new Point(26, 147);
            roundedPanel1.Margin = new Padding(26, 7, 3, 3);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(949, 280);
            roundedPanel1.TabIndex = 6;
            // 
            // dgvPresupuestos
            // 
            dgvPresupuestos.AllowUserToAddRows = false;
            dgvPresupuestos.AllowUserToDeleteRows = false;
            dgvPresupuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPresupuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPresupuestos.Columns.AddRange(new DataGridViewColumn[] { IDPresupuesto, colId, colEmail, colNombre });
            dgvPresupuestos.Dock = DockStyle.Fill;
            dgvPresupuestos.Location = new Point(0, 0);
            dgvPresupuestos.MultiSelect = false;
            dgvPresupuestos.Name = "dgvPresupuestos";
            dgvPresupuestos.ReadOnly = true;
            dgvPresupuestos.RowHeadersWidth = 62;
            dgvPresupuestos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPresupuestos.Size = new Size(949, 280);
            dgvPresupuestos.TabIndex = 0;
            // 
            // IDPresupuesto
            // 
            IDPresupuesto.DataPropertyName = "ID";
            IDPresupuesto.HeaderText = "IDPresupuesto";
            IDPresupuesto.MinimumWidth = 8;
            IDPresupuesto.Name = "IDPresupuesto";
            IDPresupuesto.ReadOnly = true;
            // 
            // colId
            // 
            colId.DataPropertyName = "IDtecnico";
            colId.HeaderText = "IDTecnico";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "IDadministrado";
            colEmail.HeaderText = "IDAdministrador";
            colEmail.MinimumWidth = 8;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.DataPropertyName = "IDequipo";
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
            rpBarraBusqueda.Location = new Point(26, 103);
            rpBarraBusqueda.Margin = new Padding(26, 3, 3, 3);
            rpBarraBusqueda.Name = "rpBarraBusqueda";
            rpBarraBusqueda.Size = new Size(949, 30);
            rpBarraBusqueda.TabIndex = 5;
            // 
            // lBusqueda
            // 
            lBusqueda.AutoSize = true;
            lBusqueda.ForeColor = SystemColors.ControlDarkDark;
            lBusqueda.Location = new Point(24, 5);
            lBusqueda.Name = "lBusqueda";
            lBusqueda.Size = new Size(367, 25);
            lBusqueda.TabIndex = 0;
            lBusqueda.Text = "Ingrese un dato del presupuesto para buscar";
            // 
            // rpFiltro
            // 
            rpFiltro.BackColor = Color.FromArgb(33, 33, 33);
            rpFiltro.Controls.Add(comboBox1);
            rpFiltro.Controls.Add(lFiltro);
            rpFiltro.Location = new Point(30, 63);
            rpFiltro.Margin = new Padding(30, 3, 3, 3);
            rpFiltro.Name = "rpFiltro";
            rpFiltro.Size = new Size(259, 28);
            rpFiltro.TabIndex = 4;
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
            label1.Size = new Size(275, 54);
            label1.TabIndex = 2;
            label1.Text = "Presupuestos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // roundedPanel7
            // 
            roundedPanel7.BackColor = Color.White;
            roundedPanel7.BorderSize = 3F;
            roundedPanel7.Controls.Add(dgvItems);
            roundedPanel7.Location = new Point(26, 592);
            roundedPanel7.Margin = new Padding(26, 7, 3, 3);
            roundedPanel7.Name = "roundedPanel7";
            roundedPanel7.Size = new Size(950, 217);
            roundedPanel7.TabIndex = 11;
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
            dgvItems.Size = new Size(950, 217);
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
            // PresupuestosView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 77, 53);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "PresupuestosView";
            Size = new Size(1026, 837);
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
            ((System.ComponentModel.ISupportInitialize)dgvPresupuestos).EndInit();
            rpBarraBusqueda.ResumeLayout(false);
            rpBarraBusqueda.PerformLayout();
            rpFiltro.ResumeLayout(false);
            rpFiltro.PerformLayout();
            roundedPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
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
        private DataGridView dgvPresupuestos;
        private Shared.Controls.RoundedPanel roundedPanel7;
        private DataGridView dgvItems;
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
        private DataGridViewTextBoxColumn IDPresupuesto;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
