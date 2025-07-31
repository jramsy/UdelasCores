using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
[Table("Bd_maestria_eliminado")]
public partial class BdMaestriaEliminado
{
    [Column("Cod_maest")]
    public int? CodMaest { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Maestria { get; set; }
}
