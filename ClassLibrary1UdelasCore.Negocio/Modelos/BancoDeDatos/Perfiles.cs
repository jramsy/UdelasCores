using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

public partial class Perfiles
{
    [Key]
    public int PerfilId { get; set; }

    public long? CodigoProfesor { get; set; }

    public byte[]? FotoPerfil { get; set; }

    /// <summary>
    /// 1: Foto, 2: Certificado de Colegio, 3: FotoCarnet
    /// </summary>
    public int? TipoDoc { get; set; }

    [StringLength(50)]
    public string? MimeType { get; set; }

    public DateOnly? FechaRegistro { get; set; }
}
