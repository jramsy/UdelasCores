using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
public partial class Docentes
{
    [StringLength(13)]
    [Unicode(false)]
    public string Cedula { get; set; } = null!;

    [StringLength(25)]
    [Unicode(false)]
    public string Nombres { get; set; } = null!;

    [StringLength(25)]
    [Unicode(false)]
    public string Apellidos { get; set; } = null!;
}
