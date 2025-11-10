using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller_2_Gestor.Infra;
using Taller_2_Gestor.Domain.Entities;

namespace Taller_2_Gestor.Features.Centro_de_Tareas_Administrador
{
    public partial class DetallePospuestoForm : Form
    {
        private readonly TareasAdminService _Tsvc;

        public DetallePospuestoForm()
        {
            var db = new AppDbContext();
            _Tsvc = new TareasAdminService(db);
            InitializeComponent();
            dgvServicios.AutoGenerateColumns = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void CargarDatosPresupuesto(Presupuesto p)
        {
            tbId.Text = p.IdPresupuesto.ToString();
            tbNombre.Text = p.NombreCliente;
            tbDescripcion.Text = p.DescripcionEquipo;
            tbMail.Text = p.MailCliente;
            tbTel.Text = p.TelefonoCliente.ToString();

            dgvServicios.DataSource = _Tsvc.ItemsPospuestosNoNecesarios(p.IdPresupuesto);
        }

        private void bActualizar_Click(object sender, EventArgs e)
        {
            var restultado = MessageBox.Show("¿Está seguro de actualizar el estado de los ítems pospuestos?", "Confirmar actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (restultado == DialogResult.Yes)
            {

                int pospuestosRechazados = 0;
                foreach (DataGridViewRow row in dgvServicios.Rows)
                {
                    bool rechazado = Convert.ToBoolean(row.Cells["colRechazado"].Value);
                    int Nfila = ((ItemPresupuesto)row.DataBoundItem).NFila;
                    if (rechazado)
                    {
                        pospuestosRechazados++;
                        _Tsvc.ModificarEstadoItemPresupuesto(Convert.ToInt32(tbId.Text), Nfila, 3); // 3 = Rechazado
                    }
                    else
                    {
                        _Tsvc.ModificarEstadoItemPresupuesto(Convert.ToInt32(tbId.Text), Nfila, 2); // 2 = Aceptado
                    }
                }

                if (pospuestosRechazados == dgvServicios.Rows.Count && dgvServicios.Rows.Count == _Tsvc.CantidadDeItemsAprobadosOPospuestosPorPresupuesto(Convert.ToInt32(tbId.Text)))
                {
                    _Tsvc.ModificarEstadoPresupuesto(Convert.ToInt32(tbId.Text), 3); // 3 = Rechazado
                    _Tsvc.ModificarEstadoEquipo(_Tsvc.ObtenerPresupuesto(Convert.ToInt32(tbId.Text)).IdEquipo, 5); // 5 = Cliente contactado
                    MessageBox.Show("Se han rechazado todos los ítems pospuestos. El presupuesto ha sido marcado como rechazado y el equipo como cliente contactado.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (pospuestosRechazados == dgvServicios.Rows.Count && dgvServicios.Rows.Count < _Tsvc.CantidadDeItemsAprobadosOPospuestosPorPresupuesto(Convert.ToInt32(tbId.Text)))
                {
                    _Tsvc.ModificarEstadoPresupuesto(Convert.ToInt32(tbId.Text), 2); // 2 = Aprobado
                    _Tsvc.ModificarEstadoEquipo(_Tsvc.ObtenerPresupuesto(Convert.ToInt32(tbId.Text)).IdEquipo, 4); // 4 = Pendiente de reparación
                }
                else if (pospuestosRechazados < dgvServicios.Rows.Count)
                {
                    _Tsvc.ModificarEstadoPresupuesto(Convert.ToInt32(tbId.Text), 5); // 5 = Pospuesto
                }
                this.DialogResult = DialogResult.OK;
            }


        }
    }
}
