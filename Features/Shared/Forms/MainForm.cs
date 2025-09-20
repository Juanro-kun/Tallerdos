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
using static System.Collections.Specialized.BitVector32;

namespace Taller_2_Gestor.Forms
{
    public partial class MainForm : BaseForm
    {
        private readonly UserSession _session;//variable de solo lectura que guarda la sesion del usuario

        public MainForm(UserSession session)
        {
            InitializeComponent();
            _session = session;
            Text = "Taller 2 Gestor — Menú";
        }

        private void CargarUsuariosView()
        {
            ContentHost.Controls.Clear();              // limpiás lo que había
            var view = new UsuariosView();              // creás la vista
            view.Dock = DockStyle.Fill;                 // que llene el panel
            ContentHost.Controls.Add(view);            // la metés al panel
            view.BringToFront();
        }

        private void CargarEquiposView()
        {
            ContentHost.Controls.Clear();              // limpiás lo que había
            var view = new EquiposView();              // creás la vista
            view.Dock = DockStyle.Fill;                 // que llene el panel
            ContentHost.Controls.Add(view);            // la metés al panel
            view.BringToFront();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarUsuariosView();
        }

        private void ContentHost_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bEquipos_Click(object sender, EventArgs e)
        {
            CargarEquiposView();
        }
    }
}
