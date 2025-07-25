using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
[Table("Bd_perfeccionamiento")]
public partial class BdPerfeccionamiento
{
    [Column("Cod_perfeccionamiento")]
    [StringLength(20)]
    [Unicode(false)]
    public string CodPerfeccionamiento { get; set; } = null!;

    [StringLength(40)]
    [Unicode(false)]
    public string Perfeccionamiento { get; set; } = null!;

    public float Puntaje { get; set; }

    [Column("Cod_1")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Cod1 { get; set; }
}
