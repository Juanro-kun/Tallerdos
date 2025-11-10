using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Taller_2_Gestor.Domain.Entities;
using Taller_2_Gestor.Features.Clientes;
using Taller_2_Gestor.Features.Presupuestos;
using Taller_2_Gestor.Features.Shared;
using Taller_2_Gestor.Infra;

namespace Taller_2_Gestor.Features.Equipos
{
    public partial class EquiposView : UserControl
    {
        private int _idCliente;
        private readonly EquiposService _Esvc;
        private readonly PresupuestosService _Isvc;
        bool _ready = false;
        public EquiposView()
        {
            var db = new AppDbContext();
            _Esvc = new EquiposService(db);
            _Isvc = new PresupuestosService(db);
            InitializeComponent();

            dgvEquipos.AutoGenerateColumns = false;
            dgvEquipos.DataSource = _Esvc.ListarEquipos();

            dgvItems.AutoGenerateColumns = false;
            dgvItems.ClearSelection();

            // Estado inicial
            bNuevoEquipo.Visible = true;
            bGuardarNuevo.Visible = false;
            CargarCombobox();
        }

        #region Metodos Asociados Preparacion de la vista por Eventos
        public void PrepararParaCliente(int idCliente)
        {
            _idCliente = idCliente;
            LimpiarCampos();
            dgvEquipos.ClearSelection();
            bNuevoEquipo_Click(null, null);
            tbIdCliente.Text = idCliente.ToString();
            dgvEquipos.CurrentCell = null;
        }

        public void PrepararParaVerEquipo(int idEquipo)
        {
            var eq = _Esvc.GetById(idEquipo);
            CargarDetalles(eq);
            dgvItems.DataSource = _Isvc.ItemsPorEquipo(eq.IdEquipo);
            SeleccionarFilaPorIDdgvEquipos(idEquipo);

        }
        #endregion

        #region Metodos auxiliares

        private void LimpiarCampos()
        {
            tbIdCliente.Text = "";
            tbDescripcion.Text = "";
            lIdContenido.Text = "";
            cbEstado.SelectedIndex = -1;
            cbMarca.SelectedIndex = -1;
            cbTipo.SelectedIndex = -1;
        }

        private void CargarDetalles(Equipo? eq)
        {
            if (eq == null) return;
            tbDescripcion.Text = eq.Nombre;
            lIdContenido.Text = eq.IdEquipo.ToString();
            tbIdCliente.Text = eq.IdCliente.ToString();
            cbEstado.SelectedValue = eq.IdEstado;
            cbMarca.SelectedValue = eq.IdMarca;
            cbTipo.SelectedValue = eq.IdTipo;
        }

        private void ToggleCampos(bool active)
        {
            tbIdCliente.ReadOnly = !active;
            tbDescripcion.ReadOnly = !active;
            cbEstado.Enabled = active;
            cbMarca.Enabled = active;
            cbTipo.Enabled = active;
        }

        private void CargarCombobox()
        {
            cbEstado.DataSource = _Esvc.ListarEstados();
            cbEstado.DisplayMember = nameof(EstadoEquipo.Nombre);
            cbEstado.ValueMember = nameof(EstadoEquipo.IdEstado);
            cbMarca.DataSource = _Esvc.ListarMarcas();
            cbMarca.DisplayMember = nameof(Marca.Nombre);
            cbMarca.ValueMember = nameof(Marca.IdMarca);
            cbTipo.DataSource = _Esvc.ListarTipos();
            cbTipo.DisplayMember = nameof(TipoEquipo.Nombre);
            cbTipo.ValueMember = nameof(TipoEquipo.IdTipo);
        }

        private void EquiposView_Load(object sender, EventArgs e)
        {

        }
        #endregion      //TERMINA LA SECCION DE METODOS AUXILIARES

        #region Metodos asociados a botones
        private void bEditar_Click(object sender, EventArgs e)
        {
            if (dgvEquipos.CurrentRow == null) return;
            bNuevoEquipo.Enabled = false;
            bEditar.Visible = false;
            bGuardarExistente.Visible = true;
            bCancelar.Visible = true;
            ToggleCampos(true);
        }

        private void bGuardarExistente_Click(object sender, EventArgs e)
        {
            var (ok, error, equipo) = _Esvc.Actualizar(
                int.Parse(lIdContenido.Text),
                tbDescripcion.Text,
                int.Parse(tbIdCliente.Text),
                (int)cbMarca.SelectedValue,
                (int)cbTipo.SelectedValue,
                (int)cbEstado.SelectedValue
                );
            if (!ok)
            {
                MessageBox.Show("Error al guardar: " + error);
                return;
            }
            bNuevoEquipo.Enabled = true;
            bEditar.Visible = true;
            bGuardarExistente.Visible = false;
            ToggleCampos(false);
            dgvEquipos.DataSource = _Esvc.ListarEquipos();
        }

        private void bNuevoEquipo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            dgvEquipos.ClearSelection();
            // Cambiar visibilidad botones
            bNuevoEquipo.Visible = false;
            bGuardarNuevo.Visible = true;
            bEditar.Enabled = false;
            bCancelar.Visible = true;
            dgvEquipos.Enabled = false;
            dgvItems.Enabled = false;
            ToggleCampos(true);
        }

