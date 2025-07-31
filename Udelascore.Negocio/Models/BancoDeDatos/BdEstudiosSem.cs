using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
[Table("Bd_EstudiosSem")]
public partial class BdEstudiosSem
{
    [StringLength(20)]
    [Unicode(false)]
    public string Ced { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? Seminarios { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Ejecutorias { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Publicaciones { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Conferencias { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Ponencias { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Otrasejecutorias { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Experiencia { get; set; }

    public int? Puntaje { get; set; }
}
