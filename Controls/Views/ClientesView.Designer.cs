namespace Taller_2_Gestor.Views
{
    partial class ClientesView
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
            tlpViews = new TableLayoutPanel();
            label1 = new Label();
            rpFiltro = new Taller_2_Gestor.Controls.RoundedPanel();
            lFiltro = new Label();
            comboBox1 = new ComboBox();
            rpBarraBusqueda = new Taller_2_Gestor.Controls.RoundedPanel();
            lBusqueda = new Label();
            roundedPanel1 = new Taller_2_Gestor.Controls.RoundedPanel();
            dataGridView1 = new DataGridView();
            tlpViews.SuspendLayout();
            rpFiltro.SuspendLayout();
            rpBarraBusqueda.SuspendLayout();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tlpViews
            // 
            tlpViews.AllowDrop = true;
            tlpViews.ColumnCount = 1;
            tlpViews.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpViews.Controls.Add(label1, 0, 0);
            tlpViews.Controls.Add(rpFiltro, 0, 1);
            tlpViews.Controls.Add(rpBarraBusqueda, 0, 2);
            tlpViews.Controls.Add(roundedPanel1, 0, 3);
            tlpViews.Dock = DockStyle.Fill;
            tlpViews.Location = new Point(0, 0);
            tlpViews.Name = "tlpViews";
            tlpViews.RowCount = 6;
            tlpViews.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tlpViews.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tlpViews.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tlpViews.RowStyles.Add(new RowStyle(SizeType.Percent, 36F));
            tlpViews.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tlpViews.RowStyles.Add(new RowStyle(SizeType.Percent, 39F));
            tlpViews.Size = new Size(1016, 688);
            tlpViews.TabIndex = 0;
            tlpViews.Paint += tableLayoutPanel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(185, 48);
            label1.TabIndex = 0;
            label1.Text = "Usuarios";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rpFiltro
            // 
            rpFiltro.BackColor = Color.FromArgb(33, 33, 33);
            rpFiltro.BorderColor = Color.Black;
            rpFiltro.BorderSize = 1F;
            rpFiltro.Controls.Add(comboBox1);
            rpFiltro.Controls.Add(lFiltro);
            rpFiltro.CornerRadius = 12;
            rpFiltro.Location = new Point(30, 51);
            rpFiltro.Margin = new Padding(30, 3, 3, 3);
            rpFiltro.Name = "rpFiltro";
            rpFiltro.Size = new Size(258, 35);
            rpFiltro.TabIndex = 2;
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
            lFiltro.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(33, 33, 33);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(118, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(137, 33);
            comboBox1.TabIndex = 1;
            // 
            // rpBarraBusqueda
            // 
            rpBarraBusqueda.BackColor = Color.DarkGray;
            rpBarraBusqueda.BorderColor = Color.DarkGray;
            rpBarraBusqueda.BorderSize = 1F;
            rpBarraBusqueda.Controls.Add(lBusqueda);
            rpBarraBusqueda.CornerRadius = 12;
            rpBarraBusqueda.Location = new Point(25, 92);
            rpBarraBusqueda.Margin = new Padding(25, 3, 3, 3);
            rpBarraBusqueda.Name = "rpBarraBusqueda";
            rpBarraBusqueda.Size = new Size(950, 35);
            rpBarraBusqueda.TabIndex = 3;
            // 
            // lBusqueda
            // 
            lBusqueda.AutoSize = true;
            lBusqueda.ForeColor = SystemColors.ControlDarkDark;
            lBusqueda.Location = new Point(24, 5);
            lBusqueda.Name = "lBusqueda";
            lBusqueda.Size = new Size(326, 25);
            lBusqueda.TabIndex = 0;
            lBusqueda.Text = "Ingrese un dato del usuario para buscar";
            lBusqueda.Click += label2_Click_1;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BorderColor = Color.Black;
            roundedPanel1.BorderSize = 3F;
            roundedPanel1.Controls.Add(dataGridView1);
            roundedPanel1.CornerRadius = 12;
            roundedPanel1.Location = new Point(25, 137);
            roundedPanel1.Margin = new Padding(25, 7, 3, 3);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(950, 237);
            roundedPanel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(950, 237);
            dataGridView1.TabIndex = 0;
            // 
            // ClientesView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 77, 53);
            Controls.Add(tlpViews);
            Name = "ClientesView";
            Size = new Size(1016, 688);
            Load += ClientesView_Load;
            tlpViews.ResumeLayout(false);
            tlpViews.PerformLayout();
            rpFiltro.ResumeLayout(false);
            rpFiltro.PerformLayout();
            rpBarraBusqueda.ResumeLayout(false);
            rpBarraBusqueda.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpViews;
        private Label label1;
        private Controls.RoundedPanel rpFiltro;
        private Label lFiltro;
        private ComboBox comboBox1;
        private Controls.RoundedPanel rpBarraBusqueda;
        private Label lBusqueda;
        private Controls.RoundedPanel roundedPanel1;
        private DataGridView dataGridView1;
    }
}
