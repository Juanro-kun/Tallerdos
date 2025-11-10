namespace Taller_2_Gestor.Features.Centro_de_Tareas_Tecnico
{
    partial class GenerarOrdenForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            label5 = new Label();
            label9 = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            roundedPanel3 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            tbId = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
            roundedPanel5 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            tbDescripcion = new TextBox();
            label6 = new Label();
            panel2 = new Panel();
            roundedPanel1 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            tbMarca = new TextBox();
            label2 = new Label();
            panel4 = new Panel();
            roundedPanel2 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            tbTipo = new TextBox();
            label3 = new Label();
            panel5 = new Panel();
            roundedPanel6 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            tbIdPresupuesto = new TextBox();
            label7 = new Label();
            roundedPanel4 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            dgvItems = new DataGridView();
            colNombreServicio = new DataGridViewTextBoxColumn();
            tableLayoutPanel2 = new TableLayoutPanel();
            bPosponer = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            bGenerarOrden = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            roundedPanel3.SuspendLayout();
            panel3.SuspendLayout();
            roundedPanel5.SuspendLayout();
            panel2.SuspendLayout();
            roundedPanel1.SuspendLayout();
            panel4.SuspendLayout();
            roundedPanel2.SuspendLayout();
            panel5.SuspendLayout();
            roundedPanel6.SuspendLayout();
            roundedPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label9, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 2);
            tableLayoutPanel1.Controls.Add(roundedPanel4, 0, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1038, 612);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 177);
            label5.Margin = new Padding(15, 0, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(188, 32);
            label5.TabIndex = 15;
            label5.Text = "Items a realizar:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 60);
            label9.Name = "label9";
            label9.Size = new Size(205, 32);
            label9.TabIndex = 13;
            label9.Text = "Datos del equipo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(519, 54);
            label1.TabIndex = 2;
            label1.Text = "Generar Orden de Servicio";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 100);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1032, 74);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.Controls.Add(roundedPanel3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(94, 74);
            panel1.TabIndex = 1;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.Transparent;
            roundedPanel3.BorderSize = 3F;
            roundedPanel3.Controls.Add(tbId);
            roundedPanel3.Location = new Point(9, 28);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(71, 43);
            roundedPanel3.TabIndex = 1;
            // 
            // tbId
            // 
            tbId.BackColor = Color.FromArgb(51, 77, 53);
            tbId.BorderStyle = BorderStyle.None;
            tbId.Location = new Point(3, 9);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new Size(65, 24);
            tbId.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 0);
            label4.Name = "label4";
            label4.Size = new Size(28, 25);
            label4.TabIndex = 0;
            label4.Text = "Id";
            // 
            // panel3
            // 
            panel3.Controls.Add(roundedPanel5);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(103, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(304, 74);
            panel3.TabIndex = 4;
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.Transparent;
            roundedPanel5.BorderSize = 3F;
            roundedPanel5.Controls.Add(tbDescripcion);
            roundedPanel5.Location = new Point(9, 28);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(292, 43);
            roundedPanel5.TabIndex = 1;
            // 
            // tbDescripcion
            // 
            tbDescripcion.BackColor = Color.FromArgb(51, 77, 53);
            tbDescripcion.BorderStyle = BorderStyle.None;
            tbDescripcion.Location = new Point(3, 9);
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.ReadOnly = true;
            tbDescripcion.Size = new Size(286, 24);
            tbDescripcion.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 0);
            label6.Name = "label6";
            label6.Size = new Size(194, 25);
            label6.TabIndex = 0;
            label6.Text = "Descripcion del Equipo";
            // 
            // panel2
            // 
            panel2.Controls.Add(roundedPanel1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(413, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(227, 74);
            panel2.TabIndex = 4;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.BorderSize = 3F;
            roundedPanel1.Controls.Add(tbMarca);
            roundedPanel1.Location = new Point(9, 28);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(215, 43);
            roundedPanel1.TabIndex = 1;
            // 
            // tbMarca
            // 
            tbMarca.BackColor = Color.FromArgb(51, 77, 53);
            tbMarca.BorderStyle = BorderStyle.None;
            tbMarca.Location = new Point(3, 9);
            tbMarca.Name = "tbMarca";
            tbMarca.ReadOnly = true;
            tbMarca.Size = new Size(191, 24);
            tbMarca.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 0;
            label2.Text = "Marca";
            label2.Click += label2_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(roundedPanel2);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(646, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(236, 74);
            panel4.TabIndex = 4;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.Transparent;
            roundedPanel2.BorderSize = 3F;
            roundedPanel2.Controls.Add(tbTipo);
            roundedPanel2.Location = new Point(9, 28);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(217, 43);
            roundedPanel2.TabIndex = 1;
            // 
            // tbTipo
            // 
            tbTipo.BackColor = Color.FromArgb(51, 77, 53);
            tbTipo.BorderStyle = BorderStyle.None;
            tbTipo.Location = new Point(3, 9);
            tbTipo.Name = "tbTipo";
            tbTipo.ReadOnly = true;
            tbTipo.Size = new Size(188, 24);
            tbTipo.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 0);
            label3.Name = "label3";
            label3.Size = new Size(47, 25);
            label3.TabIndex = 0;
            label3.Text = "Tipo";
            // 
            // panel5
            // 
            panel5.Controls.Add(roundedPanel6);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(888, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(135, 74);
            panel5.TabIndex = 2;
            panel5.Visible = false;
            // 
            // roundedPanel6
            // 
            roundedPanel6.BackColor = Color.Transparent;
            roundedPanel6.BorderSize = 3F;
            roundedPanel6.Controls.Add(tbIdPresupuesto);
            roundedPanel6.Location = new Point(9, 28);
            roundedPanel6.Name = "roundedPanel6";
            roundedPanel6.Size = new Size(123, 43);
            roundedPanel6.TabIndex = 1;
            // 
            // tbIdPresupuesto
            // 
            tbIdPresupuesto.BackColor = Color.FromArgb(51, 77, 53);
            tbIdPresupuesto.BorderStyle = BorderStyle.None;
            tbIdPresupuesto.Location = new Point(3, 9);
            tbIdPresupuesto.Name = "tbIdPresupuesto";
            tbIdPresupuesto.ReadOnly = true;
            tbIdPresupuesto.Size = new Size(106, 24);
            tbIdPresupuesto.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 0);
            label7.Name = "label7";
            label7.Size = new Size(131, 25);
            label7.TabIndex = 0;
            label7.Text = "Id Presupuesto";
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.White;
            roundedPanel4.Controls.Add(dgvItems);
            roundedPanel4.Location = new Point(15, 217);
            roundedPanel4.Margin = new Padding(15, 3, 3, 3);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(963, 283);
            roundedPanel4.TabIndex = 16;
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { colNombreServicio });
            dgvItems.Dock = DockStyle.Fill;
            dgvItems.Location = new Point(0, 0);
            dgvItems.MultiSelect = false;
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersWidth = 62;
            dgvItems.Size = new Size(963, 283);
            dgvItems.TabIndex = 0;
            // 
            // colNombreServicio
            // 
            colNombreServicio.DataPropertyName = "NombreServicio";
            colNombreServicio.HeaderText = "Servicio";
            colNombreServicio.MinimumWidth = 8;
            colNombreServicio.Name = "colNombreServicio";
            colNombreServicio.ReadOnly = true;
            colNombreServicio.Width = 150;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(bPosponer, 1, 0);
            tableLayoutPanel2.Controls.Add(bGenerarOrden, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 517);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1032, 92);
            tableLayoutPanel2.TabIndex = 17;
            // 
            // bPosponer
            // 
            bPosponer.Anchor = AnchorStyles.Left;
            bPosponer.BackColor = Color.FromArgb(40, 40, 40);
            bPosponer.BackNormal = Color.Maroon;
            bPosponer.FlatAppearance.BorderSize = 0;
            bPosponer.FlatStyle = FlatStyle.Flat;
            bPosponer.ForeColor = Color.WhiteSmoke;
            bPosponer.Location = new Point(566, 23);
            bPosponer.Margin = new Padding(50, 3, 3, 3);
            bPosponer.Name = "bPosponer";
            bPosponer.Size = new Size(203, 46);
            bPosponer.TabIndex = 1;
            bPosponer.Text = "Posponer Reparacion";
            bPosponer.UseVisualStyleBackColor = false;
            bPosponer.Click += bPosponer_Click;
            // 
            // bGenerarOrden
            // 
            bGenerarOrden.Anchor = AnchorStyles.Right;
            bGenerarOrden.BackColor = Color.FromArgb(40, 40, 40);
            bGenerarOrden.FlatAppearance.BorderSize = 0;
            bGenerarOrden.FlatStyle = FlatStyle.Flat;
            bGenerarOrden.ForeColor = Color.Gainsboro;
            bGenerarOrden.Location = new Point(265, 23);
            bGenerarOrden.Margin = new Padding(3, 3, 50, 3);
            bGenerarOrden.Name = "bGenerarOrden";
            bGenerarOrden.Size = new Size(201, 46);
            bGenerarOrden.TabIndex = 0;
            bGenerarOrden.Text = "Generar Orden";
            bGenerarOrden.UseVisualStyleBackColor = false;
            bGenerarOrden.Click += bGenerarOrden_Click;
            // 
            // GenerarOrdenForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 77, 53);
            ClientSize = new Size(1038, 612);
            Controls.Add(tableLayoutPanel1);
            Name = "GenerarOrdenForm";
            Text = "GenerarOrdenForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            roundedPanel5.ResumeLayout(false);
            roundedPanel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            roundedPanel6.ResumeLayout(false);
            roundedPanel6.PerformLayout();
            roundedPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label9;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Shared.Controls.RoundedPanel roundedPanel3;
        private TextBox tbId;
        private Label label4;
        private Panel panel3;
        private Shared.Controls.RoundedPanel roundedPanel5;
        private TextBox tbDescripcion;
        private Label label6;
        private Panel panel2;
        private Shared.Controls.RoundedPanel roundedPanel1;
        private TextBox tbMarca;
        private Label label2;
        private Panel panel4;
        private Shared.Controls.RoundedPanel roundedPanel2;
        private TextBox tbTipo;
        private Label label3;
        private Label label5;
        private Shared.Controls.RoundedPanel roundedPanel4;
        private DataGridView dgvItems;
        private TableLayoutPanel tableLayoutPanel2;
        private Shared.Controls.RoundedButton bGenerarOrden;
        private Shared.Controls.RoundedButton bPosponer;
        private DataGridViewTextBoxColumn colNombreServicio;
        private Panel panel5;
        private Shared.Controls.RoundedPanel roundedPanel6;
        private TextBox tbIdPresupuesto;
        private Label label7;
    }
}