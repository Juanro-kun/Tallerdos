using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller_2_Gestor.Domain.Entities;
using Taller_2_Gestor.Infra;

namespace Taller_2_Gestor.Features.Centro_de_Tareas_Tecnico
{
    internal class TareasTecnicoService
    {
        private readonly AppDbContext _db;

        public TareasTecnicoService(AppDbContext db)
        {
            _db = db;
        }

        public Equipo ObtenerEquipo(int idEquipo)
        {
            return _db.Equipos
                .Include(e => e.IdMarcaNavigation)
                .Include(e => e.IdTipoNavigation)
                .Include(e => e.IdEstadoNavigation)
                .Include(e => e.IdClienteNavigation)
                .FirstOrDefault(e => e.IdEquipo == idEquipo);
        }

        public List<Equipo> ListarEquiposPendientesDeRevision()
        {
            int idEstadoPendienteRevision = 1;
            return _db.Equipos
                .Include(e => e.IdMarcaNavigation)
                .Include(e => e.IdTipoNavigation)
                .Include(e => e.IdEstadoNavigation)
                .Include(e => e.IdClienteNavigation)
                .Where(e => e.IdEstado == idEstadoPendienteRevision)
                .ToList();
        }

        public List<Equipo> ListarEquiposPendientesDeReparacion()
        {
            int idEstadoPendienteReparacion = 3;
            return _db.Equipos
                .Include(e => e.IdMarcaNavigation)
                .Include(e => e.IdTipoNavigation)
                .Include(e => e.IdEstadoNavigation)
                .Include(e => e.IdClienteNavigation)
                .Where(e => e.IdEstado == idEstadoPendienteReparacion)
                .ToList();
        }
    }
}
