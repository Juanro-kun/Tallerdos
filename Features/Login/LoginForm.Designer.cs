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
            tbMail = new TextBox();
            tbContrasena = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            bSesion = new Button();
            SuspendLayout();
            // 
            // tbMail
            // 
            tbMail.BackColor = Color.FromArgb(51, 77, 53);
            tbMail.BorderStyle = BorderStyle.FixedSingle;
            tbMail.Location = new Point(317, 158);
            tbMail.Name = "tbMail";
            tbMail.Size = new Size(171, 34);
            tbMail.TabIndex = 3;
            // 
            // tbContrasena
            // 
            tbContrasena.BackColor = Color.FromArgb(51, 77, 53);
            tbContrasena.BorderStyle = BorderStyle.FixedSingle;
            tbContrasena.Location = new Point(317, 227);
            tbContrasena.Name = "tbContrasena";
            tbContrasena.Size = new Size(171, 34);
            tbContrasena.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(263, 63);
            label1.Name = "label1";
            label1.Size = new Size(290, 45);
            label1.TabIndex = 5;
            label1.Text = "INICIO DE SESION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(261, 158);
            label2.Name = "label2";
            label2.Size = new Size(50, 28);
            label2.TabIndex = 6;
            label2.Text = "Mail";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 230);
            label3.Name = "label3";
            label3.Size = new Size(110, 28);
            label3.TabIndex = 7;
            label3.Text = "Contraseña";
            // 
            // bSesion
            // 
            bSesion.Location = new Point(333, 307);
            bSesion.Name = "bSesion";
            bSesion.Size = new Size(134, 37);
            bSesion.TabIndex = 8;
            bSesion.Text = "Iniciar Sesion";
            bSesion.UseVisualStyleBackColor = true;
            bSesion.Click += bSesion_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bSesion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbContrasena);
            Controls.Add(tbMail);
            Margin = new Padding(1, 2, 1, 2);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbMail;
        private TextBox tbContrasena;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button bSesion;
    }
}