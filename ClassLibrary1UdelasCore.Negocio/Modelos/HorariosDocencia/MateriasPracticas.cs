using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
[Table("Materias_Practicas")]
public partial class MateriasPracticas
{
    public int Idmateria { get; set; }

    [Column("Cod_materia")]
    public int CodMateria { get; set; }

    [Column("Cod_carrera")]
    public int CodCarrera { get; set; }

    [Column("Competencia_nivel_practica")]
    [StringLength(2500)]
    public string CompetenciaNivelPractica { get; set; } = null!;
}
