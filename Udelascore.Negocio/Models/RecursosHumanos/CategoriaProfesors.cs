using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Table("Categoria_Profesors")]
public partial class CategoriaProfesors
{
    [Key]
    [Column("Cod_Categoria_Profesor")]
    public int CodCategoriaProfesor { get; set; }

    [Column("Nombre_Categoria_Profesor")]
    [StringLength(50)]
    public string NombreCategoriaProfesor { get; set; } = null!;

    [StringLength(10)]
    public string Abreviatura { get; set; } = null!;
}
