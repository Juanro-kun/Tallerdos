using System.Windows.Forms.DataVisualization.Charting;
namespace Taller_2_Gestor.Features.Informes
{
    partial class InformesView
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            roundedPanel1 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            lTotalGenerado = new Label();
            label2 = new Label();
            roundedPanel4 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            lServicioMasContratado = new Label();
            label5 = new Label();
            roundedPanel5 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            lTecnicoMasProductivo = new Label();
            label6 = new Label();
            roundedPanel7 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            lTipoEquipoMasReparado = new Label();
            label8 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            roundedPanel2 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            label3 = new Label();
            dtpDesde = new DateTimePicker();
            roundedPanel3 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            label4 = new Label();
            dtpHasta = new DateTimePicker();
            flowLayoutPanel3 = new FlowLayoutPanel();
            bServicioMasContratado = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            bTecnicoMasProductivo = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            bTipoEquipoMasReparado = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            bAlternarVista = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            roundedPanel6 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            tlpTotales = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            lTotalesID = new Label();
            lTotalesII = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            lTotalesMD = new Label();
            lTotalesMI = new Label();
            dgvInformes = new DataGridView();
            chartReportes = new ScottPlot.WinForms.FormsPlot();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            roundedPanel1.SuspendLayout();
            roundedPanel4.SuspendLayout();
            roundedPanel5.SuspendLayout();
            roundedPanel7.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            roundedPanel2.SuspendLayout();
            roundedPanel3.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            roundedPanel6.SuspendLayout();
            tlpTotales.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInformes).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel3, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 453F));
            tableLayoutPanel1.Size = new Size(1154, 716);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(192, 54);
            label1.TabIndex = 1;
            label1.Text = "Informes";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(roundedPanel1);
            flowLayoutPanel1.Controls.Add(roundedPanel4);
            flowLayoutPanel1.Controls.Add(roundedPanel5);
            flowLayoutPanel1.Controls.Add(roundedPanel7);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 116);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.RightToLeft = RightToLeft.No;
            flowLayoutPanel1.Size = new Size(1148, 144);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.Controls.Add(lTotalGenerado);
            roundedPanel1.Controls.Add(label2);
            roundedPanel1.Location = new Point(15, 3);
            roundedPanel1.Margin = new Padding(15, 3, 3, 3);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(196, 116);
            roundedPanel1.TabIndex = 0;
            // 
            // lTotalGenerado
            // 
            lTotalGenerado.AutoSize = true;
            lTotalGenerado.Location = new Point(12, 53);
            lTotalGenerado.Name = "lTotalGenerado";
            lTotalGenerado.Size = new Size(59, 25);
            lTotalGenerado.TabIndex = 2;
            lTotalGenerado.Text = "label9";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 10);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 0;
            label2.Text = "Total generado:";
            label2.Click += label2_Click;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.White;
            roundedPanel4.Controls.Add(lServicioMasContratado);
            roundedPanel4.Controls.Add(label5);
            roundedPanel4.Location = new Point(229, 3);
            roundedPanel4.Margin = new Padding(15, 3, 3, 3);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(232, 116);
            roundedPanel4.TabIndex = 2;
            // 
            // lServicioMasContratado
            // 
            lServicioMasContratado.AutoSize = true;
            lServicioMasContratado.Location = new Point(8, 55);
            lServicioMasContratado.Name = "lServicioMasContratado";
            lServicioMasContratado.Size = new Size(59, 25);
            lServicioMasContratado.TabIndex = 3;
            lServicioMasContratado.Text = "label9";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 10);
            label5.Name = "label5";
            label5.Size = new Size(207, 25);
            label5.TabIndex = 0;
            label5.Text = "Servicio mas contratado:";
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.White;
            roundedPanel5.Controls.Add(lTecnicoMasProductivo);
            roundedPanel5.Controls.Add(label6);
            roundedPanel5.Location = new Point(479, 3);
            roundedPanel5.Margin = new Padding(15, 3, 3, 3);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(232, 116);
            roundedPanel5.TabIndex = 3;
            // 
            // lTecnicoMasProductivo
            // 
            lTecnicoMasProductivo.AutoSize = true;
            lTecnicoMasProductivo.Location = new Point(8, 53);
            lTecnicoMasProductivo.Name = "lTecnicoMasProductivo";
            lTecnicoMasProductivo.Size = new Size(59, 25);
            lTecnicoMasProductivo.TabIndex = 4;
            lTecnicoMasProductivo.Text = "label9";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 10);
            label6.Name = "label6";
            label6.Size = new Size(203, 25);
            label6.TabIndex = 0;
            label6.Text = "Tecnico mas productivo:";
            // 
            // roundedPanel7
            // 
            roundedPanel7.BackColor = Color.White;
            roundedPanel7.Controls.Add(lTipoEquipoMasReparado);
            roundedPanel7.Controls.Add(label8);
            roundedPanel7.Location = new Point(729, 3);
            roundedPanel7.Margin = new Padding(15, 3, 3, 3);
            roundedPanel7.Name = "roundedPanel7";
            roundedPanel7.Size = new Size(273, 116);
            roundedPanel7.TabIndex = 5;
            // 
            // lTipoEquipoMasReparado
            // 
            lTipoEquipoMasReparado.AutoSize = true;
            lTipoEquipoMasReparado.Location = new Point(7, 53);
            lTipoEquipoMasReparado.Name = "lTipoEquipoMasReparado";
            lTipoEquipoMasReparado.Size = new Size(59, 25);
            lTipoEquipoMasReparado.TabIndex = 5;
            lTipoEquipoMasReparado.Text = "label9";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 10);
            label8.Name = "label8";
            label8.Size = new Size(252, 25);
            label8.TabIndex = 0;
            label8.Text = "Tipo de equipo mas reparado:";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(roundedPanel2);
            flowLayoutPanel2.Controls.Add(roundedPanel3);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 59);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1148, 51);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.Black;
            roundedPanel2.Controls.Add(label3);
            roundedPanel2.Controls.Add(dtpDesde);
            roundedPanel2.Location = new Point(3, 3);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(271, 38);
            roundedPanel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(12, 5);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 0;
            label3.Text = "Desde:";
            // 
            // dtpDesde
            // 
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(82, 3);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(169, 31);
            dtpDesde.TabIndex = 3;
            dtpDesde.ValueChanged += dtpDesde_ValueChanged;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.Black;
            roundedPanel3.Controls.Add(label4);
            roundedPanel3.Controls.Add(dtpHasta);
            roundedPanel3.Location = new Point(280, 3);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(266, 38);
            roundedPanel3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(12, 5);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 0;
            label4.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(82, 3);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(166, 31);
            dtpHasta.TabIndex = 3;
            dtpHasta.ValueChanged += dtpHasta_ValueChanged;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(bServicioMasContratado);
            flowLayoutPanel3.Controls.Add(bTecnicoMasProductivo);
            flowLayoutPanel3.Controls.Add(bTipoEquipoMasReparado);
            flowLayoutPanel3.Controls.Add(bAlternarVista);
            flowLayoutPanel3.Controls.Add(roundedPanel6);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(3, 266);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(1148, 447);
            flowLayoutPanel3.TabIndex = 4;
            // 
            // bServicioMasContratado
            // 
            bServicioMasContratado.BackColor = Color.FromArgb(40, 40, 40);
            bServicioMasContratado.FlatAppearance.BorderSize = 0;
            bServicioMasContratado.FlatStyle = FlatStyle.Flat;
            bServicioMasContratado.ForeColor = Color.Gainsboro;
            bServicioMasContratado.Location = new Point(15, 3);
            bServicioMasContratado.Margin = new Padding(15, 3, 3, 3);
            bServicioMasContratado.Name = "bServicioMasContratado";
            bServicioMasContratado.Size = new Size(208, 34);
            bServicioMasContratado.TabIndex = 0;
            bServicioMasContratado.Text = "Servicio mas contratado";
            bServicioMasContratado.UseVisualStyleBackColor = false;
            bServicioMasContratado.Click += bServicioMasContratado_Click;
            // 
            // bTecnicoMasProductivo
            // 
            bTecnicoMasProductivo.BackColor = Color.FromArgb(40, 40, 40);
            bTecnicoMasProductivo.FlatAppearance.BorderSize = 0;
            bTecnicoMasProductivo.FlatStyle = FlatStyle.Flat;
            bTecnicoMasProductivo.ForeColor = Color.Gainsboro;
            bTecnicoMasProductivo.Location = new Point(229, 3);
            bTecnicoMasProductivo.Name = "bTecnicoMasProductivo";
            bTecnicoMasProductivo.Size = new Size(226, 34);
            bTecnicoMasProductivo.TabIndex = 1;
            bTecnicoMasProductivo.Text = "Tecnico mas productivo";
            bTecnicoMasProductivo.UseVisualStyleBackColor = false;
            bTecnicoMasProductivo.Click += bTecnicoMasProductivo_Click;
            // 
            // bTipoEquipoMasReparado
            // 
            bTipoEquipoMasReparado.BackColor = Color.FromArgb(40, 40, 40);
            bTipoEquipoMasReparado.FlatAppearance.BorderSize = 0;
            bTipoEquipoMasReparado.FlatStyle = FlatStyle.Flat;
            bTipoEquipoMasReparado.ForeColor = Color.Gainsboro;
            bTipoEquipoMasReparado.Location = new Point(461, 3);
            bTipoEquipoMasReparado.Name = "bTipoEquipoMasReparado";
            bTipoEquipoMasReparado.Size = new Size(262, 34);
            bTipoEquipoMasReparado.TabIndex = 2;
            bTipoEquipoMasReparado.Text = "Tipo de equipo mas reparado";
            bTipoEquipoMasReparado.UseVisualStyleBackColor = false;
            bTipoEquipoMasReparado.Click += bTipoEquipoMasReparado_Click;
            // 
            // bAlternarVista
            // 
            bAlternarVista.BackColor = Color.FromArgb(40, 40, 40);
            bAlternarVista.FlatAppearance.BorderSize = 0;
            bAlternarVista.FlatStyle = FlatStyle.Flat;
            bAlternarVista.ForeColor = Color.Gainsboro;
            bAlternarVista.Location = new Point(741, 3);
            bAlternarVista.Margin = new Padding(15, 3, 3, 3);
            bAlternarVista.Name = "bAlternarVista";
            bAlternarVista.Size = new Size(208, 34);
            bAlternarVista.TabIndex = 4;
            bAlternarVista.Text = "Mostrar grafico";
            bAlternarVista.UseVisualStyleBackColor = false;
            bAlternarVista.Click += bAlternarVista_Click;
            // 
            // roundedPanel6
            // 
            roundedPanel6.BackColor = Color.White;
            roundedPanel6.Controls.Add(tlpTotales);
            roundedPanel6.Controls.Add(dgvInformes);
            roundedPanel6.Controls.Add(chartReportes);
            roundedPanel6.Location = new Point(15, 43);
            roundedPanel6.Margin = new Padding(15, 3, 3, 3);
            roundedPanel6.Name = "roundedPanel6";
            roundedPanel6.Size = new Size(1103, 386);
            roundedPanel6.TabIndex = 3;
            // 
            // tlpTotales
            // 
            tlpTotales.ColumnCount = 3;
            tlpTotales.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.8310242F));
            tlpTotales.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.1689758F));
            tlpTotales.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 380F));
            tlpTotales.Controls.Add(tableLayoutPanel3, 2, 0);
            tlpTotales.Controls.Add(tableLayoutPanel2, 1, 0);
            tlpTotales.Dock = DockStyle.Bottom;
            tlpTotales.Location = new Point(0, 345);
            tlpTotales.Name = "tlpTotales";
            tlpTotales.RowCount = 1;
            tlpTotales.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpTotales.Size = new Size(1103, 41);
            tlpTotales.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(lTotalesID, 1, 0);
            tableLayoutPanel3.Controls.Add(lTotalesII, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(725, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(375, 35);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // lTotalesID
            // 
            lTotalesID.Anchor = AnchorStyles.Right;
            lTotalesID.AutoSize = true;
            lTotalesID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lTotalesID.Location = new Point(372, 5);
            lTotalesID.Name = "lTotalesID";
            lTotalesID.Size = new Size(0, 25);
            lTotalesID.TabIndex = 1;
            // 
            // lTotalesII
            // 
            lTotalesII.Anchor = AnchorStyles.Left;
            lTotalesII.AutoSize = true;
            lTotalesII.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lTotalesII.Location = new Point(3, 5);
            lTotalesII.Name = "lTotalesII";
            lTotalesII.Size = new Size(0, 25);
            lTotalesII.TabIndex = 0;
            lTotalesII.Click += lTotalesII_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.47565F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.5243568F));
            tableLayoutPanel2.Controls.Add(lTotalesMD, 1, 0);
            tableLayoutPanel2.Controls.Add(lTotalesMI, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(370, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(349, 35);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // lTotalesMD
            // 
            lTotalesMD.Anchor = AnchorStyles.Right;
            lTotalesMD.AutoSize = true;
            lTotalesMD.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lTotalesMD.Location = new Point(346, 5);
            lTotalesMD.Name = "lTotalesMD";
            lTotalesMD.Size = new Size(0, 25);
            lTotalesMD.TabIndex = 1;
            // 
            // lTotalesMI
            // 
            lTotalesMI.Anchor = AnchorStyles.Left;
            lTotalesMI.AutoSize = true;
            lTotalesMI.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lTotalesMI.Location = new Point(3, 5);
            lTotalesMI.Name = "lTotalesMI";
            lTotalesMI.Size = new Size(0, 25);
            lTotalesMI.TabIndex = 0;
            lTotalesMI.Click += label7_Click;
            // 
            // dgvInformes
            // 
            dgvInformes.AllowUserToAddRows = false;
            dgvInformes.AllowUserToDeleteRows = false;
            dgvInformes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInformes.Dock = DockStyle.Fill;
            dgvInformes.Location = new Point(0, 0);
            dgvInformes.Name = "dgvInformes";
            dgvInformes.ReadOnly = true;
            dgvInformes.RowHeadersWidth = 62;
            dgvInformes.Size = new Size(1103, 386);
            dgvInformes.TabIndex = 0;
            // 
            // chartReportes
            // 
            chartReportes.DisplayScale = 1.5F;
            chartReportes.Dock = DockStyle.Fill;
            chartReportes.Enabled = false;
            chartReportes.Location = new Point(0, 0);
            chartReportes.Name = "chartReportes";
            chartReportes.Size = new Size(1103, 386);
            chartReportes.TabIndex = 5;
            // 
            // InformesView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 77, 53);
            Controls.Add(tableLayoutPanel1);
            Name = "InformesView";
            Size = new Size(1154, 716);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            roundedPanel5.ResumeLayout(false);
            roundedPanel5.PerformLayout();
            roundedPanel7.ResumeLayout(false);
            roundedPanel7.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            roundedPanel6.ResumeLayout(false);
            tlpTotales.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInformes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Shared.Controls.RoundedPanel roundedPanel1;
        private Label label2;
        private DateTimePicker dtpDesde;
        private FlowLayoutPanel flowLayoutPanel2;
        private Shared.Controls.RoundedPanel roundedPanel2;
        private Label label3;
        private Shared.Controls.RoundedPanel roundedPanel3;
        private Label label4;
        private DateTimePicker dtpHasta;
        private Shared.Controls.RoundedPanel roundedPanel4;
        private Label label5;
        private Shared.Controls.RoundedPanel roundedPanel5;
        private Label label6;
        private Shared.Controls.RoundedPanel roundedPanel7;
        private Label label8;
        private Label lTotalGenerado;
        private Label lServicioMasContratado;
        private Label lTecnicoMasProductivo;
        private Label lTipoEquipoMasReparado;
        private FlowLayoutPanel flowLayoutPanel3;
        private Shared.Controls.RoundedButton bServicioMasContratado;
        private Shared.Controls.RoundedButton bTecnicoMasProductivo;
        private Shared.Controls.RoundedButton bTipoEquipoMasReparado;
        private Shared.Controls.RoundedPanel roundedPanel6;
        private DataGridView dgvInformes;
        private TableLayoutPanel tlpTotales;
        private Label lTotalesMI;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lTotalesID;
        private Label lTotalesII;
        private Label lTotalesMD;

        private Shared.Controls.RoundedButton bAlternarVista;
        private ScottPlot.WinForms.FormsPlot chartReportes;
    }
}
