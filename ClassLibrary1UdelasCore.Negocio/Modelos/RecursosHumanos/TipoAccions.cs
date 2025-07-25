using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Table("Tipo_Accions")]
public partial class TipoAccions
{
    [Key]
    [Column("Cod_Tipo_Accion")]
    public int CodTipoAccion { get; set; }

    [Column("Nombre_Accion")]
    [StringLength(50)]
    public string NombreAccion { get; set; } = null!;

    [Column("Descripcion_Accion")]
    [StringLength(300)]
    public string DescripcionAccion { get; set; } = null!;

    [Column("Horas_Curso")]
    [StringLength(1)]
    [Unicode(false)]
    public string HorasCurso { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal Monto { get; set; }

    [Column(TypeName = "money")]
    public decimal Vacaciones { get; set; }

    [Column("Cod_Categoria_Profesor")]
    public int CodCategoriaProfesor { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string Mensual { get; set; } = null!;

    public int Meses { get; set; }

    [Column("Cod_Nivel")]
    public int CodNivel { get; set; }

    [Column("Cod_Sub_Nivel")]
    public int CodSubNivel { get; set; }

    [Column("Tipo_Periodo")]
    public int TipoPeriodo { get; set; }

    [Column("Numero_Periodo")]
    public int NumeroPeriodo { get; set; }

    public int GradoId { get; set; }
}
