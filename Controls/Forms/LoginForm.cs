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

namespace Taller_2_Gestor.Forms
{
    public partial class LoginForm : BaseForm
    {
        private Role? _selectedRole;
        public Role SelectedRole => _selectedRole!.Value;

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
    }
}
