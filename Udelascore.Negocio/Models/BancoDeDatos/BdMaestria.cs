using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
[Table("Bd_Maestria")]
public partial class BdMaestria
{
    [Column("Cod_maest")]
    public int CodMaest { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Maestria { get; set; }

    public int? Puntos { get; set; }

    [Column("Cod_1")]
    public int? Cod1 { get; set; }

    [Column("Cod_2")]
    public int? Cod2 { get; set; }
}
