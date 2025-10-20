using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taller_2_Gestor.Domain.Entities;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string? Mail { get; set; }

    public string Contrasena { get; set; } = null!;

    public bool Active { get; set; }

    public byte IdRol { get; set; }

    public string RolNombre => IdRolNavigation.NombreRol;

    public virtual Rol IdRolNavigation { get; set; } = null!;

    public virtual ICollection<Presupuesto> PresupuestoIdAdministradorNavigations { get; set; } = new List<Presupuesto>();

    public virtual ICollection<Presupuesto> PresupuestoIdTecnicoNavigations { get; set; } = new List<Presupuesto>();
}
