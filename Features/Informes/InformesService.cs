using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller_2_Gestor.Infra;

namespace Taller_2_Gestor.Features.Informes
{
    internal class InformesService
    {
        private readonly AppDbContext _db;

        public InformesService(AppDbContext db)
        {
            _db = db;
        }

        public float CalcularTotalGenerado(DateTime desde, DateTime hasta)
        {
            return _db.ItemPresupuestos
                .Where(ip => ip.IdEstado == 5) // Estado 5 = 'Realizado'
                .Where(ip => ip.IdOrdenNavigation.Fecha >= desde && ip.IdOrdenNavigation.Fecha <= hasta)
                .Sum(ip => (float?)ip.Precio) ?? 0f;
        }

        public string ObtenerNombreServicioMasRepetido(DateTime desde, DateTime hasta)
        {
            var nombreServicio = _db.ItemPresupuestos
                // 1. Filtrar por estado 5.
                .Where(ip => ip.IdEstado == 5)
                // 2. FILTRAR POR RANGO DE FECHAS EN LA ORDEN DE SERVICIO.
                .Where(ip => ip.IdOrdenNavigation.Fecha >= desde && ip.IdOrdenNavigation.Fecha <= hasta)
                // 3. Agrupar por el IdServicio.
                .GroupBy(ip => ip.IdServicio)
                // 4. Ordenar los grupos por el tamaño (Conteo) de forma descendente.
                .OrderByDescending(g => g.Count())
                // 5. Seleccionar el NombreServicio del primer elemento (el más repetido).
                .Select(g => g.First().IdServicioNavigation.NombreServicio)
                // 6. Tomar el primer resultado de la selección.
                .FirstOrDefault();

            // Devuelve el nombre o un mensaje si no se encuentra.
            return nombreServicio ?? "No Data";
        }

        public string ObtenerTecnicoMasProductivo(DateTime desde, DateTime hasta)
        {
            var tecnicoMasProductivo = _db.ItemPresupuestos
                // 1. Filtrar los ItemPresupuestos que están en estado 'Realizado' (5).
                .Where(ip => ip.IdEstado == 5)
                // 2. Filtrar por el rango de fechas de la Orden de Servicio.
                .Where(ip => ip.IdOrdenNavigation.Fecha >= desde && ip.IdOrdenNavigation.Fecha <= hasta)
                // 3. Agrupar los ítems por el IdTecnico, navegando a través de la Orden de Servicio.
                .GroupBy(ip => ip.IdOrdenNavigation.IdTecnico)
                // 4. Ordenar los grupos por el tamaño (Conteo de ítems) de forma descendente.
                .OrderByDescending(g => g.Count()).Select(g => g.Key)
                // 5. Tomar el primer grupo (el Técnico con más ítems).
                .FirstOrDefault();

            // Si encontramos un técnico (el grupo no es nulo)
            if (tecnicoMasProductivo != null)
            {
                // 6. Usamos el IdTecnico del grupo para buscar el Nombre y Apellido en la tabla Usuario.
                //    Podríamos usar una JOIN/navegación, pero buscar el nombre aquí es a menudo más claro.
                var tecnicoInfo = _db.Usuarios
                    .Where(u => u.IdUsuario == tecnicoMasProductivo)
                    .Select(u => new { u.Nombre, u.Apellido })
                    .FirstOrDefault();

                if (tecnicoInfo != null)
                {
                    // Devolver el nombre completo.
                    return $"{tecnicoInfo.Nombre} {tecnicoInfo.Apellido}";
                }
            }

            // Si no se encontraron técnicos o ítems en el rango y estado.
            return "No data";
        }

        public string ObtenerTipoEquipoMasReparado(DateTime desde, DateTime hasta)
        {
            var nombreTipoEquipo = _db.Presupuestos
                // 1. Filtrar los presupuestos que indican una reparación finalizada (ajusta el '4' si tu estado es otro).
                .Where(p => p.IdEstado == 4)
                // 2. Filtrar por el rango de fechas de actualización del presupuesto.
                .Where(p => p.FechaActualizacion >= desde && p.FechaActualizacion <= hasta)
                // 3. Agrupar los presupuestos por el IdTipo del equipo.
                .GroupBy(p => p.IdEquipoNavigation.IdTipo)
                // 4. Ordenar los grupos por el tamaño (Conteo) de forma descendente.
                .OrderByDescending(g => g.Count())
                // 5. Seleccionar el Nombre del Tipo de Equipo del primer elemento.
                //    Navegamos a través de IdEquipoNavigation (Equipo) -> IdTipoNavigation (TipoEquipo) -> Nombre.
                .Select(g => g.First().IdEquipoNavigation.IdTipoNavigation.Nombre)
                // 6. Tomar el primer resultado de la selección (el Tipo más repetido).
                .FirstOrDefault();

            // Devuelve el nombre o un mensaje si no se encuentra.
            return nombreTipoEquipo ?? "No Data";
        }
    }
}
