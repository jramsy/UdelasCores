using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
[Table("Notas_materia")]
public partial class NotasMateria
{
    [StringLength(25)]
    [Unicode(false)]
    public string Nomenclatura { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string Fecha { get; set; } = null!;

    [Column("Firma_de")]
    [StringLength(50)]
    [Unicode(false)]
    public string FirmaDe { get; set; } = null!;

    [Column("Resumen_contenido")]
    [StringLength(150)]
    [Unicode(false)]
    public string ResumenContenido { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Asunto { get; set; } = null!;

    [Column("cod_carrera")]
    public int CodCarrera { get; set; }

    [Column("plan_carrera")]
    [StringLength(2)]
    [Unicode(false)]
    public string PlanCarrera { get; set; } = null!;
}
