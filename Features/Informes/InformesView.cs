using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller_2_Gestor.Features.Equipos;
using Taller_2_Gestor.Infra;

namespace Taller_2_Gestor.Features.Informes
{
    public partial class InformesView : UserControl
    {
        private readonly InformesService _Isvc;

        public InformesView()
        {
            var db = new AppDbContext();
            _Isvc = new InformesService(db);

            InitializeComponent();
            dtpDesde.Value = DateTime.Now.AddMonths(-1);
            dtpHasta.Value = DateTime.Now;
            CargarInformes();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CargarInformes()
        {
            lTotalGenerado.Text = _Isvc.CalcularTotalGenerado(dtpDesde.Value, dtpHasta.Value).ToString("C2");
            lServicioMasContratado.Text = _Isvc.ObtenerNombreServicioMasRepetido(dtpDesde.Value, dtpHasta.Value);
            lTecnicoMasProductivo.Text = _Isvc.ObtenerTecnicoMasProductivo(dtpDesde.Value, dtpHasta.Value);
            lTipoEquipoMasReparado.Text = _Isvc.ObtenerTipoEquipoMasReparado(dtpDesde.Value, dtpHasta.Value);
        }
    }
}
