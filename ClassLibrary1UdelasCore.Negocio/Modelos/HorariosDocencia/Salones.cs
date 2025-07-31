using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class Salones
{
    [Column("cod_salon")]
    [StringLength(15)]
    [Unicode(false)]
    public string CodSalon { get; set; } = null!;

    [Column("cod_edificio")]
    [StringLength(5)]
    [Unicode(false)]
    public string CodEdificio { get; set; } = null!;

    [Column("cod_extension")]
    public int CodExtension { get; set; }

    [Column("nombre_salon")]
    [StringLength(50)]
    [Unicode(false)]
    public string NombreSalon { get; set; } = null!;

    [Column("ubicacion")]
    [StringLength(50)]
    [Unicode(false)]
    public string Ubicacion { get; set; } = null!;

    [Column("tipo_salon")]
    public int TipoSalon { get; set; }

    [Column("condiciones")]
    public int Condiciones { get; set; }

    [Column("GG")]
    public int Gg { get; set; }
}
