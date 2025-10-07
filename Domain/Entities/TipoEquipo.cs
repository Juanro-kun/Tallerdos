using System;
using System.Collections.Generic;

namespace Taller_2_Gestor.Domain.Entities;

public partial class TipoEquipo
{
    public int IdTipo { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Equipo> Equipos { get; set; } = new List<Equipo>();
}
