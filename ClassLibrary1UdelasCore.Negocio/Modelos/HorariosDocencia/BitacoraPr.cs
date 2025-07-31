using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Table("Bitacora_PR")]
public partial class BitacoraPr
{
    [Key]
    [Column("ID_tbl")]
    public int IdTbl { get; set; }

    [Column("ID_Materia")]
    public int? IdMateria { get; set; }

    [Column("Cod_Materia_PR")]
    public int? CodMateriaPr { get; set; }

    [Column("Cod_Carrera")]
    public int? CodCarrera { get; set; }

    /// <summary>
    /// 1. borró PR, 2. agregró PR
    /// </summary>
    public int? Estatus { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Operador { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Motivo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Fecha { get; set; }
}
