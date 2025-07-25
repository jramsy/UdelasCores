using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Keyless]
[Table("REPORTES")]
public partial class Reportes
{
    [Column("FUNCIONARIO")]
    [StringLength(255)]
    public string? Funcionario { get; set; }

    [Column("CEDULA")]
    [StringLength(255)]
    public string? Cedula { get; set; }

    [Column("DEPARTAMENTO")]
    [StringLength(255)]
    public string? Departamento { get; set; }

    [Column("SEDE")]
    [StringLength(255)]
    public string? Sede { get; set; }

    [Column("CORREO")]
    [StringLength(255)]
    public string? Correo { get; set; }

    public int Id { get; set; }

    [Column("cod_Sede")]
    public int CodSede { get; set; }

    [Column("codDepto")]
    public int CodDepto { get; set; }
}
