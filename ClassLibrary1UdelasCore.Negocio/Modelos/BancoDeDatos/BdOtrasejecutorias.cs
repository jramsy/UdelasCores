using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
[Table("Bd_otrasejecutorias")]
public partial class BdOtrasejecutorias
{
    [Column("Cod_otrasejec")]
    [StringLength(20)]
    [Unicode(false)]
    public string CodOtrasejec { get; set; } = null!;

    [StringLength(40)]
    [Unicode(false)]
    public string? Otrasejecutorias { get; set; }

    public float? Puntaje { get; set; }

    [Column("cod_1")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Cod1 { get; set; }
}
