using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
[Table("Bd_OtrosEstudios")]
public partial class BdOtrosEstudios
{
    [Column("Cod_estudio")]
    public int CodEstudio { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Estudio { get; set; }

    public int? Puntos { get; set; }

    [Column("Cod_1")]
    public int? Cod1 { get; set; }

    [Column("Cod_2")]
    public int? Cod2 { get; set; }
}
