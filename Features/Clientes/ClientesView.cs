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
using Taller_2_Gestor.Features.Shared;
using Taller_2_Gestor.Features.Usuarios;
using Taller_2_Gestor.Features.Equipos;
using Taller_2_Gestor.Infra;

namespace Taller_2_Gestor.Features.Clientes
{
    public partial class ClientesView : UserControl
    {

        private readonly ClientesService _Csvc;
        private readonly EquiposService _Esvc;
        public ClientesView()
        {
            InitializeComponent();
            var db = new AppDbContext();
            _Csvc = new ClientesService(db);
            _Esvc = new EquiposService(db);


            dgvClientes.AutoGenerateColumns = false;         // o false si querés definirlas a mano
            dgvClientes.DataSource = _Csvc.ListarClientes();
            dgvClientes.ClearSelection();

            dgvEquipos.AutoGenerateColumns = false;
            dgvEquipos.ClearSelection();

        }

        private void dgvClientes_SelectionChanged(object? sender, EventArgs e)//cuando se selecciona una fila del datagridview guarda los datos es una variable temporal u
        {
            if (dgvClientes.CurrentRow == null) return;

            var c = dgvClientes.CurrentRow.DataBoundItem as Cliente;
            if (c == null) return;

            CargarDetalles(c);
            dgvEquipos.DataSource = _Esvc.ListarEquiposPorCliente(c.IdCliente);
        }

        private void CargarDetalles(Cliente c)
        {
            lIdContenido.Text = c.IdCliente.ToString();
            tbMail.Text = c.Mail;
            tbNombre.Text = c.Nombre;
            tbApellido.Text = c.Apellido;
            tbTelefono.Text = c.Telefono.ToString();
            tbDni.Text = c.Dni.ToString();
        }

        private void lContrasena_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // permite solo números y la tecla backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void dgvUsuarios_SelectionChanged(object? sender, EventArgs e)//cuando se selecciona una fila del datagridview guarda los datos es una variable temporal u
        {
            if (dgvClientes.CurrentRow == null) return;

        }

        private void bGuardarNuevo_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNombre.Text))
            { MessageBox.Show("El nombre es obligatorio."); tbNombre.Focus(); return; }

            if (string.IsNullOrWhiteSpace(tbApellido.Text))
            { MessageBox.Show("El apellido es obligatorio."); tbApellido.Focus(); return; }

            if (string.IsNullOrWhiteSpace(tbMail.Text) || !tbMail.Text.Contains("@"))
            { MessageBox.Show("Mail inválido."); tbMail.Focus(); return; }

            if (string.IsNullOrWhiteSpace(tbTelefono.Text))
            { MessageBox.Show("El teléfono es obligatorio."); tbTelefono.Focus(); return; }

            if (string.IsNullOrWhiteSpace(tbDni.Text))
            { MessageBox.Show("El DNI es obligatorio."); tbDni.Focus(); return; }

            var (ok, error, cliente) = _Csvc.Crear(tbNombre.Text, tbApellido.Text, tbMail.Text, int.Parse(tbTelefono.Text), int.Parse(tbDni.Text));

            if (!ok)
            {
                MessageBox.Show("No se pudo crear el cliente. " + error);
                return;
            }

            bNuevoCliente.Visible = true;
            bGuardarNuevo.Visible = false;
            bEditar.Enabled = true;
            bCancelar.Visible = false;
            LimpiarCampos();
            ToggleCampos(false);
            dgvClientes.DataSource = _Csvc.ListarClientes();    
        }

        private void ToggleCampos(bool readOnly)
        {
            tbMail.ReadOnly = !readOnly;
            tbNombre.ReadOnly = !readOnly;
            tbApellido.ReadOnly = !readOnly;
            tbTelefono.ReadOnly = !readOnly;
            tbDni.ReadOnly = !readOnly;
        }

        private void LimpiarCampos()
        {
            lIdContenido.Text = "-";
            tbMail.Text = "";
            tbNombre.Text = "";
            tbApellido.Text = "";
            tbTelefono.Text = "";
            tbDni.Text = "";
        }

        private void bNuevoCliente_Click(object sender, EventArgs e)
        {
            bNuevoCliente.Visible = false;
            bGuardarNuevo.Visible = true;
            bEditar.Enabled = false;
            bCancelar.Visible = true;
            LimpiarCampos();
            ToggleCampos(true);
        }

        private void bEditar_Click_1(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null) return;
            bEditar.Visible = false;
            bGuardarExistente.Visible = true;
            bNuevoCliente.Enabled = false;
            bCancelar.Visible = true;
            ToggleCampos(true);
        }

        private void bGuardarExistente_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNombre.Text))
            { MessageBox.Show("El nombre es obligatorio."); tbNombre.Focus(); return; }

            if (string.IsNullOrWhiteSpace(tbApellido.Text))
            { MessageBox.Show("El apellido es obligatorio."); tbApellido.Focus(); return; }

            if (string.IsNullOrWhiteSpace(tbMail.Text) || !tbMail.Text.Contains("@"))
            { MessageBox.Show("Mail inválido."); tbMail.Focus(); return; }

            if (string.IsNullOrWhiteSpace(tbTelefono.Text))
            { MessageBox.Show("El teléfono es obligatorio."); tbTelefono.Focus(); return; }

            if (string.IsNullOrWhiteSpace(tbDni.Text))
            { MessageBox.Show("El DNI es obligatorio."); tbDni.Focus(); return; }

            var (ok, error, cliente) = _Csvc.Actualizar(tbNombre.Text, tbApellido.Text, tbMail.Text, int.Parse(tbTelefono.Text), int.Parse(tbDni.Text));

            if (!ok)
            {
                MessageBox.Show("No se pudo actualizar el cliente. " + error);
                return;
            }

            bEditar.Visible = true;
            bGuardarExistente.Visible = false;
            bNuevoCliente.Enabled = true;
            bCancelar.Visible = false;
            ToggleCampos(false);

            dgvClientes.DataSource = _Csvc.ListarClientes();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            bNuevoCliente.Visible = true;
            bNuevoCliente.Enabled = true;
            bGuardarNuevo.Visible = false;
            bEditar.Visible = true;
            bEditar.Enabled = true;
            bGuardarExistente.Visible = false;
            bCancelar.Visible = false;
            var c = dgvClientes.CurrentRow.DataBoundItem as Cliente;
            if (c == null) return;

            CargarDetalles(c);
        }
    }
}
