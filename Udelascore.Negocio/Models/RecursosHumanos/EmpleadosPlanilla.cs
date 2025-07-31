using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class EmpleadosPlanilla
{
    [Key]
    public int IdEmpleado { get; set; }

    public Guid GuidEmpleado { get; set; }

    [Column("DNI")]
    [StringLength(15)]
    public string Dni { get; set; } = null!;

    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    [StringLength(50)]
    public string Apellido { get; set; } = null!;

    [StringLength(1)]
    public string Sexo { get; set; } = null!;

    [StringLength(60)]
    public string Email { get; set; } = null!;

    public int CodDepto { get; set; }

    public int CodSede { get; set; }

    [StringLength(50)]
    public string Token { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime FechaRegistro { get; set; }

    public int Enviado { get; set; }
}
