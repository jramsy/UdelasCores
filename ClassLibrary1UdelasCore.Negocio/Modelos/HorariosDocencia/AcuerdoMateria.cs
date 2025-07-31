using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
[Table("Acuerdo_materia")]
public partial class AcuerdoMateria
{
    /// <summary>
    /// identificacion del acuerdo
    /// </summary>
    [StringLength(25)]
    [Unicode(false)]
    public string Nomenclatura { get; set; } = null!;

    [StringLength(11)]
    [Unicode(false)]
    public string Fecha { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Observacion { get; set; } = null!;

    /// <summary>
    /// Hay veces que ademas de la nomenclatura o identif de plan, se adjunta un titulo que lo describe
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string Titulo { get; set; } = null!;

    [Column("Cod_carrera")]
    public int CodCarrera { get; set; }

    [Column("plan_carrera")]
    [StringLength(2)]
    [Unicode(false)]
    public string PlanCarrera { get; set; } = null!;
}
