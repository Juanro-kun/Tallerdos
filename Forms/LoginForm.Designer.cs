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
            SuspendLayout();
            // 
            // bDueno
            // 
            bDueno.BackColor = Color.FromArgb(33, 33, 33);
            bDueno.FlatAppearance.BorderSize = 0;
            bDueno.FlatStyle = FlatStyle.Flat;
            bDueno.ForeColor = SystemColors.ScrollBar;
            bDueno.Location = new Point(194, 229);
            bDueno.Name = "bDueno";
            bDueno.Size = new Size(126, 59);
            bDueno.TabIndex = 0;
            bDueno.Text = "Dueño";
            bDueno.UseVisualStyleBackColor = false;
            bDueno.Click += bDueno_Click;
            // 
            // bAdmin
            // 
            bAdmin.BackColor = Color.FromArgb(33, 33, 33);
            bAdmin.FlatAppearance.BorderSize = 0;
            bAdmin.FlatStyle = FlatStyle.Flat;
            bAdmin.ForeColor = SystemColors.ScrollBar;
            bAdmin.Location = new Point(348, 229);
            bAdmin.Name = "bAdmin";
            bAdmin.Size = new Size(126, 59);
            bAdmin.TabIndex = 1;
            bAdmin.Text = "Administrador";
            bAdmin.UseVisualStyleBackColor = false;
            bAdmin.Click += bAdmin_Click;
            // 
            // bTecnico
            // 
            bTecnico.BackColor = Color.FromArgb(33, 33, 33);
            bTecnico.FlatAppearance.BorderSize = 0;
            bTecnico.FlatStyle = FlatStyle.Flat;
            bTecnico.ForeColor = SystemColors.ScrollBar;
            bTecnico.Location = new Point(494, 229);
            bTecnico.Name = "bTecnico";
            bTecnico.Size = new Size(126, 59);
            bTecnico.TabIndex = 2;
            bTecnico.Text = "Tecnico";
            bTecnico.UseVisualStyleBackColor = false;
            bTecnico.Click += bTecnico_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bTecnico);
            Controls.Add(bAdmin);
            Controls.Add(bDueno);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button bDueno;
        private Button bAdmin;
        private Button bTecnico;
    }
}