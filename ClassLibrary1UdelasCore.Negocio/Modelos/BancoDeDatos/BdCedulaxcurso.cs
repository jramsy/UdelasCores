using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
[Table("Bd_cedulaxcurso")]
public partial class BdCedulaxcurso
{
    [Column("cedula")]
    [StringLength(13)]
    [Unicode(false)]
    public string? Cedula { get; set; }

    [Column("curso")]
    [StringLength(4)]
    [Unicode(false)]
    public string? Curso { get; set; }
}
