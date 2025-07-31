using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Table("CSV_Correos")]
public partial class CsvCorreos
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string Cedula { get; set; } = null!;

    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    [StringLength(50)]
    public string Apellido { get; set; } = null!;

    [StringLength(100)]
    public string Correo { get; set; } = null!;

    [StringLength(50)]
    public string Clave { get; set; } = null!;

    [StringLength(50)]
    public string Tipo { get; set; } = null!;

    public int CodExtension { get; set; }

    [StringLength(50)]
    public string NombreSede { get; set; } = null!;
}
