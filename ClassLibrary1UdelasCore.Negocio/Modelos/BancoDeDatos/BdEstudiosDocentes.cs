using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Table("Bd_Estudios_Docentes")]
[Index("Cedula", Name = "ID_CodTipEstCed")]
public partial class BdEstudiosDocentes
{
    [Key]
    [Column("Id_Estudio")]
    public int IdEstudio { get; set; }

    [StringLength(50)]
    public string Cedula { get; set; } = null!;

    [Column("Cod_Estudio")]
    public int CodEstudio { get; set; }

    [Column("Cod_Tipo_Estudio")]
    public int CodTipoEstudio { get; set; }

    [Column("Nombre_Estudio")]
    [StringLength(200)]
    public string NombreEstudio { get; set; } = null!;

    public int Puntaje { get; set; }

    [StringLength(50)]
    public string Provincia { get; set; } = null!;

    [StringLength(1)]
    public string Habilitado { get; set; } = null!;

    [Column("Fecha_Registro", TypeName = "datetime")]
    public DateTime FechaRegistro { get; set; }

    [StringLength(200)]
    public string Direccion { get; set; } = null!;
}
