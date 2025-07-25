using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Table("Bd_Categorias")]
public partial class BdCategorias
{
    [Key]
    public int IdCategoria { get; set; }

    [StringLength(50)]
    public string NombreCategoria { get; set; } = null!;
}
