using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Taller_2_Gestor.Forms
{
    public class ReportesView : UserControl
    {
        private Label lblInicio;
        private Label lblFin;
        private DateTimePicker dtpInicio;
        private DateTimePicker dtpFin;
        private Button btnGenerar;
        private Panel panelGrafico;
        private DataGridView dgvDatos;
        private Chart chartReportes;


    public ReportesView()
        {
            InicializarControles();
            InicializarGrafico();
        }

        private void InicializarControles()
        {
            // === CONFIGURACIÓN GENERAL DEL USERCONTROL ===
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.White;
            this.Padding = new Padding(10);

            // === LABELS Y SELECTORES DE FECHA ===
            lblInicio = new Label
            {
                Text = "Fecha inicio:",
                AutoSize = true,
                Location = new Point(10, 15)
            };

            dtpInicio = new DateTimePicker
            {
                Location = new Point(100, 10),
                Width = 150
            };

            lblFin = new Label
            {
                Text = "Fecha fin:",
                AutoSize = true,
                Location = new Point(270, 15)
            };

            dtpFin = new DateTimePicker
            {
                Location = new Point(340, 10),
                Width = 150
            };

            // === BOTÓN GENERAR ===
            btnGenerar = new Button
            {
                Text = "Generar reporte",
                Location = new Point(510, 10),
                Width = 150,
                Height = 30,
                BackColor = Color.LightSteelBlue,
                FlatStyle = FlatStyle.Flat
            };
            btnGenerar.Click += BtnGenerar_Click;

            // === PANEL PARA EL GRÁFICO ===
            panelGrafico = new Panel
            {
                Location = new Point(10, 50),
                Size = new Size(750, 300),
                BorderStyle = BorderStyle.FixedSingle
            };

            // === DATAGRIDVIEW PARA MOSTRAR DATOS ===
            dgvDatos = new DataGridView
            {
                Location = new Point(10, 360),
                Size = new Size(750, 200),
                ReadOnly = true,
                AllowUserToAddRows = false
            };

            // === AGREGAR TODOS LOS CONTROLES ===
            this.Controls.Add(lblInicio);
            this.Controls.Add(dtpInicio);
            this.Controls.Add(lblFin);
            this.Controls.Add(dtpFin);
            this.Controls.Add(btnGenerar);
            this.Controls.Add(panelGrafico);
            this.Controls.Add(dgvDatos);
        }

        private void InicializarGrafico()
        {
            chartReportes = new Chart
            {
                Dock = DockStyle.Fill
            };

            ChartArea area = new ChartArea("MainArea");
            area.AxisX.Interval = 1;
            area.AxisX.LabelStyle.Angle = -45;
            area.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            area.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartReportes.ChartAreas.Add(area);

            Series serie = new Series("Cantidad")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.SteelBlue,
                IsValueShownAsLabel = true
            };
            chartReportes.Series.Add(serie);

            Legend legend = new Legend();
            chartReportes.Legends.Add(legend);

            panelGrafico.Controls.Clear();
            panelGrafico.Controls.Add(chartReportes);
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            DateTime inicio = dtpInicio.Value.Date;
            DateTime fin = dtpFin.Value.Date;

            if (inicio > fin)
            {
                MessageBox.Show("La fecha de inicio no puede ser posterior a la fecha de fin.", "Fechas inválidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var datos = GenerarDatosSimulados(inicio, fin);

            // Actualizar gráfico
            Series serie = chartReportes.Series["Cantidad"];
            serie.Points.Clear();

            foreach (var punto in datos)
            {
                serie.Points.AddXY(punto.Fecha.ToString("yyyy-MM-dd"), punto.Cantidad);
            }

            // Actualizar tabla
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Fecha", typeof(string));
            tabla.Columns.Add("Cantidad de servicios", typeof(int));
            tabla.Columns.Add("Ingreso estimado ($)", typeof(decimal));

            foreach (var p in datos)
            {
                tabla.Rows.Add(p.Fecha.ToString("yyyy-MM-dd"), p.Cantidad, p.IngresoEstimado);
            }

            dgvDatos.DataSource = tabla;
            dgvDatos.AutoResizeColumns();
        }

        private List<PuntoReporte> GenerarDatosSimulados(DateTime inicio, DateTime fin)
        {
            var rnd = new Random();
            var lista = new List<PuntoReporte>();

            DateTime cur = inicio;
            while (cur <= fin)
            {
                int cantidad = rnd.Next(0, 15); // servicios por día
                decimal ingreso = Math.Round((decimal)(cantidad * (rnd.Next(50, 300) + rnd.NextDouble())), 2);

                lista.Add(new PuntoReporte
                {
                    Fecha = cur,
                    Cantidad = cantidad,
                    IngresoEstimado = ingreso
                });

                cur = cur.AddDays(1);
            }

            return lista;
        }

        private class PuntoReporte
        {
            public DateTime Fecha { get; set; }
            public int Cantidad { get; set; }
            public decimal IngresoEstimado { get; set; }
        }
    }

}
