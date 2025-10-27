namespace Taller_2_Gestor.Features.Equipos
{
    partial class GenerarPresupuestoForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel6 = new Panel();
            roundedPanel1 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            cbServicio = new ComboBox();
            label3 = new Label();
            panel8 = new Panel();
            chbNecesario = new CheckBox();
            label8 = new Label();
            bAgregarItem = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            label1 = new Label();
            label9 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel1 = new Panel();
            lId = new Label();
            roundedPanel2 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            lIdContenido = new Label();
            panel2 = new Panel();
            lIdCliente = new Label();
            roundedPanel3 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            tbIdCliente = new TextBox();
            panel7 = new Panel();
            label2 = new Label();
            roundedPanel8 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            label6 = new Label();
            label7 = new Label();
            tbDescripcion = new TextBox();
            panel5 = new Panel();
            roundedPanel6 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            tbMarca = new TextBox();
            lRol = new Label();
            panel3 = new Panel();
            roundedPanel4 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            tbTipo = new TextBox();
            label4 = new Label();
            panel4 = new Panel();
            roundedPanel5 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            tbEstado = new TextBox();
            label5 = new Label();
            label10 = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            roundedPanel7 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            dgvServicios = new DataGridView();
            colServicio = new DataGridViewTextBoxColumn();
            colIdServicio = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colNecesario = new DataGridViewCheckBoxColumn();
            colEliminar = new DataGridViewButtonColumn();
            bGenerarPresupuesto = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel6.SuspendLayout();
            roundedPanel1.SuspendLayout();
            panel8.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            panel2.SuspendLayout();
            roundedPanel3.SuspendLayout();
            panel7.SuspendLayout();
            roundedPanel8.SuspendLayout();
            panel5.SuspendLayout();
            roundedPanel6.SuspendLayout();
            panel3.SuspendLayout();
            roundedPanel4.SuspendLayout();
            panel4.SuspendLayout();
            roundedPanel5.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            roundedPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 4);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label9, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(label10, 0, 3);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel3, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 12F);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 79F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.Size = new Size(1076, 563);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(panel8);
            flowLayoutPanel1.Controls.Add(bAgregarItem);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 214);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1070, 73);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // panel6
            // 
            panel6.Controls.Add(roundedPanel1);
            panel6.Controls.Add(label3);
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(201, 67);
            panel6.TabIndex = 7;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel1.BorderSize = 4F;
            roundedPanel1.Controls.Add(cbServicio);
            roundedPanel1.Location = new Point(3, 25);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(191, 38);
            roundedPanel1.TabIndex = 1;
            // 
            // cbServicio
            // 
            cbServicio.BackColor = Color.FromArgb(51, 77, 53);
            cbServicio.FlatStyle = FlatStyle.Flat;
            cbServicio.FormattingEnabled = true;
            cbServicio.Location = new Point(4, 3);
            cbServicio.Name = "cbServicio";
            cbServicio.Size = new Size(182, 40);
            cbServicio.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 0;
            label3.Text = "Servicio";
            // 
            // panel8
            // 
            panel8.Controls.Add(chbNecesario);
            panel8.Controls.Add(label8);
            panel8.Location = new Point(210, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(105, 67);
            panel8.TabIndex = 8;
            // 
            // chbNecesario
            // 
            chbNecesario.AutoSize = true;
            chbNecesario.Location = new Point(40, 28);
            chbNecesario.Name = "chbNecesario";
            chbNecesario.Size = new Size(22, 21);
            chbNecesario.TabIndex = 1;
            chbNecesario.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(100, 25);
            label8.TabIndex = 0;
            label8.Text = "Necesario";
            // 
            // bAgregarItem
            // 
            bAgregarItem.BackColor = Color.FromArgb(40, 40, 40);
            bAgregarItem.FlatAppearance.BorderSize = 0;
            bAgregarItem.FlatStyle = FlatStyle.Flat;
            bAgregarItem.ForeColor = Color.Gainsboro;
            bAgregarItem.Location = new Point(331, 15);
            bAgregarItem.Margin = new Padding(13, 15, 3, 3);
            bAgregarItem.Name = "bAgregarItem";
            bAgregarItem.Size = new Size(164, 34);
            bAgregarItem.TabIndex = 9;
            bAgregarItem.Text = "Agregar Item";
            bAgregarItem.UseVisualStyleBackColor = false;
            bAgregarItem.Click += bAgregarItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(418, 54);
            label1.TabIndex = 0;
            label1.Text = "Generar Presupuesto";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 60);
            label9.Name = "label9";
            label9.Size = new Size(205, 32);
            label9.TabIndex = 11;
            label9.Text = "Datos del equipo:";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(panel1);
            flowLayoutPanel2.Controls.Add(panel2);
            flowLayoutPanel2.Controls.Add(panel7);
            flowLayoutPanel2.Controls.Add(panel5);
            flowLayoutPanel2.Controls.Add(panel3);
            flowLayoutPanel2.Controls.Add(panel4);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 97);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1070, 74);
            flowLayoutPanel2.TabIndex = 8;
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
            lId.Size = new Size(92, 25);
            lId.TabIndex = 0;
            lId.Text = "IdEquipo";
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
            lIdContenido.Size = new Size(0, 32);
            lIdContenido.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(lIdCliente);
            panel2.Controls.Add(roundedPanel3);
            panel2.Location = new Point(113, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(104, 67);
            panel2.TabIndex = 1;
            // 
            // lIdCliente
            // 
            lIdCliente.AutoSize = true;
            lIdCliente.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lIdCliente.Location = new Point(3, 0);
            lIdCliente.Name = "lIdCliente";
            lIdCliente.Size = new Size(92, 25);
            lIdCliente.TabIndex = 0;
            lIdCliente.Text = "IdCliente";
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel3.BorderSize = 4F;
            roundedPanel3.Controls.Add(tbIdCliente);
            roundedPanel3.Location = new Point(3, 25);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(74, 38);
            roundedPanel3.TabIndex = 1;
            // 
            // tbIdCliente
            // 
            tbIdCliente.BackColor = Color.FromArgb(51, 77, 53);
            tbIdCliente.BorderStyle = BorderStyle.None;
            tbIdCliente.Location = new Point(9, 5);
            tbIdCliente.Name = "tbIdCliente";
            tbIdCliente.ReadOnly = true;
            tbIdCliente.Size = new Size(59, 32);
            tbIdCliente.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(label2);
            panel7.Controls.Add(roundedPanel8);
            panel7.Location = new Point(223, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(220, 67);
            panel7.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 0;
            label2.Text = "Descripcion";
            // 
            // roundedPanel8
            // 
            roundedPanel8.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel8.BorderSize = 4F;
            roundedPanel8.Controls.Add(label6);
            roundedPanel8.Controls.Add(label7);
            roundedPanel8.Controls.Add(tbDescripcion);
            roundedPanel8.Location = new Point(3, 28);
            roundedPanel8.Name = "roundedPanel8";
            roundedPanel8.Size = new Size(214, 38);
            roundedPanel8.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 6);
            label6.Name = "label6";
            label6.Size = new Size(0, 32);
            label6.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 7);
            label7.Name = "label7";
            label7.Size = new Size(0, 32);
            label7.TabIndex = 0;
            // 
            // tbDescripcion
            // 
            tbDescripcion.BackColor = Color.FromArgb(51, 77, 53);
            tbDescripcion.BorderStyle = BorderStyle.None;
            tbDescripcion.Location = new Point(9, 3);
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.ReadOnly = true;
            tbDescripcion.Size = new Size(202, 32);
            tbDescripcion.TabIndex = 9;
            // 
            // panel5
            // 
            panel5.Controls.Add(roundedPanel6);
            panel5.Controls.Add(lRol);
            panel5.Location = new Point(449, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(201, 67);
            panel5.TabIndex = 6;
            // 
            // roundedPanel6
            // 
            roundedPanel6.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel6.BorderSize = 4F;
            roundedPanel6.Controls.Add(tbMarca);
            roundedPanel6.Location = new Point(3, 25);
            roundedPanel6.Name = "roundedPanel6";
            roundedPanel6.Size = new Size(191, 38);
            roundedPanel6.TabIndex = 1;
            // 
            // tbMarca
            // 
            tbMarca.BackColor = Color.FromArgb(51, 77, 53);
            tbMarca.BorderStyle = BorderStyle.None;
            tbMarca.Location = new Point(3, 3);
            tbMarca.Name = "tbMarca";
            tbMarca.ReadOnly = true;
            tbMarca.Size = new Size(202, 32);
            tbMarca.TabIndex = 10;
            // 
            // lRol
            // 
            lRol.AutoSize = true;
            lRol.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lRol.Location = new Point(3, 0);
            lRol.Name = "lRol";
            lRol.Size = new Size(67, 25);
            lRol.TabIndex = 0;
            lRol.Text = "Marca";
            // 
            // panel3
            // 
            panel3.Controls.Add(roundedPanel4);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(656, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(201, 67);
            panel3.TabIndex = 7;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel4.BorderSize = 4F;
            roundedPanel4.Controls.Add(tbTipo);
            roundedPanel4.Location = new Point(3, 25);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(191, 38);
            roundedPanel4.TabIndex = 1;
            // 
            // tbTipo
            // 
            tbTipo.BackColor = Color.FromArgb(51, 77, 53);
            tbTipo.BorderStyle = BorderStyle.None;
            tbTipo.Location = new Point(4, 6);
            tbTipo.Name = "tbTipo";
            tbTipo.ReadOnly = true;
            tbTipo.Size = new Size(202, 32);
            tbTipo.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(52, 25);
            label4.TabIndex = 0;
            label4.Text = "Tipo";
            // 
            // panel4
            // 
            panel4.Controls.Add(roundedPanel5);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(863, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(201, 67);
            panel4.TabIndex = 8;
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.FromArgb(51, 77, 53);
            roundedPanel5.BorderSize = 4F;
            roundedPanel5.Controls.Add(tbEstado);
            roundedPanel5.Location = new Point(3, 25);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(191, 38);
            roundedPanel5.TabIndex = 1;
            // 
            // tbEstado
            // 
            tbEstado.BackColor = Color.FromArgb(51, 77, 53);
            tbEstado.BorderStyle = BorderStyle.None;
            tbEstado.Location = new Point(5, 5);
            tbEstado.Name = "tbEstado";
            tbEstado.ReadOnly = true;
            tbEstado.Size = new Size(202, 32);
            tbEstado.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(72, 25);
            label5.TabIndex = 0;
            label5.Text = "Estado";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label10.Location = new Point(3, 174);
            label10.Name = "label10";
            label10.Size = new Size(185, 32);
            label10.TabIndex = 12;
            label10.Text = "Carga de Items:";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(roundedPanel7);
            flowLayoutPanel3.Controls.Add(bGenerarPresupuesto);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(3, 293);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(1070, 267);
            flowLayoutPanel3.TabIndex = 13;
            // 
            // roundedPanel7
            // 
            roundedPanel7.BackColor = Color.White;
            roundedPanel7.Controls.Add(dgvServicios);
            roundedPanel7.Location = new Point(15, 3);
            roundedPanel7.Margin = new Padding(15, 3, 3, 3);
            roundedPanel7.Name = "roundedPanel7";
            roundedPanel7.Size = new Size(787, 241);
            roundedPanel7.TabIndex = 0;
            // 
            // dgvServicios
            // 
            dgvServicios.AllowUserToAddRows = false;
            dgvServicios.AllowUserToDeleteRows = false;
            dgvServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicios.Columns.AddRange(new DataGridViewColumn[] { colServicio, colIdServicio, colPrecio, colNecesario, colEliminar });
            dgvServicios.Dock = DockStyle.Fill;
            dgvServicios.Location = new Point(0, 0);
            dgvServicios.MultiSelect = false;
            dgvServicios.Name = "dgvServicios";
            dgvServicios.ReadOnly = true;
            dgvServicios.RowHeadersWidth = 62;
            dgvServicios.Size = new Size(787, 241);
            dgvServicios.TabIndex = 0;
            dgvServicios.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colServicio
            // 
            colServicio.HeaderText = "Servicio";
            colServicio.MinimumWidth = 8;
            colServicio.Name = "colServicio";
            colServicio.ReadOnly = true;
            colServicio.Width = 150;
            // 
            // colIdServicio
            // 
            colIdServicio.HeaderText = "IdServicio";
            colIdServicio.MinimumWidth = 8;
            colIdServicio.Name = "colIdServicio";
            colIdServicio.ReadOnly = true;
            colIdServicio.Width = 150;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Precio";
            colPrecio.MinimumWidth = 8;
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            colPrecio.Width = 150;
            // 
            // colNecesario
            // 
            colNecesario.HeaderText = "Necesario";
            colNecesario.MinimumWidth = 8;
            colNecesario.Name = "colNecesario";
            colNecesario.ReadOnly = true;
            colNecesario.Width = 150;
            // 
            // colEliminar
            // 
            colEliminar.HeaderText = "";
            colEliminar.MinimumWidth = 8;
            colEliminar.Name = "colEliminar";
            colEliminar.ReadOnly = true;
            colEliminar.Width = 150;
            // 
            // bGenerarPresupuesto
            // 
            bGenerarPresupuesto.BackColor = Color.FromArgb(40, 40, 40);
            bGenerarPresupuesto.FlatAppearance.BorderSize = 0;
            bGenerarPresupuesto.FlatStyle = FlatStyle.Flat;
            bGenerarPresupuesto.ForeColor = Color.Gainsboro;
            bGenerarPresupuesto.Location = new Point(808, 3);
            bGenerarPresupuesto.Name = "bGenerarPresupuesto";
            bGenerarPresupuesto.Size = new Size(239, 40);
            bGenerarPresupuesto.TabIndex = 1;
            bGenerarPresupuesto.Text = "Generar Presupuesto";
            bGenerarPresupuesto.UseVisualStyleBackColor = false;
            bGenerarPresupuesto.Click += bGenerarPresupuesto_Click;
            // 
            // GenerarPresupuestoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 77, 53);
            ClientSize = new Size(1076, 563);
            Controls.Add(tableLayoutPanel1);
            Name = "GenerarPresupuestoForm";
            Text = "GenerarPresupuestoForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            roundedPanel8.ResumeLayout(false);
            roundedPanel8.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            roundedPanel6.ResumeLayout(false);
            roundedPanel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            roundedPanel5.ResumeLayout(false);
            roundedPanel5.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            roundedPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvServicios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel1;
        private Label lId;
        private Shared.Controls.RoundedPanel roundedPanel2;
        private Label lIdContenido;
        private Panel panel2;
        private Label lIdCliente;
        private Shared.Controls.RoundedPanel roundedPanel3;
        private TextBox tbIdCliente;
        private Panel panel7;
        private Label label2;
        private Shared.Controls.RoundedPanel roundedPanel8;
        private Label label6;
        private Label label7;
        private TextBox tbDescripcion;
        private Panel panel5;
        private Shared.Controls.RoundedPanel roundedPanel6;
        private Label lRol;
        private Panel panel3;
        private Shared.Controls.RoundedPanel roundedPanel4;
        private Label label4;
        private Panel panel4;
        private Shared.Controls.RoundedPanel roundedPanel5;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel6;
        private Shared.Controls.RoundedPanel roundedPanel1;
        private ComboBox cbServicio;
        private Label label3;
        private Panel panel8;
        private Label label8;
        private CheckBox chbNecesario;
        private Shared.Controls.RoundedButton bAgregarItem;
        private Label label9;
        private Label label10;
        private FlowLayoutPanel flowLayoutPanel3;
        private Shared.Controls.RoundedPanel roundedPanel7;
        private DataGridView dgvServicios;
        private Shared.Controls.RoundedButton bGenerarPresupuesto;
        private TextBox tbMarca;
        private TextBox tbTipo;
        private TextBox tbEstado;
        private DataGridViewTextBoxColumn colServicio;
        private DataGridViewTextBoxColumn colIdServicio;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewCheckBoxColumn colNecesario;
        private DataGridViewButtonColumn colEliminar;
    }
}