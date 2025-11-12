namespace Taller_2_Gestor.Features.BackupFeature
{
    partial class BackupView
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
            tbNombreArchivo = new TextBox();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tbRuta = new TextBox();
            bExaminar = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            bRealizarBackup = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            saveFileDialog1 = new SaveFileDialog();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tbNombreArchivo, 0, 4);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 2);
            tableLayoutPanel1.Controls.Add(bRealizarBackup, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.ForeColor = SystemColors.ControlText;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 11F));
            tableLayoutPanel1.Size = new Size(759, 449);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 129);
            label3.Margin = new Padding(10, 18, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(151, 20);
            label3.TabIndex = 5;
            label3.Text = "Nombre del archivo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(2, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(219, 36);
            label1.TabIndex = 1;
            label1.Text = "Realizar Backup";
            // 
            // tbNombreArchivo
            // 
            tbNombreArchivo.Location = new Point(14, 151);
            tbNombreArchivo.Margin = new Padding(14, 2, 2, 2);
            tbNombreArchivo.Name = "tbNombreArchivo";
            tbNombreArchivo.ReadOnly = true;
            tbNombreArchivo.Size = new Size(521, 23);
            tbNombreArchivo.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 54);
            label2.Margin = new Padding(10, 18, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(157, 21);
            label2.TabIndex = 2;
            label2.Text = "Ubicacion de destino:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(tbRuta);
            flowLayoutPanel1.Controls.Add(bExaminar);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(2, 79);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(755, 30);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // tbRuta
            // 
            tbRuta.Location = new Point(14, 2);
            tbRuta.Margin = new Padding(14, 2, 2, 2);
            tbRuta.Name = "tbRuta";
            tbRuta.ReadOnly = true;
            tbRuta.Size = new Size(521, 23);
            tbRuta.TabIndex = 4;
            // 
            // bExaminar
            // 
            bExaminar.BackColor = Color.FromArgb(40, 40, 40);
            bExaminar.FlatAppearance.BorderSize = 0;
            bExaminar.FlatStyle = FlatStyle.Flat;
            bExaminar.ForeColor = Color.Gainsboro;
            bExaminar.Location = new Point(539, 2);
            bExaminar.Margin = new Padding(2);
            bExaminar.Name = "bExaminar";
            bExaminar.Size = new Size(110, 20);
            bExaminar.TabIndex = 5;
            bExaminar.Text = "Examinar...";
            bExaminar.UseVisualStyleBackColor = false;
            bExaminar.Click += bExaminar_Click;
            // 
            // bRealizarBackup
            // 
            bRealizarBackup.Anchor = AnchorStyles.None;
            bRealizarBackup.BackColor = Color.FromArgb(40, 40, 40);
            bRealizarBackup.FlatAppearance.BorderSize = 0;
            bRealizarBackup.FlatStyle = FlatStyle.Flat;
            bRealizarBackup.ForeColor = Color.Gainsboro;
            bRealizarBackup.Location = new Point(316, 304);
            bRealizarBackup.Margin = new Padding(2);
            bRealizarBackup.Name = "bRealizarBackup";
            bRealizarBackup.Size = new Size(126, 20);
            bRealizarBackup.TabIndex = 4;
            bRealizarBackup.Text = "REALIZAR BACKUP";
            bRealizarBackup.UseVisualStyleBackColor = false;
            bRealizarBackup.Click += bRealizarBackup_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "bak";
            saveFileDialog1.Filter = "Archivos de Backup (*.bak)|*.bak";
            // 
            // BackupView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 77, 53);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "BackupView";
            Size = new Size(759, 449);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private SaveFileDialog saveFileDialog1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox tbRuta;
        private Shared.Controls.RoundedButton bExaminar;
        private Label label3;
        private TextBox tbNombreArchivo;
        private Shared.Controls.RoundedButton bRealizarBackup;
    }
}
