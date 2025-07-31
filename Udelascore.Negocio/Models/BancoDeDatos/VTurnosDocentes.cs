using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
public partial class VTurnosDocentes
{
    [Column("Cod_turno")]
    public int? CodTurno { get; set; }

    [StringLength(50)]
    public string CedulaDocente { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? Turno { get; set; }
}
