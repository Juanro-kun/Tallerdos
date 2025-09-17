using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller_2_Gestor.Features.Usuarios;
using Taller_2_Gestor.Infra;
using Taller_2_Gestor.Domain.Entities;  

namespace Taller_2_Gestor.Views
{
    public partial class UsuariosView : UserControl
    {
        private readonly UsuariosService _svc;

        public UsuariosView()
        {
            InitializeComponent();

            var db = new AppDbContext();           // usa OnConfiguring con tu connection string
            _svc = new UsuariosService(db);
        }

        private void UsuariosView_Load(object sender, EventArgs e)
        {
            var lista = _svc.ListarUsuarios();
            dgvUsuarios.DataSource = lista;
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)//cuando se selecciona una fila del datagridview guarda los datos es una variable temporal u
        {
            if (dgvUsuarios.CurrentRow == null) return;

            var u = dgvUsuarios.CurrentRow.DataBoundItem as Usuario;
            if (u == null) return;

            CargarDetalles(u);
        }

        private void CargarDetalles(Usuario u)
        {
            lIdContenido.Text = u.idUsuario.ToString();
            tbMail.Text = u.mail;
            tbNombre.Text = u.Nombre;
            tbApellido.Text = u.Apellido;

            // Si abajo mostrás solo texto:
            cbRol.Text = u.RolNombre;

            // Si tenés un ComboBox de roles para editar:
            // cboRol.SelectedValue = u.Rol;     // (rol id)
            // cboRol.Text = u.RolNombre;        // (para mostrar nombre si corresponde)

            chbActivo.Checked = u.Active;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
