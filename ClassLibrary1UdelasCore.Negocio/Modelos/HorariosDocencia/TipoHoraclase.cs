using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
[Table("Tipo_horaclase")]
public partial class TipoHoraclase
{
    [Column("cod_tipo_hora")]
    public int CodTipoHora { get; set; }

    [Column("descripcion")]
    [StringLength(10)]
    [Unicode(false)]
    public string Descripcion { get; set; } = null!;

    [Column("observacion")]
    [StringLength(100)]
    [Unicode(false)]
    public string Observacion { get; set; } = null!;
}
