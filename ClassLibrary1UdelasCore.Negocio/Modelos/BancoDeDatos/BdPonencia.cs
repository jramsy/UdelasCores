using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
[Table("Bd_Ponencia")]
public partial class BdPonencia
{
    [Column("Cod_ponencia")]
    [StringLength(20)]
    [Unicode(false)]
    public string CodPonencia { get; set; } = null!;

    [StringLength(40)]
    [Unicode(false)]
    public string Ponencia { get; set; } = null!;

    public float Puntaje { get; set; }

    [Column("Cod_1")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Cod1 { get; set; }
}
