using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
[Table("Temp_Doc3Anios")]
public partial class TempDoc3Anios
{
    [Column("Id_Doc")]
    public int? IdDoc { get; set; }

    [StringLength(15)]
    public string? Cedula { get; set; }
}
