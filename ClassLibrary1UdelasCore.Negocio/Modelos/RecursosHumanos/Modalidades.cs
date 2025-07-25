using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Keyless]
public partial class Modalidades
{
    [Column("Id_Modalidad")]
    public int IdModalidad { get; set; }

    [Column("Nombre_Modalidad")]
    [StringLength(50)]
    [Unicode(false)]
    public string NombreModalidad { get; set; } = null!;
}
