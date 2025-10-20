using System;
using System.Collections.Generic;

namespace Taller_2_Gestor.Domain.Entities;

public partial class EstadoPresupuesto
{
    public int IdEstado { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Presupuesto> Presupuestos { get; set; } = new List<Presupuesto>();
}
