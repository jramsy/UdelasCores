using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
[Table("Bd_ejecutoria")]
public partial class BdEjecutoria
{
    [Column("Cod_ejecutoria")]
    [StringLength(20)]
    [Unicode(false)]
    public string CodEjecutoria { get; set; } = null!;

    [StringLength(40)]
    [Unicode(false)]
    public string Ejecutoria { get; set; } = null!;

    public float Puntaje { get; set; }

    [Column("Cod_1")]
    public int? Cod1 { get; set; }
}
