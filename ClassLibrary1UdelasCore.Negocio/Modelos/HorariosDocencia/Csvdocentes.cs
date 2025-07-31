using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class Csvdocentes
{
    [Column("nombre")]
    [StringLength(75)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    [Column("apellido")]
    [StringLength(75)]
    [Unicode(false)]
    public string Apellido { get; set; } = null!;

    [Column("ced_profesor")]
    [StringLength(13)]
    [Unicode(false)]
    public string CedProfesor { get; set; } = null!;

    [StringLength(21)]
    [Unicode(false)]
    public string? Telefono { get; set; }

    [StringLength(169)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Sede { get; set; }
}
