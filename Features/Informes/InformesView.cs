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

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDesde.Value > dtpHasta.Value)
            {
                MessageBox.Show("La fecha \"desde\" deber ser anterior a la fecha \"hasta\"");
                return;
            }

            CargarInformes();
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDesde.Value > dtpHasta.Value)
            {
                MessageBox.Show("La fecha \"Desde\" deber ser anterior a la fecha \"Hasta\"");
                return;
            }

            CargarInformes();
        }

        private void bServicioMasContratado_Click(object sender, EventArgs e)
        {
            CargarInformeServicios();
        }

        public void CargarInformeServicios()
        {
            dgvInformes.DataSource = _Isvc.ObtenerServiciosMasRepetidos(dtpDesde.Value, dtpHasta.Value);
            if (dgvInformes.Columns.Contains("VecesContratado"))
            {
                dgvInformes.Columns["VecesContratado"].HeaderText = "Cantidad Total";
            }
            if (dgvInformes.Columns.Contains("NombreServicio"))
            {
                dgvInformes.Columns["NombreServicio"].HeaderText = "Servicio";
            }
        }

        private void bTecnicoMasProductivo_Click(object sender, EventArgs e)
        {
            CargarInformeTecnicos();
        }

        public void CargarInformeTecnicos()
        {
            dgvInformes.DataSource = _Isvc.ObtenerTecnicosMasProductivos(dtpDesde.Value, dtpHasta.Value);

            if (dgvInformes.Columns.Contains("TotalRecaudado"))
            {
                dgvInformes.Columns["TotalRecaudado"].HeaderText = "Total Generado";
            }
            if (dgvInformes.Columns.Contains("ItemsCompletados"))
            {
                dgvInformes.Columns["ItemsCompletados"].HeaderText = "Servicios Finalizados";
            }
        }

        private void bTipoEquipoMasReparado_Click(object sender, EventArgs e)
        {
            CargarInformeEquipos();
        }

        private void CargarInformeEquipos()
        {
            dgvInformes.DataSource = _Isvc.ObtenerTiposEquipoMasReparados(dtpDesde.Value, dtpHasta.Value);

            if (dgvInformes.Columns.Contains("ItemsCompletados"))
            {
                dgvInformes.Columns["VecesReparado"].HeaderText = "Cantidad de Reparaciones";
            }
            if (dgvInformes.Columns.Contains("ItemsCompletados"))
            {
                dgvInformes.Columns["TipoEquipo"].HeaderText = "Tipo Equipo";
            }
        }
    }
}
