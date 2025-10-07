using System;
using System.Collections.Generic;

namespace Taller_2_Gestor.Domain.Entities;

public partial class EstadoItem
{
    public int IdEstado { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<ItemPresupuesto> ItemPresupuestos { get; set; } = new List<ItemPresupuesto>();
}
