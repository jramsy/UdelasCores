using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
[Table("FechaSeparada$")]
public partial class FechaSeparada
{
    [StringLength(255)]
    public string? Cedula { get; set; }

    [Column("dia")]
    public double? Dia { get; set; }

    [Column("mes")]
    public double? Mes { get; set; }

    [Column("anio")]
    public double? Anio { get; set; }
}
