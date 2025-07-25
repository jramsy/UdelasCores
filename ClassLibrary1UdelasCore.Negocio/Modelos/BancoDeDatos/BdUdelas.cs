using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
[Table("Bd_UDELAS")]
public partial class BdUdelas
{
    [Column("Cod_especialidad")]
    [StringLength(50)]
    [Unicode(false)]
    public string CodEspecialidad { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? Cedula { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Decanato { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Carrera { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Materia { get; set; }

    public int? Anno { get; set; }

    public int? Periodo { get; set; }

    [Column("Cod_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Cod1 { get; set; }

    [Column("Cod_2")]
    public int? Cod2 { get; set; }
}
