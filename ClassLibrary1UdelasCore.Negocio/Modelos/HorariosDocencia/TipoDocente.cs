using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
[Table("Tipo_docente")]
public partial class TipoDocente
{
    [Column("cod_tipo_docente")]
    public int CodTipoDocente { get; set; }

    [Column("descripcion")]
    [StringLength(15)]
    [Unicode(false)]
    public string Descripcion { get; set; } = null!;

    [Column("observacion")]
    [StringLength(100)]
    [Unicode(false)]
    public string Observacion { get; set; } = null!;
}
