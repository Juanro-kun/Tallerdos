namespace Taller_2_Gestor.Forms
{
    partial class MainForm : BaseForm
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
            tlpRoot = new TableLayoutPanel();
            ContentHost = new Panel();
            panelMenu = new Panel();
            flpMenu = new FlowLayoutPanel();
            bClientes = new Button();
            bEquipos = new Button();
            bPresupuestos = new Button();
            bOrdenes = new Button();
            bUsuarios = new Button();
            bTareasTecnico = new Button();
            bTareasAdmin = new Button();
            panel1 = new Panel();
            lBrand = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tlpRoot.SuspendLayout();
            panelMenu.SuspendLayout();
            flpMenu.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tlpRoot
            // 
            tlpRoot.ColumnCount = 2;
            tlpRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tlpRoot.ColumnStyles.Add(new ColumnStyle());
            tlpRoot.Controls.Add(ContentHost, 1, 0);
            tlpRoot.Controls.Add(panelMenu, 0, 0);
            tlpRoot.Dock = DockStyle.Fill;
            tlpRoot.Location = new Point(0, 0);
            tlpRoot.Name = "tlpRoot";
            tlpRoot.RowCount = 1;
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRoot.Size = new Size(800, 450);
            tlpRoot.TabIndex = 0;
            // 
            // ContentHost
            // 
            ContentHost.Dock = DockStyle.Fill;
            ContentHost.Location = new Point(203, 3);
            ContentHost.Name = "ContentHost";
            ContentHost.Size = new Size(594, 444);
            ContentHost.TabIndex = 1;
            ContentHost.Paint += ContentHost_Paint;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(33, 33, 33);
            panelMenu.Controls.Add(flpMenu);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Fill;
            panelMenu.Location = new Point(3, 3);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(194, 444);
            panelMenu.TabIndex = 0;
            // 
            // flpMenu
            // 
            flpMenu.AutoSize = true;
            flpMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpMenu.Controls.Add(bClientes);
            flpMenu.Controls.Add(bEquipos);
            flpMenu.Controls.Add(bPresupuestos);
            flpMenu.Controls.Add(bOrdenes);
            flpMenu.Controls.Add(bUsuarios);
            flpMenu.Controls.Add(bTareasTecnico);
            flpMenu.Controls.Add(bTareasAdmin);
            flpMenu.Dock = DockStyle.Top;
            flpMenu.FlowDirection = FlowDirection.TopDown;
            flpMenu.Location = new Point(0, 58);
            flpMenu.Name = "flpMenu";
            flpMenu.Padding = new Padding(9, 8, 9, 8);
            flpMenu.Size = new Size(194, 338);
            flpMenu.TabIndex = 0;
            flpMenu.WrapContents = false;
            // 
            // bClientes
            // 
            bClientes.BackColor = Color.FromArgb(33, 33, 33);
            bClientes.FlatAppearance.BorderSize = 0;
            bClientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 42, 42);
            bClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 42, 42);
            bClientes.FlatStyle = FlatStyle.Flat;
            bClientes.ForeColor = Color.Gainsboro;
            bClientes.Location = new Point(12, 11);
            bClientes.Name = "bClientes";
            bClientes.Padding = new Padding(11, 0, 0, 0);
            bClientes.Size = new Size(180, 40);
            bClientes.TabIndex = 0;
            bClientes.Text = "Clientes";
            bClientes.TextAlign = ContentAlignment.MiddleLeft;
            bClientes.UseVisualStyleBackColor = false;
            bClientes.Click += button1_Click;
            // 
            // bEquipos
            // 
            bEquipos.BackColor = Color.FromArgb(33, 33, 33);
            bEquipos.FlatAppearance.BorderSize = 0;
            bEquipos.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 42, 42);
            bEquipos.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 42, 42);
            bEquipos.FlatStyle = FlatStyle.Flat;
            bEquipos.ForeColor = Color.Gainsboro;
            bEquipos.Location = new Point(12, 57);
            bEquipos.Name = "bEquipos";
            bEquipos.Padding = new Padding(11, 0, 0, 0);
            bEquipos.Size = new Size(180, 40);
            bEquipos.TabIndex = 1;
            bEquipos.Text = "Equipos";
            bEquipos.TextAlign = ContentAlignment.MiddleLeft;
            bEquipos.UseVisualStyleBackColor = false;
            bEquipos.Click += bEquipos_Click;
            // 
            // bPresupuestos
            // 
            bPresupuestos.BackColor = Color.FromArgb(33, 33, 33);
            bPresupuestos.FlatAppearance.BorderSize = 0;
            bPresupuestos.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 42, 42);
            bPresupuestos.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 42, 42);
            bPresupuestos.FlatStyle = FlatStyle.Flat;
            bPresupuestos.ForeColor = Color.Gainsboro;
            bPresupuestos.Location = new Point(12, 103);
            bPresupuestos.Name = "bPresupuestos";
            bPresupuestos.Padding = new Padding(11, 0, 0, 0);
            bPresupuestos.Size = new Size(180, 40);
            bPresupuestos.TabIndex = 2;
            bPresupuestos.Text = "Presupuestos";
            bPresupuestos.TextAlign = ContentAlignment.MiddleLeft;
            bPresupuestos.UseVisualStyleBackColor = false;
            bPresupuestos.Click += bPresupuestos_Click;
            // 
            // bOrdenes
            // 
            bOrdenes.BackColor = Color.FromArgb(33, 33, 33);
            bOrdenes.FlatAppearance.BorderSize = 0;
            bOrdenes.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 42, 42);
            bOrdenes.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 42, 42);
            bOrdenes.FlatStyle = FlatStyle.Flat;
            bOrdenes.ForeColor = Color.Gainsboro;
            bOrdenes.Location = new Point(12, 149);
            bOrdenes.Name = "bOrdenes";
            bOrdenes.Padding = new Padding(11, 0, 0, 0);
            bOrdenes.Size = new Size(180, 40);
            bOrdenes.TabIndex = 3;
            bOrdenes.Text = "Ordenes";
            bOrdenes.TextAlign = ContentAlignment.MiddleLeft;
            bOrdenes.UseVisualStyleBackColor = false;
            bOrdenes.Click += bOrdenes_Click;
            // 
            // bUsuarios
            // 
            bUsuarios.BackColor = Color.FromArgb(33, 33, 33);
            bUsuarios.FlatAppearance.BorderSize = 0;
            bUsuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 42, 42);
            bUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 42, 42);
            bUsuarios.FlatStyle = FlatStyle.Flat;
            bUsuarios.ForeColor = Color.Gainsboro;
            bUsuarios.Location = new Point(12, 195);
            bUsuarios.Name = "bUsuarios";
            bUsuarios.Padding = new Padding(11, 0, 0, 0);
            bUsuarios.Size = new Size(180, 40);
            bUsuarios.TabIndex = 4;
            bUsuarios.Text = "Usuarios";
            bUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            bUsuarios.UseVisualStyleBackColor = false;
            bUsuarios.Click += bUsuarios_Click;
            // 
            // bTareasTecnico
            // 
            bTareasTecnico.BackColor = Color.FromArgb(33, 33, 33);
            bTareasTecnico.FlatAppearance.BorderSize = 0;
            bTareasTecnico.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 42, 42);
            bTareasTecnico.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 42, 42);
            bTareasTecnico.FlatStyle = FlatStyle.Flat;
            bTareasTecnico.ForeColor = Color.Gainsboro;
            bTareasTecnico.Location = new Point(12, 241);
            bTareasTecnico.Name = "bTareasTecnico";
            bTareasTecnico.Padding = new Padding(11, 0, 0, 0);
            bTareasTecnico.Size = new Size(180, 40);
            bTareasTecnico.TabIndex = 5;
            bTareasTecnico.Text = "Tareas Tecnico";
            bTareasTecnico.TextAlign = ContentAlignment.MiddleLeft;
            bTareasTecnico.UseVisualStyleBackColor = false;
            bTareasTecnico.Click += bTareasTecnico_Click;
            // 
            // bTareasAdmin
            // 
            bTareasAdmin.BackColor = Color.FromArgb(33, 33, 33);
            bTareasAdmin.FlatAppearance.BorderSize = 0;
            bTareasAdmin.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 42, 42);
            bTareasAdmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 42, 42);
            bTareasAdmin.FlatStyle = FlatStyle.Flat;
            bTareasAdmin.ForeColor = Color.Gainsboro;
            bTareasAdmin.Location = new Point(12, 287);
            bTareasAdmin.Name = "bTareasAdmin";
            bTareasAdmin.Padding = new Padding(11, 0, 0, 0);
            bTareasAdmin.Size = new Size(180, 40);
            bTareasAdmin.TabIndex = 6;
            bTareasAdmin.Text = "Tareas Admin";
            bTareasAdmin.TextAlign = ContentAlignment.MiddleLeft;
            bTareasAdmin.UseVisualStyleBackColor = false;
            bTareasAdmin.Click += bTareasAdmin_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lBrand);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 58);
            panel1.TabIndex = 1;
            // 
            // lBrand
            // 
            lBrand.AutoSize = true;
            lBrand.Dock = DockStyle.Fill;
            lBrand.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lBrand.ForeColor = Color.Gainsboro;
            lBrand.Location = new Point(0, 0);
            lBrand.MaximumSize = new Size(200, 0);
            lBrand.Name = "lBrand";
            lBrand.Size = new Size(196, 56);
            lBrand.TabIndex = 0;
            lBrand.Text = "Gestor de Taller de Reparaciones";
            lBrand.Click += lBrand_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tlpRoot);
            Margin = new Padding(1, 2, 1, 2);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            tlpRoot.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            flpMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpRoot;
        private Panel panelMenu;
        private Panel ContentHost;
        private FlowLayoutPanel flpMenu;
        private Button bClientes;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button bEquipos;
        private Button bUsuarios;
        private Button bOrdenes;
        private Button bPresupuestos;
        private Panel panel1;
        private Label lBrand;
        private Button bTareasTecnico;
        private Button bTareasAdmin;
    }
}