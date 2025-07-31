using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class ProfesoresEvaluacionCursos
{
    [Column("ced_profesor")]
    [StringLength(13)]
    [Unicode(false)]
    public string? CedProfesor { get; set; }

    [Column("cod_extension")]
    public int? CodExtension { get; set; }

    [Column("ano")]
    public int? Ano { get; set; }

    [Column("periodo")]
    public int? Periodo { get; set; }

    public int Facultad { get; set; }

    [Column("actualperiodoEvaluacion")]
    [StringLength(50)]
    public string? ActualperiodoEvaluacion { get; set; }
}
