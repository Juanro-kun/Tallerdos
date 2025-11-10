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
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            roundedPanel1 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            dgvPresupuestosAprobacion = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            NombreCliente = new DataGridViewTextBoxColumn();
            DescripcionEquipo = new DataGridViewTextBoxColumn();
            bVerDetalles = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            flowLayoutPanel2 = new FlowLayoutPanel();
            roundedPanel2 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            dgvPendientesContacto = new DataGridView();
            colDescripcion = new DataGridViewTextBoxColumn();
            colMarca = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colNombreCliente = new DataGridViewTextBoxColumn();
            colMail = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            bMarcarContactado = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            label5 = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            roundedPanel3 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            dgvPospuestos = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            bDetallePospuestos = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            flowLayoutPanel4 = new FlowLayoutPanel();
            roundedPanel4 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            dgvListos = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            bMarcarRetirado = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPresupuestosAprobacion).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPendientesContacto).BeginInit();
            flowLayoutPanel3.SuspendLayout();
            roundedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPospuestos).BeginInit();
            flowLayoutPanel4.SuspendLayout();
            roundedPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListos).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label4, 0, 5);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 4);
            tableLayoutPanel1.Controls.Add(label5, 0, 7);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel3, 0, 6);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel4, 0, 8);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 308F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1195, 1618);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 780);
            label4.Name = "label4";
            label4.Size = new Size(418, 45);
            label4.TabIndex = 5;
            label4.Text = "Consultar por postergacion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 420);
            label3.Name = "label3";
            label3.Size = new Size(339, 45);
            label3.TabIndex = 3;
            label3.Text = "Avisar reparacion lista";
            label3.Click += label3_Click;
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
            flowLayoutPanel1.Size = new Size(1189, 302);
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
            flowLayoutPanel2.Controls.Add(bMarcarContactado);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 483);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1189, 294);
            flowLayoutPanel2.TabIndex = 4;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.White;
            roundedPanel2.Controls.Add(dgvPendientesContacto);
            roundedPanel2.Location = new Point(26, 3);
            roundedPanel2.Margin = new Padding(26, 3, 3, 3);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(911, 290);
            roundedPanel2.TabIndex = 6;
            // 
            // dgvPendientesContacto
            // 
            dgvPendientesContacto.AllowUserToAddRows = false;
            dgvPendientesContacto.AllowUserToDeleteRows = false;
            dgvPendientesContacto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPendientesContacto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPendientesContacto.Columns.AddRange(new DataGridViewColumn[] { colDescripcion, colMarca, colTipo, colNombreCliente, colMail, colTelefono });
            dgvPendientesContacto.Dock = DockStyle.Fill;
            dgvPendientesContacto.Location = new Point(0, 0);
            dgvPendientesContacto.MultiSelect = false;
            dgvPendientesContacto.Name = "dgvPendientesContacto";
            dgvPendientesContacto.ReadOnly = true;
            dgvPendientesContacto.RowHeadersWidth = 62;
            dgvPendientesContacto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPendientesContacto.Size = new Size(911, 290);
            dgvPendientesContacto.TabIndex = 2;
            // 
            // colDescripcion
            // 
            colDescripcion.DataPropertyName = "Nombre";
            colDescripcion.HeaderText = "Descripcion";
            colDescripcion.MinimumWidth = 8;
            colDescripcion.Name = "colDescripcion";
            colDescripcion.ReadOnly = true;
            // 
            // colMarca
            // 
            colMarca.DataPropertyName = "NombreMarca";
            colMarca.HeaderText = "Marca";
            colMarca.MinimumWidth = 8;
            colMarca.Name = "colMarca";
            colMarca.ReadOnly = true;
            // 
            // colTipo
            // 
            colTipo.DataPropertyName = "NombreTipo";
            colTipo.HeaderText = "Tipo";
            colTipo.MinimumWidth = 8;
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            // 
            // colNombreCliente
            // 
            colNombreCliente.DataPropertyName = "NombreCompletoCliente";
            colNombreCliente.HeaderText = "Nombre Cliente";
            colNombreCliente.MinimumWidth = 8;
            colNombreCliente.Name = "colNombreCliente";
            colNombreCliente.ReadOnly = true;
            // 
            // colMail
            // 
            colMail.DataPropertyName = "MailCliente";
            colMail.HeaderText = "Mail";
            colMail.MinimumWidth = 8;
            colMail.Name = "colMail";
            colMail.ReadOnly = true;
            // 
            // colTelefono
            // 
            colTelefono.DataPropertyName = "TelefonoCliente";
            colTelefono.HeaderText = "Telefono";
            colTelefono.MinimumWidth = 8;
            colTelefono.Name = "colTelefono";
            colTelefono.ReadOnly = true;
            // 
            // bMarcarContactado
            // 
            bMarcarContactado.BackColor = Color.FromArgb(40, 40, 40);
            bMarcarContactado.FlatAppearance.BorderSize = 0;
            bMarcarContactado.FlatStyle = FlatStyle.Flat;
            bMarcarContactado.ForeColor = Color.Gainsboro;
            bMarcarContactado.Location = new Point(943, 3);
            bMarcarContactado.Name = "bMarcarContactado";
            bMarcarContactado.Size = new Size(232, 50);
            bMarcarContactado.TabIndex = 7;
            bMarcarContactado.Text = "Marcar como contactado";
            bMarcarContactado.UseVisualStyleBackColor = false;
            bMarcarContactado.Click += bMarcarContactado_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 1140);
            label5.Name = "label5";
            label5.Size = new Size(392, 45);
            label5.TabIndex = 6;
            label5.Text = "Equipos listos para retirar";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(roundedPanel3);
            flowLayoutPanel3.Controls.Add(bDetallePospuestos);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(3, 843);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(1189, 294);
            flowLayoutPanel3.TabIndex = 7;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.White;
            roundedPanel3.Controls.Add(dgvPospuestos);
            roundedPanel3.Location = new Point(26, 3);
            roundedPanel3.Margin = new Padding(26, 3, 3, 3);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(911, 290);
            roundedPanel3.TabIndex = 7;
            // 
            // dgvPospuestos
            // 
            dgvPospuestos.AllowUserToAddRows = false;
            dgvPospuestos.AllowUserToDeleteRows = false;
            dgvPospuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPospuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPospuestos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dgvPospuestos.Dock = DockStyle.Fill;
            dgvPospuestos.Location = new Point(0, 0);
            dgvPospuestos.MultiSelect = false;
            dgvPospuestos.Name = "dgvPospuestos";
            dgvPospuestos.ReadOnly = true;
            dgvPospuestos.RowHeadersWidth = 62;
            dgvPospuestos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPospuestos.Size = new Size(911, 290);
            dgvPospuestos.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "DescripcionEquipo";
            dataGridViewTextBoxColumn1.HeaderText = "Descripcion";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "NombreMarcaEquipo";
            dataGridViewTextBoxColumn2.HeaderText = "Marca";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "NombreTipoEquipo";
            dataGridViewTextBoxColumn3.HeaderText = "Tipo";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "NombreCliente";
            dataGridViewTextBoxColumn4.HeaderText = "Nombre Cliente";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "MailCliente";
            dataGridViewTextBoxColumn5.HeaderText = "Mail";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "TelefonoCliente";
            dataGridViewTextBoxColumn6.HeaderText = "Telefono";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // bDetallePospuestos
            // 
            bDetallePospuestos.BackColor = Color.FromArgb(40, 40, 40);
            bDetallePospuestos.FlatAppearance.BorderSize = 0;
            bDetallePospuestos.FlatStyle = FlatStyle.Flat;
            bDetallePospuestos.ForeColor = Color.Gainsboro;
            bDetallePospuestos.Location = new Point(943, 3);
            bDetallePospuestos.Name = "bDetallePospuestos";
            bDetallePospuestos.Size = new Size(232, 50);
            bDetallePospuestos.TabIndex = 8;
            bDetallePospuestos.Text = "Ver Detalle";
            bDetallePospuestos.UseVisualStyleBackColor = false;
            bDetallePospuestos.Click += bDetallePospuestos_Click;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(roundedPanel4);
            flowLayoutPanel4.Controls.Add(bMarcarRetirado);
            flowLayoutPanel4.Dock = DockStyle.Fill;
            flowLayoutPanel4.Location = new Point(3, 1203);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(1189, 412);
            flowLayoutPanel4.TabIndex = 8;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.White;
            roundedPanel4.Controls.Add(dgvListos);
            roundedPanel4.Location = new Point(26, 3);
            roundedPanel4.Margin = new Padding(26, 3, 3, 3);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(911, 290);
            roundedPanel4.TabIndex = 8;
            // 
            // dgvListos
            // 
            dgvListos.AllowUserToAddRows = false;
            dgvListos.AllowUserToDeleteRows = false;
            dgvListos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10 });
            dgvListos.Dock = DockStyle.Fill;
            dgvListos.Location = new Point(0, 0);
            dgvListos.MultiSelect = false;
            dgvListos.Name = "dgvListos";
            dgvListos.ReadOnly = true;
            dgvListos.RowHeadersWidth = 62;
            dgvListos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListos.Size = new Size(911, 290);
            dgvListos.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "Nombre";
            dataGridViewTextBoxColumn7.HeaderText = "Descripcion";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "NombreMarca";
            dataGridViewTextBoxColumn8.HeaderText = "Marca";
            dataGridViewTextBoxColumn8.MinimumWidth = 8;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "NombreTipo";
            dataGridViewTextBoxColumn9.HeaderText = "Tipo";
            dataGridViewTextBoxColumn9.MinimumWidth = 8;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "NombreCompletoCliente";
            dataGridViewTextBoxColumn10.HeaderText = "Nombre Cliente";
            dataGridViewTextBoxColumn10.MinimumWidth = 8;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // bMarcarRetirado
            // 
            bMarcarRetirado.BackColor = Color.FromArgb(40, 40, 40);
            bMarcarRetirado.FlatAppearance.BorderSize = 0;
            bMarcarRetirado.FlatStyle = FlatStyle.Flat;
            bMarcarRetirado.ForeColor = Color.Gainsboro;
            bMarcarRetirado.Location = new Point(943, 3);
            bMarcarRetirado.Name = "bMarcarRetirado";
            bMarcarRetirado.Size = new Size(232, 50);
            bMarcarRetirado.TabIndex = 9;
            bMarcarRetirado.Text = "Marcar como retirado";
            bMarcarRetirado.UseVisualStyleBackColor = false;
            bMarcarRetirado.Click += bMarcarRetirado_Click;
            // 
            // TareasAdminView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 77, 53);
            Controls.Add(tableLayoutPanel1);
            Name = "TareasAdminView";
            Size = new Size(1195, 1618);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPresupuestosAprobacion).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            roundedPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPendientesContacto).EndInit();
            flowLayoutPanel3.ResumeLayout(false);
            roundedPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPospuestos).EndInit();
            flowLayoutPanel4.ResumeLayout(false);
            roundedPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListos).EndInit();
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
        private DataGridView dgvPendientesContacto;
        private Shared.Controls.RoundedButton bMarcarContactado;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn NombreCliente;
        private DataGridViewTextBoxColumn DescripcionEquipo;
        private Label label4;
        private Label label5;
        private DataGridViewTextBoxColumn colDescripcion;
        private DataGridViewTextBoxColumn colMarca;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colNombreCliente;
        private DataGridViewTextBoxColumn colMail;
        private DataGridViewTextBoxColumn colTelefono;
        private FlowLayoutPanel flowLayoutPanel3;
        private Shared.Controls.RoundedPanel roundedPanel3;
        private DataGridView dgvPospuestos;
        private Shared.Controls.RoundedButton bDetallePospuestos;
        private FlowLayoutPanel flowLayoutPanel4;
        private Shared.Controls.RoundedPanel roundedPanel4;
        private DataGridView dgvListos;
        private Shared.Controls.RoundedButton bMarcarRetirado;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
