using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class TipoDePlanillas
{
    [Key]
    public int TipoPlanillaId { get; set; }

    [StringLength(2)]
    public string Codigo { get; set; } = null!;

    [StringLength(50)]
    public string Descripcion { get; set; } = null!;
}
