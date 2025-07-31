using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class PlanillaPorMeses
{
    [Key]
    public int PlanillaId { get; set; }

    [Column("CEDULA")]
    [StringLength(25)]
    public string Cedula { get; set; } = null!;

    [Column("NOMBRE")]
    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    [Column("APELLIDO")]
    [StringLength(50)]
    public string Apellido { get; set; } = null!;

    [Column("SEXO")]
    [StringLength(2)]
    public string Sexo { get; set; } = null!;

    [Column("MONTO", TypeName = "decimal(18, 2)")]
    public decimal Monto { get; set; }

    [Column("AREA")]
    [StringLength(2)]
    public string Area { get; set; } = null!;

    [Column("CEDULA2")]
    [StringLength(50)]
    public string Cedula2 { get; set; } = null!;

    [StringLength(2)]
    public string Mes { get; set; } = null!;

    [StringLength(4)]
    public string Anio { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime FechaRegistro { get; set; }

    [StringLength(20)]
    public string Usuario { get; set; } = null!;

    [Column("ISLR", TypeName = "decimal(18, 2)")]
    public decimal Islr { get; set; }

    [Column("CODISR")]
    [StringLength(2)]
    public string Codisr { get; set; } = null!;

    /// <summary>
    /// Dependientes
    /// </summary>
    [Column("DEPEND")]
    public int Depend { get; set; }

    [Column("DPTO")]
    [StringLength(2)]
    public string Dpto { get; set; } = null!;
}
