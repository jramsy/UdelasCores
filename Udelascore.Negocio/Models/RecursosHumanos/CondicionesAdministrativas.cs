using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class CondicionesAdministrativas
{
    [Key]
    public int CodCondicion { get; set; }

    [StringLength(200)]
    public string? Condicion { get; set; }
}
