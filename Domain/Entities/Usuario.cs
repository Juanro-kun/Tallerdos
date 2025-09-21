using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taller_2_Gestor.Domain.Entities;

public partial class Usuario
{
    [Key]
    [Column("idUsuario")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int idUsuario { get; set; }

    public string Mail { get; set; } = null!;

    public string Contrasena { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public byte Rol { get; set; }

    public bool Active { get; set; }

    public virtual Rol RolNavigation { get; set; } = null!;

    public string RolNombre => RolNavigation != null ? RolNavigation.Nombre : string.Empty;
}
