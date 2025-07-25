using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Table("Bd_especialidad")]
public partial class BdEspecialidad
{
    [Key]
    [Column("Cod_especialidad")]
    public int CodEspecialidad { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Especialidad { get; set; }

    [Column("Cod_1")]
    public int Cod1 { get; set; }

    [Column("Cod_2")]
    public int Cod2 { get; set; }

    [Column("Cod_3")]
    public int Cod3 { get; set; }
}
