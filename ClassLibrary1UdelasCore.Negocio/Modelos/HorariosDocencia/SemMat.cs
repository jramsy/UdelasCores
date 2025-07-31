using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Table("Sem_mat")]
public partial class SemMat
{
    [Key]
    public int IdSemMat { get; set; }

    [Column("Nom_sem_materia")]
    [StringLength(50)]
    public string? NomSemMateria { get; set; }

    public int? Codigo { get; set; }

    [Column("Cod_carrera")]
    public int? CodCarrera { get; set; }

    public int Periodo { get; set; }

    public int TipoPeriodo { get; set; }

    public int? GradoId { get; set; }
}
