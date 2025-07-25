using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Table("Tipo_Periodos")]
public partial class TipoPeriodos
{
    [Key]
    public int TipoPeriodoId { get; set; }

    [Column("Cod_Tipo_Periodo")]
    public int CodTipoPeriodo { get; set; }

    [Column("Nombre_Tipo_Periodo")]
    [StringLength(50)]
    public string NombreTipoPeriodo { get; set; } = null!;
}
