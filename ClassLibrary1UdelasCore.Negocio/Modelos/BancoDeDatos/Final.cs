using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
[Table("FINAL")]
public partial class Final
{
    [StringLength(13)]
    public string Cedula { get; set; } = null!;

    [StringLength(13)]
    public string Cedulacorta { get; set; } = null!;

    [StringLength(50)]
    public string? Nombre { get; set; }

    [StringLength(50)]
    public string? Apellido { get; set; }

    public int? AnioC { get; set; }

    public int? PeriodoC { get; set; }

    public int? AnioUlt { get; set; }

    public int? PeriodoUlt { get; set; }

    [StringLength(20)]
    public string? Sede { get; set; }
}
