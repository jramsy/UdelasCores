using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
[Table("Periodos_vigentes")]
public partial class PeriodosVigentes
{
    [Column("Ano_vigente")]
    public int AnoVigente { get; set; }

    [Column("periodo_semestre")]
    public int PeriodoSemestre { get; set; }

    [Column("periodo_cuatrimestre")]
    public int PeriodoCuatrimestre { get; set; }

    [Column("periodo_modulo")]
    public int PeriodoModulo { get; set; }
}
