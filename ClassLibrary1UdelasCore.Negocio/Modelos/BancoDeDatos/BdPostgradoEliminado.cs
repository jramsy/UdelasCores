using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
[Table("Bd_postgrado_eliminado")]
public partial class BdPostgradoEliminado
{
    [Column("Cod_postg")]
    public int? CodPostg { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Postgrado { get; set; }
}
