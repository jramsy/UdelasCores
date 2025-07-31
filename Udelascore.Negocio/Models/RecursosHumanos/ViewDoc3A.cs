using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Keyless]
public partial class ViewDoc3A
{
    [StringLength(13)]
    public string? Cedula { get; set; }

    [Column("cant1")]
    public int? Cant1 { get; set; }
}
