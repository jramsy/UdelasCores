using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class NivelesEducativos
{
    [Key]
    public int NivelEducativoId { get; set; }

    [StringLength(50)]
    public string Descripcion { get; set; } = null!;
}
