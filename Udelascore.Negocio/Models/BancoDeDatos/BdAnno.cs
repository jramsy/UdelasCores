using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Table("Bd_anno")]
public partial class BdAnno
{
    [Key]
    [Column("id_ano")]
    public int IdAno { get; set; }

    [Column("ANNOS")]
    public int Annos { get; set; }

    [Column("Cod_1")]
    public int? Cod1 { get; set; }
}
