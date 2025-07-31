using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
[Table("R_servicios_prof")]
public partial class RServiciosProf
{
    [StringLength(13)]
    [Unicode(false)]
    public string Cedula { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Apellido { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Seguro { get; set; }

    [Column("sueldobruto", TypeName = "money")]
    public decimal? Sueldobruto { get; set; }

    [Column("cod_1")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Cod1 { get; set; }

    [Column("Cod_2")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Cod2 { get; set; }

    [Column("cod_3")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Cod3 { get; set; }
}
