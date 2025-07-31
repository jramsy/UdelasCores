using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[PrimaryKey("CodPlantilla", "NumeroHora")]
[Table("Horarios_plantilla_detalles")]
public partial class HorariosPlantillaDetalles
{
    [Key]
    [Column("cod_plantilla")]
    public int CodPlantilla { get; set; }

    [Column("h_inicial")]
    public int HInicial { get; set; }

    [Column("m_inicial")]
    public int MInicial { get; set; }

    [Column("ampm_i")]
    [StringLength(2)]
    [Unicode(false)]
    public string AmpmI { get; set; } = null!;

    [Column("h_final")]
    public int HFinal { get; set; }

    [Column("m_final")]
    public int MFinal { get; set; }

    [Column("ampm_f")]
    [StringLength(2)]
    [Unicode(false)]
    public string AmpmF { get; set; } = null!;

    [Key]
    [Column("numero_hora")]
    public int NumeroHora { get; set; }

    [Column("minutos_intermedio")]
    public int MinutosIntermedio { get; set; }

    [Column("cod_extension")]
    public int? CodExtension { get; set; }
}
