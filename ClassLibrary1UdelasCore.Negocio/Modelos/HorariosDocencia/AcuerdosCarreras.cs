using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Table("Acuerdos_carreras")]
public partial class AcuerdosCarreras
{
    [Key]
    [Column("ID_Plan")]
    public int IdPlan { get; set; }

    [Column("Nom_Plan")]
    [StringLength(150)]
    [Unicode(false)]
    public string NomPlan { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Acuerdo { get; set; } = null!;

    [Column("Cod_carrera")]
    public int CodCarrera { get; set; }
}
