using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller_2_Gestor.Domain;
using Taller_2_Gestor.Infra;
using Microsoft.EntityFrameworkCore;

namespace Taller_2_Gestor.Features.Login
{
    internal class LoginService
    {
        public (bool ok, string? error) Login(string mail, string password)
        {
            const string ERROR = "Usuario o contraseña inválidos.";

            if (string.IsNullOrWhiteSpace(mail) || string.IsNullOrEmpty(password))
                return (false, ERROR);

            using var db = new AppDbContext();

            var u = db.Usuarios
                      .AsNoTracking()
                      .SingleOrDefault(x => x.Mail == mail);

            if (u is null)
                return (false, ERROR);

            // Comparación en plano (sin hash), como pediste
            if (!string.Equals(u.Contrasena, password))
                return (false, ERROR);

            // Éxito: guardar sesión
            UserSession.Start(u.idUsuario, u.Nombre, u.Apellido, u.Mail, u.Rol);

            return (true, null);
        }
    }
}