        private void bGuardarNuevo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbIdCliente.Text))
            {
                { MessageBox.Show("El id de cliente es obligatorio."); tbIdCliente.Focus(); return; }
            }
            if (string.IsNullOrWhiteSpace(tbDescripcion.Text))
            {
                { MessageBox.Show("La descripcion es obligatoria."); tbDescripcion.Focus(); return; }
            }
            if (cbMarca.SelectedItem == null && cbMarca.SelectedValue == null)
            {
                { MessageBox.Show("Selecciona una marca."); cbMarca.Focus(); return; }
            }
            if (cbTipo.SelectedItem == null && cbTipo.SelectedValue == null)
            {
                { MessageBox.Show("Selecciona un tipo."); cbTipo.Focus(); return; }
            }
            if (cbEstado.SelectedItem == null && cbEstado.SelectedValue == null)
            {
                cbEstado.SelectedValue = 1;
            }


            var (ok, error, equipo) = _Esvc.Crear(
                tbDescripcion.Text,
                int.Parse(tbIdCliente.Text),
                (int)cbMarca.SelectedValue,
                (int)cbTipo.SelectedValue,
                (int)cbEstado.SelectedValue
                );

            if (!ok)
            {
                MessageBox.Show("Error al guardar: " + error);
                return;
            }
            ToggleCampos(false);
            dgvEquipos.DataSource = _Esvc.ListarEquipos();
            bNuevoEquipo.Visible = true;
            bGuardarNuevo.Visible = false;
            bCancelar.Visible = false;
            bEditar.Enabled = true;
            dgvEquipos.Enabled = true;
            dgvItems.Enabled = true;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            bNuevoEquipo.Visible = true;
            bNuevoEquipo.Enabled = true;
            bGuardarNuevo.Visible = false;
            bEditar.Visible = true;
            bEditar.Enabled = true;
            bGuardarExistente.Visible = false;
            bCancelar.Visible = false;
            Equipo? eq;
            if (dgvEquipos.SelectedRows == null)
            { eq = null; }
            else { eq = dgvEquipos.CurrentRow?.DataBoundItem as Equipo; }
            CargarDetalles(eq);
            ToggleCampos(false);
            dgvEquipos.Enabled = true;
            dgvItems.Enabled = true;
        }
        #endregion

        private void SeleccionarFilaPorIDdgvEquipos(int idUsuarioBuscado)
        {
            // 1. Deseleccionar todas las filas existentes (opcional pero recomendado)
            dgvEquipos.ClearSelection();

            // 2. Definir el nombre de la columna que contiene el ID
            string nombreColumnaID = "colId";

            // 3. Iterar sobre todas las filas del DataGridView
            foreach (DataGridViewRow row in dgvEquipos.Rows)
            {
                // 4. Obtener el valor de la celda en la columna de ID para la fila actual
                // Convertimos a string y luego intentamos parsear a int
                if (row.Cells[nombreColumnaID].Value != null)
                {
                    if (int.TryParse(row.Cells[nombreColumnaID].Value.ToString(), out int idActual))
                    {
                        // 5. Comparar el ID de la fila con el ID que estamos buscando
                        if (idActual == idUsuarioBuscado)
                        {
                            // 6. Seleccionar la fila
                            row.Selected = true;

                            // Opcional: Desplazar la vista del DGV a la fila seleccionada
                            object dataItem = row.DataBoundItem;
                            //Carga los datos del equipo seleccionado en los campos correspondientes
                            Equipo equipoSeleccionado = (Equipo)dataItem;
                            CargarDetalles(equipoSeleccionado);
                            // Salir del bucle una vez que se encuentra la fila
                            return;
                        }
                    }
                }
            }

            // Opcional: Mensaje si no se encuentra la fila
            MessageBox.Show($"El usuario con ID {idUsuarioBuscado} no fue encontrado.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvEquipos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEquipos.CurrentRow == null)
            {
                LimpiarCampos();
                dgvItems.ClearSelection();
            }
            var eq = dgvEquipos.CurrentRow.DataBoundItem as Equipo;

            CargarDetalles(eq);
            dgvItems.DataSource = _Isvc.ItemsPorEquipo(eq.IdEquipo);
        }


        #region Metodos sin codigo
        private void roundedPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvEquipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void bEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
            "¿Está seguro de que desea eliminar este equipo? Esta acción no se puede deshacer.", // Mensaje
            "Confirmar Eliminación de Equipo", // Título de la ventana
            MessageBoxButtons.YesNo, // Botones Sí y No
            MessageBoxIcon.Warning // Ícono de advertencia
            );
            if ( resultado == DialogResult.Yes)
            {
                bool eliminado = _Esvc.EliminarEquipo(int.Parse(lIdContenido.Text));
                if (eliminado)
                {
                    MessageBox.Show("El equipo ha sido eliminado exitosamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvEquipos.DataSource = _Esvc.ListarEquipos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el equipo. Por favor, intente nuevamente.", "Error al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
