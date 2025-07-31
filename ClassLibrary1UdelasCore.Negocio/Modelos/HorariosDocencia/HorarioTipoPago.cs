using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class HorarioTipoPago
{
    [Column("id_curso")]
    public int IdCurso { get; set; }

    [Column("tipo_pago")]
    [StringLength(15)]
    [Unicode(false)]
    public string TipoPago { get; set; } = null!;

    [Column("t")]
    public int? T { get; set; }
}
