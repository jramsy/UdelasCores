using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Table("M_costos_fijos_grupos_TEMP")]
public partial class MCostosFijosGruposTemp
{
    [Key]
    [Column("M_costos_fijos_gruposID")]
    public int MCostosFijosGruposId { get; set; }

    [Column("cod_carrera")]
    public int CodCarrera { get; set; }

    [Column("cod_contenedor")]
    public int CodContenedor { get; set; }

    [Column("cod_grupo")]
    [StringLength(50)]
    [Unicode(false)]
    public string CodGrupo { get; set; } = null!;

    [Column("cod_extension")]
    public int CodExtension { get; set; }

    [Column("ano")]
    public int Ano { get; set; }

    [Column("cod_periodo_matricula")]
    public int CodPeriodoMatricula { get; set; }

    [Column("tipo_periodo_matricula")]
    public int TipoPeriodoMatricula { get; set; }
}
