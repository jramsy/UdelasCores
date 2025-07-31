using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
[Table("TemporalDoceSS3A")]
public partial class TemporalDoceSs3a
{
    public int? Id { get; set; }

    [StringLength(15)]
    public string? Cedula { get; set; }

    public int? CodSede { get; set; }

    [StringLength(30)]
    public string? Sede { get; set; }
}
