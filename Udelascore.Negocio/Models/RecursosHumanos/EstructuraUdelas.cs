using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Table("ESTRUCTURA_UDELAS")]
public partial class EstructuraUdelas
{
    [Key]
    [Column("IdEstructuraUDELAS")]
    public int IdEstructuraUdelas { get; set; }

    public int? CodArea { get; set; }

    public int? CodEntidad { get; set; }

    [Column("codigo_estructura")]
    [StringLength(255)]
    public string? CodigoEstructura { get; set; }

    [StringLength(255)]
    public string? Nombre { get; set; }

    [StringLength(255)]
    public string? Apellido { get; set; }

    [StringLength(255)]
    public string? Cedula { get; set; }

    [StringLength(255)]
    public string? SeguroSocial { get; set; }

    [Column("salario", TypeName = "numeric(18, 2)")]
    public decimal? Salario { get; set; }

    [Column("grepresentacion", TypeName = "numeric(18, 2)")]
    public decimal? Grepresentacion { get; set; }

    [Column("sobre_sueldo", TypeName = "numeric(18, 2)")]
    public decimal? SobreSueldo { get; set; }

    [StringLength(255)]
    public string? Patrono { get; set; }

    [StringLength(255)]
    public string? TipoPago { get; set; }

    [StringLength(255)]
    public string? CodDependencia { get; set; }

    [StringLength(255)]
    public string? Provincia { get; set; }

    [StringLength(255)]
    public string? Cargo { get; set; }

    [StringLength(255)]
    public string? DescripcionCargo { get; set; }

    [StringLength(10)]
    public string? FechaInicio { get; set; }

    [StringLength(10)]
    public string? FechaSeparacion { get; set; }

    [StringLength(1)]
    public string? EmpleadoManejo { get; set; }

    [StringLength(30)]
    public string? Condicion { get; set; }

    [StringLength(25)]
    public string? Estado { get; set; }

    public int? Quincena { get; set; }

    [StringLength(10)]
    public string? FechaRegistro { get; set; }

    [StringLength(2)]
    public string? Mes { get; set; }

    [StringLength(4)]
    public string? Anio { get; set; }

    [StringLength(255)]
    public string? NombreCompleto { get; set; }

    [Column("partida")]
    [StringLength(255)]
    public string? Partida { get; set; }

    [Column("sede")]
    [StringLength(255)]
    public string? Sede { get; set; }

    [Column("departamento")]
    [StringLength(255)]
    public string? Departamento { get; set; }

    public int? Activo { get; set; }
}
