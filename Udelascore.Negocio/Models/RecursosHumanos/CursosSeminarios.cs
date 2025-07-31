using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class CursosSeminarios
{
    [Key]
    public int CursosId { get; set; }

    [Column("DescripcionCS")]
    [StringLength(10)]
    public string DescripcionCs { get; set; } = null!;

    public int Duracion { get; set; }

    /// <summary>
    /// Guid del administrativo
    /// </summary>
    public Guid Guid { get; set; }
}
