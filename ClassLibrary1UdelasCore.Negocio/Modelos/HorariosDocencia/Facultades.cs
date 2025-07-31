using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class Facultades
{
    [Column("cod_facultad")]
    public int CodFacultad { get; set; }

    [Column("facultad")]
    [StringLength(50)]
    [Unicode(false)]
    public string Facultad { get; set; } = null!;

    [Column("cod_extension")]
    public int CodExtension { get; set; }

    [Column("cod_Nivel")]
    public int CodNivel { get; set; }
}
