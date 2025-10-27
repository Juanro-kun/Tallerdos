using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taller_2_Gestor.Domain.Entities;

public partial class ItemPresupuesto
{
    public int NFila { get; set; }

    public int IdPresupuesto { get; set; }

    public double Precio { get; set; }

    public int? IdOrden { get; set; }

    public int IdServicio { get; set; }

    public string NombreServicio => IdServicioNavigation.NombreServicio;

    public int IdEstado { get; set; }

    public bool? Necesario { get; set; }

    public int IdEquipo => IdPresupuestoNavigation.IdEquipo;

    public virtual EstadoItem IdEstadoNavigation { get; set; } = null!;

    public virtual OrdenServicio? IdOrdenNavigation { get; set; }

    public virtual Presupuesto IdPresupuestoNavigation { get; set; } = null!;

    public virtual Servicio IdServicioNavigation { get; set; } = null!;
}
