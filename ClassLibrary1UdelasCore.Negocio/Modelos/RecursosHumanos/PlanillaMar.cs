using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Keyless]
public partial class PlanillaMar
{
    [Column("CEDULA")]
    [StringLength(255)]
    public string? Cedula { get; set; }

    [Column("APELLIDO")]
    [StringLength(255)]
    public string? Apellido { get; set; }

    [Column("NOMBRE")]
    [StringLength(255)]
    public string? Nombre { get; set; }

    [Column("MONTO", TypeName = "decimal(18, 2)")]
    public decimal? Monto { get; set; }

    [Column("AREA")]
    [StringLength(255)]
    public string? Area { get; set; }

    [Column("CEDULA2")]
    [StringLength(50)]
    public string? Cedula2 { get; set; }
}
