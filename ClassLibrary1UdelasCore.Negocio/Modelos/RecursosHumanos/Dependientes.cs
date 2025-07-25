using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class Dependientes
{
    [Key]
    public int DependientesId { get; set; }

    public Guid Guid { get; set; }

    [StringLength(100)]
    public string NombreDependiente { get; set; } = null!;

    [StringLength(50)]
    public string Parentesco { get; set; } = null!;

    public int Edad { get; set; }
}
