using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class ListadoAnioMayorDocentes
{
    [Column("ced_profesor")]
    [StringLength(13)]
    [Unicode(false)]
    public string CedProfesor { get; set; } = null!;

    [Column("ano")]
    public int Ano { get; set; }

    [Column("facultad")]
    [StringLength(50)]
    [Unicode(false)]
    public string Facultad { get; set; } = null!;

    [Column("nombre_extension")]
    [StringLength(50)]
    [Unicode(false)]
    public string NombreExtension { get; set; } = null!;
}
