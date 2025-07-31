using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
[Table("Bd_Publicaciones")]
public partial class BdPublicaciones
{
    [Column("Cod_publicacion")]
    [StringLength(20)]
    [Unicode(false)]
    public string CodPublicacion { get; set; } = null!;

    [StringLength(40)]
    [Unicode(false)]
    public string? Publicacion { get; set; }

    public float? Puntaje { get; set; }

    [Column("Cod_1")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Cod1 { get; set; }
}
