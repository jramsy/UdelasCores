using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class Entidades
{
    [Column("cod_entidad")]
    public int CodEntidad { get; set; }

    [Column("nombre")]
    [StringLength(25)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    [Column("ubicacion")]
    [StringLength(50)]
    [Unicode(false)]
    public string Ubicacion { get; set; } = null!;

    [Column("observacion")]
    [StringLength(100)]
    [Unicode(false)]
    public string Observacion { get; set; } = null!;
}
