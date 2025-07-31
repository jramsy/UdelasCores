using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class ViewHorariosCurso
{
    [Column("h_inicial")]
    public int HInicial { get; set; }

    [Column("m_inicial")]
    public int MInicial { get; set; }

    [Column("am_pm_i")]
    [StringLength(2)]
    [Unicode(false)]
    public string AmPmI { get; set; } = null!;

    [Column("h_final")]
    public int HFinal { get; set; }

    [Column("m_final")]
    public int MFinal { get; set; }

    [Column("am_pm_f")]
    [StringLength(2)]
    [Unicode(false)]
    public string AmPmF { get; set; } = null!;

    [Column("id_curso")]
    public int IdCurso { get; set; }

    [Column("cod_extension")]
    public int? CodExtension { get; set; }

    [Column("ced_profesor")]
    [StringLength(13)]
    [Unicode(false)]
    public string? CedProfesor { get; set; }

    [Column("nombre_dia")]
    [StringLength(10)]
    [Unicode(false)]
    public string NombreDia { get; set; } = null!;

    [Column("id_horario")]
    public int IdHorario { get; set; }
}
