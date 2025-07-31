using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class Periodos
{
    [Key]
    public int PeriodoId { get; set; }

    public int Periodo { get; set; }

    public int CodPeriodo { get; set; }

    [StringLength(50)]
    public string Descripcion { get; set; } = null!;
}
