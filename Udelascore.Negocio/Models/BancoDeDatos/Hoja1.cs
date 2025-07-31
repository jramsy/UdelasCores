using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
[Table("Hoja1$")]
public partial class Hoja1
{
    [Column("CEDULA")]
    [StringLength(255)]
    public string? Cedula { get; set; }

    [Column("NOMBRE")]
    [StringLength(255)]
    public string? Nombre { get; set; }

    [Column("APELLIDO ")]
    [StringLength(255)]
    public string? Apellido { get; set; }

    [Column("EXTENCION")]
    public double? Extencion { get; set; }
}
