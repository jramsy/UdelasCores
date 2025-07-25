using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class Horarios
{
    [Key]
    public int HorariosId { get; set; }

    [StringLength(50)]
    public string HoraInicial { get; set; } = null!;

    [Column("AMPM_I")]
    [StringLength(50)]
    public string AmpmI { get; set; } = null!;

    [StringLength(50)]
    public string HoraFinal { get; set; } = null!;

    [Column("AMPM_F")]
    [StringLength(50)]
    public string AmpmF { get; set; } = null!;
}
