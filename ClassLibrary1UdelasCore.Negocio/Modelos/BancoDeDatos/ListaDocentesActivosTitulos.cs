using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
public partial class ListaDocentesActivosTitulos
{
    [Column("ced_profesor")]
    [StringLength(13)]
    [Unicode(false)]
    public string CedProfesor { get; set; } = null!;

    [Column("nombre")]
    [StringLength(25)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    [Column("apellido")]
    [StringLength(25)]
    [Unicode(false)]
    public string Apellido { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? Tecnicos { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Licenciaturas { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Profesorados { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Postgrados { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Maestrias { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Doctorados { get; set; }
}
