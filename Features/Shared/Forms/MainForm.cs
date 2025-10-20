using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller_2_Gestor.Domain;
using Taller_2_Gestor.Views;
using Taller_2_Gestor.Features.Equipos;
using Taller_2_Gestor.Features.Presupuestos;
using Taller_2_Gestor.Features.Ordenes;
using static System.Collections.Specialized.BitVector32;
using Taller_2_Gestor.Features.Clientes;
using Taller_2_Gestor.Features.Centro_de_Tareas;

namespace Taller_2_Gestor.Forms
{
    public partial class MainForm : BaseForm
    {
        private readonly UserSession _session;//variable de solo lectura que guarda la sesion del usuario

        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Text = "Taller 2 Gestor — Menú";
            if (UserSession.Current?.Rol != 1)
            {
                bUsuarios.Visible = false;
            }
        }

        private void CargarView(UserControl view)
        {
            ContentHost.Controls.Clear();              // limpiás lo que había
            view.Dock = DockStyle.Fill;                 // que llene el panel
            ContentHost.Controls.Add(view);            // la metés al panel
            view.BringToFront();
        }

        private void CargarUsuariosView()
        {
            var view = new UsuariosView();
            CargarView(view);
        }

        private EquiposView CargarEquiposView()
        {
            var view = new EquiposView();              // creás la vista

            return view;
        }

        private void CargarPresupuestosView()
        {
            ContentHost.Controls.Clear();              // limpiás lo que había
            var view = new PresupuestosView();              // creás la vista
            view.Dock = DockStyle.Fill;                 // que llene el panel
            ContentHost.Controls.Add(view);            // la metés al panel
            view.BringToFront();
        }

        private void CargarOrdenesView()
        {
            ContentHost.Controls.Clear();              // limpiás lo que había
            var view = new OrdenesView();              // creás la vista
            view.Dock = DockStyle.Fill;                 // que llene el panel
            ContentHost.Controls.Add(view);            // la metés al panel
            view.BringToFront();
        }

        private ClientesView CargarClientesView()
        {
            var view = new ClientesView();              // creás la vista
            view.NuevoEquipoSolicitado += OnNuevoEquipoSolicitado;
            view.DetalleEquipoSolicitado += OnDetalleEquipoSolicitado;

            return view;
        }

        private void OnNuevoEquipoSolicitado(int idCliente)
        {
            var view = CargarEquiposView();
            CargarView(view);
            view.PrepararParaCliente(idCliente);
            //VincularEventosEquiposView(view);

        }

        private void OnDetalleEquipoSolicitado(int idEquipo)
        {
            var view = CargarEquiposView();
            CargarView(view);
            view.PrepararParaVerEquipo(idEquipo);
            //VincularEventosEquiposView(view);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var view = CargarClientesView();
            CargarView(view);
        }

        private void ContentHost_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bEquipos_Click(object sender, EventArgs e)
        {
            var view = CargarEquiposView();
            CargarView(view);
        }

        private void bPresupuestos_Click(object sender, EventArgs e)
        {
            CargarPresupuestosView();
        }

        private void bOrdenes_Click(object sender, EventArgs e)
        {
            CargarOrdenesView();
        }

        private void bUsuarios_Click(object sender, EventArgs e)
        {
            CargarUsuariosView();
        }

        private void bTareasTecnico_Click(object sender, EventArgs e)
        {
            var view = new TareasTecnicoView();
            CargarView(view);
        }
    }
}
