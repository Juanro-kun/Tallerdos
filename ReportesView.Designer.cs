namespace Taller_2_Gestor
{
    partial class ReportesView
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
            bGenerarReporte = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            dataGridView1 = new DataGridView();
            panelGrafico = new Panel();
            dtpInicio = new DateTimePicker();
            dtpFin = new DateTimePicker();
            lFechaIni = new Label();
            lFechaFin = new Label();
            lTipoReporte = new Label();
            cbTipoReporte = new ComboBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.9021F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.0979F));
            tableLayoutPanel1.Controls.Add(bGenerarReporte, 0, 4);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 3);
            tableLayoutPanel1.Controls.Add(panelGrafico, 1, 3);
            tableLayoutPanel1.Controls.Add(dtpInicio, 0, 2);
            tableLayoutPanel1.Controls.Add(dtpFin, 1, 2);
            tableLayoutPanel1.Controls.Add(lFechaIni, 0, 1);
            tableLayoutPanel1.Controls.Add(lFechaFin, 1, 1);
            tableLayoutPanel1.Controls.Add(lTipoReporte, 0, 0);
            tableLayoutPanel1.Controls.Add(cbTipoReporte, 1, 0);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.178792F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.559924F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.4947548F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 53.3160973F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.4504356F));
            tableLayoutPanel1.Size = new Size(858, 534);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // bGenerarReporte
            // 
            bGenerarReporte.BackColor = Color.FromArgb(40, 40, 40);
            bGenerarReporte.FlatAppearance.BorderSize = 0;
            bGenerarReporte.FlatStyle = FlatStyle.Flat;
            bGenerarReporte.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bGenerarReporte.ForeColor = Color.Gainsboro;
            bGenerarReporte.Location = new Point(2, 446);
            bGenerarReporte.Margin = new Padding(2);
            bGenerarReporte.Name = "bGenerarReporte";
            bGenerarReporte.Size = new Size(154, 30);
            bGenerarReporte.TabIndex = 13;
            bGenerarReporte.Text = "Generar Reporte";
            bGenerarReporte.UseVisualStyleBackColor = false;
            bGenerarReporte.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(405, 226);
            dataGridView1.TabIndex = 15;
            // 
            // panelGrafico
            // 
            panelGrafico.Location = new Point(414, 163);
            panelGrafico.Name = "panelGrafico";
            panelGrafico.Size = new Size(424, 226);
            panelGrafico.TabIndex = 14;
            // 
            // dtpInicio
            // 
            dtpInicio.Location = new Point(3, 102);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(200, 23);
            dtpInicio.TabIndex = 11;
            // 
            // dtpFin
            // 
            dtpFin.Location = new Point(414, 102);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(200, 23);
            dtpFin.TabIndex = 12;
            // 
            // lFechaIni
            // 
            lFechaIni.AutoSize = true;
            lFechaIni.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lFechaIni.Location = new Point(18, 54);
            lFechaIni.Margin = new Padding(18, 0, 2, 0);
            lFechaIni.Name = "lFechaIni";
            lFechaIni.Size = new Size(140, 30);
            lFechaIni.TabIndex = 9;
            lFechaIni.Text = "Fecha Inicio:";
            // 
            // lFechaFin
            // 
            lFechaFin.AutoSize = true;
            lFechaFin.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lFechaFin.Location = new Point(429, 54);
            lFechaFin.Margin = new Padding(18, 0, 2, 0);
            lFechaFin.Name = "lFechaFin";
            lFechaFin.Size = new Size(114, 30);
            lFechaFin.TabIndex = 10;
            lFechaFin.Text = "Fecha Fin:";
            // 
            // lTipoReporte
            // 
            lTipoReporte.Anchor = AnchorStyles.None;
            lTipoReporte.AutoSize = true;
            lTipoReporte.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lTipoReporte.Location = new Point(63, 12);
            lTipoReporte.Margin = new Padding(18, 0, 2, 0);
            lTipoReporte.Name = "lTipoReporte";
            lTipoReporte.Size = new Size(301, 30);
            lTipoReporte.TabIndex = 16;
            lTipoReporte.Text = "Seleccionar tipo de reporte:";
            lTipoReporte.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbTipoReporte
            // 
            cbTipoReporte.Anchor = AnchorStyles.Left;
            cbTipoReporte.FormattingEnabled = true;
            cbTipoReporte.Location = new Point(414, 15);
            cbTipoReporte.Name = "cbTipoReporte";
            cbTipoReporte.Size = new Size(336, 23);
            cbTipoReporte.TabIndex = 17;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // ReportesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 77, 53);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "ReportesView";
            Size = new Size(864, 540);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lFechaFin;
        private Label lFechaIni;
        private DateTimePicker dtpInicio;
        private DateTimePicker dtpFin;
        private Features.Shared.Controls.RoundedButton bGenerarReporte;
        private Panel panelGrafico;
        private DataGridView dataGridView1;
        private Label lTipoReporte;
        private ComboBox cbTipoReporte;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}
