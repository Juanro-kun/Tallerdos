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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
