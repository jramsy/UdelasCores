using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class Autoridades
{
    [Key]
    public int AutoridadesId { get; set; }

    [StringLength(50)]
    public string Nombres { get; set; } = null!;

    [StringLength(50)]
    public string Apellidos { get; set; } = null!;

    [StringLength(50)]
    public string Cedula { get; set; } = null!;

    /// <summary>
    /// Valor binario para la firma digital
    /// </summary>
    public byte[] Firma { get; set; } = null!;

    /// <summary>
    /// Codigo: 1-Rector; 2-Director de Recursos Humanos
    /// </summary>
    public int CodAutoridad { get; set; }

    public int IdCargo { get; set; }

    public int Estatus { get; set; }
}
