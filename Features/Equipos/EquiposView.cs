using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller_2_Gestor.Features.Clientes;
using Taller_2_Gestor.Features.Shared;
using Taller_2_Gestor.Infra;

namespace Taller_2_Gestor.Features.Equipos
{
    public partial class EquiposView : UserControl
    {
        private readonly EquiposService _Esvc;
        public EquiposView()
        {
            var db = new AppDbContext();
            _Esvc = new EquiposService(db);
            InitializeComponent();

            dgvEquipos.AutoGenerateColumns = false;
            dgvEquipos.DataSource = _Esvc.ListarEquipos();
            dgvEquipos.ClearSelection();

            dgvItems.AutoGenerateColumns = false;
            dgvItems.DataSource = MockData.GetItems();
            dgvItems.ClearSelection();

            // Estado inicial
            bNuevoEquipo.Visible = true;
            bGuardarNuevo.Visible = false;
        }

        private void bNuevoEquipo_Click(object sender, EventArgs e)
        {
            // Cambiar visibilidad botones
            bNuevoEquipo.Visible = false;
            bGuardarNuevo.Visible = true;
            bCancelar.Visible = true;
        }

        private void bGuardarNuevo_Click(object sender, EventArgs e)
        {
            // Cambiar visibilidad botones
            bNuevoEquipo.Visible = true;
            bGuardarNuevo.Visible = false;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            bNuevoEquipo.Visible = true;
            bGuardarNuevo.Visible = false;
            bCancelar.Visible = false;
        }

        private void roundedPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvEquipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
