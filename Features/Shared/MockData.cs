using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_2_Gestor.Features.Shared
{

    

    public class Item
    {
        public int IDpresupuesto { get; set; }
        public decimal Precio { get; set; }
        public string Servicio { get; set; } = "";
        public int? IDorden { get; set; }   // puede ser null
    }

    public class Presupuesto
    {
        public int ID { get; set; }
        public int IDtecnico { get; set; }
        public int IDadministrador { get; set; }
        public int IDequipo { get; set; }
    }

    public class Orden
    {
        public int IDorden { get; set; }
        public int IDequipo { get; set; }
    }

    public static class MockData
    {
        public static List<Orden> GetOrdenes()
        {
            return new List<Orden>
        {
            new Orden { IDorden = 5001, IDequipo = 1 },
            new Orden { IDorden = 5002, IDequipo = 2 },
            new Orden { IDorden = 5003, IDequipo = 3 },
            new Orden { IDorden = 5004, IDequipo = 4 },
            new Orden { IDorden = 5005, IDequipo = 5 },
            new Orden { IDorden = 5006, IDequipo = 6 },
            new Orden { IDorden = 5007, IDequipo = 7 },
            new Orden { IDorden = 5008, IDequipo = 8 },
            new Orden { IDorden = 5009, IDequipo = 9 },
            new Orden { IDorden = 5010, IDequipo = 10 },
        };
        }
        
        

        public static List<Item> GetItems()
        {
            return new List<Item>
        {
            new Item { IDpresupuesto = 1001, Precio = 12000m, Servicio = "Limpieza de teclado",                    IDorden = 5001 },
            new Item { IDpresupuesto = 1001, Precio = 45000m, Servicio = "Cambio de memoria (8→16 GB)",            IDorden = 5001 },
            new Item { IDpresupuesto = 1002, Precio = 38000m, Servicio = "Reemplazo a SSD 480 GB",                  IDorden = 5002 },
            new Item { IDpresupuesto = 1002, Precio = 15000m, Servicio = "Clonación y migración de sistema",        IDorden = 5002 },
            new Item { IDpresupuesto = 1003, Precio = 9000m,  Servicio = "Limpieza interna + pasta térmica",        IDorden = null },
            new Item { IDpresupuesto = 1003, Precio = 22000m, Servicio = "Cambio de batería",                        IDorden = null },
            new Item { IDpresupuesto = 1004, Precio = 18000m, Servicio = "Reinstalación de Windows + drivers",      IDorden = 5005 },
            new Item { IDpresupuesto = 1005, Precio = 60000m, Servicio = "Cambio de pantalla 14”",                  IDorden = 5006 },
            new Item { IDpresupuesto = 1006, Precio = 25000m, Servicio = "Reparación de placa de carga",            IDorden = null },
            new Item { IDpresupuesto = 1006, Precio = 12000m, Servicio = "Diagnóstico y test completos",            IDorden = null },
        };
        }

        public static List<Presupuesto> GetPresupuestos()
        {
            return new List<Presupuesto>
        {
            new Presupuesto { ID = 1001, IDtecnico = 201, IDadministrador = 301, IDequipo = 1 },
            new Presupuesto { ID = 1002, IDtecnico = 202, IDadministrador = 301, IDequipo = 2 },
            new Presupuesto { ID = 1003, IDtecnico = 203, IDadministrador = 302, IDequipo = 3 },
            new Presupuesto { ID = 1004, IDtecnico = 201, IDadministrador = 302, IDequipo = 4 },
            new Presupuesto { ID = 1005, IDtecnico = 204, IDadministrador = 301, IDequipo = 5 },
            new Presupuesto { ID = 1006, IDtecnico = 205, IDadministrador = 303, IDequipo = 6 },
            new Presupuesto { ID = 1007, IDtecnico = 202, IDadministrador = 303, IDequipo = 7 },
            new Presupuesto { ID = 1008, IDtecnico = 206, IDadministrador = 302, IDequipo = 8 },
            new Presupuesto { ID = 1009, IDtecnico = 205, IDadministrador = 301, IDequipo = 9 },
            new Presupuesto { ID = 1010, IDtecnico = 204, IDadministrador = 303, IDequipo = 10 },
        };
        }
    }
}
