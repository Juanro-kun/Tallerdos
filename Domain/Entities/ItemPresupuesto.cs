using System;
using System.Collections.Generic;

namespace Taller_2_Gestor.Domain.Entities;

public partial class ItemPresupuesto
{
    public int NFila { get; set; }

    public double Precio { get; set; }

    public int IdPresupuesto { get; set; }

    public int IdServicio { get; set; }

    public int IdEstado { get; set; }

    public virtual EstadoItem IdEstadoNavigation { get; set; } = null!;

    public virtual Presupuesto IdPresupuesto1 { get; set; } = null!;

    public virtual OrdenServicio IdPresupuestoNavigation { get; set; } = null!;

    public virtual Servicio IdServicioNavigation { get; set; } = null!;
}
