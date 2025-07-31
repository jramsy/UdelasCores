using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
[Table("Clim_Lib_M_grupos_temp-1")]
public partial class ClimLibMGruposTemp1
{
    [Column("M_gruposID")]
    public int MGruposId { get; set; }

    [Column("cod_grupo")]
    [StringLength(50)]
    [Unicode(false)]
    public string CodGrupo { get; set; } = null!;

    [Column("grupo")]
    [StringLength(50)]
    [Unicode(false)]
    public string Grupo { get; set; } = null!;

    [Column("cod_turno")]
    public int CodTurno { get; set; }

    [Column("bloqueado")]
    [StringLength(50)]
    [Unicode(false)]
    public string Bloqueado { get; set; } = null!;

    [Column("cerrado")]
    [StringLength(50)]
    [Unicode(false)]
    public string Cerrado { get; set; } = null!;

    [Column("ver_en_informe")]
    [StringLength(50)]
    [Unicode(false)]
    public string VerEnInforme { get; set; } = null!;

    [Column("cod_facultad")]
    public int CodFacultad { get; set; }

    [Column("cod_carrera")]
    public int CodCarrera { get; set; }

    [Column("ano_matricula")]
    public int AnoMatricula { get; set; }

    [Column("mes_matricula")]
    public int MesMatricula { get; set; }

    [Column("cod_periodo_matricula")]
    public int CodPeriodoMatricula { get; set; }

    [Column("tipo_periodo_matricula")]
    public int TipoPeriodoMatricula { get; set; }

    [Column("cod_periodo_carrera")]
    public int CodPeriodoCarrera { get; set; }

    [Column("tipo_periodo_carrera")]
    public int TipoPeriodoCarrera { get; set; }

    [Column("cod_extension_regional")]
    public int CodExtensionRegional { get; set; }

    [Column("primeringreso")]
    [StringLength(50)]
    [Unicode(false)]
    public string Primeringreso { get; set; } = null!;
}
