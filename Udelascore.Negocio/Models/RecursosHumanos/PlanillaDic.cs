using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Keyless]
public partial class PlanillaDic
{
    public int IdPlanillaDic { get; set; }

    [Column("CEDULA")]
    [StringLength(25)]
    public string? Cedula { get; set; }

    [Column("NOMBRE")]
    [StringLength(255)]
    public string? Nombre { get; set; }

    [Column("APELLIDO")]
    [StringLength(255)]
    public string? Apellido { get; set; }

    [Column("SEXO")]
    [StringLength(255)]
    public string? Sexo { get; set; }

    [Column("MONTO", TypeName = "decimal(18, 2)")]
    public decimal? Monto { get; set; }

    [Column("DECIMO_D", TypeName = "decimal(18, 2)")]
    public decimal? DecimoD { get; set; }

    [Column("AREA")]
    [StringLength(5)]
    public string? Area { get; set; }

    [Column("BONO", TypeName = "decimal(18, 2)")]
    public decimal? Bono { get; set; }

    [Column("CEDULA2")]
    [StringLength(13)]
    public string? Cedula2 { get; set; }
}
