using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
[Table("TempDocentes_PendRevisar")]
public partial class TempDocentesPendRevisar
{
    [Column("Ced_profe")]
    [StringLength(13)]
    public string CedProfe { get; set; } = null!;
}
