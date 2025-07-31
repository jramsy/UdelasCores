using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
[Table("Tipo_periodos")]
public partial class TipoPeriodos
{
    [Column("Cod_periodo")]
    public int CodPeriodo { get; set; }

    [Column("descripcion")]
    [StringLength(15)]
    [Unicode(false)]
    public string Descripcion { get; set; } = null!;
}
