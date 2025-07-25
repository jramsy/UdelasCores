using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
[Table("Bd_sexo")]
public partial class BdSexo
{
    [Column("Cod_sexo")]
    [StringLength(2)]
    [Unicode(false)]
    public string CodSexo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [Column("Cod_1")]
    public int? Cod1 { get; set; }
}
