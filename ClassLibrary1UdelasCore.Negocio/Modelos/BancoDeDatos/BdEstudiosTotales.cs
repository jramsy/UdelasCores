using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Table("Bd_estudios_totales")]
public partial class BdEstudiosTotales
{
    [Key]
    [StringLength(13)]
    [Unicode(false)]
    public string Ced { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? Tecnicos { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Licenciaturas { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Profesorados { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Postgrados { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Maestrias { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Doctorados { get; set; }

    public float? Puntaje { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Provincia { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Habilitado { get; set; }

    [Column("fecha", TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Direccion { get; set; }
}
