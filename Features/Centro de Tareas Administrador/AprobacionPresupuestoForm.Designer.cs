namespace Taller_2_Gestor.Features.Centro_de_Tareas_Administrador
{
    partial class AprobacionPresupuestoForm
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
            lTotal = new Label();
            label9 = new Label();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            lSubtotalOpcionales = new Label();
            roundedPanel2 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            dgvItemsOpcionales = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            colMontoOpcionales = new DataGridViewTextBoxColumn();
            colAceptado = new DataGridViewCheckBoxColumn();
            label3 = new Label();
            label2 = new Label();
            roundedPanel1 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            dgvItemsNecesarios = new DataGridView();
            colServicio = new DataGridViewTextBoxColumn();
            colMonto = new DataGridViewTextBoxColumn();
            lSubtotalNecesarios = new Label();
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
            roundedPanel4 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            tbNombre = new TextBox();
            label5 = new Label();
            panel4 = new Panel();
            roundedPanel6 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            tbMail = new TextBox();
            label7 = new Label();
            panel5 = new Panel();
            roundedPanel7 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            tbTel = new TextBox();
            label8 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            bRechazar = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            bAceptar = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItemsOpcionales).BeginInit();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItemsNecesarios).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            roundedPanel3.SuspendLayout();
            panel3.SuspendLayout();
            roundedPanel5.SuspendLayout();
            panel2.SuspendLayout();
            roundedPanel4.SuspendLayout();
            panel4.SuspendLayout();
            roundedPanel6.SuspendLayout();
            panel5.SuspendLayout();
            roundedPanel7.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lTotal, 0, 4);
            tableLayoutPanel1.Controls.Add(label9, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 3);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 414F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            tableLayoutPanel1.Size = new Size(1159, 708);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // lTotal
            // 
            lTotal.Anchor = AnchorStyles.Left;
            lTotal.AutoSize = true;
            lTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lTotal.Location = new Point(430, 599);
            lTotal.Margin = new Padding(430, 0, 0, 0);
            lTotal.Name = "lTotal";
            lTotal.Size = new Size(77, 32);
            lTotal.TabIndex = 19;
            lTotal.Text = "Total:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 60);
            label9.Name = "label9";
            label9.Size = new Size(264, 32);
            label9.TabIndex = 12;
            label9.Text = "Datos del presupuesto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(424, 54);
            label1.TabIndex = 1;
            label1.Text = "Aprobar Presupuesto";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(lSubtotalOpcionales, 1, 2);
            tableLayoutPanel2.Controls.Add(roundedPanel2, 1, 1);
            tableLayoutPanel2.Controls.Add(label3, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(roundedPanel1, 0, 1);
            tableLayoutPanel2.Controls.Add(lSubtotalNecesarios, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 180);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.324009F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 75.5244751F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.9184151F));
            tableLayoutPanel2.Size = new Size(1153, 408);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // lSubtotalOpcionales
            // 
            lSubtotalOpcionales.AutoSize = true;
            lSubtotalOpcionales.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lSubtotalOpcionales.Location = new Point(591, 361);
            lSubtotalOpcionales.Margin = new Padding(15, 15, 3, 0);
            lSubtotalOpcionales.Name = "lSubtotalOpcionales";
            lSubtotalOpcionales.Size = new Size(117, 32);
            lSubtotalOpcionales.TabIndex = 18;
            lSubtotalOpcionales.Text = "Subtotal:";
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.White;
            roundedPanel2.Controls.Add(dgvItemsOpcionales);
            roundedPanel2.Location = new Point(591, 41);
            roundedPanel2.Margin = new Padding(15, 3, 3, 3);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(550, 302);
            roundedPanel2.TabIndex = 17;
            // 
            // dgvItemsOpcionales
            // 
            dgvItemsOpcionales.AllowUserToAddRows = false;
            dgvItemsOpcionales.AllowUserToDeleteRows = false;
            dgvItemsOpcionales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItemsOpcionales.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, colMontoOpcionales, colAceptado });
            dgvItemsOpcionales.Dock = DockStyle.Fill;
            dgvItemsOpcionales.Location = new Point(0, 0);
            dgvItemsOpcionales.MultiSelect = false;
            dgvItemsOpcionales.Name = "dgvItemsOpcionales";
            dgvItemsOpcionales.RowHeadersWidth = 62;
            dgvItemsOpcionales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItemsOpcionales.Size = new Size(550, 302);
            dgvItemsOpcionales.TabIndex = 1;
            dgvItemsOpcionales.CellContentClick += dgvItemsOpcionales_CellContentClick;
            dgvItemsOpcionales.CellValueChanged += dgvItemsOpcionales_CellValueChanged;
            dgvItemsOpcionales.CurrentCellDirtyStateChanged += dgvItemsOpcionales_CurrentCellDirtyStateChanged;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "NombreServicio";
            dataGridViewTextBoxColumn1.HeaderText = "Servicio";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // colMontoOpcionales
            // 
            colMontoOpcionales.DataPropertyName = "Precio";
            colMontoOpcionales.HeaderText = "Monto";
            colMontoOpcionales.MinimumWidth = 8;
            colMontoOpcionales.Name = "colMontoOpcionales";
            colMontoOpcionales.ReadOnly = true;
            colMontoOpcionales.Width = 150;
            // 
            // colAceptado
            // 
            colAceptado.HeaderText = "Aceptado";
            colAceptado.MinimumWidth = 8;
            colAceptado.Name = "colAceptado";
            colAceptado.Width = 150;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(591, 3);
            label3.Margin = new Padding(15, 3, 3, 3);
            label3.Name = "label3";
            label3.Size = new Size(206, 32);
            label3.TabIndex = 15;
            label3.Text = "Items Opcionales:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 3);
            label2.Margin = new Padding(15, 3, 3, 3);
            label2.Name = "label2";
            label2.Size = new Size(204, 32);
            label2.TabIndex = 14;
            label2.Text = "Items Necesarios:";
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.Controls.Add(dgvItemsNecesarios);
            roundedPanel1.Location = new Point(15, 41);
            roundedPanel1.Margin = new Padding(15, 3, 3, 3);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(550, 302);
            roundedPanel1.TabIndex = 16;
            // 
            // dgvItemsNecesarios
            // 
            dgvItemsNecesarios.AllowUserToAddRows = false;
            dgvItemsNecesarios.AllowUserToDeleteRows = false;
            dgvItemsNecesarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItemsNecesarios.Columns.AddRange(new DataGridViewColumn[] { colServicio, colMonto });
            dgvItemsNecesarios.Dock = DockStyle.Fill;
            dgvItemsNecesarios.Location = new Point(0, 0);
            dgvItemsNecesarios.MultiSelect = false;
            dgvItemsNecesarios.Name = "dgvItemsNecesarios";
            dgvItemsNecesarios.RowHeadersWidth = 62;
            dgvItemsNecesarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItemsNecesarios.Size = new Size(550, 302);
            dgvItemsNecesarios.TabIndex = 0;
            // 
            // colServicio
            // 
            colServicio.DataPropertyName = "NombreServicio";
            colServicio.HeaderText = "Servicio";
            colServicio.MinimumWidth = 8;
            colServicio.Name = "colServicio";
            colServicio.ReadOnly = true;
            colServicio.Width = 150;
            // 
            // colMonto
            // 
            colMonto.DataPropertyName = "Precio";
            colMonto.HeaderText = "Monto";
            colMonto.MinimumWidth = 8;
            colMonto.Name = "colMonto";
            colMonto.ReadOnly = true;
            colMonto.Width = 150;
            // 
            // lSubtotalNecesarios
            // 
            lSubtotalNecesarios.AutoSize = true;
            lSubtotalNecesarios.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lSubtotalNecesarios.Location = new Point(15, 361);
            lSubtotalNecesarios.Margin = new Padding(15, 15, 3, 0);
            lSubtotalNecesarios.Name = "lSubtotalNecesarios";
            lSubtotalNecesarios.Size = new Size(117, 32);
            lSubtotalNecesarios.TabIndex = 16;
            lSubtotalNecesarios.Text = "Subtotal:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 97);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1159, 80);
            flowLayoutPanel1.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.Controls.Add(roundedPanel3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(94, 74);
            panel1.TabIndex = 0;
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
            panel3.TabIndex = 3;
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
            panel2.Controls.Add(roundedPanel4);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(413, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(279, 74);
            panel2.TabIndex = 2;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.Transparent;
            roundedPanel4.BorderSize = 3F;
            roundedPanel4.Controls.Add(tbNombre);
            roundedPanel4.Location = new Point(9, 28);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(267, 43);
            roundedPanel4.TabIndex = 1;
            // 
            // tbNombre
            // 
            tbNombre.BackColor = Color.FromArgb(51, 77, 53);
            tbNombre.BorderStyle = BorderStyle.None;
            tbNombre.Location = new Point(3, 9);
            tbNombre.Name = "tbNombre";
            tbNombre.ReadOnly = true;
            tbNombre.Size = new Size(248, 24);
            tbNombre.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 0);
            label5.Name = "label5";
            label5.Size = new Size(165, 25);
            label5.TabIndex = 0;
            label5.Text = "Nombre del Cliente";
            // 
            // panel4
            // 
            panel4.Controls.Add(roundedPanel6);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(698, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(306, 74);
            panel4.TabIndex = 4;
            // 
            // roundedPanel6
            // 
            roundedPanel6.BackColor = Color.Transparent;
            roundedPanel6.BorderSize = 3F;
            roundedPanel6.Controls.Add(tbMail);
            roundedPanel6.Location = new Point(9, 28);
            roundedPanel6.Name = "roundedPanel6";
            roundedPanel6.Size = new Size(295, 43);
            roundedPanel6.TabIndex = 1;
            // 
            // tbMail
            // 
            tbMail.BackColor = Color.FromArgb(51, 77, 53);
            tbMail.BorderStyle = BorderStyle.None;
            tbMail.Location = new Point(3, 9);
            tbMail.Name = "tbMail";
            tbMail.ReadOnly = true;
            tbMail.Size = new Size(283, 24);
            tbMail.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 0);
            label7.Name = "label7";
            label7.Size = new Size(45, 25);
            label7.TabIndex = 0;
            label7.Text = "Mail";
            // 
            // panel5
            // 
            panel5.Controls.Add(roundedPanel7);
            panel5.Controls.Add(label8);
            panel5.Location = new Point(1010, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(143, 74);
            panel5.TabIndex = 5;
            // 
            // roundedPanel7
            // 
            roundedPanel7.BackColor = Color.Transparent;
            roundedPanel7.BorderSize = 3F;
            roundedPanel7.Controls.Add(tbTel);
            roundedPanel7.Location = new Point(9, 28);
            roundedPanel7.Name = "roundedPanel7";
            roundedPanel7.Size = new Size(125, 43);
            roundedPanel7.TabIndex = 1;
            // 
            // tbTel
            // 
            tbTel.BackColor = Color.FromArgb(51, 77, 53);
            tbTel.BorderStyle = BorderStyle.None;
            tbTel.Location = new Point(3, 9);
            tbTel.Name = "tbTel";
            tbTel.ReadOnly = true;
            tbTel.Size = new Size(108, 24);
            tbTel.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 0);
            label8.Name = "label8";
            label8.Size = new Size(79, 25);
            label8.TabIndex = 0;
            label8.Text = "Telefono";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(bRechazar, 1, 0);
            tableLayoutPanel3.Controls.Add(bAceptar, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 642);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(1153, 63);
            tableLayoutPanel3.TabIndex = 14;
            // 
            // bRechazar
            // 
            bRechazar.Anchor = AnchorStyles.Left;
            bRechazar.BackColor = Color.Maroon;
            bRechazar.BackNormal = Color.Maroon;
            bRechazar.FlatAppearance.BorderSize = 0;
            bRechazar.FlatStyle = FlatStyle.Flat;
            bRechazar.ForeColor = Color.WhiteSmoke;
            bRechazar.Location = new Point(626, 6);
            bRechazar.Margin = new Padding(50, 3, 50, 3);
            bRechazar.Name = "bRechazar";
            bRechazar.Size = new Size(207, 50);
            bRechazar.TabIndex = 1;
            bRechazar.Text = "Rechazar Presupuesto";
            bRechazar.UseVisualStyleBackColor = false;
            bRechazar.Click += bRechazar_Click;
            // 
            // bAceptar
            // 
            bAceptar.Anchor = AnchorStyles.Right;
            bAceptar.BackColor = Color.FromArgb(40, 40, 40);
            bAceptar.FlatAppearance.BorderSize = 0;
            bAceptar.FlatStyle = FlatStyle.Flat;
            bAceptar.ForeColor = Color.Gainsboro;
            bAceptar.Location = new Point(319, 6);
            bAceptar.Margin = new Padding(3, 3, 50, 3);
            bAceptar.Name = "bAceptar";
            bAceptar.Size = new Size(207, 50);
            bAceptar.TabIndex = 0;
            bAceptar.Text = "Aceptar Presupuesto";
            bAceptar.UseVisualStyleBackColor = false;
            bAceptar.Click += roundedButton1_Click;
            // 
            // AprobacionPresupuestoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 77, 53);
            ClientSize = new Size(1159, 708);
            Controls.Add(tableLayoutPanel1);
            Name = "AprobacionPresupuestoForm";
            Text = "AprobacionPresupuestoForm";
            Load += AprobacionPresupuestoForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItemsOpcionales).EndInit();
            roundedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItemsNecesarios).EndInit();
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
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            roundedPanel6.ResumeLayout(false);
            roundedPanel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            roundedPanel7.ResumeLayout(false);
            roundedPanel7.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label9;
        private TableLayoutPanel tableLayoutPanel2;
        private Shared.Controls.RoundedPanel roundedPanel2;
        private Label label3;
        private Label label2;
        private Shared.Controls.RoundedPanel roundedPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Shared.Controls.RoundedButton bAceptar;
        private Shared.Controls.RoundedButton bRechazar;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label label4;
        private Shared.Controls.RoundedPanel roundedPanel3;
        private TextBox tbId;
        private Panel panel3;
        private Shared.Controls.RoundedPanel roundedPanel5;
        private TextBox tbDescripcion;
        private Label label6;
        private Panel panel2;
        private Shared.Controls.RoundedPanel roundedPanel4;
        private TextBox tbNombre;
        private Label label5;
        private Panel panel4;
        private Shared.Controls.RoundedPanel roundedPanel6;
        private TextBox tbMail;
        private Label label7;
        private Panel panel5;
        private Shared.Controls.RoundedPanel roundedPanel7;
        private TextBox tbTel;
        private Label label8;
        private Label lTotal;
        private Label lSubtotalOpcionales;
        private Label lSubtotalNecesarios;
        private DataGridView dgvItemsNecesarios;
        private DataGridView dgvItemsOpcionales;
        private DataGridViewTextBoxColumn colServicio;
        private DataGridViewTextBoxColumn colMonto;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn colMontoOpcionales;
        private DataGridViewCheckBoxColumn colAceptado;
    }
}