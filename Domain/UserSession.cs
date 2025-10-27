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
        public int Id { get; }
        public string Apellido { get; }
        public string Nombre { get; }
        public string Mail { get; }
        public byte Rol { get; }
        public string RolNombre { get; }


        // Evita que alguien haga `new UserSession()` por fuera
        private UserSession(int id, string nombre, string apellido, string mail, byte rol, string rolnombre)
        {
            Id = id; Nombre = nombre; Apellido = apellido; Mail = mail; Rol = rol; RolNombre = rolnombre;
        }

        // “Log in”: setea la instancia global
        public static void Start(int id, string nombre, string apellido, string mail, byte rol, string rolnombre)
            => Current = new UserSession(id, nombre, apellido, mail, rol, rolnombre);

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

