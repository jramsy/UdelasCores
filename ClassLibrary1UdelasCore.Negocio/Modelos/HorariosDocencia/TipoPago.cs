using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
[Table("Tipo_pago")]
public partial class TipoPago
{
    [Column("cod_tipo")]
    public int CodTipo { get; set; }

    [Column("descripcion")]
    [StringLength(15)]
    [Unicode(false)]
    public string Descripcion { get; set; } = null!;

    [Column("observacion")]
    [StringLength(100)]
    [Unicode(false)]
    public string Observacion { get; set; } = null!;
}
