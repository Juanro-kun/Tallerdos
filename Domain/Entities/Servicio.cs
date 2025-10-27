using System;
using System.Collections.Generic;

namespace Taller_2_Gestor.Domain.Entities;

public partial class Servicio
{
    public int IdServicio { get; set; }

    public string NombreServicio { get; set; } = null!;

    public float Precio { get; set; }

    public virtual ICollection<ItemPresupuesto> ItemPresupuestos { get; set; } = new List<ItemPresupuesto>();
}
