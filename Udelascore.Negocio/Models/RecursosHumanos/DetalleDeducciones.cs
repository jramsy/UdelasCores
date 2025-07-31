using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class DetalleDeducciones
{
    [Key]
    public int DetalleDeduccioneId { get; set; }

    public Guid DeduccionGuid { get; set; }

    [StringLength(50)]
    public string Cedula { get; set; } = null!;

    [Column("NroDRH")]
    [StringLength(7)]
    public string NroDrh { get; set; } = null!;

    public int CodDeduccion { get; set; }

    [StringLength(100)]
    public string DescripcionDeduccion { get; set; } = null!;

    [Column(TypeName = "numeric(18, 2)")]
    public decimal MontoDeducción { get; set; }
}
