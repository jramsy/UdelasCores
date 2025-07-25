using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
[Table("Bd_especialidad_eliminados")]
public partial class BdEspecialidadEliminados
{
    [Column("Cod_especialidad")]
    public int CodEspecialidad { get; set; }

    [StringLength(35)]
    [Unicode(false)]
    public string? Especialidad { get; set; }
}
