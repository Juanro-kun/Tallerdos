using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller_2_Gestor.Infra;
using Taller_2_Gestor.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Taller_2_Gestor.Domain;

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

        public List<Equipo> ListarEquiposPendientesDeContacto()
        {
            return _db.Equipos
                .Where(e => e.IdEstado == 3)
                .Include(e => e.IdClienteNavigation)
                .Include(e => e.IdMarcaNavigation)
                .Include(e => e.IdTipoNavigation)
                .ToList();
        }

        public List<Presupuesto> ListarPresupuestosPospuestosParaConsultar()
        {
            return _db.Presupuestos
                .Where(p => p.IdEstado == 6)
                .Include(p => p.IdEquipoNavigation)
                    .ThenInclude(e => e.IdClienteNavigation)
                .Include(p => p.IdEquipoNavigation)
                    .ThenInclude(e => e.IdMarcaNavigation)
                .Include(p => p.IdEquipoNavigation)
                    .ThenInclude(e => e.IdTipoNavigation)
                .ToList();
        }

        public List<Equipo> ListarEquiposListosParaRetiro()
        {
            return _db.Equipos
                .Where(e => e.IdEstado == 5)
                .Include(e => e.IdClienteNavigation)
                .Include(e => e.IdMarcaNavigation)
                .Include(e => e.IdTipoNavigation)
                .ToList();
        }

        public List<ItemPresupuesto> ItemsPospuestosNoNecesarios(int idPresupuesto)
        {
            return _db.ItemPresupuestos
                .Where(ip => ip.IdPresupuesto == idPresupuesto && ip.Necesario == false && ip.IdEstado == 4)
                .Include(ip => ip.IdServicioNavigation)
                .ToList();
        }

        public int CantidadDeItemsAprobadosOPospuestosPorPresupuesto(int idPresupuesto)
        {
            return _db.ItemPresupuestos
                .Count(ip => ip.IdPresupuesto == idPresupuesto && (ip.IdEstado == 2 || ip.IdEstado == 4));
        }

        public void CargarAdminAPresupuesto(int idPresupuesto)
        {
            _db.Presupuestos
                .Where(p => p.IdPresupuesto == idPresupuesto)
                .ToList()
                .ForEach(p => p.IdAdministrador = UserSession.Current.Id); // Asumiendo que el ID del admin es 1
            _db.SaveChanges();
        }

        public int CantidadTotalDeItemsPorPresupuesto(int idPresupuesto)
        {
            return _db.ItemPresupuestos
                .Count(ip => ip.IdPresupuesto == idPresupuesto);
        }

        public void RechazarTodosLosItemsDePresupuesto(int idPresupuesto)
        {
            // 1. Obtener todos los ItemPresupuestos que pertenecen al ID dado.
            var itemsAActualizar = _db.ItemPresupuestos
                .Where(ip => ip.IdPresupuesto == idPresupuesto)
                .ToList(); // Carga la lista en memoria para poder modificarla

            // 2. Iterar y actualizar la propiedad IdEstado.
            foreach (var item in itemsAActualizar)
            {
                item.IdEstado = 3;
            }

            // 3. Guardar los cambios en la base de datos.
            // EF Core rastrea automáticamente los cambios realizados en las entidades cargadas.
            _db.SaveChanges();
        }
    }
}
