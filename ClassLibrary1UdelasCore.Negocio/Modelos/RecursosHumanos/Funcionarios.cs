using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Keyless]
public partial class Funcionarios
{
    public int? No { get; set; }

    [StringLength(255)]
    public string? Cedula { get; set; }

    [StringLength(255)]
    public string? Nombre { get; set; }

    [Column("SEDE")]
    [StringLength(255)]
    public string? Sede { get; set; }

    public double? CodSede { get; set; }
}
