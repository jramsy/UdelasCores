using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class View3
{
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

    [Column("carrera")]
    [StringLength(100)]
    [Unicode(false)]
    public string Carrera { get; set; } = null!;

    [Column("semestre_grupo")]
    public int? SemestreGrupo { get; set; }

    [Column("letra_grupo")]
    [StringLength(12)]
    [Unicode(false)]
    public string? LetraGrupo { get; set; }

    [Column("turno")]
    public int? Turno { get; set; }

    [Column("materia_completa")]
    [StringLength(150)]
    [Unicode(false)]
    public string MateriaCompleta { get; set; } = null!;

    [Column("tipo_pago")]
    [StringLength(15)]
    [Unicode(false)]
    public string TipoPago { get; set; } = null!;

    [Column("periodo_matricula")]
    public int? PeriodoMatricula { get; set; }

    [Column("Tipo_periodo")]
    public int TipoPeriodo { get; set; }

    public int? Expr1 { get; set; }
}
