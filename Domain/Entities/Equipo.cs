using System;
using System.Collections.Generic;

namespace Taller_2_Gestor.Domain.Entities;

public partial class Equipo
{
    public int IdEquipo { get; set; }

    public string Nombre { get; set; } = null!;

    public int IdMarca { get; set; }

    public string NombreMarca => IdMarcaNavigation.Nombre;

    public int IdTipo { get; set; }

    public string NombreTipo => IdTipoNavigation.Nombre;

    public int IdEstado { get; set; }

    public string NombreEstado => IdEstadoNavigation.Nombre;
    public int IdCliente { get; set; }
    public string NombreCliente => IdClienteNavigation.Nombre;
    public virtual Cliente IdClienteNavigation { get; set; } = null!;
    public virtual EstadoEquipo IdEstadoNavigation { get; set; } = null!;
    public virtual Marca IdMarcaNavigation { get; set; } = null!;
    public virtual TipoEquipo IdTipoNavigation { get; set; } = null!;
    public virtual ICollection<OrdenServicio> OrdenServicios { get; set; } = new List<OrdenServicio>();
    public virtual ICollection<Presupuesto> Presupuestos { get; set; } = new List<Presupuesto>();
}
