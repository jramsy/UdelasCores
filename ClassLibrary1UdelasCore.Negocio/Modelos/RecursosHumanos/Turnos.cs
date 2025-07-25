using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Keyless]
public partial class Turnos
{
    [Column("Id_Turno")]
    public int IdTurno { get; set; }

    [Column("Nombre_Turno")]
    [StringLength(20)]
    [Unicode(false)]
    public string NombreTurno { get; set; } = null!;
}
