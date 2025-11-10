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
            dgvPendientesContacto.AutoGenerateColumns = false;
            dgvPendientesContacto.DataSource = _Tsvc.ListarEquiposPendientesDeContacto();
            dgvPospuestos.AutoGenerateColumns = false;
            dgvPospuestos.DataSource = _Tsvc.ListarPresupuestosPospuestosParaConsultar();
            dgvListos.AutoGenerateColumns = false;
            dgvListos.DataSource = _Tsvc.ListarEquiposListosParaRetiro();
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
                dgvListos.DataSource = _Tsvc.ListarEquiposListosParaRetiro();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bMarcarContactado_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea marcar el equipo como contactado?",
                "Confirmar contacto",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                if (dgvPendientesContacto.SelectedRows == null)
                {
                    MessageBox.Show("Seleccione un equipo para marcar como contactado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int idEquipo = ((Equipo)(dgvPendientesContacto.SelectedRows[0].DataBoundItem)).IdEquipo;
                _Tsvc.ModificarEstadoEquipo(idEquipo, 5); // 3 = Contactado
                dgvPendientesContacto.DataSource = _Tsvc.ListarEquiposPendientesDeContacto();
                dgvListos.DataSource = _Tsvc.ListarEquiposListosParaRetiro();
            }
        }

        private void bMarcarRetirado_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea marcar el equipo como retirado?",
                "Confirmar retiro",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                if (dgvListos.SelectedRows == null)
                {
                    MessageBox.Show("Seleccione un equipo para marcar como retirado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int idEquipo = ((Equipo)dgvListos.SelectedRows[0].DataBoundItem).IdEquipo;
                _Tsvc.ModificarEstadoEquipo(idEquipo, 7); // 7 = Retirado
                dgvListos.DataSource = _Tsvc.ListarEquiposListosParaRetiro();
            }
        }

        private void bDetallePospuestos_Click(object sender, EventArgs e)
        {
            if (dgvPospuestos.SelectedRows == null)
            {
                MessageBox.Show("Seleccione un presupuesto para ver los detalles.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var form = new DetallePospuestoForm();
            form.CargarDatosPresupuesto((Presupuesto)dgvPospuestos.SelectedRows[0].DataBoundItem);
            var resultado = form.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                //refrescar la grilla
                dgvPospuestos.DataSource = _Tsvc.ListarPresupuestosPospuestosParaConsultar();
            }
        }
    }
}

