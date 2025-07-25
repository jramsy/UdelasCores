using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class Cuentas
{
    [Key]
    public int IdCuenta { get; set; }

    [StringLength(6)]
    public string CodCuenta { get; set; } = null!;

    [StringLength(100)]
    public string DescipcionDeCuenta { get; set; } = null!;
}
