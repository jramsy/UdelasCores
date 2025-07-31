using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
[Table("Bd_seminarios")]
public partial class BdSeminarios
{
    [Column("ced")]
    [StringLength(13)]
    [Unicode(false)]
    public string? Ced { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? Ejecutorias { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? Publicaciones { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? Conferencias { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? Ponencias { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? Otras { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? Experiencia { get; set; }
}
