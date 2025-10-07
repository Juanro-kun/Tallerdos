using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller_2_Gestor.Domain.Entities;  
using Taller_2_Gestor.Features.Usuarios;
using Taller_2_Gestor.Infra;

namespace Taller_2_Gestor.Views
{
    public partial class UsuariosView : UserControl
    {
        private readonly UsuariosService _svc;
        private const string Placeholder = "Ingrese un dato del usuario para buscar";
        private readonly Color PlaceholderColor = Color.Gray;
        private readonly Color TextColor = Color.White;

        public UsuariosView()
        {
            InitializeComponent();

            var db = new AppDbContext();           // usa OnConfiguring con tu connection string
            _svc = new UsuariosService(db);

            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.SelectionChanged += dgvUsuarios_SelectionChanged;
            CargarRoles();

            cbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;

            cbFiltro.DisplayMember = "Text";
            cbFiltro.ValueMember = "Value";
            cbFiltro.DataSource = new[]
            {
                new { Text = "Todos", Value = (bool?)null},
                new { Text = "Activo",   Value = (bool?)true  },
                new { Text = "Inactivo", Value = (bool?)false }
            };

            // por defecto: Activo
            cbFiltro.SelectedValue = true;

            cbFiltro.SelectedIndexChanged += cbFiltro_SelectedIndexChanged;
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecargarGridPorFiltroDeActivos();
            LimpiarCampos();
            if (dgvUsuarios.CurrentRow == null) return;
            var u = dgvUsuarios.CurrentRow.DataBoundItem as Usuario;


            CargarDetalles(u);
        }

        private void RecargarGridPorFiltroDeActivos()
        {
            bool? filtro = cbFiltro.SelectedValue as bool?;
            var lista = filtro.HasValue ? _svc.ListarUsuarios(filtro.Value)
                                        : _svc.ListarUsuarios(); // todos
            dgvUsuarios.DataSource = lista;
        }

        private void UsuariosView_Load(object sender, EventArgs e)
        {
            var lista = _svc.ListarUsuarios(true);
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
            lIdContenido.Text = u.IdUsuario.ToString();
            tbMail.Text = u.Mail;
            tbNombre.Text = u.Nombre;
            tbApellido.Text = u.Apellido;

            cbRol.SelectedValue = u.IdRol;     // rol id
            cbRol.Text = u.IdRolNavigation.NombreRol;        // Nombre del rol traido desde ListarUsuarios()

            chbActivo.Checked = u.Active;
        }

        private void CargarRoles()
        {
            var roles = _svc.ListarRoles();
            cbRol.DataSource = roles;
            cbRol.DisplayMember = nameof(Rol.NombreRol);
            cbRol.ValueMember = nameof(Rol.IdRol);

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
            if (string.IsNullOrWhiteSpace(tbNombre.Text))
            { MessageBox.Show("El nombre es obligatorio."); tbNombre.Focus(); return; }

            if (string.IsNullOrWhiteSpace(tbApellido.Text))
            { MessageBox.Show("El apellido es obligatorio."); tbApellido.Focus(); return; }

            if (string.IsNullOrWhiteSpace(tbMail.Text) || !tbMail.Text.Contains("@"))
            { MessageBox.Show("Mail inválido."); tbMail.Focus(); return; }

            if (cbRol.SelectedItem == null && cbRol.SelectedValue == null)
            { MessageBox.Show("Seleccioná un rol."); cbRol.DroppedDown = true; return; }

            if (string.IsNullOrWhiteSpace(tbContrasena.Text))
            { MessageBox.Show("La contraseña es obligatoria."); tbContrasena.Focus(); return; }

            if (tbContrasena.Text != tbCContrasena.Text)
            { MessageBox.Show("Las contraseñas no coinciden."); tbCContrasena.Focus(); return; }

            var idRol = Convert.ToByte(cbRol.SelectedValue ?? 0);

            var (ok, error, usuario) = _svc.Crear(
            tbNombre.Text, tbApellido.Text, tbMail.Text,
            tbContrasena.Text, idRol, chbActivo.Checked);

            if (!ok)
            {
                MessageBox.Show(error);
                return;
            }

            RecargarGridPorFiltroDeActivos();
            dgvUsuarios.ClearSelection();
            dgvUsuarios.CurrentCell = null;


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
            MessageBox.Show($"Usuario #{usuario!.IdUsuario} creado.");
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentCell == null) return;
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
            var id = int.Parse(lIdContenido.Text);
            var nombre = tbNombre.Text.Trim();
            var apellido = tbApellido.Text.Trim();
            var mail = tbMail.Text.Trim();
            var rol = (byte)(cbRol.SelectedValue ?? 0);
            var activo = chbActivo.Checked;

