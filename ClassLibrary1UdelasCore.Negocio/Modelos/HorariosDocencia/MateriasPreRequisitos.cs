using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[PrimaryKey("CodMateria", "IdMateriaAsociada")]
[Table("Materias_PreRequisitos")]
public partial class MateriasPreRequisitos
{
    [Key]
    [Column("cod_materia")]
    public int CodMateria { get; set; }

    [Column("cod_carrera")]
    public int CodCarrera { get; set; }

    [Column("plan_carrera")]
    [StringLength(2)]
    [Unicode(false)]
    public string PlanCarrera { get; set; } = null!;

    [Key]
    [Column("id_materia_asociada")]
    public int IdMateriaAsociada { get; set; }

    [Column("nombre_materia")]
    [StringLength(500)]
    [Unicode(false)]
    public string NombreMateria { get; set; } = null!;
}
