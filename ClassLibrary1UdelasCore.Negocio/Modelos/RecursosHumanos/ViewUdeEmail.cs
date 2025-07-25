using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Keyless]
public partial class ViewUdeEmail
{
    [StringLength(50)]
    public string Cedula { get; set; } = null!;

    [StringLength(50)]
    public string PrimerNombre { get; set; } = null!;

    [StringLength(50)]
    public string ApellidoPaterno { get; set; } = null!;

    public int CodExtension { get; set; }

    [StringLength(4)]
    public string? Anio { get; set; }

    [StringLength(2)]
    public string? Mes { get; set; }

    [StringLength(200)]
    public string Email { get; set; } = null!;

    [StringLength(13)]
    public string? CedulaCorta { get; set; }
}
