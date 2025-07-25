using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Keyless]
public partial class ViewListadoResueltosLicFecha
{
    [StringLength(10)]
    public string? Resolucion { get; set; }

    [StringLength(13)]
    public string? Cedula { get; set; }

    [StringLength(50)]
    public string? Nombre { get; set; }

    [StringLength(50)]
    public string? Apellido { get; set; }

    public string Partida { get; set; } = null!;

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? Salario { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? Vacaciones { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? Total { get; set; }

    [Column(TypeName = "decimal(20, 6)")]
    public decimal? Monto50P { get; set; }

    [Column("Periodo_Contrato")]
    [StringLength(50)]
    public string? PeriodoContrato { get; set; }

    [Column("Numero_Periodo")]
    public int NumeroPeriodo { get; set; }

    [StringLength(50)]
    public string NombreExtension { get; set; } = null!;

    [StringLength(50)]
    public string? Posicion { get; set; }
}
