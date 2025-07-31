using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class Posiciones
{
    [Key]
    public int IdPosicion { get; set; }

    public int NroPosicion { get; set; }

    [StringLength(100)]
    public string Descripcion { get; set; } = null!;

    [Column(TypeName = "numeric(18, 2)")]
    public decimal Monto { get; set; }

    public int Anio { get; set; }

    public int CodInstancia { get; set; }

    public int CodExtension { get; set; }

    [StringLength(1)]
    public string Asignado { get; set; } = null!;

    [StringLength(50)]
    public string Partida { get; set; } = null!;
}
