using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class DepartamentosAdministrativos
{
    [Key]
    public int DepartamentoId { get; set; }

    [StringLength(100)]
    public string Descripcion { get; set; } = null!;

    [StringLength(50)]
    public string Edificio { get; set; } = null!;
}
