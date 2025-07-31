using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
public partial class Profesores2011
{
    [StringLength(13)]
    [Unicode(false)]
    public string? CedulaDocente { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nombres { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Apellidos { get; set; }
}
