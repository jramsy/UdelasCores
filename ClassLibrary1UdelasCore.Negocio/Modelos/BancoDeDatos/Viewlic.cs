using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
[Table("VIEWLIC")]
public partial class Viewlic
{
    [Column("Cod_lic")]
    public int CodLic { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Licenciatura { get; set; }

    public int Puntos { get; set; }
}
