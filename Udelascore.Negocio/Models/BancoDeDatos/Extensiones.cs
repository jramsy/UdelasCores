using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
public partial class Extensiones
{
    [Column("idSede")]
    public int? IdSede { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Sede { get; set; }
}
