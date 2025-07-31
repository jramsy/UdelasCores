using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

public partial class ProvinciasPorDocentes
{
    [Key]
    public int ProvinciaDocenteId { get; set; }

    [StringLength(50)]
    public string CedulaDocente { get; set; } = null!;

    public int CodProvincia { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaRegistro { get; set; }
}
