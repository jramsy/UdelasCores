using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Table("ESTRUCTURA_CONTINGENTE")]
public partial class EstructuraContingente
{
    [Key]
    public int IdEstructura { get; set; }

    [Column("partida")]
    [StringLength(255)]
    public string? Partida { get; set; }

    [Column("NumeroPosicion_cargo")]
    [StringLength(255)]
    public string? NumeroPosicionCargo { get; set; }

    [StringLength(255)]
    public string? Cargo { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Sueldo1 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? M1 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Sueldo2 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? M2 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Sueldo3 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? M3 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Sueldo4 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? M4 { get; set; }

    [Column("AHORRO", TypeName = "decimal(18, 2)")]
    public decimal? Ahorro { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? SueldoAnual { get; set; }

    [Column("Gastos_de_Representacion")]
    [StringLength(255)]
    public string? GastosDeRepresentacion { get; set; }

    [StringLength(255)]
    public string? SobreSueldo { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? SueldoPlanilla { get; set; }

    [StringLength(100)]
    public string? Nombre { get; set; }

    [StringLength(255)]
    public string? Cedula { get; set; }

    [Column("Total_Posiciones")]
    [StringLength(255)]
    public string? TotalPosiciones { get; set; }

    [Column("CAT")]
    [StringLength(255)]
    public string? Cat { get; set; }

    [StringLength(255)]
    public string? Clase { get; set; }

    [Column("QN1")]
    [StringLength(255)]
    public string? Qn1 { get; set; }

    [StringLength(5)]
    public string? Posicion { get; set; }
}
