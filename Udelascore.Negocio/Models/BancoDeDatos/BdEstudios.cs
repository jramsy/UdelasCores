using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
[Table("Bd_estudios")]
public partial class BdEstudios
{
    [Column("Cod_estudio")]
    [StringLength(20)]
    [Unicode(false)]
    public string CodEstudio { get; set; } = null!;

    [StringLength(40)]
    [Unicode(false)]
    public string Estudio { get; set; } = null!;

    public float Puntaje { get; set; }

    [Column("Cod_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Cod1 { get; set; }
}
