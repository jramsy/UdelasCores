using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Table("Sem_mats")]
public partial class SemMats
{
    [Key]
    public int SemMatId { get; set; }

    [Column("Nom_sem_materia")]
    [StringLength(15)]
    public string NomSemMateria { get; set; } = null!;

    public int Codigo { get; set; }

    [Column("Cod_carrera")]
    public int CodCarrera { get; set; }

    public int Periodo { get; set; }

    public int TipoPeriodo { get; set; }
}
