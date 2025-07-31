using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class Sucursales
{
    [Key]
    public int IdSucursal { get; set; }

    [StringLength(50)]
    public string NombreSucursal { get; set; } = null!;

    [StringLength(5)]
    public string CodSucursal { get; set; } = null!;

    public int CodSede { get; set; }
}
