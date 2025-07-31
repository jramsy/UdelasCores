using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Table("Observaciones_materia")]
public partial class ObservacionesMateria
{
    [Key]
    [Column("id_materia")]
    public int IdMateria { get; set; }

    [Column("observacion")]
    [StringLength(100)]
    [Unicode(false)]
    public string Observacion { get; set; } = null!;
}
