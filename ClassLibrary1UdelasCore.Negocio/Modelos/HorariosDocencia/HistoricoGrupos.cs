using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class HistoricoGrupos
{
    [Column("id_grupo")]
    public int IdGrupo { get; set; }

    [Column("ano_matricula")]
    public int? AnoMatricula { get; set; }

    [Column("periodo_matricula")]
    public int? PeriodoMatricula { get; set; }

    [Column("fecha_matricula")]
    [StringLength(10)]
    [Unicode(false)]
    public string? FechaMatricula { get; set; }

    [Column("cod_extension")]
    public int? CodExtension { get; set; }

    [Column("cod_facultad")]
    public int? CodFacultad { get; set; }

    [Column("cod_escuela")]
    public int? CodEscuela { get; set; }

    [Column("cod_carrera")]
    public int? CodCarrera { get; set; }

    [Column("cod_grupo")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CodGrupo { get; set; }

    [Column("letra_grupo")]
    [StringLength(12)]
    [Unicode(false)]
    public string? LetraGrupo { get; set; }

    [Column("semestre_grupo")]
    public int? SemestreGrupo { get; set; }

    [Column("turno")]
    public int? Turno { get; set; }

    [Column("salon")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Salon { get; set; }

    [Column("edificio")]
    [StringLength(5)]
    [Unicode(false)]
    public string? Edificio { get; set; }

    [Column("estatus1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Estatus1 { get; set; }

    [Column("estatus2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Estatus2 { get; set; }

    [Column("cod_hor_plantilla")]
    public int? CodHorPlantilla { get; set; }

    [Column("observacion")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Observacion { get; set; }

    [Column("cod1")]
    public int? Cod1 { get; set; }

    [Column("cod2")]
    [StringLength(5)]
    [Unicode(false)]
    public string? Cod2 { get; set; }
}
