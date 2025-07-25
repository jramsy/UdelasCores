using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class Extensiones
{
    [Key]
    [Column("ExtensionesID")]
    public int ExtensionesId { get; set; }

    [Column("Cod_Extension")]
    public int CodExtension { get; set; }

    [StringLength(50)]
    public string NombreExtension { get; set; } = null!;
}
