using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller_2_Gestor.Domain.Entities;
using Taller_2_Gestor.Infra;

namespace Taller_2_Gestor.Features.Ordenes
{
    internal class OrdenesService
    {
        private readonly AppDbContext _db;

        public OrdenesService(AppDbContext db)
        {
            _db = db;
        }

        public List<OrdenServicio> ListarOrdenes()
        {
            return _db.OrdenServicios.ToList();
        }

        public List<ItemPresupuesto> ItemsPorOrden(int idOrden)
        {
            return _db.ItemPresupuestos.Where(i => i.IdOrden == idOrden).ToList();
        }

        public List<OrdenServicio> ListarOrdenesPorTecnico(int idTecnico)
        {
            return _db.OrdenServicios.Where(o => o.IdTecnico == idTecnico).ToList();
        }
    }
}
