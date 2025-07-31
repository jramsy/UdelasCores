using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

public partial class SubTiposGrados
{
    [Key]
    public int SubTipoGradoId { get; set; }

    public int TipoGrado { get; set; }

    [StringLength(100)]
    public string Descripcion { get; set; } = null!;
}
