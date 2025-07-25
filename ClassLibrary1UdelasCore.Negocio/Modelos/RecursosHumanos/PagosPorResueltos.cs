using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class PagosPorResueltos
{
    [Key]
    public long IdPago { get; set; }

    public Guid GuidPago { get; set; }

    public Guid GuidResuelto { get; set; }

    [StringLength(10)]
    public string NroResuelto { get; set; } = null!;

    [StringLength(13)]
    public string Cedula { get; set; } = null!;

    /// <summary>
    /// Nro. de Documento con el que se pagó el resuelto.
    /// </summary>
    [StringLength(10)]
    public string Comprobante { get; set; } = null!;

    /// <summary>
    /// Numero de planila, ingresodo por el usuario
    /// </summary>
    [StringLength(6)]
    public string Planilla { get; set; } = null!;

    public DateOnly FechaPago { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaSistema { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal MontoPago { get; set; }

    [StringLength(100)]
    public string Observacion { get; set; } = null!;

    [StringLength(50)]
    public string Usuario { get; set; } = null!;

    /// <summary>
    /// N: No Anulado; S: Si Anulado
    /// </summary>
    [StringLength(1)]
    public string Anulado { get; set; } = null!;

    /// <summary>
    /// 0: Indefinido; 1:Docente; 2:Administrativo
    /// </summary>
    public int TipoResuelto { get; set; }

    public int PlanillaId { get; set; }

    public int AnioPlanilla { get; set; }
}
