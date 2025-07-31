using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class T3Horarios
{
    [Column("id_curso")]
    public int IdCurso { get; set; }

    [Column("t")]
    [StringLength(15)]
    [Unicode(false)]
    public string T { get; set; } = null!;

    [Column("ano")]
    public int? Ano { get; set; }

    [Column("periodo")]
    public int? Periodo { get; set; }
}
