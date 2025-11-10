using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller_2_Gestor.Features.Centro_de_Tareas_Tecnico;
using Taller_2_Gestor.Features.Equipos;
using Taller_2_Gestor.Infra;

namespace Taller_2_Gestor.Features.Centro_de_Tareas
{
    public partial class TareasTecnicoView : UserControl
    {
        private readonly TareasTecnicoService _Tsvc;
        public TareasTecnicoView()
        {
            var db = new AppDbContext();
            _Tsvc = new TareasTecnicoService(db);
            InitializeComponent();

            dgvEquiposReparacion.AutoGenerateColumns = false;
            dgvEquiposRevision.AutoGenerateColumns = false;

            dgvEquiposRevision.DataSource = _Tsvc.ListarEquiposPendientesDeRevision();
            dgvEquiposReparacion.DataSource = _Tsvc.ListarPresupuestosAprobadosOPospuestosARevisar();
        }

        private void bGenerarPresupuesto_Click(object sender, EventArgs e)
        {
            if (dgvEquiposRevision.SelectedRows == null)
            {
                MessageBox.Show("Seleccione un equipo para generar el presupuesto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idEquipo = (int)dgvEquiposRevision.SelectedRows[0].Cells["colId"].Value;
            //llamar al formulario de presupuesto pasando el idEquipo
            var form = new GenerarPresupuestoForm();
            var equipo = _Tsvc.ObtenerEquipo(idEquipo);
            form.CargarDatosEquipo(equipo);
            DialogResult resultado = form.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                //refrescar la grilla
                dgvEquiposRevision.DataSource = _Tsvc.ListarEquiposPendientesDeRevision;
            }
        }

        private void bGenerarOrden_Click(object sender, EventArgs e)
        {
            if (dgvEquiposReparacion.SelectedRows == null)
            {
                MessageBox.Show("Seleccione un equipo para generar la orden de reparación.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idPresupuesto = (int)dgvEquiposReparacion.SelectedRows[0].Cells["colIdPresupuesto"].Value;
            var form = new GenerarOrdenForm();
            form.CargarDatosPresupuesto(idPresupuesto);
            DialogResult resultado = form.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                dgvEquiposReparacion.DataSource = _Tsvc.ListarPresupuestosAprobados();
            }
        }
    }
}
