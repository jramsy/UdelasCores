using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class TempD1
{
    [Column("cedprofe")]
    [StringLength(50)]
    public string? Cedprofe { get; set; }

    [Column("nomprofe")]
    [StringLength(150)]
    public string? Nomprofe { get; set; }

    [Column("apeprofe")]
    [StringLength(150)]
    public string? Apeprofe { get; set; }

    [Column("codext")]
    public int? Codext { get; set; }
}
