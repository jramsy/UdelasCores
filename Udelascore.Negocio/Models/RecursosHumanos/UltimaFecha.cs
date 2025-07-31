using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Keyless]
public partial class UltimaFecha
{
    [StringLength(13)]
    public string? Cedula { get; set; }

    [Column("Fecha_Sistema", TypeName = "datetime")]
    public DateTime? FechaSistema { get; set; }
}
