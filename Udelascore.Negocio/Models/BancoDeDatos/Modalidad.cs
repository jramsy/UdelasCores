using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

public partial class Modalidad
{
    [Key]
    [Column("Cod_Mod")]
    public int CodMod { get; set; }

    [Column("Modalidad")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Modalidad1 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Cod1 { get; set; }
}
