using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

public partial class PeriodoPorDiplomados
{
    [Key]
    public int IdPeriodoPorDiplomado { get; set; }

    public int Periodo { get; set; }

    [Column("codPeriodo")]
    public int CodPeriodo { get; set; }

    public int CodCarrera { get; set; }

    [StringLength(300)]
    public string DescripcionDiplomado { get; set; } = null!;
}
