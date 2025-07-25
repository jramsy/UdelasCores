using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Table("Sub_Nivels")]
public partial class SubNivels
{
    [Key]
    [Column("Cod_Sub_Nivel")]
    public int CodSubNivel { get; set; }

    [Column("Nombre_Sub_Nivel")]
    [StringLength(50)]
    public string NombreSubNivel { get; set; } = null!;

    [Column("Cod_Nivel")]
    public int CodNivel { get; set; }
}
