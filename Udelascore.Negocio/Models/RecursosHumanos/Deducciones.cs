using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class Deducciones
{
    [Key]
    public int DeduccionId { get; set; }

    [Column("NroDRH")]
    [StringLength(7)]
    public string NroDrh { get; set; } = null!;

    [StringLength(50)]
    public string Cedula { get; set; } = null!;

    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    [StringLength(50)]
    public string Apellido { get; set; } = null!;

    [StringLength(50)]
    public string SeguroSocial { get; set; } = null!;

    public int Categoria { get; set; }

    [StringLength(10)]
    public string InicioLaboral { get; set; } = null!;

    [Column(TypeName = "numeric(18, 2)")]
    public decimal Salario { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal GastosRepresentacion { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal SobreSueldo { get; set; }

    [Column("A_QUIEN")]
    [StringLength(50)]
    public string AQuien { get; set; } = null!;

    [StringLength(10)]
    public string FechaRegistro { get; set; } = null!;

    public int CodCargo { get; set; }

    [StringLength(50)]
    public string Cargo { get; set; } = null!;

    [Column("Guid_Deduccion")]
    public Guid GuidDeduccion { get; set; }
}
