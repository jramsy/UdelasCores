using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class Sedes
{
    [Key]
    [Column("ID_Sede")]
    public int IdSede { get; set; }

    [Column("Nombre_Sede")]
    [StringLength(50)]
    public string NombreSede { get; set; } = null!;

    [Column("Codigo_Sede")]
    public int CodigoSede { get; set; }
}
