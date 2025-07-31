using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
[Table("Bd_puntajes")]
public partial class BdPuntajes
{
    [Column("Cod_prof")]
    [StringLength(20)]
    [Unicode(false)]
    public string CodProf { get; set; } = null!;

    [Column("Cod_estudio")]
    [StringLength(50)]
    [Unicode(false)]
    public string CodEstudio { get; set; } = null!;

    [Column("Cod_perfeccionamiento")]
    [StringLength(50)]
    [Unicode(false)]
    public string CodPerfeccionamiento { get; set; } = null!;

    [Column("Cod_ejecutoria")]
    [StringLength(50)]
    [Unicode(false)]
    public string CodEjecutoria { get; set; } = null!;

    [Column("Cod_publicacion")]
    [StringLength(50)]
    [Unicode(false)]
    public string CodPublicacion { get; set; } = null!;

    [Column("Cod_conferencia")]
    [StringLength(50)]
    [Unicode(false)]
    public string CodConferencia { get; set; } = null!;

    [Column("Cod_ponencia")]
    [StringLength(50)]
    [Unicode(false)]
    public string CodPonencia { get; set; } = null!;

    public int? Total { get; set; }
}
