using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class ViewIltec1
{
    [Column("ced_profesor")]
    [StringLength(50)]
    public string? CedProfesor { get; set; }

    [Column("extension")]
    [StringLength(50)]
    public string? Extension { get; set; }

    public string? GruposCursos { get; set; }
}
