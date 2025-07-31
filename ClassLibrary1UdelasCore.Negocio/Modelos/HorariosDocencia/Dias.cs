using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class Dias
{
    [Column("Numero_dia")]
    public int NumeroDia { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string Dia { get; set; } = null!;
}
