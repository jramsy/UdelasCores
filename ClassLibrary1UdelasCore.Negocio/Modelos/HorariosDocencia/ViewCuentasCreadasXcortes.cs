using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class ViewCuentasCreadasXcortes
{
    [Column("t")]
    public int? T { get; set; }

    [Column("extension")]
    [StringLength(50)]
    public string? Extension { get; set; }
}
