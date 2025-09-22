using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_2_Gestor.Domain
{
    public class UserSession
    {
        // Instancia actual accesible en toda la app:
        public static UserSession? Current { get; private set; }

        // Datos inmutables de la sesión (no guardes la entidad de EF, solo un snapshot)
        public int id { get; }
        public string Apellido { get; }
        public string Nombre { get; }
        public string Mail { get; }
        public byte Rol { get; }

        // Evita que alguien haga `new UserSession()` por fuera
        private UserSession(int id, string nombre, string apellido, string mail, byte rol)
        {
            id = id; Nombre = nombre; Apellido = apellido; Mail = mail; Rol = rol;
        }

        // “Log in”: setea la instancia global
        public static void Start(int id, string nombre, string apellido, string mail, byte rol)
            => Current = new UserSession(id, nombre, apellido, mail, rol);

        // “Log out”: limpia la instancia global
        public static void End() => Current = null;

        // Helper para pedir sesión de forma segura
        public static bool Require(out UserSession session)
        {
            session = Current!;
            return session != null;
        }
    }
}

