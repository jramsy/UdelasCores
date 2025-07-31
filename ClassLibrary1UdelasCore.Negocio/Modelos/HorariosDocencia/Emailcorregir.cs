using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class Emailcorregir
{
    [Column("ced_profesor")]
    [StringLength(50)]
    public string? CedProfesor { get; set; }

    public int? Expr1 { get; set; }
}
