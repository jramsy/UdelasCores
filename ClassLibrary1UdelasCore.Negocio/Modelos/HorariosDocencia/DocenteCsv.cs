using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Table("Docente_CSV")]
public partial class DocenteCsv
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("nombre")]
    [StringLength(50)]
    public string? Nombre { get; set; }

    [Column("apellido")]
    [StringLength(50)]
    public string? Apellido { get; set; }

    [Column("ced_profesor")]
    [StringLength(50)]
    public string? CedProfesor { get; set; }

    [Column("telefono")]
    [StringLength(50)]
    public string? Telefono { get; set; }

    [Column("extension")]
    [StringLength(50)]
    public string? Extension { get; set; }

    [Column("clave")]
    [StringLength(50)]
    public string? Clave { get; set; }

    [Column("email")]
    [StringLength(50)]
    public string? Email { get; set; }

    [Column("version")]
    [StringLength(50)]
    public string? Version { get; set; }

    [Column("activo")]
    [StringLength(50)]
    public string? Activo { get; set; }

    [StringLength(50)]
    public string? Plataforma { get; set; }
}
