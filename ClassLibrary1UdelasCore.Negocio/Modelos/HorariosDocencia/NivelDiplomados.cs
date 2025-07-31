using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

public partial class NivelDiplomados
{
    [Key]
    public int IdNivelDip { get; set; }

    [StringLength(50)]
    public string DescripcionNivel { get; set; } = null!;
}
