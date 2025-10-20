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

        public Equipo? GetById(int idEquipo)
        {
            return _db.Equipos
                .Include(e => e.IdMarcaNavigation)
                .Include(e => e.IdTipoNavigation)
                .Include(e => e.IdEstadoNavigation)
                .Include(e => e.IdClienteNavigation)
                .FirstOrDefault(e => e.IdEquipo == idEquipo);
        }

        public List<Equipo> ListarEquipos()
        {
            return _db.Equipos
                .Include(e => e.IdMarcaNavigation)
                .Include(e => e.IdTipoNavigation)
                .Include(e => e.IdEstadoNavigation)
                .Include(e => e.IdClienteNavigation)
                .ToList();
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

        public (bool ok, string? error, Equipo? equipo) Crear(
        string nombre, int idCliente, int idMarca, int idTipo, int idEstado)
        {
            try
            {
                if (!_db.Clientes.Any(c => c.IdCliente == idCliente))
                    return (false, "Cliente no existe.", null);

                var nuevo = new Equipo
                {
                    Nombre = nombre.Trim(),
                    IdCliente = idCliente,
                    IdMarca = idMarca,
                    IdEstado = idEstado,
                    IdTipo = idTipo
                };

                _db.Equipos.Add(nuevo);
                _db.SaveChanges(); // completa nuevo.idCliente

                return (true, null, nuevo);
            }
            catch (Exception ex)
            {
                return (false, "Error al guardar: " + ex.Message, null);
            }
        }

        public (bool ok, string error, Equipo equipo) Actualizar(
        int idEquipo, string nombre, int idCliente, int idMarca, int idTipo, int idEstado)
        {
            try
            {
                var e = _db.Equipos.FirstOrDefault(x => x.IdEquipo == idEquipo);
                if (e == null) return (false, "Equipo no encontrado.", null!);
                e.Nombre = nombre.Trim();
                e.IdCliente = idCliente;
                e.IdMarca = idMarca; 
                e.IdTipo = idTipo;
                e.IdEstado = idEstado;

                _db.SaveChanges();
                return (true, null!, e);
            }
            catch (Exception ex)
            {
                return (false, "Error al guardar: " + ex.Message, null!);
            }
        }

        public List<Marca> ListarMarcas()
        {
            return _db.Marcas.ToList();
        }

        public List<TipoEquipo> ListarTipos()
        {
            return _db.TipoEquipos.ToList();
        }

        public List<EstadoEquipo> ListarEstados()
        {
            return _db.EstadoEquipos.ToList();
        }
    }
}
