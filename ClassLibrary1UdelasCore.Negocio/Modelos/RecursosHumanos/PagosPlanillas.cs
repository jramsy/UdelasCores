using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class PagosPlanillas
{
    [Key]
    public int IdPagosPlanillas { get; set; }

    [StringLength(1)]
    public string? CodArea { get; set; }

    [StringLength(2)]
    public string? CodEntidad { get; set; }

    [StringLength(255)]
    public string? Nombre { get; set; }

    [StringLength(255)]
    public string? Apellido { get; set; }

    [StringLength(2)]
    public string? CedProvincia { get; set; }

    [StringLength(2)]
    public string? CedIniciales { get; set; }

    [StringLength(4)]
    public string? CedTomo { get; set; }

    [StringLength(5)]
    public string? CedAsiento { get; set; }

    [StringLength(7)]
    public string? SeguroSocial2 { get; set; }

    [StringLength(9)]
    public string? Sueldo { get; set; }

    [StringLength(10)]
    public string? Patrono { get; set; }

    public int? TipoPago { get; set; }

    [StringLength(2)]
    public string? CodDependencia { get; set; }

    [StringLength(2)]
    public string? Provincia { get; set; }

    [StringLength(7)]
    public string? Cargo { get; set; }

    [StringLength(80)]
    public string? DescripcionCargo { get; set; }

    [StringLength(4)]
    public string? CedProvincia2 { get; set; }

    [StringLength(9)]
    public string? GastoRepresentacion { get; set; }

    [StringLength(10)]
    public string? FechaToma { get; set; }

    [StringLength(10)]
    public string? FechaSeparacion { get; set; }

    [StringLength(1)]
    public string? EmpleadoManejo { get; set; }

    [StringLength(30)]
    public string? Condicion { get; set; }

    [StringLength(25)]
    public string? Estado { get; set; }

    [StringLength(10)]
    public string? FechaRegistro { get; set; }

    [StringLength(1)]
    public string? Quincena { get; set; }

    [StringLength(2)]
    public string? Mes { get; set; }

    [StringLength(4)]
    public string? Anio { get; set; }

    [StringLength(1)]
    public string? Sexo { get; set; }

    [StringLength(2)]
    public string? Tipo { get; set; }

    [StringLength(255)]
    public string? Cedula { get; set; }

    [StringLength(15)]
    public string? CedulaPlanilla { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Monto { get; set; }

    [StringLength(50)]
    public string? SeguroSocial { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? GastoRep { get; set; }

    [StringLength(13)]
    public string? CedulaCorta { get; set; }

    [Column("Cod_Estructura")]
    [StringLength(5)]
    public string? CodEstructura { get; set; }

    [StringLength(1)]
    public string? Imprimir { get; set; }
}
