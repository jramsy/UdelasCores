using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class PartidasPresupuestarias
{
    [Key]
    public int IdPartida { get; set; }

    [StringLength(50)]
    public string CodPartida { get; set; } = null!;

    public int Estatus { get; set; }
}
