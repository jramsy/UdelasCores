using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Table("Tipo_Estados")]
public partial class TipoEstados
{
    [Key]
    [Column("Cod_Tipo")]
    public int CodTipo { get; set; }

    [Column("Nombre_Tipo")]
    [StringLength(50)]
    public string NombreTipo { get; set; } = null!;

    [Column("Num_Partida")]
    [StringLength(50)]
    public string? NumPartida { get; set; }
}
