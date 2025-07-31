using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class ViewDocenteVotantesUlt3Anios
{
    [Column("ced_profesor")]
    [StringLength(13)]
    [Unicode(false)]
    public string? CedProfesor { get; set; }

    [Column("nombre")]
    [StringLength(75)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [Column("apellido")]
    [StringLength(75)]
    [Unicode(false)]
    public string? Apellido { get; set; }

    [Column("ano")]
    public int? Ano { get; set; }

    [Column("cod_extension")]
    public int? CodExtension { get; set; }
}
