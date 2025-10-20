using System;
using System.Collections.Generic;

namespace Taller_2_Gestor.Domain.Entities;

public partial class Comentario
{
    public int IdComentario { get; set; }

    public int IdPresupuesto { get; set; }

    public string Detalle { get; set; } = null!;

    public DateOnly Fecha { get; set; }

    public virtual Presupuesto IdPresupuestoNavigation { get; set; } = null!;
}
