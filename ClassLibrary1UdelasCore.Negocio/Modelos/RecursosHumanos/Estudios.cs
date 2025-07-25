using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class Estudios
{
    [Key]
    public int EducacionId { get; set; }

    public int NivelEducativoId { get; set; }

    [StringLength(100)]
    public string Institucion { get; set; } = null!;

    [StringLength(50)]
    public string NivelAlcanzado { get; set; } = null!;

    [StringLength(100)]
    public string TituloObtenido { get; set; } = null!;

    /// <summary>
    /// Guid del Administrativo
    /// </summary>
    public Guid Guid { get; set; }

    /// <summary>
    /// Año en que obtubo el titulo
    /// </summary>
    public int Anio { get; set; }
}
