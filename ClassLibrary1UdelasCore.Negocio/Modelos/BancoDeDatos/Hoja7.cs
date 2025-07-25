using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
[Table("Hoja7$")]
public partial class Hoja7
{
    [Column("cedula")]
    [StringLength(255)]
    public string? Cedula { get; set; }

    [Column("nombre")]
    [StringLength(255)]
    public string? Nombre { get; set; }

    [Column("apellido")]
    [StringLength(255)]
    public string? Apellido { get; set; }

    [Column("1")]
    public double? _1 { get; set; }

    [Column("0")]
    public double? _0 { get; set; }

    [Column("11")]
    public double? _11 { get; set; }

    public double? F7 { get; set; }
}
