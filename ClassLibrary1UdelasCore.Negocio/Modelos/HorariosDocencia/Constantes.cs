using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class Constantes
{
    public int Codigo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Valor { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Valor2 { get; set; }

    public int? Valor3 { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Valor4 { get; set; }
}
