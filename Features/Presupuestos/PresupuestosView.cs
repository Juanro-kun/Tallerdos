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
using Taller_2_Gestor.Features.Shared;
using Taller_2_Gestor.Infra;

namespace Taller_2_Gestor.Features.Presupuestos
{
    public partial class PresupuestosView : UserControl
    {
        private readonly PresupuestosService _Psvc;
        public PresupuestosView()
        {
            var db = new AppDbContext();
            _Psvc = new PresupuestosService(db);
            InitializeComponent();

            dgvPresupuestos.AutoGenerateColumns = false;
            var rol = UserSession.Current?.Rol;
            switch (rol)
            {
                case 1: // Maestro
                    dgvPresupuestos.DataSource = _Psvc.ListarPresupuestos();
                    break;
                case 2: // Técnico
                    lTitulo.Text = "Mis presupuestos";
                    dgvPresupuestos.DataSource = _Psvc.ListarPresupuestosPorTecnico(UserSession.Current.Id);
                    colPrecio.Visible = false;
                    break;
                case 3: // Administrador
                    lTitulo.Text = "Presupuestos a mi cargo";
                    dgvPresupuestos.DataSource = _Psvc.ListarPresupuestosPorAdmin(UserSession.Current.Id);
                    break;
            }
            dgvPresupuestos.DataSource = _Psvc.ListarPresupuestos();
            dgvPresupuestos.ClearSelection();

            dgvItems.AutoGenerateColumns = false;
            dgvItems.ClearSelection();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lIDPresupuesto_Click(object sender, EventArgs e)
        {

        }

        private void dgvPresupuestos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPresupuestos.SelectedRows == null || dgvPresupuestos.SelectedRows.Count == 0)
            {
                return;
            }
            Presupuesto p = (Presupuesto)dgvPresupuestos.SelectedRows[0].DataBoundItem;
            if (p == null) return;
            CargarDetalles(p);
            dgvItems.DataSource = _Psvc.ItemsPorPresupuesto(p.IdPresupuesto);
        }

        private void CargarDetalles(Presupuesto p)
        {
            tbIdPresupuesto.Text = p.IdPresupuesto.ToString();
            tbIdAdmin.Text = p.NombreAdministrador.ToString();
            tbIdTecnico.Text = p.NombreTecnico.ToString();
            tbIdEquipo.Text = p.DescripcionEquipo.ToString();
            tbFechaActualizacion.Text = p.FechaActualizacion.ToString("g");
        }
    }
}
