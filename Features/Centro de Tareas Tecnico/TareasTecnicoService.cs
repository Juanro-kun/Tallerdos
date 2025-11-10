using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller_2_Gestor.Domain.Entities;
using Taller_2_Gestor.Infra;
using Taller_2_Gestor.Domain;

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
            int idEstadoPendienteReparacion = 4;
            return _db.Equipos
                .Include(e => e.IdMarcaNavigation)
                .Include(e => e.IdTipoNavigation)
                .Include(e => e.IdEstadoNavigation)
                .Include(e => e.IdClienteNavigation)
                .Where(e => e.IdEstado == idEstadoPendienteReparacion)
                .ToList();
        }

        public List<Servicio> ListarServicios()
        {
            return _db.Servicios.ToList();
        }

        public int CrearPresupuesto(int idEquipo, int idTecnico)
        {
            var nuevoPresupuesto = new Presupuesto
            {
                IdEquipo = idEquipo,
                IdTecnico = idTecnico,
                IdEstado = 1,
                FechaActualizacion = DateTime.Now
            };
            _db.Presupuestos.Add(nuevoPresupuesto);
            _db.SaveChanges();
            return nuevoPresupuesto.IdPresupuesto;
        }

        public void CrearItemPresupuesto(int nfila, int idPresupuesto, double precio, int idServicio, bool necesario)
        {
            var nuevoItem = new ItemPresupuesto
            {
                NFila = nfila,
                IdPresupuesto = idPresupuesto,
                Precio = precio,
                IdServicio = idServicio,
                IdEstado = 1,
                Necesario = necesario
            };
            _db.ItemPresupuestos.Add(nuevoItem);
            _db.SaveChanges();
        }

        public void ActualizarEstadoEquipo(int idEquipo, int nuevoEstado)
        {
            var equipo = _db.Equipos.FirstOrDefault(e => e.IdEquipo == idEquipo);
            if (equipo != null)
            {
                equipo.IdEstado = nuevoEstado;
                _db.SaveChanges();
            }
        }

        public List<Presupuesto> ListarPresupuestosAprobados()
        {
            int idEstadoAprobado = 2;
            return _db.Presupuestos
                .Where(p => p.IdEstado == idEstadoAprobado)
                .Include(p => p.IdEquipoNavigation) // Incluye la primera navegación: Presupuesto -> Equipo
                    .ThenInclude(e => e.IdClienteNavigation) // Incluye la navegación Cliente a través de Equipo
                .Include(p => p.IdEquipoNavigation) // (Opcional, pero claro) Vuelve a la navegación Equipo
                    .ThenInclude(e => e.IdMarcaNavigation) // Incluye la navegación Marca a través de Equipo
                .Include(p => p.IdEquipoNavigation) // (Opcional, pero claro) Vuelve a la navegación Equipo
                    .ThenInclude(e => e.IdTipoNavigation) // Incluye la navegación Tipo a través de Equipo
                .ToList();
        }

        public List<ItemPresupuesto> ListarItemsAprobadosPresupuesto(int idPresupuesto)
        {
            return _db.ItemPresupuestos
                .Where(ip => ip.IdPresupuesto == idPresupuesto && ip.IdEstado == 2)
                .Include(ip => ip.IdServicioNavigation)
                .ToList();
        }

        public Presupuesto ObtenerPresupuesto(int idPresupuesto)
        {
            return _db.Presupuestos
                .Include(p => p.IdEquipoNavigation)
                    .ThenInclude(e => e.IdClienteNavigation)
                .Include(p => p.IdEquipoNavigation)
                    .ThenInclude(e => e.IdMarcaNavigation)
                .Include(p => p.IdEquipoNavigation)
                    .ThenInclude(e => e.IdTipoNavigation)
                .FirstOrDefault(p => p.IdPresupuesto == idPresupuesto);
        }

        public void ActualizarEstadoPresupuesto(int idPresupuesto, int nuevoEstado)
        {
            var presupuesto = _db.Presupuestos.FirstOrDefault(p => p.IdPresupuesto == idPresupuesto);
            if (presupuesto != null)
            {
                presupuesto.IdEstado = nuevoEstado;
                _db.SaveChanges();
            }
        }

        public void CrearOrdenServicio(int idPresupuesto)
        {
            var nuevaOrden = new OrdenServicio
            {
                IdPresupuesto = idPresupuesto,
                Fecha = DateTime.Now,
                IdTecnico = UserSession.Current.Id
            };
            _db.OrdenServicios.Add(nuevaOrden);
            _db.SaveChanges();
        }

        public void ActualizarEstadoItemPresupuesto(int idPresupuesto, int nfila, int nuevoEstado)
        {
            var item = _db.ItemPresupuestos.FirstOrDefault(ip => ip.IdPresupuesto == idPresupuesto && ip.NFila == nfila);
            if (item != null)
            {
                item.IdEstado = nuevoEstado;
                _db.SaveChanges();
            }
        }

        public void CargarOrdenAItem(int idPresupuesto, int nfila)
        {
            var item = _db.ItemPresupuestos.FirstOrDefault(ip => ip.IdPresupuesto == idPresupuesto && ip.NFila == nfila);
            if (item != null)
            {
                item.IdOrden = idPresupuesto;
                _db.SaveChanges();
            }
        }

        public void CrearComentario(int idPresupuesto, string textoComentario)
        {
            int siguienteIdComentario = _db.Comentarios
            .Where(c => c.IdPresupuesto == idPresupuesto)
            .Max(c => (int?)c.IdComentario) ?? 0;

            siguienteIdComentario += 1;

            var nuevoComentario = new Comentario
            {
                IdComentario = siguienteIdComentario,
                IdPresupuesto = idPresupuesto,
                Detalle = textoComentario,
                Fecha = DateTime.Now,
                TecnicoId = UserSession.Current.Id
            };
            _db.Comentarios.Add(nuevoComentario);
            _db.SaveChanges();
        }

        public List<Presupuesto> ListarPresupuestosAprobadosOPospuestosARevisar()
        {
            int idEstadoAprobado = 2;
            return _db.Presupuestos
                .Where(p => p.IdEstado == idEstadoAprobado || p.FechaActualizacion >= DateTime.Today.AddDays(-7))
                .Include(p => p.IdEquipoNavigation) // Incluye la primera navegación: Presupuesto -> Equipo
                    .ThenInclude(e => e.IdClienteNavigation) // Incluye la navegación Cliente a través de Equipo
                .Include(p => p.IdEquipoNavigation) // (Opcional, pero claro) Vuelve a la navegación Equipo
                    .ThenInclude(e => e.IdMarcaNavigation) // Incluye la navegación Marca a través de Equipo
                .Include(p => p.IdEquipoNavigation) // (Opcional, pero claro) Vuelve a la navegación Equipo
                    .ThenInclude(e => e.IdTipoNavigation) // Incluye la navegación Tipo a través de Equipo
                .ToList();
        }
    }
}
