using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller_2_Gestor.Infra;
using Taller_2_Gestor.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Taller_2_Gestor.Features.Centro_de_Tareas_Administrador
{
    internal class TareasAdminService
    {
        private readonly AppDbContext _db;

        public TareasAdminService(AppDbContext db)
        {
            _db = db;
        }

        public List<Presupuesto> ListarPresupuestosPendientesDeAprobacion()
        {
            return _db.Presupuestos
                .Where(p => p.IdEstado == 1)
                .Include(p => p.IdEquipoNavigation)
                    .ThenInclude(e => e.IdClienteNavigation)
                .ToList();
        }

        public Presupuesto ObtenerPresupuesto(int idPresupuesto)
        {
            return _db.Presupuestos
                .Include(p => p.IdEquipoNavigation)
                    .ThenInclude(e => e.IdClienteNavigation)
                .FirstOrDefault(p => p.IdPresupuesto == idPresupuesto);
        }

        public List<ItemPresupuesto> ItemsNecesariosPorPresupuesto(int idPresupuesto)
        {
            return _db.ItemPresupuestos
                .Where(ip => ip.IdPresupuesto == idPresupuesto && ip.Necesario == true)
                .Include(ip => ip.IdServicioNavigation)
                .ToList();
        }

        public List<ItemPresupuesto> ItemsOpcionalesPorPresupuesto(int idPresupuesto)
        {
            return _db.ItemPresupuestos
                .Where(ip => ip.IdPresupuesto == idPresupuesto && ip.Necesario == false)
                .Include(ip => ip.IdServicioNavigation)
                .ToList();
        }

        public void ModificarEstadoPresupuesto(int idPresupuesto, int nuevoEstado)
        {
            var presupuesto = _db.Presupuestos.FirstOrDefault(p => p.IdPresupuesto == idPresupuesto);
            if (presupuesto != null)
            {
                presupuesto.IdEstado = nuevoEstado;
                presupuesto.FechaActualizacion = DateTime.Now;
                _db.SaveChanges();
            }
        }

        public void ModificarEstadoItemPresupuesto(int idPresupuesto, int nFila, int nuevoEstado)
        {
            var item = _db.ItemPresupuestos.FirstOrDefault(ip => ip.IdPresupuesto == idPresupuesto && ip.NFila == nFila);
            if (item != null)
            {
                item.IdEstado = nuevoEstado;
                _db.SaveChanges();
            }
        }

        public void ModificarEstadoEquipo(int idEquipo, int nuevoEstado)
        {
            var equipo = _db.Equipos.FirstOrDefault(e => e.IdEquipo == idEquipo);
            if (equipo != null)
            {
                equipo.IdEstado = nuevoEstado;
                _db.SaveChanges();
            }
        }
    }
}
