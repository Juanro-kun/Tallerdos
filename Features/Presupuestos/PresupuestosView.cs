using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller_2_Gestor.Features.Shared;

namespace Taller_2_Gestor.Features.Presupuestos
{
    public partial class PresupuestosView : UserControl
    {
        public PresupuestosView()
        {
            InitializeComponent();

            dgvPresupuestos.AutoGenerateColumns = false;
            dgvPresupuestos.DataSource = MockData.GetPresupuestos();
            dgvPresupuestos.ClearSelection();

            dgvItems.AutoGenerateColumns = false;
            dgvItems.DataSource = MockData.GetItems();
            dgvItems.ClearSelection();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
    }
}
