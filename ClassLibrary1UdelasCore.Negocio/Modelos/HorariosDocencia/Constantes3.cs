using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class Constantes3
{
    [Column("id_tabla")]
    public int IdTabla { get; set; }

    [Column("ano")]
    public int? Ano { get; set; }

    [Column("periodo")]
    public int? Periodo { get; set; }

    [Column("fecha_inicial_Sem")]
    [StringLength(50)]
    public string? FechaInicialSem { get; set; }

    [Column("fecha_final_Sem")]
    [StringLength(50)]
    public string? FechaFinalSem { get; set; }

    [Column("fecha_inicial_Post")]
    [StringLength(50)]
    public string? FechaInicialPost { get; set; }

    [Column("fecha_final_Post")]
    [StringLength(50)]
    public string? FechaFinalPost { get; set; }

    [Column("version")]
    [StringLength(10)]
    public string? Version { get; set; }

    [Column("periodo_post")]
    public int? PeriodoPost { get; set; }

    [Column("actual")]
    [StringLength(50)]
    public string Actual { get; set; } = null!;

    [Column("cerrado")]
    [StringLength(50)]
    public string? Cerrado { get; set; }

    [Column("cerradoEvaluacion")]
    [StringLength(50)]
    public string? CerradoEvaluacion { get; set; }

    [Column("actualLibreta")]
    [StringLength(50)]
    public string? ActualLibreta { get; set; }

    [Column("actualperiodoEvaluacion")]
    [StringLength(50)]
    public string? ActualperiodoEvaluacion { get; set; }
}
