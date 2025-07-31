using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Keyless]
public partial class AccionModificada
{
    [StringLength(13)]
    public string? Cedula { get; set; }

    [StringLength(50)]
    public string? Nombre { get; set; }

    [StringLength(50)]
    public string? Apellido { get; set; }

    public int? Anio { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? Total { get; set; }

    [Column("Nombre_Accion")]
    [StringLength(50)]
    public string? NombreAccion { get; set; }

    [Column("Cod_Sede")]
    public int? CodSede { get; set; }
}
