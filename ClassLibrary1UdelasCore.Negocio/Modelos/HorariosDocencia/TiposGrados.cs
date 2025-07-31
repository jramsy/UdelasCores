using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

public partial class TiposGrados
{
    [Key]
    public int GradoId { get; set; }

    [StringLength(50)]
    public string NombreGrado { get; set; } = null!;
}
