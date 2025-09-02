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

                var session = new UserSession
                {
                    UserName = "Demo", // más adelante lo sacamos del login real
                    Rol = login.SelectedRole
                };

                Application.Run(new MainForm(session));
            }
        }
    }
}