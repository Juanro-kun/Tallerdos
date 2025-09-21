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
            label1 = new Label();
            rpFiltro = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            comboBox1 = new ComboBox();
            lFiltro = new Label();
            rpBarraBusqueda = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            lBusqueda = new Label();
            roundedPanel1 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            dgvUsuarios = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            flowLayoutPanel1 = new FlowLayoutPanel();
            bNuevoUsuario = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            bGuardarNuevo = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            pNuevoUsuario = new Panel();
            roundedPanel7 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            rpFiltro.SuspendLayout();
            rpBarraBusqueda.SuspendLayout();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            pNuevoUsuario.SuspendLayout();
            roundedPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(roundedPanel7, 0, 5);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 4);
            tableLayoutPanel1.Controls.Add(roundedPanel1, 0, 3);
            tableLayoutPanel1.Controls.Add(rpBarraBusqueda, 0, 2);
            tableLayoutPanel1.Controls.Add(rpFiltro, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.763098F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.44345474F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.95893049F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 32.5726128F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.01659775F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 32.9875526F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.22406626F));
            tableLayoutPanel1.Size = new Size(718, 482);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(2, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 37);
            label1.TabIndex = 1;
            label1.Text = "Ordenes";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rpFiltro
            // 
            rpFiltro.BackColor = Color.FromArgb(33, 33, 33);
            rpFiltro.Controls.Add(comboBox1);
            rpFiltro.Controls.Add(lFiltro);
            rpFiltro.Location = new Point(21, 44);
            rpFiltro.Margin = new Padding(21, 2, 2, 2);
            rpFiltro.Name = "rpFiltro";
            rpFiltro.Size = new Size(181, 20);
            rpFiltro.TabIndex = 3;
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
            // rpBarraBusqueda
            // 
            rpBarraBusqueda.BackColor = Color.DarkGray;
            rpBarraBusqueda.BorderColor = Color.DarkGray;
            rpBarraBusqueda.Controls.Add(lBusqueda);
            rpBarraBusqueda.Location = new Point(18, 75);
            rpBarraBusqueda.Margin = new Padding(18, 2, 2, 2);
            rpBarraBusqueda.Name = "rpBarraBusqueda";
            rpBarraBusqueda.Size = new Size(665, 20);
            rpBarraBusqueda.TabIndex = 4;
            // 
            // lBusqueda
            // 
            lBusqueda.AutoSize = true;
            lBusqueda.ForeColor = SystemColors.ControlDarkDark;
            lBusqueda.Location = new Point(17, 3);
            lBusqueda.Margin = new Padding(2, 0, 2, 0);
            lBusqueda.Name = "lBusqueda";
            lBusqueda.Size = new Size(226, 15);
            lBusqueda.TabIndex = 0;
            lBusqueda.Text = "Ingrese un dato de una orden para buscar";
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BorderSize = 3F;
            roundedPanel1.Controls.Add(dgvUsuarios);
            roundedPanel1.Location = new Point(18, 110);
            roundedPanel1.Margin = new Padding(18, 4, 2, 2);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(665, 142);
            roundedPanel1.TabIndex = 5;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { colId, colEmail });
            dgvUsuarios.Dock = DockStyle.Fill;
            dgvUsuarios.Location = new Point(0, 0);
            dgvUsuarios.Margin = new Padding(2);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersWidth = 62;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(665, 142);
            dgvUsuarios.TabIndex = 0;
            // 
            // colId
            // 
            colId.DataPropertyName = "idUsuario";
            colId.HeaderText = "IDOrden";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "Mail";
            colEmail.HeaderText = "IDMarca";
            colEmail.MinimumWidth = 8;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pNuevoUsuario);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(2, 265);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(714, 25);
            flowLayoutPanel1.TabIndex = 6;
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
            bNuevoUsuario.Margin = new Padding(2);
            bNuevoUsuario.Name = "bNuevoUsuario";
            bNuevoUsuario.Size = new Size(127, 19);
            bNuevoUsuario.TabIndex = 0;
            bNuevoUsuario.Text = "Nuevo Usuario";
            bNuevoUsuario.UseVisualStyleBackColor = false;
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
            bGuardarNuevo.Margin = new Padding(2);
            bGuardarNuevo.Name = "bGuardarNuevo";
            bGuardarNuevo.Size = new Size(127, 19);
            bGuardarNuevo.TabIndex = 1;
            bGuardarNuevo.Text = "Guardar";
            bGuardarNuevo.UseVisualStyleBackColor = false;
            bGuardarNuevo.Visible = false;
            // 
            // pNuevoUsuario
            // 
            pNuevoUsuario.Controls.Add(bGuardarNuevo);
            pNuevoUsuario.Controls.Add(bNuevoUsuario);
            pNuevoUsuario.Location = new Point(24, 2);
            pNuevoUsuario.Margin = new Padding(24, 2, 2, 2);
            pNuevoUsuario.Name = "pNuevoUsuario";
            pNuevoUsuario.Size = new Size(127, 19);
            pNuevoUsuario.TabIndex = 0;
            // 
            // roundedPanel7
            // 
            roundedPanel7.BackColor = Color.White;
            roundedPanel7.BorderSize = 3F;
            roundedPanel7.Controls.Add(dataGridView1);
            roundedPanel7.Location = new Point(18, 296);
            roundedPanel7.Margin = new Padding(18, 4, 2, 2);
            roundedPanel7.Name = "roundedPanel7";
            roundedPanel7.Size = new Size(665, 142);
            roundedPanel7.TabIndex = 9;
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
            dataGridView1.Size = new Size(665, 142);
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
            // OrdenesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 77, 53);
            Controls.Add(tableLayoutPanel1);
            Name = "OrdenesView";
            Size = new Size(718, 482);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            rpFiltro.ResumeLayout(false);
            rpFiltro.PerformLayout();
            rpBarraBusqueda.ResumeLayout(false);
            rpBarraBusqueda.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            pNuevoUsuario.ResumeLayout(false);
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
        private Shared.Controls.RoundedPanel roundedPanel1;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colEmail;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pNuevoUsuario;
        private Shared.Controls.RoundedButton bGuardarNuevo;
        private Shared.Controls.RoundedButton bNuevoUsuario;
        private Shared.Controls.RoundedPanel roundedPanel7;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
