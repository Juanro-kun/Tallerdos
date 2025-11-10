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
using Taller_2_Gestor.Domain.Entities;
using Taller_2_Gestor.Features.Centro_de_Tareas_Tecnico;
using Taller_2_Gestor.Infra;
using static System.Collections.Specialized.BitVector32;

namespace Taller_2_Gestor.Features.Equipos
{
    public partial class GenerarPresupuestoForm : Form
    {
        private readonly TareasTecnicoService _Tsvc;
        public GenerarPresupuestoForm()
        {
            var db = new AppDbContext();
            _Tsvc = new TareasTecnicoService(db);
            InitializeComponent();
            CargarComboboxServicios();
        }

        private void CargarComboboxServicios()
        {
            cbServicio.DataSource = _Tsvc.ListarServicios();
            cbServicio.DisplayMember = "NombreServicio";
            cbServicio.ValueMember = "IdServicio";
        }

        public void CargarDatosEquipo(Equipo? eq)
        {
            if (eq == null) return;
            tbDescripcion.Text = eq.Nombre;
            lIdContenido.Text = eq.IdEquipo.ToString();
            tbIdCliente.Text = eq.IdCliente.ToString();
            tbMarca.Text = eq.NombreMarca;
            tbTipo.Text = eq.NombreTipo;
            tbEstado.Text = eq.NombreEstado;
        }

        private void bAgregarItem_Click(object sender, EventArgs e)
        {
            if (cbServicio.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un servicio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombreServicio = cbServicio.GetItemText(cbServicio.SelectedItem);
            int idServicio = (int)cbServicio.SelectedValue;
            bool esNecesario = chbNecesario.Checked;
            float precio = ((Servicio)cbServicio.SelectedItem).Precio;

            dgvServicios.Rows.Add(nombreServicio, idServicio,precio, esNecesario, "Eliminar");
            cbServicio.SelectedIndex = -1; // Deseleccionar
            chbNecesario.Checked = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvServicios.Columns["colEliminar"].Index && e.RowIndex >= 0)
            {
                // Preguntar al usuario antes de eliminar (opcional)
                DialogResult result = MessageBox.Show(
                    "¿Estás seguro de que quieres eliminar este item?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    // **Eliminar la fila seleccionada**
                    dgvServicios.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void bGenerarPresupuesto_Click(object sender, EventArgs e)
        {
            // 1. Obtener datos de la Sesión/Formulario
            // Asumiendo que obtienes el ID del técnico de alguna clase de sesión
            int idTecnico = UserSession.Current.Id;

            // Obtener el ID del equipo. Convertimos a entero.
            if (!int.TryParse(lIdContenido.Text, out int idEquipo))
            {
                MessageBox.Show("El ID del Equipo no es válido.", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dgvServicios.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un servicio para generar el presupuesto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            

            int idPresupuesto = _Tsvc.CrearPresupuesto(idEquipo, idTecnico);

            int nroFila = 0;

            foreach (DataGridViewRow row in dgvServicios.Rows)
            {
                nroFila++; // Incrementar el número de fila (1, 2, 3...)

                try
                {
                    // Obtener los valores de las celdas
                    int idServicio = Convert.ToInt32(row.Cells["colIdServicio"].Value);
                    double precio = Convert.ToDouble(row.Cells["colPrecio"].Value);
                    bool necesario = Convert.ToBoolean(row.Cells["colNecesario"].Value);


                    // LLAMADA A MÉTODO DE ACCESO A DATOS (BD)
                    _Tsvc.CrearItemPresupuesto(
                        nroFila,
                        idPresupuesto,
                        precio,
                        idServicio,
                        necesario
                    );
                }
                catch (Exception ex)
                {
                    // Manejo de error si falla la inserción de algún item
                    MessageBox.Show($"Error al crear el Item N° {nroFila}: {ex.Message}. Se cancelará la operación.", "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Opcional: Podrías querer borrar el Presupuesto y los Items ya creados (Rollback)
                    // DataAccess.EliminarPresupuesto(idPresupuestoGenerado); 
                    return;
                }

                try
                {
                    // LLAMADA A MÉTODO DE ACCESO A DATOS (BD)
                    _Tsvc.ActualizarEstadoEquipo(idEquipo, 2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Advertencia: El presupuesto se creó, pero falló la actualización del estado del equipo: {ex.Message}", "Advertencia de BD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // La ejecución puede continuar, pero se notifica el fallo
                }
            }
            //Finalizar la operación
            MessageBox.Show($"Presupuesto N° {idPresupuesto} generado con éxito. El equipo se marcó como 'Pendiente de aprobacion'.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
