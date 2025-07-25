using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Table("Num_Resueltos")]
public partial class NumResueltos
{
    [Key]
    [Column("ID_resuelto")]
    public int IdResuelto { get; set; }

    [Column("Num_resuelto")]
    [StringLength(10)]
    public string NumResuelto { get; set; } = null!;
}
