using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Table("Estatus_Accions")]
public partial class EstatusAccions
{
    [Key]
    [Column("Cod_Estatus_Accion")]
    public int CodEstatusAccion { get; set; }

    [Column("Nombre_Estatus_Accion")]
    [StringLength(50)]
    public string NombreEstatusAccion { get; set; } = null!;
}
