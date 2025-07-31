using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Table("Grupos_especiales")]
public partial class GruposEspeciales
{
    [Key]
    public int Idr { get; set; }

    [Column("Anio_actual")]
    public int? AnioActual { get; set; }

    [Column("Periodo_actual")]
    public int? PeriodoActual { get; set; }

    [Column("Grupo_actual")]
    [StringLength(10)]
    [Unicode(false)]
    public string? GrupoActual { get; set; }

    [Column("cod_extension")]
    public int? CodExtension { get; set; }

    [Column("cod_facultad")]
    public int? CodFacultad { get; set; }

    [Column("id_grupo_referencia")]
    public int? IdGrupoReferencia { get; set; }

    [Column("Grupo_anterior")]
    [StringLength(10)]
    [Unicode(false)]
    public string? GrupoAnterior { get; set; }

    [Column("Anio_anterior")]
    public int? AnioAnterior { get; set; }

    [Column("Periodo_anterior")]
    public int? PeriodoAnterior { get; set; }
}
