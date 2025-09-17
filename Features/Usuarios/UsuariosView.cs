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

            dgvUsuarios.SelectionChanged += dgvUsuarios_SelectionChanged;
            CargarRoles();
        }

        private void UsuariosView_Load(object sender, EventArgs e)
        {
            var lista = _svc.ListarUsuarios();
            dgvUsuarios.DataSource = lista;
        }

        private void dgvUsuarios_SelectionChanged(object? sender, EventArgs e)//cuando se selecciona una fila del datagridview guarda los datos es una variable temporal u
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

            cbRol.SelectedValue = u.Rol;     // rol id
            cbRol.Text = u.RolNombre;        // Nombre del rol traido desde ListarUsuarios()

            chbActivo.Checked = u.Active;
        }

        private void CargarRoles()
        {
            var roles = _svc.ListarRoles();
            cbRol.DataSource = roles;
            cbRol.DisplayMember = nameof(Rol.Nombre);
            cbRol.ValueMember = nameof(Rol.idRol);

            cbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRol.SelectedIndex = -1;
        }

        private void LimpiarCampos()
        {
            lIdContenido.Text = "";                  // suele quedar solo-lectura en 'Nuevo'
            tbMail.Text = "";
            tbNombre.Text = "";
            tbApellido.Text = "";
            cbRol.SelectedIndex = -1;
            chbActivo.Checked = true;
            tbContrasena.Text = "";
            tbCContrasena.Text = "";
        }

        private void ToggleCampos(bool enabled)
        {
            tbMail.ReadOnly = !enabled;
            tbNombre.ReadOnly = !enabled;
            tbApellido.ReadOnly = !enabled;
            cbRol.Enabled = enabled;
            chbActivo.Enabled = enabled;
        }

        private void ToggleCamposContrasena(bool enabled)
        {
            lContrasena.Visible = enabled;
            lCContrasena.Visible = enabled;
            pContrasena.Visible = enabled;
            pCContrasena.Visible = enabled;
            tbContrasena.Visible = enabled;
            tbCContrasena.Visible = enabled;
            tbContrasena.ReadOnly = !enabled;
            tbCContrasena.ReadOnly = !enabled;
        }

        private void bNuevoUsuario_Click(object sender, EventArgs e)
        {
            bNuevoUsuario.Visible = false;
            bGuardarNuevo.Visible = true;
            bEditar.Enabled = false;
            bEliminar.Enabled = false;
            dgvUsuarios.Enabled = false;
            bCancelar.Visible = true;
            bCambiarContrasena.Enabled = false;

            LimpiarCampos();
            ToggleCampos(true);
            ToggleCamposContrasena(true);
        }

        private void bGuardarNuevo_Click(object sender, EventArgs e)
        {
            // Aquí iría la lógica para guardar el nuevo usuario
            // Por ahora, solo restablecemos la vista
            bNuevoUsuario.Visible = true;
            bGuardarNuevo.Visible = false;
            bEditar.Enabled = true;
            bEliminar.Enabled = true;
            dgvUsuarios.Enabled = true;
            bCancelar.Visible = false;
            bCambiarContrasena.Enabled = true;

            ToggleCampos(false);
            ToggleCamposContrasena(false);
            LimpiarCampos();

            dgvUsuarios.CurrentCell = null; // deselecciona la fila actual
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            bNuevoUsuario.Enabled = false;
            bEliminar.Enabled = false;
            bEditar.Visible = false;
            bGuardarExistente.Visible = true;
            dgvUsuarios.Enabled = false;
            bCancelar.Visible = true;
            bCambiarContrasena.Enabled = false;

            ToggleCampos(true);
        }

        private void bGuardarExistente_Click(object sender, EventArgs e)
        {
            bNuevoUsuario.Enabled = true;
            bEliminar.Enabled = true;
            bEditar.Visible = true;
            bGuardarExistente.Visible = false;
            dgvUsuarios.Enabled = true;
            bCancelar.Visible = false;
            bCambiarContrasena.Enabled = true;

            ToggleCamposContrasena(false);
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

        private void label2_Click_3(object sender, EventArgs e)
        {

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {

        }

        private void bCambiarContrasena_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentCell == null) return;
            dgvUsuarios.Enabled = false;
            bNuevoUsuario.Enabled = false;
            bEditar.Enabled = false;
            bEliminar.Enabled = false;
            bCambiarContrasena.Visible = false;
            bGuardarContrasena.Visible = true;
            bCancelar.Visible = true;

            ToggleCamposContrasena(true);
        }

        private void bGuardarContrasena_Click(object sender, EventArgs e)
        {
            dgvUsuarios.Enabled = true;
            bNuevoUsuario.Enabled = true;
            bEditar.Enabled = true;
            bEliminar.Enabled = true;
            bCambiarContrasena.Visible = true;
            bGuardarContrasena.Visible = false;
            bCancelar.Visible = false;

            ToggleCamposContrasena(false);
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            dgvUsuarios.Enabled = true;
            bNuevoUsuario.Visible = true;
            bNuevoUsuario.Enabled = true;
            bGuardarNuevo.Visible = false;
            bEditar.Visible = true;
            bEditar.Enabled = true;
            bGuardarExistente.Visible = false;
            bCambiarContrasena.Visible = true;
            bCambiarContrasena.Enabled = true;
            bGuardarContrasena.Visible = false;
            bCancelar.Visible = false;
        }

    }
}
