using System;
using System.Collections.Generic;

namespace Taller_2_Gestor.Domain.Entities;

public partial class Presupuesto
{
    public int IdPresupuesto { get; set; }

    public int IdTecnico { get; set; }

    public int IdAdministrador { get; set; }

    public int IdEquipo { get; set; }

    public virtual Usuario IdAdministradorNavigation { get; set; } = null!;

    public virtual Equipo IdEquipoNavigation { get; set; } = null!;

    public virtual Usuario IdTecnicoNavigation { get; set; } = null!;

    public virtual ICollection<ItemPresupuesto> ItemPresupuestos { get; set; } = new List<ItemPresupuesto>();

    public virtual OrdenServicio? OrdenServicio { get; set; }
}
