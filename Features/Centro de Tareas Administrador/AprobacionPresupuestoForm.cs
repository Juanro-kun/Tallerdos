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
using Taller_2_Gestor.Infra;

namespace Taller_2_Gestor.Features.Centro_de_Tareas_Administrador
{
    public partial class AprobacionPresupuestoForm : Form
    {
        private int subtotalNecesarios;
        private int subtotalOpcionales;
        private int _indiceColAceptado = -1;
        private readonly TareasAdminService _Tsvc;

        public AprobacionPresupuestoForm()
        {
            var db = new AppDbContext();
            _Tsvc = new TareasAdminService(db);
            InitializeComponent();
            dgvItemsNecesarios.AutoGenerateColumns = false;
            dgvItemsOpcionales.AutoGenerateColumns = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void CargarDatosPresupuesto(Presupuesto p)
        {
            tbId.Text = p.IdPresupuesto.ToString();
            tbNombre.Text = p.NombreCliente;
            tbDescripcion.Text = p.DescripcionEquipo;
            tbMail.Text = p.MailCliente;
            tbTel.Text = p.TelefonoCliente.ToString();

            dgvItemsNecesarios.DataSource = _Tsvc.ItemsNecesariosPorPresupuesto(p.IdPresupuesto);
            dgvItemsOpcionales.DataSource = _Tsvc.ItemsOpcionalesPorPresupuesto(p.IdPresupuesto);


            foreach (DataGridViewRow row in dgvItemsNecesarios.Rows)
            {
                subtotalNecesarios += Convert.ToInt32(row.Cells["colMonto"].Value);
            }

            lSubtotalNecesarios.Text = $"Subtotal: ${subtotalNecesarios}";
            lSubtotalOpcionales.Text = "Subtotal: $0";
            lTotal.Text = $"Total: ${subtotalNecesarios}";
        }

        private void dgvItemsOpcionales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea aprobar el presupuesto?",
                "Confirmación de aceptación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Comprobar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                // El usuario presionó 'Sí'
                _Tsvc.ModificarEstadoEquipo(int.Parse(tbId.Text), 4); // 4 = Pendiente de reparación
                _Tsvc.ModificarEstadoPresupuesto(int.Parse(tbId.Text), 2); // 2 = Aprobado

                foreach (DataGridViewRow row in dgvItemsNecesarios.Rows)
                {
                    int nFila = ((ItemPresupuesto)row.DataBoundItem).NFila;
                    _Tsvc.ModificarEstadoItemPresupuesto(Convert.ToInt32(tbId.Text), nFila, 2);
                }

                foreach (DataGridViewRow row in dgvItemsOpcionales.Rows)
                {
                    int nFila = ((ItemPresupuesto)row.DataBoundItem).NFila;
                    bool aceptado = Convert.ToBoolean(row.Cells["colAceptado"].Value);
                    int nuevoEstado = aceptado ? 2 : 3; // 2 = Aceptado, 3 = Rechazado
                    _Tsvc.ModificarEstadoItemPresupuesto(Convert.ToInt32(tbId.Text), nFila, nuevoEstado);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void bRechazar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea rechazar el presupuesto?",
                "Confirmación de aceptación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                _Tsvc.ModificarEstadoEquipo(int.Parse(tbId.Text), 5); // 5 = Cliente contactado ya que si se rechazó es porque el cliente está notificado
                _Tsvc.ModificarEstadoPresupuesto(int.Parse(tbId.Text), 3); // 2 = Aprobado
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void dgvItemsOpcionales_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            // Si hay cambios pendientes en la celda actual (la celda está "sucia")...
            if (dgvItemsOpcionales.IsCurrentCellDirty)
            {
                // Forzar al DGV a aceptar el valor de la celda y notificar el cambio.
                // Esto dispara inmediatamente el evento CellValueChanged.
                dgvItemsOpcionales.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvItemsOpcionales_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == _indiceColAceptado && e.RowIndex >= 0)
            {
                subtotalOpcionales = 0;
                foreach (DataGridViewRow r in dgvItemsOpcionales.Rows)
                {
                    bool aceptado = Convert.ToBoolean(r.Cells["colAceptado"].Value);
                    if (aceptado)
                    {
                        subtotalOpcionales += Convert.ToInt32(r.Cells["colMontoOpcionales"].Value);
                    }
                }
                lSubtotalOpcionales.Text = $"Subtotal: ${subtotalOpcionales}";
                int total = subtotalNecesarios + subtotalOpcionales;
                lTotal.Text = $"Total: ${total}";
            }
        }

        private void AprobacionPresupuestoForm_Load(object sender, EventArgs e)
        {
            if (dgvItemsOpcionales.Columns.Contains("colAceptado"))
            {
                _indiceColAceptado = dgvItemsOpcionales.Columns["colAceptado"].Index;
            }
        }
    }
}
