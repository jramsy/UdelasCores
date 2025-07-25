using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class Acreedores
{
    [Key]
    public int IdAcreedor { get; set; }

    [Column("RUC_Acreedor")]
    [StringLength(50)]
    public string RucAcreedor { get; set; } = null!;

    [StringLength(100)]
    public string NombreAcreedor { get; set; } = null!;
}
