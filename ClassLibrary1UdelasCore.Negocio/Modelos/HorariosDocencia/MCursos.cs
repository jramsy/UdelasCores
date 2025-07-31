using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
[Table("M_cursos")]
public partial class MCursos
{
    [Column("M_cursosID")]
    public int MCursosId { get; set; }

    [Column("cod_grupo")]
    [StringLength(50)]
    [Unicode(false)]
    public string CodGrupo { get; set; } = null!;

    [Column("grupo")]
    [StringLength(50)]
    [Unicode(false)]
    public string Grupo { get; set; } = null!;

    [Column("cod_curso")]
    public int CodCurso { get; set; }

    [Column("cod_asignatura")]
    public int CodAsignatura { get; set; }

    [Column("asignatura")]
    [StringLength(50)]
    [Unicode(false)]
    public string Asignatura { get; set; } = null!;

    [Column("cod_facultad")]
    public int CodFacultad { get; set; }

    [Column("cod_carrera")]
    public int CodCarrera { get; set; }

    [Column("cod_profesor")]
    [StringLength(50)]
    [Unicode(false)]
    public string CodProfesor { get; set; } = null!;

    [Column("cod_turno")]
    public int CodTurno { get; set; }

    [Column("creditos")]
    public int Creditos { get; set; }

    [Column("tope")]
    public int Tope { get; set; }

    [Column("minimo")]
    public int Minimo { get; set; }

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

    [Column("id_asignatura")]
    public int IdAsignatura { get; set; }

    [Column("cod_periodo_matricula")]
    public int CodPeriodoMatricula { get; set; }

    [Column("tipo_periodo_matricula")]
    public int TipoPeriodoMatricula { get; set; }

    [Column("ano_matricula")]
    public int AnoMatricula { get; set; }

    [Column("cod_extension_regional")]
    public int CodExtensionRegional { get; set; }

    [Column("id_grupo")]
    public int IdGrupo { get; set; }

    [Column("ced_profesor")]
    [StringLength(13)]
    [Unicode(false)]
    public string CedProfesor { get; set; } = null!;

    [Column("nombre")]
    [StringLength(25)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    [Column("apellido")]
    [StringLength(25)]
    [Unicode(false)]
    public string Apellido { get; set; } = null!;

    [Column("cod_escuela")]
    public int CodEscuela { get; set; }
}
