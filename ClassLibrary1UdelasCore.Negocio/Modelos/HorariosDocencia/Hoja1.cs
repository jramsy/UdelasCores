using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
[Table("Hoja1$")]
public partial class Hoja1
{
    [StringLength(255)]
    public string? Nombre { get; set; }

    [Column("apellido")]
    [StringLength(255)]
    public string? Apellido { get; set; }

    [Column("email")]
    [StringLength(255)]
    public string? Email { get; set; }

    [Column("status")]
    [StringLength(255)]
    public string? Status { get; set; }

    [Column("conexión")]
    [StringLength(50)]
    public string? Conexión { get; set; }
}
