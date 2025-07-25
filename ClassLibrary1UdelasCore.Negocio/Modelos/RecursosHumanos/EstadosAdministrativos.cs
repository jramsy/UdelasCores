using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class EstadosAdministrativos
{
    [Key]
    public int CodEstado { get; set; }

    [StringLength(100)]
    public string? Estado { get; set; }
}
