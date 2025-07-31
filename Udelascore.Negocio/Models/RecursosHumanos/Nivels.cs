using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class Nivels
{
    [Key]
    [Column("Cod_Nivel")]
    public int CodNivel { get; set; }

    [Column("Nombre_Nivel")]
    [StringLength(50)]
    public string NombreNivel { get; set; } = null!;
}
