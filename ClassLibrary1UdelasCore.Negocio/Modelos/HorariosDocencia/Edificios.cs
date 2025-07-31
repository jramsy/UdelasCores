using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class Edificios
{
    [Column("codigo_edificio")]
    [StringLength(5)]
    [Unicode(false)]
    public string CodigoEdificio { get; set; } = null!;

    [Column("cod_extension")]
    public int CodExtension { get; set; }

    [Column("nombre")]
    [StringLength(50)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    [Column("ubicacion")]
    [StringLength(50)]
    [Unicode(false)]
    public string Ubicacion { get; set; } = null!;

    [Column("cod_entidad")]
    public int CodEntidad { get; set; }
}
