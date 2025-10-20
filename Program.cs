using System;
using System.Windows.Forms;
using Taller_2_Gestor.Domain;
using Taller_2_Gestor.Forms;
using Taller_2_Gestor.Infra; // Donde est� tu DbContext
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
            // L�gica para CREAR/ACTUALIZAR la Base de Datos
            // =========================================================
            try
            {
                // Reemplaza TallerDosBaseContext por el nombre real de tu DbContext.
                // Aseg�rate de que este constructor sepa c�mo cargar la cadena de conexi�n.
                using (var context = new AppDbContext())
                {
                    // �La l�nea CLAVE! Aplica todas las migraciones pendientes.
                    context.Database.Migrate();
                }
            }
            catch (Exception ex)
            {
                // Si la conexi�n o la migraci�n fallan (p. ej., SQL EXPRESS no est� corriendo),
                // notifica al usuario y det�n la aplicaci�n.
                MessageBox.Show($"Error al inicializar la base de datos: {ex.Message}",
                                "Error de Configuraci�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir de la aplicaci�n si falla la BD
            }
            // =========================================================

            using (var login = new LoginForm())
            {
                var result = login.ShowDialog();
                if (result != DialogResult.OK) return;

                // En este punto, LoginForm ya debi� hacer:
                // UserSession.Start(id, nombre, apellido, mail, rol);

                if (UserSession.Current is null)
                {
                    // Por seguridad: si no hay sesi�n, salimos (o mostr�s un error)
                    MessageBox.Show("No se pudo iniciar la sesi�n.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Application.Run(new MainForm()); // ya no pasa la sesi�n por ctor
            }
        }
    }
}