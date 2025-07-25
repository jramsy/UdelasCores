using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Table("ESTRUCTURA")]
public partial class Estructura
{
    [Key]
    public int IdEstructura { get; set; }

    [StringLength(1)]
    public string? CodArea { get; set; }

    [StringLength(2)]
    public string? CodEntidad { get; set; }

    [Column("codigo_estructura")]
    [StringLength(5)]
    public string? CodigoEstructura { get; set; }

    public Guid? GuidAdministrativo { get; set; }

    [StringLength(13)]
    public string? Cedula { get; set; }

    [StringLength(25)]
    public string? Nombre { get; set; }

    [StringLength(25)]
    public string? Apellido { get; set; }

    [StringLength(13)]
    public string? SeguroSocial { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Salario { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? GastoRepresentacion { get; set; }

    [Column("Sobre_Sueldo", TypeName = "numeric(18, 2)")]
    public decimal? SobreSueldo { get; set; }

    [StringLength(10)]
    public string? Patrono { get; set; }

    [StringLength(7)]
    public string? Cargo { get; set; }

    [StringLength(80)]
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

    [StringLength(10)]
    public string? FechaRegistro { get; set; }

    [StringLength(50)]
    public string? Mes { get; set; }

    [StringLength(4)]
    public string? Anio { get; set; }

    [Column("partida")]
    [StringLength(5)]
    public string? Partida { get; set; }

    [Column("sede")]
    [StringLength(255)]
    public string? Sede { get; set; }

    [Column("departamento")]
    [StringLength(255)]
    public string? Departamento { get; set; }

    public int? Activo { get; set; }

    public int CodSede { get; set; }

    public int CargoEnFuncion { get; set; }

    public int CodDepartamento { get; set; }
}
