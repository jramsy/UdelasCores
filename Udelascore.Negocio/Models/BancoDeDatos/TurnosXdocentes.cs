using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Table("TurnosXDocentes")]
public partial class TurnosXdocentes
{
    [Key]
    public int TurnoDocenteId { get; set; }

    [StringLength(50)]
    public string CedulaDocente { get; set; } = null!;

    public int CodTurno { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaRegistro { get; set; }
}
