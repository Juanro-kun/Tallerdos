namespace Taller_2_Gestor.Forms
{
    partial class LoginForm : BaseForm
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
            bDueno = new Button();
            bAdmin = new Button();
            bTecnico = new Button();
            tbMail = new TextBox();
            tbContrasena = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            bSesion = new Button();
            SuspendLayout();
            // 
            // bDueno
            // 
            bDueno.BackColor = Color.FromArgb(33, 33, 33);
            bDueno.FlatAppearance.BorderSize = 0;
            bDueno.FlatStyle = FlatStyle.Flat;
            bDueno.ForeColor = SystemColors.ScrollBar;
            bDueno.Location = new Point(2, 138);
            bDueno.Margin = new Padding(2, 2, 2, 2);
            bDueno.Name = "bDueno";
            bDueno.Size = new Size(88, 35);
            bDueno.TabIndex = 0;
            bDueno.Text = "Dueño";
            bDueno.UseVisualStyleBackColor = false;
            bDueno.Visible = false;
            bDueno.Click += bDueno_Click;
            // 
            // bAdmin
            // 
            bAdmin.BackColor = Color.FromArgb(33, 33, 33);
            bAdmin.FlatAppearance.BorderSize = 0;
            bAdmin.FlatStyle = FlatStyle.Flat;
            bAdmin.ForeColor = SystemColors.ScrollBar;
            bAdmin.Location = new Point(2, 178);
            bAdmin.Margin = new Padding(2, 2, 2, 2);
            bAdmin.Name = "bAdmin";
            bAdmin.Size = new Size(88, 35);
            bAdmin.TabIndex = 1;
            bAdmin.Text = "Administrador";
            bAdmin.UseVisualStyleBackColor = false;
            bAdmin.Visible = false;
            bAdmin.Click += bAdmin_Click;
            // 
            // bTecnico
            // 
            bTecnico.BackColor = Color.FromArgb(33, 33, 33);
            bTecnico.FlatAppearance.BorderSize = 0;
            bTecnico.FlatStyle = FlatStyle.Flat;
            bTecnico.ForeColor = SystemColors.ScrollBar;
            bTecnico.Location = new Point(2, 217);
            bTecnico.Margin = new Padding(2, 2, 2, 2);
            bTecnico.Name = "bTecnico";
            bTecnico.Size = new Size(88, 35);
            bTecnico.TabIndex = 2;
            bTecnico.Text = "Tecnico";
            bTecnico.UseVisualStyleBackColor = false;
            bTecnico.Visible = false;
            bTecnico.Click += bTecnico_Click;
            // 
            // tbMail
            // 
            tbMail.BackColor = Color.FromArgb(51, 77, 53);
            tbMail.BorderStyle = BorderStyle.FixedSingle;
            tbMail.Location = new Point(222, 95);
            tbMail.Margin = new Padding(2, 2, 2, 2);
            tbMail.Name = "tbMail";
            tbMail.Size = new Size(120, 25);
            tbMail.TabIndex = 3;
            // 
            // tbContrasena
            // 
            tbContrasena.BackColor = Color.FromArgb(51, 77, 53);
            tbContrasena.BorderStyle = BorderStyle.FixedSingle;
            tbContrasena.Location = new Point(222, 136);
            tbContrasena.Margin = new Padding(2, 2, 2, 2);
            tbContrasena.Name = "tbContrasena";
            tbContrasena.Size = new Size(120, 25);
            tbContrasena.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(184, 38);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(199, 30);
            label1.TabIndex = 5;
            label1.Text = "INICIO DE SESION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 95);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(35, 19);
            label2.TabIndex = 6;
            label2.Text = "Mail";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(141, 138);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 19);
            label3.TabIndex = 7;
            label3.Text = "Contraseña";
            // 
            // bSesion
            // 
            bSesion.Location = new Point(233, 184);
            bSesion.Margin = new Padding(2, 2, 2, 2);
            bSesion.Name = "bSesion";
            bSesion.Size = new Size(94, 22);
            bSesion.TabIndex = 8;
            bSesion.Text = "Iniciar Sesion";
            bSesion.UseVisualStyleBackColor = true;
            bSesion.Click += bSesion_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(bSesion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbContrasena);
            Controls.Add(tbMail);
            Controls.Add(bTecnico);
            Controls.Add(bAdmin);
            Controls.Add(bDueno);
            Margin = new Padding(1, 1, 1, 1);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bDueno;
        private Button bAdmin;
        private Button bTecnico;
        private TextBox tbMail;
        private TextBox tbContrasena;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button bSesion;
    }
}