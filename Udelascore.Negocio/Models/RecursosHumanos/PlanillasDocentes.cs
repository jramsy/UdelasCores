using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class PlanillasDocentes
{
    [Key]
    public int IdPlanilla { get; set; }

    [StringLength(50)]
    public string Descripcion { get; set; } = null!;

    public int AnioPlanilla { get; set; }
}
