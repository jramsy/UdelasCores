using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
[Table("Bd_usuarios")]
public partial class BdUsuarios
{
    [Column("usuario")]
    [StringLength(50)]
    [Unicode(false)]
    public string Usuario { get; set; } = null!;

    [Column("clave")]
    [StringLength(50)]
    [Unicode(false)]
    public string Clave { get; set; } = null!;

    [Column("cod_a")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CodA { get; set; }

    [Column("cod_b")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CodB { get; set; }
}
