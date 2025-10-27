namespace Taller_2_Gestor.Features.Centro_de_Tareas_Administrador
{
    partial class TareasAdminView
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
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            roundedPanel1 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            dgvPresupuestosAprobacion = new DataGridView();
            bVerDetalles = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            flowLayoutPanel2 = new FlowLayoutPanel();
            roundedPanel2 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            dgvEquiposReparacion = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            bGenerarOrden = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            colId = new DataGridViewTextBoxColumn();
            NombreCliente = new DataGridViewTextBoxColumn();
            DescripcionEquipo = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPresupuestosAprobacion).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEquiposReparacion).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 308F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1149, 1030);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 420);
            label3.Name = "label3";
            label3.Size = new Size(528, 45);
            label3.TabIndex = 3;
            label3.Text = "Equipos Pendientes de Reparación:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(339, 54);
            label1.TabIndex = 0;
            label1.Text = "Centro de Tareas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 60);
            label2.Name = "label2";
            label2.Size = new Size(606, 45);
            label2.TabIndex = 1;
            label2.Text = "Presupuestos Pendientes de Aprobación";
            label2.Click += label2_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(roundedPanel1);
            flowLayoutPanel1.Controls.Add(bVerDetalles);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 115);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1143, 302);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.Controls.Add(dgvPresupuestosAprobacion);
            roundedPanel1.Location = new Point(26, 3);
            roundedPanel1.Margin = new Padding(26, 3, 3, 3);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(898, 290);
            roundedPanel1.TabIndex = 2;
            // 
            // dgvPresupuestosAprobacion
            // 
            dgvPresupuestosAprobacion.AllowUserToAddRows = false;
            dgvPresupuestosAprobacion.AllowUserToDeleteRows = false;
            dgvPresupuestosAprobacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPresupuestosAprobacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPresupuestosAprobacion.Columns.AddRange(new DataGridViewColumn[] { colId, NombreCliente, DescripcionEquipo });
            dgvPresupuestosAprobacion.Dock = DockStyle.Fill;
            dgvPresupuestosAprobacion.Location = new Point(0, 0);
            dgvPresupuestosAprobacion.MultiSelect = false;
            dgvPresupuestosAprobacion.Name = "dgvPresupuestosAprobacion";
            dgvPresupuestosAprobacion.ReadOnly = true;
            dgvPresupuestosAprobacion.RowHeadersWidth = 62;
            dgvPresupuestosAprobacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPresupuestosAprobacion.Size = new Size(898, 290);
            dgvPresupuestosAprobacion.TabIndex = 1;
            // 
            // bVerDetalles
            // 
            bVerDetalles.BackColor = Color.FromArgb(40, 40, 40);
            bVerDetalles.FlatAppearance.BorderSize = 0;
            bVerDetalles.FlatStyle = FlatStyle.Flat;
            bVerDetalles.ForeColor = Color.Gainsboro;
            bVerDetalles.Location = new Point(930, 3);
            bVerDetalles.Name = "bVerDetalles";
            bVerDetalles.Size = new Size(160, 44);
            bVerDetalles.TabIndex = 0;
            bVerDetalles.Text = "Ver Detalles";
            bVerDetalles.UseVisualStyleBackColor = false;
            bVerDetalles.Click += bVerDetalles_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(roundedPanel2);
            flowLayoutPanel2.Controls.Add(bGenerarOrden);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 483);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1143, 544);
            flowLayoutPanel2.TabIndex = 4;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.White;
            roundedPanel2.Controls.Add(dgvEquiposReparacion);
            roundedPanel2.Location = new Point(26, 3);
            roundedPanel2.Margin = new Padding(26, 3, 3, 3);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(956, 290);
            roundedPanel2.TabIndex = 6;
            // 
            // dgvEquiposReparacion
            // 
            dgvEquiposReparacion.AllowUserToAddRows = false;
            dgvEquiposReparacion.AllowUserToDeleteRows = false;
            dgvEquiposReparacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEquiposReparacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquiposReparacion.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewButtonColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dgvEquiposReparacion.Dock = DockStyle.Fill;
            dgvEquiposReparacion.Location = new Point(0, 0);
            dgvEquiposReparacion.MultiSelect = false;
            dgvEquiposReparacion.Name = "dgvEquiposReparacion";
            dgvEquiposReparacion.ReadOnly = true;
            dgvEquiposReparacion.RowHeadersWidth = 62;
            dgvEquiposReparacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEquiposReparacion.Size = new Size(956, 290);
            dgvEquiposReparacion.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "IdEquipo";
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewButtonColumn1.DataPropertyName = "NombreCompletoCliente";
            dataGridViewButtonColumn1.HeaderText = "Nombre del Cliente";
            dataGridViewButtonColumn1.MinimumWidth = 8;
            dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            dataGridViewButtonColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            dataGridViewTextBoxColumn2.HeaderText = "Descripcion";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "NombreMarca";
            dataGridViewTextBoxColumn3.HeaderText = "Marca";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "NombreTipo";
            dataGridViewTextBoxColumn4.HeaderText = "Tipo";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // bGenerarOrden
            // 
            bGenerarOrden.BackColor = Color.FromArgb(40, 40, 40);
            bGenerarOrden.FlatAppearance.BorderSize = 0;
            bGenerarOrden.FlatStyle = FlatStyle.Flat;
            bGenerarOrden.ForeColor = Color.Gainsboro;
            bGenerarOrden.Location = new Point(3, 299);
            bGenerarOrden.Name = "bGenerarOrden";
            bGenerarOrden.Size = new Size(232, 50);
            bGenerarOrden.TabIndex = 7;
            bGenerarOrden.Text = "Generar Orden de Servicio";
            bGenerarOrden.UseVisualStyleBackColor = false;
            // 
            // colId
            // 
            colId.DataPropertyName = "IdPresupuesto";
            colId.HeaderText = "Id Presupuesto";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // NombreCliente
            // 
            NombreCliente.DataPropertyName = "NombreCliente";
            NombreCliente.HeaderText = "Nombre del Cliente";
            NombreCliente.MinimumWidth = 8;
            NombreCliente.Name = "NombreCliente";
            NombreCliente.ReadOnly = true;
            // 
            // DescripcionEquipo
            // 
            DescripcionEquipo.DataPropertyName = "DescripcionEquipo";
            DescripcionEquipo.HeaderText = "Descripcion del equipo";
            DescripcionEquipo.MinimumWidth = 8;
            DescripcionEquipo.Name = "DescripcionEquipo";
            DescripcionEquipo.ReadOnly = true;
            // 
            // TareasAdminView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 77, 53);
            Controls.Add(tableLayoutPanel1);
            Name = "TareasAdminView";
            Size = new Size(1149, 1030);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPresupuestosAprobacion).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            roundedPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEquiposReparacion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private Label label1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Shared.Controls.RoundedPanel roundedPanel1;
        private DataGridView dgvPresupuestosAprobacion;
        private Shared.Controls.RoundedButton bVerDetalles;
        private FlowLayoutPanel flowLayoutPanel2;
        private Shared.Controls.RoundedPanel roundedPanel2;
        private DataGridView dgvEquiposReparacion;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Shared.Controls.RoundedButton bGenerarOrden;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn NombreCliente;
        private DataGridViewTextBoxColumn DescripcionEquipo;
    }
}
