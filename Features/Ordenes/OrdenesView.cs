using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller_2_Gestor.Features.Presupuestos;
using Taller_2_Gestor.Features.Shared;
using Taller_2_Gestor.Infra;
using Taller_2_Gestor.Domain.Entities;
using Taller_2_Gestor.Domain;
namespace Taller_2_Gestor.Features.Ordenes
{
    public partial class OrdenesView : UserControl
    {
        private readonly OrdenesService _Osvc;

        public OrdenesView()
        {
            var db = new AppDbContext();
            _Osvc = new OrdenesService(db);
            InitializeComponent();
            dgvOrdenes.AutoGenerateColumns = false;
            var rol = UserSession.Current?.Rol;
            switch (rol)
            {
                case 1: // Maestro
                    dgvOrdenes.DataSource = _Osvc.ListarOrdenes();
                    break;
                case 2: // Técnico
                    lTitulo.Text = "Mis Órdenes de Servicio";
                    dgvOrdenes.DataSource = _Osvc.ListarOrdenesPorTecnico(UserSession.Current.Id);
                    break;
            }

            dgvOrdenes.ClearSelection();

            dgvItems.AutoGenerateColumns = false;
        }

        private void dgvOrdenes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrdenes.SelectedRows == null || dgvOrdenes.SelectedRows.Count == 0)
            {
                return;
            }

            OrdenServicio o = (OrdenServicio)dgvOrdenes.SelectedRows[0].DataBoundItem;
            if (o == null) return;
            dgvItems.DataSource = _Osvc.ItemsPorOrden(o.IdPresupuesto);
        }
    }
}
