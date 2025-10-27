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

namespace Taller_2_Gestor.Features.Centro_de_Tareas_Administrador
{
    public partial class TareasAdminView : UserControl
    {
        private readonly TareasAdminService _Tsvc;

        public TareasAdminView()
        {
            var db = new AppDbContext();
            _Tsvc = new TareasAdminService(db);
            InitializeComponent();
            dgvPresupuestosAprobacion.AutoGenerateColumns = false;
            dgvPresupuestosAprobacion.DataSource = _Tsvc.ListarPresupuestosPendientesDeAprobacion();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bVerDetalles_Click(object sender, EventArgs e)
        {
            if (dgvPresupuestosAprobacion.SelectedRows == null)
            {
                MessageBox.Show("Seleccione un presupuesto para ver los detalles.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idPresupuesto = (int)dgvPresupuestosAprobacion.SelectedRows[0].Cells["colId"].Value;
            //llamar al formulario de presupuesto pasando el idEquipo
            var form = new AprobacionPresupuestoForm();
            var equipo = _Tsvc.ObtenerPresupuesto(idPresupuesto);
            form.CargarDatosPresupuesto(equipo);
            DialogResult resultado = form.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                //refrescar la grilla
                dgvPresupuestosAprobacion.DataSource = _Tsvc.ListarPresupuestosPendientesDeAprobacion();
            }
        }
    }
}

