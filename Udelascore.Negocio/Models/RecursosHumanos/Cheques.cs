using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class Cheques
{
    [Key]
    public int ChequesId { get; set; }

    [Column("No_Cheque")]
    public int NoCheque { get; set; }

    [StringLength(50)]
    public string CodEmpleado { get; set; } = null!;

    [StringLength(50)]
    public string FechaString { get; set; } = null!;

    public DateOnly Fecha { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal SueldoNeto { get; set; }

    [StringLength(50)]
    public string Quincena { get; set; } = null!;

    [StringLength(50)]
    public string Mes { get; set; } = null!;

    [Column("FichaSS")]
    [StringLength(50)]
    public string FichaSs { get; set; } = null!;
}
