using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class Departamentos
{
    [Key]
    [Column("cod_departamento")]
    public int CodDepartamento { get; set; }

    [Column("nombre")]
    [StringLength(250)]
    public string Nombre { get; set; } = null!;

    [Column("descripcion")]
    [StringLength(250)]
    public string Descripcion { get; set; } = null!;
}
