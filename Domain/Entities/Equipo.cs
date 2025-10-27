using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taller_2_Gestor.Domain.Entities;

public partial class Equipo
{
    public int IdEquipo { get; set; }

    public string Nombre { get; set; } = null!;

    public int IdMarca { get; set; }

    public string NombreMarca => IdMarcaNavigation.Nombre;

    public int IdTipo { get; set; }

    public string NombreTipo => IdTipoNavigation.Nombre;

    public int IdEstado { get; set; }

    public string NombreEstado => IdEstadoNavigation.Nombre;

    public int IdCliente { get; set; }

    public string NombreCompletoCliente => $"{IdClienteNavigation.Nombre} {IdClienteNavigation.Apellido}";

    public string NombreCliente => IdClienteNavigation.Nombre;

    public string MailCliente => IdClienteNavigation.Mail;

    public long TelefonoCliente => IdClienteNavigation.Telefono;

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual EstadoEquipo IdEstadoNavigation { get; set; } = null!;

    public virtual Marca IdMarcaNavigation { get; set; } = null!;

    public virtual TipoEquipo IdTipoNavigation { get; set; } = null!;

    public virtual ICollection<Presupuesto> Presupuestos { get; set; } = new List<Presupuesto>();
}
