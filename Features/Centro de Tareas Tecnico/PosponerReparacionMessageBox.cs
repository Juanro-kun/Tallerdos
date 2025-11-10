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

namespace Taller_2_Gestor.Features.Centro_de_Tareas_Tecnico
{
    public partial class PosponerReparacionMessageBox : Form
    {
        private readonly TareasTecnicoService _Tsvc;
        private readonly int IdPresupuesto;
        private readonly int IdEquipo;
        public PosponerReparacionMessageBox(int idPresupuesto, int idEquipo)
        {
            var db = new AppDbContext();
            _Tsvc = new TareasTecnicoService(db);
            InitializeComponent();
            this.Text = "Posponer Reparación";
            dgvItems.AutoGenerateColumns = false;
            IdPresupuesto = idPresupuesto;
            IdEquipo = idEquipo;

            dgvItems.DataSource = _Tsvc.ListarItemsAprobadosPresupuesto(idPresupuesto);
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            int cantidadItemsPospuestos = 0;
            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                bool isChecked = Convert.ToBoolean(row.Cells["colPosponer"].Value);
                if (isChecked)
                {
                    cantidadItemsPospuestos++;
                }
            }

            if (string.IsNullOrWhiteSpace(tbMensaje.Text) || tbMensaje.Text.Trim().Length < 30)
            {
                MessageBox.Show("El mensaje debe tener al menos 30 caracteres.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cantidadItemsPospuestos == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un item para posponer.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _Tsvc.CrearComentario(IdPresupuesto, tbMensaje.Text);
                int itemsNecesariosPospuestos = 0;
                foreach (DataGridViewRow row in dgvItems.Rows)
                {
                    bool isChecked = Convert.ToBoolean(row.Cells["colPosponer"].Value);
                    if (isChecked)
                    {
                        int nFila = ((Domain.Entities.ItemPresupuesto)row.DataBoundItem).NFila;
                        _Tsvc.ActualizarEstadoItemPresupuesto(IdPresupuesto, nFila, 4); // 4 = Pospuesto
                        if (((Domain.Entities.ItemPresupuesto)row.DataBoundItem).Necesario == true)
                        {
                            itemsNecesariosPospuestos++;
                        }
                    }
                }
                if (itemsNecesariosPospuestos != 0)
                {
                    _Tsvc.ActualizarEstadoPresupuesto(IdPresupuesto, 5); // 5 = Pospuesto, no se contacta al cliente
                }
                else
                {
                    _Tsvc.ActualizarEstadoPresupuesto(IdPresupuesto, 6); // 3 = Contactar al cliente
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        public static DialogResult Show(int idPresupuesto, int idEquipo)
        {
            using (var msgBox = new PosponerReparacionMessageBox(idPresupuesto, idEquipo))
            {
                return msgBox.ShowDialog();
            }
        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
