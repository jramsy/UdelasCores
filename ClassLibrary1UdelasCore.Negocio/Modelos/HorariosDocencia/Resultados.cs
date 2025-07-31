using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class Resultados
{
    [Column("COD_SEDE")]
    public int? CodSede { get; set; }

    [Column("COD_FACULT")]
    public int? CodFacult { get; set; }

    [Column("COD_ESCUEL")]
    public int? CodEscuel { get; set; }

    [Column("COD_CARRER")]
    public int? CodCarrer { get; set; }

    [Column("CARRERA")]
    [StringLength(50)]
    public string? Carrera { get; set; }

    [Column("NOMBRE_COR")]
    [StringLength(15)]
    public string? NombreCor { get; set; }
}
