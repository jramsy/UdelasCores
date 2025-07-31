using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Table("descripcion_periodos")]
public partial class DescripcionPeriodos
{
    [Key]
    public int Codigo { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string Descripcion { get; set; } = null!;
}
