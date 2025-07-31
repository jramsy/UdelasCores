using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

public partial class CarrerasTecnicos
{
    [Key]
    [Column("Cod_Tecnico")]
    public int CodTecnico { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Tecnico { get; set; }

    [Column("Abrev_Tecnico")]
    [StringLength(50)]
    [Unicode(false)]
    public string? AbrevTecnico { get; set; }

    public int? Activo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Acuerdo { get; set; }

    public int? GradoId { get; set; }

    public int? Subgrado { get; set; }

    [Column("Cod_Carrera")]
    public int? CodCarrera { get; set; }
}
