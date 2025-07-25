using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class ControlDeVacaciones
{
    [Key]
    public int VacacionesId { get; set; }

    [StringLength(50)]
    public string Cedula { get; set; } = null!;

    [StringLength(50)]
    public string Nombres { get; set; } = null!;

    [StringLength(50)]
    public string Apellidos { get; set; } = null!;

    [Column("Fecha_Inicial", TypeName = "datetime")]
    public DateTime FechaInicial { get; set; }

    [Column("Fecha_Final", TypeName = "datetime")]
    public DateTime FechaFinal { get; set; }

    public int Dias { get; set; }

    /// <summary>
    /// 1: Por derecho; 2: Tomadas
    /// </summary>
    public int TipoV { get; set; }

    [StringLength(50)]
    public string DescripcionTipo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime FechaRegistro { get; set; }

    [StringLength(50)]
    public string Usuario { get; set; } = null!;

    public int Anio { get; set; }
}
