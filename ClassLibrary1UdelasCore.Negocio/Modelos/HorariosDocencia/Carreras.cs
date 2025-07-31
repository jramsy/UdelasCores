using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

public partial class Carreras
{
    [Column("cod_extension")]
    public int CodExtension { get; set; }

    [Column("cod_facultad")]
    public int CodFacultad { get; set; }

    [Column("cod_escuela")]
    public int CodEscuela { get; set; }

    [Key]
    [Column("cod_carrera")]
    public int CodCarrera { get; set; }

    [Column("carrera")]
    [StringLength(200)]
    [Unicode(false)]
    public string Carrera { get; set; } = null!;

    [Column("abrev_carrera")]
    [StringLength(25)]
    [Unicode(false)]
    public string AbrevCarrera { get; set; } = null!;

    [Column("plan_carrera")]
    [StringLength(2)]
    [Unicode(false)]
    public string PlanCarrera { get; set; } = null!;

    [Column("Tipo_periodo")]
    public int TipoPeriodo { get; set; }

    public int Activa { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Acuerdo { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string? Observacion { get; set; }

    [Column("cod_facultad2")]
    public int? CodFacultad2 { get; set; }

    [Column("cod_escuela2")]
    public int? CodEscuela2 { get; set; }

    public int? GradoId { get; set; }

    public int? Subgrado { get; set; }

    [Column("cod_tecnico")]
    public int? CodTecnico { get; set; }

    public int? Nivel { get; set; }

    /// <summary>
    /// 0: no promocionada 1: promocionada
    /// </summary>
    public int Estatus { get; set; }
}
