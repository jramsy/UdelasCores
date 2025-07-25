using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class Entidades
{
    [Key]
    [Column("ID_Entidad")]
    public int IdEntidad { get; set; }

    [Column("Nombre_Entidad")]
    [StringLength(100)]
    [Unicode(false)]
    public string NombreEntidad { get; set; } = null!;

    [Column("Cod_Entidad")]
    public int CodEntidad { get; set; }
}
