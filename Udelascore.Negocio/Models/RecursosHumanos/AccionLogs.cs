using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Table("Accion_Logs")]
public partial class AccionLogs
{
    [Key]
    public Guid Guid { get; set; }

    [Column("Time_Stamp", TypeName = "datetime")]
    public DateTime TimeStamp { get; set; }

    [StringLength(50)]
    public string Usuario { get; set; } = null!;

    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    [StringLength(50)]
    public string Apellido { get; set; } = null!;

    [StringLength(13)]
    public string Cedula { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Fecha { get; set; }

    public int Anio { get; set; }

    public int Mes { get; set; }

    public int Dia { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Hora { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Minutos { get; set; }

    [StringLength(50)]
    public string Rol { get; set; } = null!;

    [Column("Cod_Sede")]
    public int CodSede { get; set; }

    [Column("IP")]
    [StringLength(50)]
    public string Ip { get; set; } = null!;

    [StringLength(50)]
    public string Instancia { get; set; } = null!;

    [Column("Cod_Instancia")]
    public int CodInstancia { get; set; }

    [StringLength(50)]
    public string Accion { get; set; } = null!;

    [StringLength(50)]
    public string Estatus { get; set; } = null!;
}
