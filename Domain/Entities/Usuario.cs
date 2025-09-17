using System;
using System.Collections.Generic;

namespace Taller_2_Gestor.Domain.Entities;

public partial class Usuario
{
    public int idUsuario { get; set; }

    public string mail { get; set; } = null!;

    public string contraseña { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public short Rol { get; set; }

    public bool Active { get; set; }

    public virtual Rol RolNavigation { get; set; } = null!;

    public string RolNombre => RolNavigation != null ? RolNavigation.Nombre : string.Empty;
}
