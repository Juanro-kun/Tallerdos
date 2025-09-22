using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller_2_Gestor.Domain;
using Taller_2_Gestor.Features.Login;

namespace Taller_2_Gestor.Forms
{
    public partial class LoginForm : BaseForm
    {
        private Role? _selectedRole;
        public Role SelectedRole => _selectedRole!.Value;

        private readonly LoginService _login = new LoginService();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void bDueno_Click(object sender, EventArgs e)
        {
            _selectedRole = Role.Dueno;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void bAdmin_Click(object sender, EventArgs e)
        {
            _selectedRole = Role.Administrador;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void bTecnico_Click(object sender, EventArgs e)
        {
            _selectedRole = Role.Tecnico;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bSesion_Click(object sender, EventArgs e)
        {
            var (ok, error) = _login.Login(tbMail.Text.Trim(), tbContrasena.Text);
            if (!ok) { MessageBox.Show(error, "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
