using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
[Table("Bd_provincia")]
public partial class BdProvincia
{
    [Column("Codigo_prov")]
    public int CodigoProv { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [Column("Cod_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Cod1 { get; set; }
}
