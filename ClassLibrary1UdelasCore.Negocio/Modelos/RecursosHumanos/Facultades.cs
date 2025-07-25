using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Keyless]
public partial class Facultades
{
    [Column("Cod_Facultad")]
    public int CodFacultad { get; set; }

    [Column("Nombre_Facultad")]
    [StringLength(250)]
    [Unicode(false)]
    public string NombreFacultad { get; set; } = null!;

    [Column("Tipo_Nivel")]
    public int? TipoNivel { get; set; }
}
