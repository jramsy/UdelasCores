using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class Extensiones
{
    [Column("cod_extension")]
    public int CodExtension { get; set; }

    [Column("nombre_extension")]
    [StringLength(50)]
    [Unicode(false)]
    public string NombreExtension { get; set; } = null!;

    [Column("provincia")]
    [StringLength(50)]
    [Unicode(false)]
    public string Provincia { get; set; } = null!;

    [Column("distrito")]
    [StringLength(50)]
    [Unicode(false)]
    public string Distrito { get; set; } = null!;
}
