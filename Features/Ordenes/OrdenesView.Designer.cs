namespace Taller_2_Gestor.Features.Ordenes
{
    partial class OrdenesView
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
            roundedPanel1 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            dgvOrdenes = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colTecnico = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            rpBarraBusqueda = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            lBusqueda = new Label();
            rpFiltro = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            comboBox1 = new ComboBox();
            lFiltro = new Label();
            lTitulo = new Label();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            roundedPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenes).BeginInit();
            rpBarraBusqueda.SuspendLayout();
            rpFiltro.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(roundedPanel7, 0, 5);
            tableLayoutPanel1.Controls.Add(roundedPanel1, 0, 3);
            tableLayoutPanel1.Controls.Add(rpBarraBusqueda, 0, 2);
            tableLayoutPanel1.Controls.Add(rpFiltro, 0, 1);
            tableLayoutPanel1.Controls.Add(lTitulo, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 317F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1026, 803);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // roundedPanel7
            // 
            roundedPanel7.BackColor = Color.White;
            roundedPanel7.BorderSize = 3F;
            roundedPanel7.Controls.Add(dgvItems);
            roundedPanel7.Location = new Point(26, 499);
            roundedPanel7.Margin = new Padding(26, 7, 3, 3);
            roundedPanel7.Name = "roundedPanel7";
            roundedPanel7.Size = new Size(950, 217);
            roundedPanel7.TabIndex = 12;
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
            dataGridViewTextBoxColumn1.DataPropertyName = "IdPresupuesto";
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
            dataGridViewTextBoxColumn4.DataPropertyName = "IdOrden";
            dataGridViewTextBoxColumn4.HeaderText = "IDOrden";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BorderSize = 3F;
            roundedPanel1.Controls.Add(dgvOrdenes);
            roundedPanel1.Location = new Point(26, 147);
            roundedPanel1.Margin = new Padding(26, 7, 3, 3);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(950, 279);
            roundedPanel1.TabIndex = 5;
            // 
            // dgvOrdenes
            // 
            dgvOrdenes.AllowUserToAddRows = false;
            dgvOrdenes.AllowUserToDeleteRows = false;
            dgvOrdenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrdenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenes.Columns.AddRange(new DataGridViewColumn[] { colId, colEmail, colTecnico, colFecha });
            dgvOrdenes.Dock = DockStyle.Fill;
            dgvOrdenes.Location = new Point(0, 0);
            dgvOrdenes.MultiSelect = false;
            dgvOrdenes.Name = "dgvOrdenes";
            dgvOrdenes.ReadOnly = true;
            dgvOrdenes.RowHeadersWidth = 62;
            dgvOrdenes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrdenes.Size = new Size(950, 279);
            dgvOrdenes.TabIndex = 0;
            dgvOrdenes.SelectionChanged += dgvOrdenes_SelectionChanged;
            // 
            // colId
            // 
            colId.DataPropertyName = "IdPresupuesto";
            colId.HeaderText = "IDOrden";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "IdEquipo";
            colEmail.HeaderText = "IDEquipo";
            colEmail.MinimumWidth = 8;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colTecnico
            // 
            colTecnico.HeaderText = "IDTecnico";
            colTecnico.MinimumWidth = 8;
            colTecnico.Name = "colTecnico";
            colTecnico.ReadOnly = true;
            // 
            // colFecha
            // 
            colFecha.DataPropertyName = "Fecha";
            colFecha.HeaderText = "Fecha";
            colFecha.MinimumWidth = 8;
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            // 
            // rpBarraBusqueda
            // 
            rpBarraBusqueda.BackColor = Color.DarkGray;
            rpBarraBusqueda.BorderColor = Color.DarkGray;
            rpBarraBusqueda.Controls.Add(lBusqueda);
            rpBarraBusqueda.Location = new Point(26, 103);
            rpBarraBusqueda.Margin = new Padding(26, 3, 3, 3);
            rpBarraBusqueda.Name = "rpBarraBusqueda";
            rpBarraBusqueda.Size = new Size(950, 33);
            rpBarraBusqueda.TabIndex = 4;
            // 
            // lBusqueda
            // 
            lBusqueda.AutoSize = true;
            lBusqueda.ForeColor = SystemColors.ControlDarkDark;
            lBusqueda.Location = new Point(24, 5);
            lBusqueda.Name = "lBusqueda";
            lBusqueda.Size = new Size(345, 25);
            lBusqueda.TabIndex = 0;
            lBusqueda.Text = "Ingrese un dato de una orden para buscar";
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
            // lTitulo
            // 
            lTitulo.AutoSize = true;
            lTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lTitulo.Location = new Point(3, 0);
            lTitulo.Name = "lTitulo";
            lTitulo.Size = new Size(180, 54);
            lTitulo.TabIndex = 1;
            lTitulo.Text = "Ordenes";
            lTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 457);
            label2.Margin = new Padding(15, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 32);
            label2.TabIndex = 13;
            label2.Text = "Items:";
            // 
            // OrdenesView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 77, 53);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "OrdenesView";
            Size = new Size(1026, 803);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            roundedPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            roundedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrdenes).EndInit();
            rpBarraBusqueda.ResumeLayout(false);
            rpBarraBusqueda.PerformLayout();
            rpFiltro.ResumeLayout(false);
            rpFiltro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lTitulo;
        private Shared.Controls.RoundedPanel rpFiltro;
        private ComboBox comboBox1;
        private Label lFiltro;
        private Shared.Controls.RoundedPanel rpBarraBusqueda;
        private Label lBusqueda;
        private Shared.Controls.RoundedPanel roundedPanel1;
        private DataGridView dgvOrdenes;
        private Shared.Controls.RoundedPanel roundedPanel7;
        private DataGridView dgvItems;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colTecnico;
        private DataGridViewTextBoxColumn colFecha;
        private Label label2;
    }
}
