using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Index("Ano", "Periodo", "CedProfesor", Name = "ID_CURSONOC3")]
[Index("Ano", "CodCarrera", Name = "ID_CURSOSNONC")]
[Index("CodCurso", "Ano", "Periodo", "CedProfesor", Name = "ID_CursosNOC")]
public partial class Cursos
{
    [Key]
    [Column("id_curso")]
    public int IdCurso { get; set; }

    [Column("id_grupo")]
    public int IdGrupo { get; set; }

    [Column("cod_curso")]
    public int CodCurso { get; set; }

    [Column("cod_materia")]
    public int CodMateria { get; set; }

    [Column("materia_abreviada")]
    [StringLength(10)]
    [Unicode(false)]
    public string MateriaAbreviada { get; set; } = null!;

    [Column("materia_completa")]
    [StringLength(500)]
    [Unicode(false)]
    public string MateriaCompleta { get; set; } = null!;

    [Column("ano")]
    public int Ano { get; set; }

    [Column("periodo")]
    public int Periodo { get; set; }

    [Column("cod_profesor")]
    public int CodProfesor { get; set; }

    [Column("ced_profesor")]
    [StringLength(13)]
    [Unicode(false)]
    public string CedProfesor { get; set; } = null!;

    [Column("nombre")]
    [StringLength(75)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    [Column("apellido")]
    [StringLength(75)]
    [Unicode(false)]
    public string Apellido { get; set; } = null!;

    [Column("cod_turno")]
    public int CodTurno { get; set; }

    [Column("salon")]
    [StringLength(15)]
    [Unicode(false)]
    public string Salon { get; set; } = null!;

    [Column("edificio")]
    [StringLength(5)]
    [Unicode(false)]
    public string Edificio { get; set; } = null!;

    [Column("estatus1")]
    [StringLength(15)]
    [Unicode(false)]
    public string Estatus1 { get; set; } = null!;

    [Column("estatus2")]
    [StringLength(15)]
    [Unicode(false)]
    public string Estatus2 { get; set; } = null!;

    [Column("cantidad_estudiantes")]
    public int CantidadEstudiantes { get; set; }

    [Column("creditos")]
    public int Creditos { get; set; }

    [Column("periodo_materia")]
    public int PeriodoMateria { get; set; }

    [Column("cod_financiero")]
    public int CodFinanciero { get; set; }

    [Column("dir_especial")]
    [StringLength(2)]
    [Unicode(false)]
    public string DirEspecial { get; set; } = null!;

    [Column("cod_grupo")]
    [StringLength(10)]
    [Unicode(false)]
    public string CodGrupo { get; set; } = null!;

    [Column("grupo")]
    [StringLength(2)]
    [Unicode(false)]
    public string Grupo { get; set; } = null!;

    [Column("cod_deparatmento")]
    public int CodDeparatmento { get; set; }

    [Column("cod_extension")]
    public int CodExtension { get; set; }

    [Column("cod_facultad")]
    public int CodFacultad { get; set; }

    [Column("cod_escuela")]
    public int? CodEscuela { get; set; }

    [Column("cod_carrera")]
    public int CodCarrera { get; set; }

    /// <summary>
    /// La cantidad de semanas que realmente se va impartir este curso,si es -1, entonces se usan las semanas del periodo y se obvia la cantidad de este campo.
    /// </summary>
    [Column("cod1")]
    public int Cod1 { get; set; }

    [Column("cod2")]
    [StringLength(5)]
    [Unicode(false)]
    public string Cod2 { get; set; } = null!;

    [Column("fechaasigdoc", TypeName = "datetime")]
    public DateTime? Fechaasigdoc { get; set; }

    [Column("guidusuarioasigdoc")]
    public Guid? Guidusuarioasigdoc { get; set; }

    [Column("fechaasigpos", TypeName = "datetime")]
    public DateTime? Fechaasigpos { get; set; }

    [Column("guidusuarioasigpos")]
    public Guid? Guidusuarioasigpos { get; set; }

    [Column("ID_Posicion")]
    public int? IdPosicion { get; set; }

    [Column("anio_vigente")]
    public int AnioVigente { get; set; }
}
