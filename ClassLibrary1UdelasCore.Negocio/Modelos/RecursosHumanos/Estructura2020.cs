using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Keyless]
public partial class Estructura2020
{
    [Column("CEDULA")]
    [StringLength(255)]
    public string? Cedula { get; set; }

    [Column("FUNCIONARIO")]
    [StringLength(255)]
    public string? Funcionario { get; set; }

    [StringLength(5)]
    public string? Sexo { get; set; }

    [Column("POSICION")]
    public int? Posicion { get; set; }

    public int? Partida { get; set; }

    [StringLength(7)]
    public string CodCargo { get; set; } = null!;

    [StringLength(255)]
    public string? Cargo { get; set; }

    [Column("SALARIO", TypeName = "decimal(18, 2)")]
    public decimal? Salario { get; set; }

    [Column("SOBRESUELDO", TypeName = "decimal(18, 2)")]
    public decimal? Sobresueldo { get; set; }

    [Column("GASTO_REP", TypeName = "decimal(18, 2)")]
    public decimal? GastoRep { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaTngreso { get; set; }
}
