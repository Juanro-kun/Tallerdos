using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller_2_Gestor.Infra;
using Taller_2_Gestor.Domain.Entities;

namespace Taller_2_Gestor.Features.Usuarios
{
    public class UsuariosService
    {
        private readonly AppDbContext _db;

        public UsuariosService(AppDbContext db)
        {
            _db = db;
        }

        public List<Usuario> ListarUsuarios()
        {
            return _db.Usuarios
                      .Include(u => u.IdRolNavigation) // trae también el Rol
                      .ToList();
        }

        public List<Rol> ListarRoles()
        {
            return _db.Rols
                     .AsNoTracking()
                     .OrderBy(r => r.NombreRol)
                     .ToList();
        }

        public (bool ok, string? error) Actualizar(
        int idUsuario, string nombre, string apellido, string mail,
        byte rol, bool activo)
        {
            try
            {
                var u = _db.Usuarios.FirstOrDefault(x => x.IdUsuario == idUsuario);
                if (u == null) return (false, "Usuario no encontrado.");

                bool mailEnUso = _db.Usuarios.Any(x => x.Mail == mail && x.IdUsuario != idUsuario);
                if (mailEnUso) return (false, "Ese mail ya está en uso por otro usuario.");

                u.Nombre = nombre;
                u.Apellido = apellido;
                u.Mail = mail;
                u.IdRol = rol;
                u.Active = activo;

                _db.SaveChanges();
                return (true, null);

            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (bool ok, string? error, Usuario? usuario) Crear(
        string nombre, string apellido, string mail,
        string contraseniaPlano, byte idRol, bool activo)
        {
            // Validaciones mínimas por seguridad (además de las de UI)
            if (string.IsNullOrWhiteSpace(nombre)) return (false, "Nombre vacío.", null);
            if (string.IsNullOrWhiteSpace(apellido)) return (false, "Apellido vacío.", null);
            if (string.IsNullOrWhiteSpace(mail)) return (false, "Mail vacío.", null);

            try
            {
                // Mail único
                if (_db.Usuarios.Any(u => u.Mail == mail))
                    return (false, "Ya existe un usuario con ese mail.", null);


                var nuevo = new Usuario
                {
                    Nombre = nombre.Trim(),
                    Apellido = apellido.Trim(),
                    Mail = mail.Trim(),
                    // TODO: reemplazar por hash (BCrypt/Argon2) cuando quieras
                    Contrasena = contraseniaPlano,
                    IdRol = idRol,
                    Active = activo
                };


                _db.Usuarios.Add(nuevo);
                _db.SaveChanges(); // completa nuevo.idUsuario

                return (true, null, nuevo);
            }
            catch (Exception ex)
            {
                return (false, "Error al guardar: " + ex.Message, null);
            }
        }

        public (bool ok, string? error) SetActivo(int idUsuario, bool activo)
        {
            try
            {
                var u = _db.Usuarios.FirstOrDefault(x => x.IdUsuario == idUsuario);
                if (u == null) return (false, "Usuario no encontrado.");

                if (u.Active == activo) return (true, null); // nada que hacer
                u.Active = activo;
                _db.SaveChanges();
                return (true, null);
            }
            catch (Exception ex)
            {
                return (false, $"Error al actualizar 'Activo': {ex.Message}");
            }
        }

        public List<Usuario> ListarUsuarios(bool? activo)
        {
            return _db.Usuarios
               .Where(u => u.Active == activo)
               .Include(u => u.IdRolNavigation)
               .AsNoTracking()
               .ToList();

        }

        public Usuario? BuscarPorId(int idUsuario)
        {
            return _db.Usuarios
                      .AsNoTracking()
                      .Include(u => u.IdRolNavigation)
                      .FirstOrDefault(u => u.IdUsuario == idUsuario);
        }
    }
}
