using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class EstadosCivil
{
    [Key]
    public int IdEstadoCivil { get; set; }

    [StringLength(50)]
    public string Estado { get; set; } = null!;
}
