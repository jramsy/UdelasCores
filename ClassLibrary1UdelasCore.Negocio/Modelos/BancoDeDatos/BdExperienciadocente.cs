using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
[Table("Bd_experienciadocente")]
public partial class BdExperienciadocente
{
    [Column("Cod_experiencia")]
    [StringLength(20)]
    [Unicode(false)]
    public string CodExperiencia { get; set; } = null!;

    [StringLength(40)]
    [Unicode(false)]
    public string? Experiencia { get; set; }

    public float? Puntos { get; set; }

    [Column("Cod_1")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Cod1 { get; set; }
}
