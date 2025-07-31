using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
[Table("Bd_turno")]
public partial class BdTurno
{
    [Column("Cod_turno")]
    public int CodTurno { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Turno { get; set; }

    [Column("Cod_1")]
    public int? Cod1 { get; set; }

    [Column("Cod_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Cod2 { get; set; }

    [Column("Cod_3")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Cod3 { get; set; }
}
