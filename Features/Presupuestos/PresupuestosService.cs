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
    }
}
