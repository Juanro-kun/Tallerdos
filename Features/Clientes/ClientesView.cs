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

namespace Taller_2_Gestor.Features.Clientes
{
    public partial class ClientesView : UserControl
    {
        public ClientesView()
        {
            InitializeComponent();
            dgvClientes.AutoGenerateColumns = false;         // o false si querés definirlas a mano
            dgvClientes.DataSource = MockData.GetClientes();
            dgvClientes.ClearSelection();

            dgvEquipos.AutoGenerateColumns = false;
            dgvEquipos.DataSource = MockData.GetEquipos();
            dgvEquipos.ClearSelection();

        }

        private void lContrasena_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bGuardarNuevo_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_SelectionChanged(object? sender, EventArgs e)//cuando se selecciona una fila del datagridview guarda los datos es una variable temporal u
        {
            if (dgvClientes.CurrentRow == null) return;

        }
    }
}
