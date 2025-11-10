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
using Taller_2_Gestor.Infra;

namespace Taller_2_Gestor.Features.Centro_de_Tareas_Tecnico
{
    public partial class GenerarOrdenForm : Form
    {
        private readonly TareasTecnicoService _Tsvc;
        public GenerarOrdenForm()
        {
            var db = new AppDbContext();
            _Tsvc = new TareasTecnicoService(db);
            InitializeComponent();
            dgvItems.AutoGenerateColumns = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void CargarDatosPresupuesto(int idPresupuesto)
        {
            Presupuesto p = _Tsvc.ObtenerPresupuesto(idPresupuesto);
            tbId.Text = p.IdEquipo.ToString();
            tbDescripcion.Text = p.DescripcionEquipo;
            tbMarca.Text = p.NombreMarcaEquipo;
            tbTipo.Text = p.NombreTipoEquipo;
            tbIdPresupuesto.Text = idPresupuesto.ToString();

            dgvItems.DataSource = _Tsvc.ListarItemsAprobadosPresupuesto(idPresupuesto);
        }

        private void bGenerarOrden_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que generar una orden? Si lo hace todos los items pasaran a estar marcados como realizados",
                "Confirmación de orden",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (resultado == DialogResult.Yes)
            {
                _Tsvc.ActualizarEstadoEquipo(int.Parse(tbId.Text), 3); // 3 = Pendiente de contacto
                _Tsvc.ActualizarEstadoPresupuesto(int.Parse(tbIdPresupuesto.Text), 4); // 4 = Realizado
                _Tsvc.CrearOrdenServicio(int.Parse(tbIdPresupuesto.Text));

                foreach (DataGridViewRow row in dgvItems.Rows)
                {
                    int nFila = ((ItemPresupuesto)row.DataBoundItem).NFila;
                    _Tsvc.ActualizarEstadoItemPresupuesto(Convert.ToInt32(tbIdPresupuesto.Text), nFila, 5); // 5 = Realizado
                    _Tsvc.CargarOrdenAItem(Convert.ToInt32(tbIdPresupuesto.Text), nFila);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }


        }

        private void bPosponer_Click(object sender, EventArgs e)
        {
            var resultado = PosponerReparacionMessageBox.Show(int.Parse(tbIdPresupuesto.Text), int.Parse(tbId.Text));

            if (resultado == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
