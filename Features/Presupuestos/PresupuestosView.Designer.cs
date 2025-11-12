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
            roundedPanel1 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            dgvPresupuestos = new DataGridView();
            IDPresupuesto = new DataGridViewTextBoxColumn();
            colId = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            lTitulo = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel1 = new Panel();
            lIDPresupuesto = new Label();
            roundedPanel2 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            tbIdPresupuesto = new TextBox();
            lIdContenido = new Label();
            panel2 = new Panel();
            roundedPanel4 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            tbIdTecnico = new TextBox();
            lIDTecnico = new Label();
            panel3 = new Panel();
            roundedPanel5 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            tbIdAdmin = new TextBox();
            lIDAdministrador = new Label();
            panel4 = new Panel();
            roundedPanel3 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            tbIdEquipo = new TextBox();
            lIDEquipo = new Label();
            panel5 = new Panel();
            roundedPanel6 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            tbFechaActualizacion = new TextBox();
            label2 = new Label();
            roundedPanel7 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            dgvItems = new DataGridView();
            colPrecio = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPresupuestos).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            panel2.SuspendLayout();
            roundedPanel4.SuspendLayout();
            panel3.SuspendLayout();
            roundedPanel5.SuspendLayout();
            panel4.SuspendLayout();
            roundedPanel3.SuspendLayout();
            panel5.SuspendLayout();
            roundedPanel6.SuspendLayout();
            roundedPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(roundedPanel1, 0, 1);
            tableLayoutPanel1.Controls.Add(lTitulo, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(roundedPanel7, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 180F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(718, 502);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BorderSize = 3F;
            roundedPanel1.Controls.Add(dgvPresupuestos);
            roundedPanel1.Location = new Point(18, 40);
            roundedPanel1.Margin = new Padding(18, 4, 2, 2);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(664, 168);
            roundedPanel1.TabIndex = 6;
            // 
            // dgvPresupuestos
            // 
            dgvPresupuestos.AllowUserToAddRows = false;
            dgvPresupuestos.AllowUserToDeleteRows = false;
            dgvPresupuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPresupuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPresupuestos.Columns.AddRange(new DataGridViewColumn[] { IDPresupuesto, colId, colEmail, colNombre, colFecha });
            dgvPresupuestos.Dock = DockStyle.Fill;
            dgvPresupuestos.Location = new Point(0, 0);
            dgvPresupuestos.Margin = new Padding(2, 2, 2, 2);
            dgvPresupuestos.MultiSelect = false;
            dgvPresupuestos.Name = "dgvPresupuestos";
            dgvPresupuestos.ReadOnly = true;
            dgvPresupuestos.RowHeadersWidth = 62;
            dgvPresupuestos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPresupuestos.Size = new Size(664, 168);
            dgvPresupuestos.TabIndex = 0;
            dgvPresupuestos.SelectionChanged += dgvPresupuestos_SelectionChanged;
            // 
            // IDPresupuesto
            // 
            IDPresupuesto.DataPropertyName = "IdPresupuesto";
            IDPresupuesto.HeaderText = "IDPresupuesto";
            IDPresupuesto.MinimumWidth = 8;
            IDPresupuesto.Name = "IDPresupuesto";
            IDPresupuesto.ReadOnly = true;
            // 
            // colId
            // 
            colId.DataPropertyName = "IdTecnico";
            colId.HeaderText = "IDTecnico";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "IdAdministrador";
            colEmail.HeaderText = "IDAdministrador";
            colEmail.MinimumWidth = 8;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.DataPropertyName = "IdEquipo";
            colNombre.HeaderText = "IDEquipo";
            colNombre.MinimumWidth = 8;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colFecha
            // 
            colFecha.DataPropertyName = "FechaActualizacion";
            colFecha.HeaderText = "Fecha Actualizacion";
            colFecha.MinimumWidth = 8;
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            // 
            // lTitulo
            // 
            lTitulo.AutoSize = true;
            lTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lTitulo.Location = new Point(2, 0);
            lTitulo.Margin = new Padding(2, 0, 2, 0);
            lTitulo.Name = "lTitulo";
            lTitulo.Size = new Size(188, 36);
            lTitulo.TabIndex = 2;
            lTitulo.Text = "Presupuestos";
            lTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(panel1);
            flowLayoutPanel2.Controls.Add(panel2);
            flowLayoutPanel2.Controls.Add(panel3);
            flowLayoutPanel2.Controls.Add(panel4);
            flowLayoutPanel2.Controls.Add(panel5);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(24, 225);
            flowLayoutPanel2.Margin = new Padding(24, 9, 2, 2);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(692, 45);
            flowLayoutPanel2.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Controls.Add(lIDPresupuesto);
            panel1.Controls.Add(roundedPanel2);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(100, 40);
            panel1.TabIndex = 0;
            // 
            // lIDPresupuesto
            // 
            lIDPresupuesto.AutoSize = true;
            lIDPresupuesto.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lIDPresupuesto.Location = new Point(-1, 0);
            lIDPresupuesto.Margin = new Padding(2, 0, 2, 0);
            lIDPresupuesto.Name = "lIDPresupuesto";
            lIDPresupuesto.Size = new Size(95, 15);
            lIDPresupuesto.TabIndex = 0;
            lIDPresupuesto.Text = "IdPresupuesto";
            lIDPresupuesto.Click += lIDPresupuesto_Click;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel2.BorderSize = 4F;
            roundedPanel2.Controls.Add(tbIdPresupuesto);
            roundedPanel2.Controls.Add(lIdContenido);
            roundedPanel2.Location = new Point(2, 15);
            roundedPanel2.Margin = new Padding(2, 2, 2, 2);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(52, 23);
            roundedPanel2.TabIndex = 1;
            // 
            // tbIdPresupuesto
            // 
            tbIdPresupuesto.BackColor = Color.FromArgb(51, 77, 53);
            tbIdPresupuesto.BorderStyle = BorderStyle.None;
            tbIdPresupuesto.Location = new Point(2, 2);
            tbIdPresupuesto.Margin = new Padding(2, 2, 2, 2);
            tbIdPresupuesto.Name = "tbIdPresupuesto";
            tbIdPresupuesto.Size = new Size(48, 16);
            tbIdPresupuesto.TabIndex = 1;
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
            panel2.Controls.Add(roundedPanel4);
            panel2.Controls.Add(lIDTecnico);
            panel2.Location = new Point(106, 2);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(120, 40);
            panel2.TabIndex = 3;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel4.BorderSize = 4F;
            roundedPanel4.Controls.Add(tbIdTecnico);
            roundedPanel4.Location = new Point(2, 15);
            roundedPanel4.Margin = new Padding(2, 2, 2, 2);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(106, 23);
            roundedPanel4.TabIndex = 1;
            // 
            // tbIdTecnico
            // 
            tbIdTecnico.BackColor = Color.FromArgb(51, 77, 53);
            tbIdTecnico.BorderStyle = BorderStyle.None;
            tbIdTecnico.Location = new Point(4, 4);
            tbIdTecnico.Margin = new Padding(2, 2, 2, 2);
            tbIdTecnico.Name = "tbIdTecnico";
            tbIdTecnico.ReadOnly = true;
            tbIdTecnico.Size = new Size(92, 16);
            tbIdTecnico.TabIndex = 0;
            // 
            // lIDTecnico
            // 
            lIDTecnico.AutoSize = true;
            lIDTecnico.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lIDTecnico.Location = new Point(2, 0);
            lIDTecnico.Margin = new Padding(2, 0, 2, 0);
            lIDTecnico.Name = "lIDTecnico";
            lIDTecnico.Size = new Size(103, 15);
            lIDTecnico.TabIndex = 0;
            lIDTecnico.Text = "Nombre tecnico";
            // 
            // panel3
            // 
            panel3.Controls.Add(roundedPanel5);
            panel3.Controls.Add(lIDAdministrador);
            panel3.Location = new Point(230, 2);
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(141, 40);
            panel3.TabIndex = 4;
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel5.BorderSize = 4F;
            roundedPanel5.Controls.Add(tbIdAdmin);
            roundedPanel5.Location = new Point(2, 15);
            roundedPanel5.Margin = new Padding(2, 2, 2, 2);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(132, 23);
            roundedPanel5.TabIndex = 1;
            // 
            // tbIdAdmin
            // 
            tbIdAdmin.BackColor = Color.FromArgb(51, 77, 53);
            tbIdAdmin.BorderStyle = BorderStyle.None;
            tbIdAdmin.Location = new Point(4, 4);
            tbIdAdmin.Margin = new Padding(2, 2, 2, 2);
            tbIdAdmin.Name = "tbIdAdmin";
            tbIdAdmin.ReadOnly = true;
            tbIdAdmin.Size = new Size(126, 16);
            tbIdAdmin.TabIndex = 0;
            // 
            // lIDAdministrador
            // 
            lIDAdministrador.AutoSize = true;
            lIDAdministrador.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lIDAdministrador.Location = new Point(2, 0);
            lIDAdministrador.Margin = new Padding(2, 0, 2, 0);
            lIDAdministrador.Name = "lIDAdministrador";
            lIDAdministrador.Size = new Size(99, 15);
            lIDAdministrador.TabIndex = 0;
            lIDAdministrador.Text = "Nombre Admin";
            // 
            // panel4
            // 
            panel4.Controls.Add(roundedPanel3);
            panel4.Controls.Add(lIDEquipo);
            panel4.Location = new Point(375, 2);
            panel4.Margin = new Padding(2, 2, 2, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(141, 40);
            panel4.TabIndex = 5;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel3.BorderSize = 4F;
            roundedPanel3.Controls.Add(tbIdEquipo);
            roundedPanel3.Location = new Point(2, 15);
            roundedPanel3.Margin = new Padding(2, 2, 2, 2);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(132, 23);
            roundedPanel3.TabIndex = 1;
            // 
            // tbIdEquipo
            // 
            tbIdEquipo.BackColor = Color.FromArgb(51, 77, 53);
            tbIdEquipo.BorderStyle = BorderStyle.None;
            tbIdEquipo.Location = new Point(4, 4);
            tbIdEquipo.Margin = new Padding(2, 2, 2, 2);
            tbIdEquipo.Name = "tbIdEquipo";
            tbIdEquipo.ReadOnly = true;
            tbIdEquipo.Size = new Size(126, 16);
            tbIdEquipo.TabIndex = 0;
            // 
            // lIDEquipo
            // 
            lIDEquipo.AutoSize = true;
            lIDEquipo.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lIDEquipo.Location = new Point(2, 0);
            lIDEquipo.Margin = new Padding(2, 0, 2, 0);
            lIDEquipo.Name = "lIDEquipo";
            lIDEquipo.Size = new Size(124, 15);
            lIDEquipo.TabIndex = 0;
            lIDEquipo.Text = "Descripcion Equipo";
            // 
            // panel5
            // 
            panel5.Controls.Add(roundedPanel6);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(520, 2);
            panel5.Margin = new Padding(2, 2, 2, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(141, 40);
            panel5.TabIndex = 6;
            // 
            // roundedPanel6
            // 
            roundedPanel6.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel6.BorderSize = 4F;
            roundedPanel6.Controls.Add(tbFechaActualizacion);
            roundedPanel6.Location = new Point(2, 15);
            roundedPanel6.Margin = new Padding(2, 2, 2, 2);
            roundedPanel6.Name = "roundedPanel6";
            roundedPanel6.Size = new Size(132, 23);
            roundedPanel6.TabIndex = 1;
            // 
            // tbFechaActualizacion
            // 
            tbFechaActualizacion.BackColor = Color.FromArgb(51, 77, 53);
            tbFechaActualizacion.BorderStyle = BorderStyle.None;
            tbFechaActualizacion.Location = new Point(4, 4);
            tbFechaActualizacion.Margin = new Padding(2, 2, 2, 2);
            tbFechaActualizacion.Name = "tbFechaActualizacion";
            tbFechaActualizacion.ReadOnly = true;
            tbFechaActualizacion.Size = new Size(126, 16);
            tbFechaActualizacion.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(2, 0);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 0;
            label2.Text = "Fecha Actualizacion";
            // 
            // roundedPanel7
            // 
            roundedPanel7.BackColor = Color.White;
            roundedPanel7.BorderSize = 3F;
            roundedPanel7.Controls.Add(dgvItems);
            roundedPanel7.Location = new Point(18, 276);
            roundedPanel7.Margin = new Padding(18, 4, 2, 2);
            roundedPanel7.Name = "roundedPanel7";
            roundedPanel7.Size = new Size(665, 130);
            roundedPanel7.TabIndex = 11;
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { colPrecio, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dgvItems.Dock = DockStyle.Fill;
            dgvItems.Location = new Point(0, 0);
            dgvItems.Margin = new Padding(2, 2, 2, 2);
            dgvItems.MultiSelect = false;
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersWidth = 62;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(665, 130);
            dgvItems.TabIndex = 0;
            // 
            // colPrecio
            // 
            colPrecio.DataPropertyName = "IdPresupuesto";
            colPrecio.HeaderText = "IDPresupuesto";
            colPrecio.MinimumWidth = 8;
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
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
            dataGridViewTextBoxColumn4.DataPropertyName = "NombreEstado";
            dataGridViewTextBoxColumn4.HeaderText = "Estado";
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
            roundedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPresupuestos).EndInit();
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
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            roundedPanel6.ResumeLayout(false);
            roundedPanel6.PerformLayout();
            roundedPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lTitulo;
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
        private TextBox tbIdTecnico;
        private Label lIDTecnico;
        private Panel panel3;
        private Shared.Controls.RoundedPanel roundedPanel5;
        private TextBox tbIdAdmin;
        private Label lIDAdministrador;
        private Panel panel4;
        private Shared.Controls.RoundedPanel roundedPanel3;
        private TextBox tbIdEquipo;
        private Label lIDEquipo;
        private TextBox tbIdPresupuesto;
        private Panel panel5;
        private Shared.Controls.RoundedPanel roundedPanel6;
        private TextBox tbFechaActualizacion;
        private Label label2;
        private DataGridViewTextBoxColumn IDPresupuesto;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
