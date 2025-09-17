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
                      .Include(u => u.RolNavigation) // trae también el Rol
                      .ToList();
        }

        public List<Rol> ListarRoles()
        {
            return _db.Rols               
                     .AsNoTracking()
                     .OrderBy(r => r.Nombre)
                     .ToList();
        }
    }
}
