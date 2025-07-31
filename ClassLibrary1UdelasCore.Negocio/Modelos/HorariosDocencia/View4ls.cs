using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class View4ls
{
    [Column("CANT")]
    [StringLength(13)]
    [Unicode(false)]
    public string? Cant { get; set; }

    [Column("Cod_grupo")]
    [StringLength(7)]
    [Unicode(false)]
    public string CodGrupo { get; set; } = null!;

    [Column("carrera")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Carrera { get; set; }

    [Column("facultad")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Facultad { get; set; }

    [Column("nombre")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Nombre { get; set; }
}
