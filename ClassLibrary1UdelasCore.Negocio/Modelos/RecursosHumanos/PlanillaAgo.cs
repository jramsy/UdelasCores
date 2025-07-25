using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Keyless]
public partial class PlanillaAgo
{
    [StringLength(255)]
    public string? Cedula { get; set; }

    [StringLength(255)]
    public string? Nombre { get; set; }

    [StringLength(255)]
    public string? Apellido { get; set; }

    [StringLength(255)]
    public string? Sexo { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Monto { get; set; }

    [StringLength(5)]
    public string? Area { get; set; }

    [StringLength(50)]
    public string? Cedula2 { get; set; }

    public int Id { get; set; }
}
