using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Table("Categoria_Profesores")]
public partial class CategoriaProfesores
{
    [Key]
    [Column("Cod_Categoria_Profesor")]
    public int CodCategoriaProfesor { get; set; }

    [Column("Nombre_Categoria_Profesor")]
    [StringLength(50)]
    public string NombreCategoriaProfesor { get; set; } = null!;

    [StringLength(10)]
    public string Abreviatura { get; set; } = null!;

    [Column("Id_Tipo_Pago")]
    public int IdTipoPago { get; set; }
}
