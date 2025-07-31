using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class ViewMateriasXcarreraSemestre
{
    [Column("cod_materia")]
    public int CodMateria { get; set; }

    [Column("cod_carrera")]
    public int CodCarrera { get; set; }

    [Column("periodo")]
    public int Periodo { get; set; }

    [Column("descripcion")]
    [StringLength(500)]
    [Unicode(false)]
    public string Descripcion { get; set; } = null!;

    [Column("Nom_sem_materia")]
    [StringLength(50)]
    public string? NomSemMateria { get; set; }

    [Column("ID_Plan")]
    public int? IdPlan { get; set; }
}
