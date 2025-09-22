using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_2_Gestor.Features.Shared
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Correo { get; set; } = "";
        public string Nombre { get; set; } = "";
        public string Apellido { get; set; } = "";
        public string Telefono { get; set; } = "";
        public string Dni { get; set; } = ""; // string para no perder ceros
    }

    public class Equipo
    {
        public int ID { get; set; }
        public string Marca { get; set; } = "";
        public string Tipo { get; set; } = "";
        public string Estado { get; set; } = ""; // En reparacion | Listo | Pendiente de revision
    }

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
        public static List<Cliente> GetClientes()
        {
            return new List<Cliente>
        {
            new Cliente { ID = 1,  Correo = "ana.lopez@example.com",     Nombre = "Ana",       Apellido = "López",     Telefono = "(379) 412-3456", Dni = "24567890" },
            new Cliente { ID = 2,  Correo = "juan.perez@correo.com",      Nombre = "Juan",      Apellido = "Pérez",     Telefono = "(379) 431-2299", Dni = "30511222" },
            new Cliente { ID = 3,  Correo = "carla.gomez@mail.com",       Nombre = "Carla",     Apellido = "Gómez",     Telefono = "(379) 420-7788", Dni = "31890543" },
            new Cliente { ID = 4,  Correo = "martin.fernandez@dom.com",   Nombre = "Martín",    Apellido = "Fernández", Telefono = "(379) 448-9012", Dni = "27900456" },
            new Cliente { ID = 5,  Correo = "lucia.rodri@gmail.com",      Nombre = "Lucía",     Apellido = "Rodríguez", Telefono = "(379) 455-6677", Dni = "33221456" },
            new Cliente { ID = 6,  Correo = "diego.sosa@ejemplo.com",     Nombre = "Diego",     Apellido = "Sosa",      Telefono = "(379) 426-0044", Dni = "28765012" },
            new Cliente { ID = 7,  Correo = "flor.martinez@correo.com",   Nombre = "Florencia", Apellido = "Martínez",  Telefono = "(379) 415-8899", Dni = "36123456" },
            new Cliente { ID = 8,  Correo = "nicolas.romero@mail.com",    Nombre = "Nicolás",   Apellido = "Romero",    Telefono = "(379) 440-1212", Dni = "29987654" },
            new Cliente { ID = 9,  Correo = "valen.alvarez@example.com",  Nombre = "Valentina", Apellido = "Álvarez",   Telefono = "(379) 490-7788", Dni = "35220987" },
            new Cliente { ID = 10, Correo = "tomas.herrera@dom.com",      Nombre = "Tomás",     Apellido = "Herrera",   Telefono = "(379) 422-3344", Dni = "31456789" },
        };
        }
        public static List<Equipo> GetEquipos()
        {
            return new List<Equipo>
        {
            new Equipo { ID = 1,  Marca = "Lenovo",     Tipo = "Notebook",          Estado = "En reparacion" },
            new Equipo { ID = 2,  Marca = "HP",         Tipo = "PC de escritorio",  Estado = "Pendiente de revision" },
            new Equipo { ID = 3,  Marca = "Samsung",    Tipo = "Celular",           Estado = "Listo" },
            new Equipo { ID = 4,  Marca = "Epson",      Tipo = "Impresora",         Estado = "En reparacion" },
            new Equipo { ID = 5,  Marca = "Dell",       Tipo = "Notebook",          Estado = "Listo" },
            new Equipo { ID = 6,  Marca = "Asus",       Tipo = "Notebook",          Estado = "Pendiente de revision" },
            new Equipo { ID = 7,  Marca = "Brother",    Tipo = "Impresora",         Estado = "Listo" },
            new Equipo { ID = 8,  Marca = "Motorola",   Tipo = "Celular",           Estado = "En reparacion" },
            new Equipo { ID = 9,  Marca = "PlayStation",Tipo = "Consola",           Estado = "Pendiente de revision" },
            new Equipo { ID = 10, Marca = "AOC",        Tipo = "Monitor",           Estado = "Listo" },
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
