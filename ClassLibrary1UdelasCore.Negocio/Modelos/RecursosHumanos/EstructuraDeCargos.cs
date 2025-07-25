using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Table("Estructura_de_Cargos")]
public partial class EstructuraDeCargos
{
    [Key]
    [Column("IdEstructura_Cargo")]
    public int IdEstructuraCargo { get; set; }

    [StringLength(7)]
    public string CodCargo { get; set; } = null!;

    [StringLength(80)]
    public string Descripcion { get; set; } = null!;
}
