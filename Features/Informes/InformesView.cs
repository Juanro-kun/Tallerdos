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
using ScottPlot; // Motor principal de ScottPlot
using ScottPlot.WinForms; // Requerido para el control WinForms

namespace Taller_2_Gestor.Features.Informes
{
    public partial class InformesView : UserControl
    {
        private readonly InformesService _Isvc;
        private int InformeSeleccionado = 0;
        private bool vistaGraficoActiva = false;


        public InformesView()
        {
            var db = new AppDbContext();
            _Isvc = new InformesService(db);

            InitializeComponent();
            dtpDesde.Value = DateTime.Now.AddMonths(-1);
            dtpHasta.Value = DateTime.Now;
            CargarInformes();
            dgvInformes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInformes.RowHeadersVisible = false;
            

            // Aseguramos que el gráfico esté oculto al inicio

        }

        private void label2_Click(object sender, EventArgs e) { /* Ignorado */ }

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
            if (vistaGraficoActiva)
            {
                RecargarGrafico();
            }
            else if (!vistaGraficoActiva)
            {
                RecargarGrid();
            }
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDesde.Value > dtpHasta.Value)
            {
                MessageBox.Show("La fecha \"Desde\" deber ser anterior a la fecha \"Hasta\"");
                return;
            }

            CargarInformes();
            if (vistaGraficoActiva)
            {
                RecargarGrafico();
            }
            else if (!vistaGraficoActiva)
            {
                RecargarGrid();
            }
        }

        private void bServicioMasContratado_Click(object sender, EventArgs e)
        {
            InformeSeleccionado = 1;
            if (vistaGraficoActiva)
            {
                RecargarGrafico();
            }
            else if (!vistaGraficoActiva)
            {
                RecargarGrid();
            }
        }

        public void CargarInformeServicios()
        {
            dgvInformes.DataSource = _Isvc.ObtenerServiciosMasRepetidos(dtpDesde.Value, dtpHasta.Value);

            // --- Configuración DGV ---
            if (dgvInformes.Columns.Contains("VecesContratado"))
            {
                dgvInformes.Columns["VecesContratado"].HeaderText = "Veces contratado";
                dgvInformes.Columns["VecesContratado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvInformes.Columns["VecesContratado"].DefaultCellStyle.Format = "N0"; // Formato de número
                dgvInformes.Columns["VecesContratado"].FillWeight = 35; // Total 100 con 30 y 35
            }
            if (dgvInformes.Columns.Contains("NombreServicio"))
            {
                dgvInformes.Columns["NombreServicio"].HeaderText = "Servicio";
                dgvInformes.Columns["NombreServicio"].FillWeight = 30;
            }
            if (dgvInformes.Columns.Contains("PrecioPromedio"))
            {
                dgvInformes.Columns["PrecioPromedio"].HeaderText = "Precio promedio por servicio";
                dgvInformes.Columns["PrecioPromedio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvInformes.Columns["PrecioPromedio"].DefaultCellStyle.Format = "C2"; // Formato de moneda
                dgvInformes.Columns["PrecioPromedio"].FillWeight = 35;
            }

            InformeSeleccionado = 1;
            AlinearTotales();

            
            lTotalesMI.Text = "Total servicios contratados:";
            lTotalesMD.Text = CalcularTotalMedio().ToString("N0"); // Total de ítems

            lTotalesII.Text = "Promedio General:";
            lTotalesID.Text = CalcularPromedioDerecha().ToString("C2"); // Promedio de precio

        }

        private void bTecnicoMasProductivo_Click(object sender, EventArgs e)
        {
            InformeSeleccionado = 2;
            if (vistaGraficoActiva)
            {
                RecargarGrafico();
            }
            else if (!vistaGraficoActiva)
            {
                RecargarGrid();
            }
        }

        public void CargarInformeTecnicos()
        {
            dgvInformes.DataSource = _Isvc.ObtenerTecnicosMasProductivos(dtpDesde.Value, dtpHasta.Value);

            // --- Configuración DGV ---
            if (dgvInformes.Columns.Contains("TotalRecaudado"))
            {
                dgvInformes.Columns["TotalRecaudado"].HeaderText = "Total generado por tecnico";
                dgvInformes.Columns["TotalRecaudado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvInformes.Columns["TotalRecaudado"].DefaultCellStyle.Format = "C2"; // Moneda
                dgvInformes.Columns["TotalRecaudado"].FillWeight = 35; // Total 100 con 40 y 35
            }
            if (dgvInformes.Columns.Contains("ItemsCompletados"))
            {
                dgvInformes.Columns["ItemsCompletados"].HeaderText = "Servicios finalizados";
                dgvInformes.Columns["ItemsCompletados"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvInformes.Columns["ItemsCompletados"].DefaultCellStyle.Format = "N0"; // Número
                dgvInformes.Columns["ItemsCompletados"].FillWeight = 35;
            }
            if (dgvInformes.Columns.Contains("Tecnico"))
            {
                dgvInformes.Columns["Tecnico"].FillWeight = 30;
            }

            
            AlinearTotales();

            // --- Totales (Corregido con double y formato) ---
            lTotalesMI.Text = "Total servicios realizados:";
            lTotalesMD.Text = CalcularTotalMedio().ToString("N0"); // Total de ítems

            lTotalesII.Text = "Total generado:";
            lTotalesID.Text = CalcularTotalDerecha().ToString("C2"); // Total monetario

        }

        private void bTipoEquipoMasReparado_Click(object sender, EventArgs e)
        {
            InformeSeleccionado = 3;
            if (vistaGraficoActiva)
            {
                RecargarGrafico();
            }
            else if (!vistaGraficoActiva)
            {
                RecargarGrid();
            }

        }

        private void CargarInformeEquipos()
        {
            dgvInformes.DataSource = _Isvc.ObtenerTiposEquipoMasReparados(dtpDesde.Value, dtpHasta.Value);

            // --- Configuración DGV (Solo 2 columnas) ---
            if (dgvInformes.Columns.Contains("VecesReparado"))
            {
                dgvInformes.Columns["VecesReparado"].HeaderText = "Cantidad de reparaciones";
                dgvInformes.Columns["VecesReparado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvInformes.Columns["VecesReparado"].DefaultCellStyle.Format = "N0"; // Número
                dgvInformes.Columns["VecesReparado"].FillWeight = 50; // Total 100 con 50
            }
            if (dgvInformes.Columns.Contains("TipoEquipo"))
            {
                dgvInformes.Columns["TipoEquipo"].HeaderText = "Tipo de equipo";
                dgvInformes.Columns["TipoEquipo"].FillWeight = 50;
            }

            
            AlinearTotales();

            // --- Totales (Corregido con double y formato) ---
            lTotalesMI.Text = "Total equipos reparados:";
            lTotalesMD.Text = CalcularTotalMedio().ToString("N0"); // Total de ítems

            // Ocultar segunda fila de totales para este informe (solo tiene 2 columnas de datos)
            lTotalesII.Visible = false;
            lTotalesID.Visible = false;

        }

        public void RecargarGrid()
        {
            // Resetear visibilidad de totales que se ocultan en el informe 3
            lTotalesII.Visible = true;
            lTotalesID.Visible = true;

            switch (InformeSeleccionado)
            {
                case 1: CargarInformeServicios(); break;
                case 2: CargarInformeTecnicos(); break;
                case 3: CargarInformeEquipos(); break;
                default: break;
            }
        }

        // ------------------------------------------------------------------
        // LÓGICA DE CÁLCULO DE TOTALES (CORREGIDA A DOUBLE)
        // ------------------------------------------------------------------

        // Total de la columna [1] (Veces Contratado / Items Completados)
        public double CalcularTotalMedio()
        {
            double total = 0;
            foreach (DataGridViewRow r in dgvInformes.Rows)
            {
                if (double.TryParse(r.Cells[1].Value?.ToString(), out double valor))
                {
                    total += valor;
                }
            }
            return total;
        }

        // Promedio o Total de la columna [2] (Precio Promedio / Total Recaudado)
        // Se usa como Promedio en el Informe 1, y Total en el Informe 2.
        public double CalcularTotalDerecha()
        {
            double total = 0;
            foreach (DataGridViewRow r in dgvInformes.Rows)
            {
                if (double.TryParse(r.Cells[2].Value?.ToString(), out double valor))
                {
                    total += valor;
                }
            }
            return total;
        }

        // Calcula el promedio de los valores de la columna [2]
        public double CalcularPromedioDerecha()
        {
            double totalColumna = 0;
            int totalFilas = dgvInformes.Rows.Count;

            if (totalFilas == 0) return 0.0;

            foreach (DataGridViewRow r in dgvInformes.Rows)
            {
                if (double.TryParse(r.Cells[2].Value?.ToString(), out double valor))
                {
                    totalColumna += valor;
                }
            }

            return totalColumna / totalFilas;
        }


        // ------------------------------------------------------------------
        // LÓGICA DE ALINEACIÓN DEL FOOTER
        // ------------------------------------------------------------------
        private void AlinearTotales()
        {
            if (dgvInformes.ColumnCount == 0) return;
            if (tlpTotales.ColumnCount != 3) return; // Asegurar estructura TLP

            // 1. Columna de Offset (Ancho de la columna de Nombre/Texto del DGV)
            if (dgvInformes.Columns.Count > 0 && dgvInformes.Columns[0].Visible)
            {
                tlpTotales.ColumnStyles[0].SizeType = SizeType.Absolute;
                tlpTotales.ColumnStyles[0].Width = dgvInformes.Columns[0].Width;
            }

            // 2. Columna de Total 1 (Ancho de la 1ª columna de números - Índice [1])
            if (dgvInformes.Columns.Count > 1 && dgvInformes.Columns[1].Visible)
            {
                tlpTotales.ColumnStyles[1].SizeType = SizeType.Absolute;
                tlpTotales.ColumnStyles[1].Width = dgvInformes.Columns[1].Width;
                // Reestablecer visibilidad
                tlpTotales.ColumnStyles[1].Width = dgvInformes.Columns[1].Width;
            }
            else
            {
                // Si el DGV no tiene esta columna (ej. error), su ancho es 0.
                tlpTotales.ColumnStyles[1].Width = 0;
            }

            // 3. Columna de Total 2 (Ancho de la 2ª columna de números - Índice [2])
            if (dgvInformes.Columns.Count > 2 && dgvInformes.Columns[2].Visible)
            {
                tlpTotales.ColumnStyles[2].SizeType = SizeType.Absolute;
                tlpTotales.ColumnStyles[2].Width = dgvInformes.Columns[2].Width;
            }
            else
            {
                // Para informes de 2 columnas (TipoEquipo), forzamos ancho 0.
                tlpTotales.ColumnStyles[2].Width = 0;
            }

            tlpTotales.Width = dgvInformes.Width;
        }







        private void lTotalesII_Click(object sender, EventArgs e) { /* Ignorado */ }
        private void label7_Click(object sender, EventArgs e) { /* Ignorado */ }

        private void bAlternarVista_Click(object sender, EventArgs e)
        {
            vistaGraficoActiva = !vistaGraficoActiva;

            if (vistaGraficoActiva)
            {
                bAlternarVista.Text = "Mostrar tabla";
                dgvInformes.Visible = false;
                tlpTotales.Visible = false;
                chartReportes.Visible = true; // El FormsPlot se hace visible
                RecargarGrafico(); // Llama a la lógica de ScottPlot
            }
            else
            {
                bAlternarVista.Text = "Mostrar gráfico";
                dgvInformes.Visible = true;
                tlpTotales.Visible = true;
                chartReportes.Visible = false;
                RecargarGrid();
            }
        }

        private void RecargarGrafico()
        {
            if (!vistaGraficoActiva) return;

            chartReportes.Plot.Clear(); // ScottPlot: Limpia el gráfico antes de dibujar

            // Llamar al método de ScottPlot según el informe seleccionado
            switch (InformeSeleccionado)
            {
                case 1: MostrarGraficoServicios(); break;
                case 2: MostrarGraficoTecnicos(); break;
                case 3: MostrarGraficoEquipos(); break;
                default:
                    chartReportes.Refresh(); // Simplemente refresca el gráfico vacío
                    break;
            }
            chartReportes.Plot.Axes.AutoScale();
            chartReportes.Refresh();
        }

        private void MostrarGraficoServicios()
        {
            var data = _Isvc.ObtenerServiciosMasRepetidos(dtpDesde.Value, dtpHasta.Value)
                .Cast<dynamic>()
                .ToList();

            if (data.Count == 0) return;

            // 1. Preparar datos
            double[] values = data.Select(item => (double)item.VecesContratado).ToArray();
            string[] labels = data.Select(item => (string)item.NombreServicio).ToArray();

            // 2. Dibujar las barras (por defecto son verticales)
            var barPlot = chartReportes.Plot.Add.Bars(values);

            // 3. Configurar el Eje Inferior (Etiquetas X)
            chartReportes.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(
                // ScottPlot necesita saber la posición (0, 1, 2...) y la etiqueta (Nombre Servicio)
                Enumerable.Range(0, labels.Length).Select(i => new Tick(i, labels[i])).ToArray()
            );
            chartReportes.Plot.Axes.Bottom.MajorTickStyle.Length = 0; // Ocultar marcas de ticks

            // 4. Configurar el Eje Izquierdo (Valores Y)
            chartReportes.Plot.Axes.Left.Label.Text = "Veces Contratado";
            chartReportes.Plot.Axes.Left.Min = 0;

            // 5. Título y Renderizado
            chartReportes.Plot.Title("Servicios Más Repetidos");
            chartReportes.Refresh();
        }

        private void MostrarGraficoTecnicos()
        {
            var data = _Isvc.ObtenerTecnicosMasProductivos(dtpDesde.Value, dtpHasta.Value)
                .Cast<dynamic>()
                .ToList();

            if (data.Count == 0) return;

            // 1. Preparar datos
            double[] values = data.Select(item => (double)item.ItemsCompletados).ToArray();
            string[] labels = data.Select(item => (string)item.Tecnico).ToArray();

            // 2. Dibujar las barras
            chartReportes.Plot.Add.Bars(values);

            // 3. Configurar el Eje Inferior (Etiquetas X)
            chartReportes.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(
                Enumerable.Range(0, labels.Length).Select(i => new Tick(i, labels[i])).ToArray()
            );
            chartReportes.Plot.Axes.Bottom.TickLabelStyle.Rotation = 0;
            chartReportes.Plot.Axes.Bottom.MajorTickStyle.Length = 0;

            // 4. Configurar el Eje Izquierdo (Valores Y)
            chartReportes.Plot.Axes.Left.Label.Text = "Servicios Finalizados";
            chartReportes.Plot.Axes.Left.Min = 0;

            // 5. Título y Renderizado
            chartReportes.Plot.Title("Técnicos Más Productivos (Items Completados)");
            chartReportes.Refresh();

        }

        private void MostrarGraficoEquipos()
        {
            var data = _Isvc.ObtenerTiposEquipoMasReparados(dtpDesde.Value, dtpHasta.Value)
                .Cast<dynamic>()
                .ToList();

            if (data.Count == 0) return;

            // 1. Preparar datos
            double[] values = data.Select(item => (double)item.VecesReparado).ToArray();
            string[] labels = data.Select(item => (string)item.TipoEquipo).ToArray();

            // 2. Dibujar las barras
            chartReportes.Plot.Add.Bars(values);

            // 3. Configurar el Eje Inferior (Etiquetas X)
            chartReportes.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(
                Enumerable.Range(0, labels.Length).Select(i => new Tick(i, labels[i])).ToArray()
            );
            chartReportes.Plot.Axes.Bottom.TickLabelStyle.Rotation = 0;
            chartReportes.Plot.Axes.Bottom.MajorTickStyle.Length = 0;

            // 4. Configurar el Eje Izquierdo (Valores Y)
            chartReportes.Plot.Axes.Left.Label.Text = "Cantidad de Reparaciones";
            chartReportes.Plot.Axes.Left.Min = 0;

            // 5. Título y Renderizado
            chartReportes.Plot.Title("Tipos de Equipo Más Reparados");
            chartReportes.Refresh();
        }
    }
}