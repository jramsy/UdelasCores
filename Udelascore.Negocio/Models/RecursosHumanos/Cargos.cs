using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class Cargos
{
    [Key]
    public int CargosId { get; set; }

    [StringLength(100)]
    public string DescripcionCargos { get; set; } = null!;
}
