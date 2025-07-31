using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
[Table("TempoDoceSS3A1")]
public partial class TempoDoceSs3a1
{
    public int? Id1 { get; set; }

    [Column("cedula1")]
    [StringLength(15)]
    public string? Cedula1 { get; set; }

    [Column("Cod_sede1")]
    public int? CodSede1 { get; set; }

    [StringLength(30)]
    public string? Sede1 { get; set; }
}
