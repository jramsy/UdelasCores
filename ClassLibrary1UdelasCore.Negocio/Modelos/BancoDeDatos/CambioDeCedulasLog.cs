using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

public partial class CambioDeCedulasLog
{
    [Key]
    public int CambioCedulaId { get; set; }

    [StringLength(13)]
    public string CedulaNueva { get; set; } = null!;

    [StringLength(13)]
    public string CedulaAnterior { get; set; } = null!;

    public DateOnly Fecha { get; set; }

    [Column("Nro_Identificacion")]
    [StringLength(50)]
    public string NroIdentificacion { get; set; } = null!;

    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    [StringLength(50)]
    public string Apellido { get; set; } = null!;

    [StringLength(50)]
    public string NombreUsuario { get; set; } = null!;
}
