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
using Taller_2_Gestor.Features.Centro_de_Tareas_Administrador;
using Taller_2_Gestor.Features.Login;
using Taller_2_Gestor.Features.BackupFeature;
using Taller_2_Gestor.Features.Informes;

namespace Taller_2_Gestor.Forms
{
    public partial class MainForm : BaseForm
    {
        private readonly UserSession _session;//variable de solo lectura que guarda la sesion del usuario
        private readonly LoginService _Lsvc;
        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Text = "Taller 2 Gestor — Menú";
            if (UserSession.Current?.Rol != 1)
            {
                bUsuarios.Visible = false;
            }
            ConfigurarSegunRol();
        }

        private void ConfigurarSegunRol()
        {
            var rol = UserSession.Current?.Rol;
            // Ejemplo de configuración según el rol
            switch (rol)
            {
                case 1: // Maestro
                    // Habilitar todas las funcionalidades
                    lBrand.Text = "Vista Maestro";
                    bClientes.Visible = true;
                    bEquipos.Visible = true;
                    bPresupuestos.Visible = true;
                    bOrdenes.Visible = true;
                    bUsuarios.Visible = true;
                    bTareasTecnico.Visible = false;
                    bTareasAdmin.Visible = false;
                    bInformes.Visible = true;
                    bBackup.Visible = true;
                    break;
                case 2: // Técnico
                    // Habilitar solo funcionalidades técnicas
                    lBrand.Text = "Vista Tecnico";
                    bClientes.Visible = false;
                    bEquipos.Visible = false;
                    bPresupuestos.Visible = true;
                    bPresupuestos.Text = "Mis Presupuestos";
                    bOrdenes.Visible = true;
                    bOrdenes.Text = "Mis Órdenes";
                    bUsuarios.Visible = false;
                    bTareasTecnico.Visible = true;
                    bTareasAdmin.Visible = false;
                    bInformes.Visible = false;
                    bBackup.Visible = false;
                    break;
                case 3: // Administrador
                    // Habilitar solo funcionalidades de cliente
                    lBrand.Text = "Vista Administrador";
                    bClientes.Visible = true;
                    bEquipos.Visible = true;
                    bPresupuestos.Visible = true;
                    bPresupuestos.Text = "Mis Presupuestos";
                    bOrdenes.Visible = false;
                    bUsuarios.Visible = false;
                    bTareasTecnico.Visible = false;
                    bTareasAdmin.Visible = true;
                    bInformes.Visible = false;
                    bBackup.Visible = false;
                    break;
                default:
                    // Rol desconocido, deshabilitar todo por seguridad
                    lBrand.Text = "Rol desconocido";
                    bClientes.Visible = false;
                    bEquipos.Visible = false;
                    bPresupuestos.Visible = false;
                    bOrdenes.Visible = false;
                    bUsuarios.Visible = false;
                    bTareasTecnico.Visible = false;
                    bTareasAdmin.Visible = false;
                    bInformes.Visible = false;
                    bBackup.Visible = false;
                    break;
            }
        }

        private void CargarView(UserControl view)
        {
            ContentHost.Controls.Clear();              // limpiás lo que había
            view.Dock = DockStyle.None;                 // que llene el panel
            view.Anchor = AnchorStyles.Top | AnchorStyles.Left;
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

        private void lBrand_Click(object sender, EventArgs e)
        {

        }

        private void bTareasAdmin_Click(object sender, EventArgs e)
        {
            var view = new TareasAdminView();
            CargarView(view);
        }

        private void bCerrarSesion_Click(object sender, EventArgs e)
        {
            Taller_2_Gestor.Domain.UserSession.End();
            this.Hide();

            using (var loginForm = new LoginForm())
            {
                // Mostrar el Login de forma modal (ShowDialog)
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // Si el login fue exitoso, volvemos a mostrar el formulario principal
                    this.Show();

                    // Opcional: Recargar o actualizar la vista principal
                    // para que los permisos/datos del nuevo usuario se apliquen.
                    this.ConfigurarSegunRol();
                    ContentHost.Controls.Clear();

                }
                else
                {
                    // Si el usuario cerró el formulario de Login sin éxito, 
                    // generalmente se cierra toda la aplicación.
                    Application.Exit();
                }
            }
        }

        private void bBackup_Click(object sender, EventArgs e)
        {
            var view = new BackupView();
            CargarView(view);
        }

        private void bInformes_Click(object sender, EventArgs e)
        {
            var view = new InformesView();
            CargarView(view);
        }
    }
}

