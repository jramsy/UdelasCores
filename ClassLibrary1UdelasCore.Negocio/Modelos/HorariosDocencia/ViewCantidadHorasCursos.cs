using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class ViewCantidadHorasCursos
{
    [Column("ano")]
    public int? Ano { get; set; }

    [Column("periodo")]
    public int? Periodo { get; set; }

    [Column("cod_curso")]
    public int? CodCurso { get; set; }

    public int? CantHoras { get; set; }

    public int Expr1 { get; set; }
}
