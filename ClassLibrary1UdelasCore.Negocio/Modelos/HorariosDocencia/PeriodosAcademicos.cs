using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[PrimaryKey("CodTipoPeriodo", "Numero")]
[Table("Periodos_academicos")]
public partial class PeriodosAcademicos
{
    [Key]
    [Column("Cod_tipo_periodo")]
    public int CodTipoPeriodo { get; set; }

    [Key]
    public int Numero { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string Descripcion { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string Abreviado { get; set; } = null!;
}
