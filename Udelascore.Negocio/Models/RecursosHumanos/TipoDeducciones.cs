using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class TipoDeducciones
{
    [Key]
    public int TipoDeduccionId { get; set; }

    [Column("CODIGO")]
    public int Codigo { get; set; }

    [Column("DESCRIPCION")]
    [StringLength(100)]
    public string Descripcion { get; set; } = null!;

    [Column("DIRECCION")]
    [StringLength(100)]
    public string Direccion { get; set; } = null!;

    [Column("TELEFONOS")]
    [StringLength(50)]
    public string Telefonos { get; set; } = null!;
}
