using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Table("Horarios_copia")]
public partial class HorariosCopia
{
    [Key]
    [Column("id_horario")]
    public int IdHorario { get; set; }

    [Column("id_grupo")]
    public int IdGrupo { get; set; }

    [Column("id_curso")]
    public int IdCurso { get; set; }

    [Column("cod_curso")]
    public int CodCurso { get; set; }

    [Column("abrev_materia")]
    [StringLength(25)]
    [Unicode(false)]
    public string AbrevMateria { get; set; } = null!;

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

    [Column("intermedio_minutos")]
    public int IntermedioMinutos { get; set; }

    [Column("numero_dia")]
    public int NumeroDia { get; set; }

    [Column("nombre_dia")]
    [StringLength(10)]
    [Unicode(false)]
    public string NombreDia { get; set; } = null!;

    [Column("numero_hora")]
    public int NumeroHora { get; set; }

    [Column("salon")]
    [StringLength(15)]
    [Unicode(false)]
    public string Salon { get; set; } = null!;

    [Column("edificio")]
    [StringLength(5)]
    [Unicode(false)]
    public string Edificio { get; set; } = null!;

    [Column("tipo_hora_clase")]
    public int TipoHoraClase { get; set; }

    [Column("nombre_tipo_clase")]
    [StringLength(25)]
    [Unicode(false)]
    public string NombreTipoClase { get; set; } = null!;

    [Column("tipo_pago")]
    [StringLength(15)]
    [Unicode(false)]
    public string TipoPago { get; set; } = null!;

    [Column("estatus1")]
    [StringLength(15)]
    [Unicode(false)]
    public string Estatus1 { get; set; } = null!;

    [Column("estatus2")]
    [StringLength(15)]
    [Unicode(false)]
    public string Estatus2 { get; set; } = null!;

    [Column("cod_horario_plantilla")]
    public int CodHorarioPlantilla { get; set; }

    [Column("cod1")]
    public int Cod1 { get; set; }

    [Column("cod2")]
    [StringLength(5)]
    [Unicode(false)]
    public string Cod2 { get; set; } = null!;

    [Column("periodo")]
    public int Periodo { get; set; }

    [Column("ano")]
    public int Ano { get; set; }
}
