using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class Pagos
{
    [Key]
    public int IdPago { get; set; }

    public int Tipo { get; set; }

    [StringLength(50)]
    public string DescripcionDePago { get; set; } = null!;

    public int CodPago { get; set; }
}
