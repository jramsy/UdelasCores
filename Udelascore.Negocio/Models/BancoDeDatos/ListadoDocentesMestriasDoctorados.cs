using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
public partial class ListadoDocentesMestriasDoctorados
{
    [StringLength(13)]
    [Unicode(false)]
    public string Cedula { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string Apellido { get; set; } = null!;

    [StringLength(9)]
    [Unicode(false)]
    public string Titulo { get; set; } = null!;

    [Column("Nombre_Estudio")]
    [StringLength(200)]
    public string? NombreEstudio { get; set; }
}
