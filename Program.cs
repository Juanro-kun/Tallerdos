using System;
using System.Windows.Forms;
using Taller_2_Gestor.Domain;
using Taller_2_Gestor.Forms;

namespace Taller_2_Gestor
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            using (var login = new LoginForm())
            {
                var result = login.ShowDialog();
                if (result != DialogResult.OK) return;

                // En este punto, LoginForm ya debió hacer:
                // UserSession.Start(id, nombre, apellido, mail, rol);

                if (UserSession.Current is null)
                {
                    // Por seguridad: si no hay sesión, salimos (o mostrás un error)
                    MessageBox.Show("No se pudo iniciar la sesión.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Application.Run(new MainForm()); // ya no pasa la sesión por ctor
            }
        }
    }
}