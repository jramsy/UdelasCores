using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Keyless]
public partial class ViewPosicionesXDocentesAnual
{
    [StringLength(13)]
    public string? Cedula { get; set; }

    [StringLength(50)]
    public string? Nombre { get; set; }

    [StringLength(50)]
    public string? Apellido { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Sede { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string Unidad { get; set; } = null!;

    public int? Anio { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Semestre { get; set; } = null!;

    [Column("Descripcion_Cargo")]
    [StringLength(100)]
    [Unicode(false)]
    public string DescripcionCargo { get; set; } = null!;

    [StringLength(50)]
    public string CategoriaDocente { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string Sexo { get; set; } = null!;
}
