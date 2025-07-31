using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class DocentesXCuentas
{
    [StringLength(1)]
    [Unicode(false)]
    public string Expr3 { get; set; } = null!;

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

    [StringLength(2)]
    [Unicode(false)]
    public string Expr1 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Expr2 { get; set; } = null!;
}
