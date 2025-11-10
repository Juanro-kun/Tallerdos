namespace Taller_2_Gestor.Features.Centro_de_Tareas_Tecnico
{
    partial class PosponerReparacionMessageBox
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
            label1 = new Label();
            tbMensaje = new TextBox();
            roundedPanel1 = new Taller_2_Gestor.Features.Shared.Controls.RoundedPanel();
            dgvItems = new DataGridView();
            roundedButton1 = new Taller_2_Gestor.Features.Shared.Controls.RoundedButton();
            lIdPresupuesto = new Label();
            colServicio = new DataGridViewTextBoxColumn();
            colPosponer = new DataGridViewCheckBoxColumn();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(861, 79);
            label1.TabIndex = 0;
            label1.Text = "Para posponer la reparacion, por favor, ingrese un mensaje justificando la postergacion y seleccione los items por los cuales se la realiza";
            // 
            // tbMensaje
            // 
            tbMensaje.Location = new Point(42, 86);
            tbMensaje.MaximumSize = new Size(770, 100);
            tbMensaje.MaxLength = 200;
            tbMensaje.MinimumSize = new Size(770, 100);
            tbMensaje.Multiline = true;
            tbMensaje.Name = "tbMensaje";
            tbMensaje.PlaceholderText = "Mensaje";
            tbMensaje.Size = new Size(770, 100);
            tbMensaje.TabIndex = 1;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.Controls.Add(dgvItems);
            roundedPanel1.Location = new Point(42, 212);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(770, 189);
            roundedPanel1.TabIndex = 2;
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { colServicio, colPosponer });
            dgvItems.Dock = DockStyle.Fill;
            dgvItems.Location = new Point(0, 0);
            dgvItems.Name = "dgvItems";
            dgvItems.RowHeadersWidth = 62;
            dgvItems.Size = new Size(770, 189);
            dgvItems.TabIndex = 0;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.FromArgb(40, 40, 40);
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.ForeColor = Color.Gainsboro;
            roundedButton1.Location = new Point(336, 441);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(208, 62);
            roundedButton1.TabIndex = 3;
            roundedButton1.Text = "Posponer";
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += roundedButton1_Click;
            // 
            // lIdPresupuesto
            // 
            lIdPresupuesto.AutoSize = true;
            lIdPresupuesto.Location = new Point(660, 441);
            lIdPresupuesto.Name = "lIdPresupuesto";
            lIdPresupuesto.Size = new Size(0, 25);
            lIdPresupuesto.TabIndex = 4;
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
            // colPosponer
            // 
            colPosponer.HeaderText = "Pospuesto";
            colPosponer.MinimumWidth = 8;
            colPosponer.Name = "colPosponer";
            colPosponer.Width = 150;
            // 
            // PosponerReparacionMessageBox
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 535);
            Controls.Add(lIdPresupuesto);
            Controls.Add(roundedButton1);
            Controls.Add(roundedPanel1);
            Controls.Add(tbMensaje);
            Controls.Add(label1);
            Name = "PosponerReparacionMessageBox";
            Text = "PosponerReparacionMessageBox";
            roundedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbMensaje;
        private Shared.Controls.RoundedPanel roundedPanel1;
        private DataGridView dgvItems;
        private Shared.Controls.RoundedButton roundedButton1;
        private Label lIdPresupuesto;
        private DataGridViewTextBoxColumn colServicio;
        private DataGridViewCheckBoxColumn colPosponer;
    }
}