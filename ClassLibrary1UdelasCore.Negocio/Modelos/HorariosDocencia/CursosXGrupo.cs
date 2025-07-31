using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class CursosXGrupo
{
    [Column("cod_carrera")]
    public int CodCarrera { get; set; }

    [Column("cod_grupo")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CodGrupo { get; set; }

    public int? NumCursos { get; set; }
}