            if (string.IsNullOrWhiteSpace(nombre)) { MessageBox.Show("Nombre vacío."); return; }
            if (string.IsNullOrWhiteSpace(apellido)) { MessageBox.Show("Apellido vacío."); return; }
            if (string.IsNullOrWhiteSpace(mail)) { MessageBox.Show("Mail vacío."); return; }
            if (rol == 0) { MessageBox.Show("Seleccioná un rol."); return; }

            var res = _svc.Actualizar(id, nombre, apellido, mail, rol, activo);
            if (!res.ok) { MessageBox.Show(res.error ?? "Error al actualizar."); return; }

            RecargarGridPorFiltroDeActivos();

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
            ToggleCamposContrasena(false);
            ToggleCampos(false);
            var u = dgvUsuarios.CurrentRow.DataBoundItem as Usuario;
            if (u == null) return;
            tbCContrasena.Text = "";
            tbContrasena.Text = "";

            CargarDetalles(u);
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null) return;
            var u = dgvUsuarios.CurrentRow.DataBoundItem as Usuario;
            var (ok, error) = _svc.SetActivo(u.IdUsuario, false);
            if (!ok)
            {
                MessageBox.Show(error ?? "Error desconocido al desactivar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RecargarGridPorFiltroDeActivos();
            dgvUsuarios.ClearSelection();
            LimpiarCampos();
        }

        private void SetPlaceholder()
        {
            tbBuscar.Text = Placeholder;
            tbBuscar.ForeColor = PlaceholderColor;
            bClearSearch.Visible = false;
            bSearch.Visible = false;
        }

        private void TbBuscar_TextChanged(object? sender, EventArgs e)
        {
            // mostrar X solo si hay texto real (no placeholder)
            bClearSearch.Visible = !string.IsNullOrWhiteSpace(tbBuscar.Text) && tbBuscar.Text != Placeholder;
            bSearch.Visible = !string.IsNullOrWhiteSpace(tbBuscar.Text) && tbBuscar.Text != Placeholder;
        }

        private void bClearSearch_Click(object sender, EventArgs e)
        {
            tbBuscar.Text = "";
            // restaurar placeholder explícitamente
            if (!tbBuscar.Focused) SetPlaceholder();
            tbBuscar.Focus();
            RecargarGridPorFiltroDeActivos();
        }

        private void TbBuscar_Enter(object? sender, EventArgs e)
        {
            if (tbBuscar.Text == Placeholder)
            {
                tbBuscar.Text = "";
                tbBuscar.ForeColor = TextColor;
            }
        }
        private void TbBuscar_Leave(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbBuscar.Text))
                SetPlaceholder();
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            var u = _svc.BuscarPorId(int.Parse(tbBuscar.Text));  // <-- devuelve Usuario? con Include del Rol
            var lista = (u != null) ? new List<Usuario> { u } : new List<Usuario>();
            dgvUsuarios.DataSource = lista;
        }

        private void tbBuscarSoloEnteros_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // permitir control keys (backspace, etc.)
            if (char.IsControl(e.KeyChar)) return;

            // permitir dígitos
            if (char.IsDigit(e.KeyChar)) return;

            // bloquear todo lo demás
            e.Handled = true;
        }
    }
}
