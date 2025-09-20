using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_2_Gestor.Features.Equipos
{
    public partial class EquiposView : UserControl
    {
        public EquiposView()
        {
            InitializeComponent();

            // Estado inicial
            bNuevoEquipo.Visible = true;
            bGuardarNuevo.Visible = false;
        }

        private void bNuevoEquipo_Click(object sender, EventArgs e)
        {
            // Cambiar visibilidad botones
            bNuevoEquipo.Visible = false;
            bGuardarNuevo.Visible = true;

            //limpiar los textboxes
            tbMarca.Text = "";
            tbTipo.Text = "";
            tbEstado.Text = "";
        }

        private void bGuardarNuevo_Click(object sender, EventArgs e)
        {
            // Cambiar visibilidad botones
            bNuevoEquipo.Visible = true;
            bGuardarNuevo.Visible = false;
        }
    }
}
