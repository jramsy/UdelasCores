using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
[Table("Materias_por_carreras")]
[Index("CodCarrera", "Estatus", Name = "ID_MXCNOC1")]
public partial class MateriasPorCarreras
{
    [Column("id_materia")]
    public int IdMateria { get; set; }

    [Column("cod_materia")]
    public int CodMateria { get; set; }

    [Column("descripcion")]
    [StringLength(500)]
    [Unicode(false)]
    public string Descripcion { get; set; } = null!;

    [Column("abreviatura")]
    [StringLength(100)]
    [Unicode(false)]
    public string Abreviatura { get; set; } = null!;

    [Column("tipo_periodo")]
    public int TipoPeriodo { get; set; }

    [Column("periodo")]
    public int Periodo { get; set; }

    [Column("creditos")]
    public int Creditos { get; set; }

    [Column("cod_carrera")]
    public int CodCarrera { get; set; }

    [Column("cod_departamento")]
    public int CodDepartamento { get; set; }

    [Column("Horas_teoria")]
    public int HorasTeoria { get; set; }

    [Column("Horas_Lab")]
    public int HorasLab { get; set; }

    [Column("Horas_otros")]
    public int HorasOtros { get; set; }

    [Column("Horas_total")]
    public int HorasTotal { get; set; }

    [Column("Flag_prerequisitos")]
    public int FlagPrerequisitos { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Observacion { get; set; }

    [Column("ID_Plan")]
    public int? IdPlan { get; set; }

    [Column("cod_carrera2")]
    public int CodCarrera2 { get; set; }

    [Column("tecnico")]
    public int Tecnico { get; set; }

    /// <summary>
    /// 1 - materia activa / 0 - materia desactivada
    /// </summary>
    [Column("estatus")]
    public int Estatus { get; set; }

    /// <summary>
    /// Estatus para las materias Prácticas Universitarias: 0 No tiene horas prácticas, 1 si tiene horas prácticas (Lic)
    /// </summary>
    [Column("horas_practicas")]
    public int HorasPracticas { get; set; }

    [Column("horaregistro", TypeName = "datetime")]
    public DateTime Horaregistro { get; set; }

    [Column("operador")]
    [StringLength(50)]
    [Unicode(false)]
    public string Operador { get; set; } = null!;
}
