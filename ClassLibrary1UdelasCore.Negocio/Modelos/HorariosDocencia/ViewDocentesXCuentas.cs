using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class ViewDocentesXCuentas
{
    [Column("id")]
    [StringLength(1)]
    [Unicode(false)]
    public string Id { get; set; } = null!;

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

    [Column("nombre_extension")]
    [StringLength(50)]
    [Unicode(false)]
    public string? NombreExtension { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string Clave { get; set; } = null!;

    [StringLength(169)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("version")]
    [StringLength(1)]
    [Unicode(false)]
    public string Version { get; set; } = null!;

    [Column("activo")]
    [StringLength(1)]
    [Unicode(false)]
    public string Activo { get; set; } = null!;
}
