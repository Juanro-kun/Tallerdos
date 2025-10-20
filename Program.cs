using System;
using System.Windows.Forms;
using Taller_2_Gestor.Domain;
using Taller_2_Gestor.Forms;
using Taller_2_Gestor.Infra; // Donde está tu DbContext
using Microsoft.EntityFrameworkCore;

namespace Taller_2_Gestor
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // =========================================================
            // Lógica para CREAR/ACTUALIZAR la Base de Datos
            // =========================================================
            try
            {
                // Reemplaza TallerDosBaseContext por el nombre real de tu DbContext.
                // Asegúrate de que este constructor sepa cómo cargar la cadena de conexión.
                using (var context = new AppDbContext())
                {
                    // ¡La línea CLAVE! Aplica todas las migraciones pendientes.
                    context.Database.Migrate();
                }
            }
            catch (Exception ex)
            {
                // Si la conexión o la migración fallan (p. ej., SQL EXPRESS no está corriendo),
                // notifica al usuario y detén la aplicación.
                MessageBox.Show($"Error al inicializar la base de datos: {ex.Message}",
                                "Error de Configuración", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir de la aplicación si falla la BD
            }
            // =========================================================

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