using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class Turnos
{
    [Column("cod_turno")]
    public int CodTurno { get; set; }

    [Column("nombre")]
    [StringLength(30)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    [Column("abreviado")]
    [StringLength(3)]
    [Unicode(false)]
    public string Abreviado { get; set; } = null!;

    [Column("observacion")]
    [StringLength(50)]
    [Unicode(false)]
    public string Observacion { get; set; } = null!;
}
