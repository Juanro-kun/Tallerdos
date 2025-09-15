using System;
using System.Collections.Generic;

namespace Taller_2_Gestor.Data.EF;

public partial class Rol
{
    public short idRol { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
