using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
[Table("Bd_Cantidad_especialidad")]
public partial class BdCantidadEspecialidad
{
    [Column("Cod_Especialidad")]
    public int CodEspecialidad { get; set; }

    public int? Cantidad { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Cod1 { get; set; }
}
