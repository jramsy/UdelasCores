using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class TokenDocentes
{
    [StringLength(255)]
    public string? Sede { get; set; }

    [StringLength(255)]
    public string? Cedula { get; set; }

    [StringLength(255)]
    public string? Nombre { get; set; }

    [StringLength(255)]
    public string? Apellido { get; set; }

    [StringLength(255)]
    public string? Correo { get; set; }

    [Column("DNI2")]
    [StringLength(255)]
    public string? Dni2 { get; set; }
}
