using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Table("Accion_Detalles")]
public partial class AccionDetalles
{
    [Key]
    [Column("ID_Accion_Detalle")]
    public long IdAccionDetalle { get; set; }

    [Column("Guid_Accion")]
    public Guid GuidAccion { get; set; }

    [Column("Fecha_Inicial_Curso")]
    [StringLength(50)]
    public string FechaInicialCurso { get; set; } = null!;

    [Column("Nombre_Curso_Materia")]
    [StringLength(200)]
    public string NombreCursoMateria { get; set; } = null!;

    [Column("Cod_Curso")]
    public int CodCurso { get; set; }

    [Column("Cod_Materia")]
    public int CodMateria { get; set; }

    [Column("Cod_Carrera")]
    public int CodCarrera { get; set; }

    [Column("Cod_Sede")]
    public int CodSede { get; set; }

    [Column("Cod_Facultad")]
    public int CodFacultad { get; set; }

    [Column("Cod_Tipo_Periodo")]
    public int CodTipoPeriodo { get; set; }

    [Column("Cod_Turno")]
    public int CodTurno { get; set; }

    [StringLength(50)]
    public string Turno { get; set; } = null!;

    [Column("Horas_Totales_Curso")]
    public int HorasTotalesCurso { get; set; }

    [StringLength(200)]
    public string Carrera { get; set; } = null!;

    [StringLength(50)]
    public string Sede { get; set; } = null!;

    [Column("Numero_Periodo")]
    public int NumeroPeriodo { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal Monto { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal Vacaciones { get; set; }

    [Column("semanas")]
    public int Semanas { get; set; }

    [StringLength(50)]
    public string? Modalidad { get; set; }
}
