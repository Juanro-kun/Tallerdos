using System;
using System.Collections.Generic;

namespace Taller_2_Gestor.Domain.Entities;

public partial class Presupuesto
{
    public int IdPresupuesto { get; set; }

    public int IdTecnico { get; set; }

    public int? IdAdministrador { get; set; }

    public int IdEquipo { get; set; }

    public int IdEstado { get; set; }

    public DateTime FechaActualizacion { get; set; }

    public string DescripcionEquipo => IdEquipoNavigation.Nombre;

    public string NombreCliente => IdEquipoNavigation.NombreCompletoCliente;

    public string MailCliente => IdEquipoNavigation.MailCliente;

    public long TelefonoCliente => IdEquipoNavigation.TelefonoCliente;

    public virtual ICollection<Comentario> Comentarios { get; set; } = new List<Comentario>();

    public virtual Usuario IdAdministradorNavigation { get; set; } = null!;

    public virtual Equipo IdEquipoNavigation { get; set; } = null!;

    public virtual EstadoPresupuesto IdEstadoNavigation { get; set; } = null!;

    public virtual Usuario IdTecnicoNavigation { get; set; } = null!;

    public virtual ICollection<ItemPresupuesto> ItemPresupuestos { get; set; } = new List<ItemPresupuesto>();

    public virtual OrdenServicio? OrdenServicio { get; set; }
}
