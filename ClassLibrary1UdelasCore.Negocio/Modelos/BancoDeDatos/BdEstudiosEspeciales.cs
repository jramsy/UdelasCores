using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
[Table("Bd_EstudiosEspeciales")]
public partial class BdEstudiosEspeciales
{
    [Column("postgrado")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Postgrado { get; set; }

    [Column("puntos")]
    public int? Puntos { get; set; }

    [Column("codigo")]
    public int? Codigo { get; set; }
}
