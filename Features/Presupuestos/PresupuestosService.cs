using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller_2_Gestor.Domain.Entities;
using Taller_2_Gestor.Infra;

namespace Taller_2_Gestor.Features.Presupuestos
{
    internal class PresupuestosService
    {
        private readonly AppDbContext _db;

        public PresupuestosService(AppDbContext db)
        {
            _db = db;
        }

        public List<ItemPresupuesto> ItemsPorEquipo(int idEquipo)
        {
            return _db.ItemPresupuestos
                .Include(i => i.IdPresupuestoNavigation)
                .Include(i => i.IdServicioNavigation)
                .Where(i => i.IdPresupuestoNavigation.IdEquipo == idEquipo)
                .ToList();
        }

        public List<Presupuesto> ListarPresupuestos()
        {
            return _db.Presupuestos
                .Include(p => p.IdEquipoNavigation)
                .Include(p => p.IdEstadoNavigation)
                .Include(p => p.IdTecnicoNavigation)
                .ToList();
        }

        public List<ItemPresupuesto> ItemsPorPresupuesto(int id)
        {
            return _db.ItemPresupuestos
                .Include(i => i.IdServicioNavigation)
                .Include(i => i.IdEstadoNavigation)
                .Where(i => i.IdPresupuesto == id)
                .ToList();
        }

        public List<Presupuesto> ListarPresupuestosPorTecnico(int idTecnico)
        {
            return _db.Presupuestos
                .Include(p => p.IdEquipoNavigation)
                .Include(p => p.IdEstadoNavigation)
                .Include(p => p.IdTecnicoNavigation)
                .Where(p => p.IdTecnico == idTecnico)
                .ToList();
        }

        public List<Presupuesto> ListarPresupuestosPorAdmin(int idAdmin)
        {
            return _db.Presupuestos
                .Include(p => p.IdEquipoNavigation)
                .Include(p => p.IdEstadoNavigation)
                .Include(p => p.IdTecnicoNavigation)
                .Where(p => p.IdAdministrador == idAdmin)
                .ToList();
        }
    }
}
