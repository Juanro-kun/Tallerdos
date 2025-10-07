using System;
using System.Collections.Generic;

namespace Taller_2_Gestor.Domain.Entities;

public partial class OrdenServicio
{
    public DateOnly Fecha { get; set; }

    public int IdPresupuesto { get; set; }

    public virtual Presupuesto IdPresupuestoNavigation { get; set; } = null!;

    public virtual ICollection<ItemPresupuesto> ItemPresupuestos { get; set; } = new List<ItemPresupuesto>();
}
