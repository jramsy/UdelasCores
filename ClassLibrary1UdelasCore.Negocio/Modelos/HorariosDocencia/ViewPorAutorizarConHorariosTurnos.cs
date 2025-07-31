using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class ViewPorAutorizarConHorariosTurnos
{
    [StringLength(13)]
    public string? Expr1 { get; set; }

    [Column("h_inicial")]
    public int? HInicial { get; set; }

    [Column("m_inicial")]
    public int? MInicial { get; set; }

    [Column("am_pm_i")]
    [StringLength(2)]
    [Unicode(false)]
    public string? AmPmI { get; set; }

    [Column("h_final")]
    public int? HFinal { get; set; }

    [Column("m_final")]
    public int? MFinal { get; set; }

    [Column("am_pm_f")]
    [StringLength(2)]
    [Unicode(false)]
    public string? AmPmF { get; set; }

    [Column("cod_extension")]
    public int? CodExtension { get; set; }

    [StringLength(50)]
    public string? Nombre { get; set; }

    [StringLength(50)]
    public string? Apellido { get; set; }

    [Column("nombre_dia")]
    [StringLength(10)]
    [Unicode(false)]
    public string? NombreDia { get; set; }

    [Column("id_horario")]
    public int? IdHorario { get; set; }
}
