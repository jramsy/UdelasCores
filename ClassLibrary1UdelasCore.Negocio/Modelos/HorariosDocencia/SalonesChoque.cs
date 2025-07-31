using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class SalonesChoque
{
    [Column("numero_dia")]
    public int NumeroDia { get; set; }

    [Column("numero_hora")]
    public int NumeroHora { get; set; }

    [Column("salon")]
    [StringLength(5)]
    [Unicode(false)]
    public string Salon { get; set; } = null!;

    [Column("edificio")]
    [StringLength(5)]
    [Unicode(false)]
    public string Edificio { get; set; } = null!;

    public int? Expr1 { get; set; }
}
