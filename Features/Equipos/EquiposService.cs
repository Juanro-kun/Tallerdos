using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller_2_Gestor.Domain.Entities;
using Taller_2_Gestor.Features.Shared;
using Taller_2_Gestor.Infra;

namespace Taller_2_Gestor.Features.Equipos
{
    internal class EquiposService
    {
        private readonly AppDbContext _db;

        public EquiposService(AppDbContext db)
        {
            _db = db;
        }

        public List<Equipo> ListarEquipos()
        {
            return _db.Equipos.ToList();
        }

        public List<Equipo> ListarEquiposPorCliente(int idCliente)
        {
            return _db.Equipos
                .Include(e => e.IdMarcaNavigation)
                .Include(e => e.IdTipoNavigation)
                .Include(e => e.IdEstadoNavigation)
                .Where(e => e.IdCliente == idCliente)
                .ToList();

        }
    }
}
