using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Keyless]
public partial class VmAccion4
{
    [Column("id_accion")]
    public int IdAccion { get; set; }

    [Column("Guid_Accion")]
    public Guid GuidAccion { get; set; }

    [StringLength(10)]
    public string? Resolucion { get; set; }

    [StringLength(13)]
    public string? Cedula { get; set; }

    [StringLength(50)]
    public string? Nombre { get; set; }

    [StringLength(50)]
    public string? Apellido { get; set; }

    [Column("Cod_Tipo_Accion")]
    public int? CodTipoAccion { get; set; }

    [Column("Cod_Sede")]
    public int? CodSede { get; set; }

    [Column("Codigo_BancoDatos")]
    public long? CodigoBancoDatos { get; set; }

    [Column("posicion")]
    [StringLength(5)]
    public string? Posicion { get; set; }

    [StringLength(50)]
    public string? Cargo { get; set; }

    [Column("Cod_Instancia")]
    public int? CodInstancia { get; set; }

    [Column("Cod_Departamento")]
    public int? CodDepartamento { get; set; }

    [Column("Accion_Afectada")]
    public int? AccionAfectada { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? Salario { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? Vacaciones { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? Total { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? Mensual { get; set; }

    [Column("Fecha_Contrato", TypeName = "datetime")]
    public DateTime? FechaContrato { get; set; }

    public int? Anio { get; set; }

    public int? Mes { get; set; }

    public int? Dia { get; set; }

    [Column("Fecha_Sistema", TypeName = "datetime")]
    public DateTime? FechaSistema { get; set; }

    [StringLength(50)]
    public string? Observacion { get; set; }

    [Column("Estatus_Accion")]
    public int? EstatusAccion { get; set; }

    public int? Extension { get; set; }

    [Column("Periodo_Contrato")]
    [StringLength(50)]
    public string? PeriodoContrato { get; set; }

    [Column("Inicio_Clase")]
    [StringLength(50)]
    public string? InicioClase { get; set; }

    [Column("Fecha_Nacimiento")]
    [StringLength(50)]
    public string? FechaNacimiento { get; set; }

    [Column("Lugar_Nacimiento")]
    [StringLength(70)]
    public string? LugarNacimiento { get; set; }

    [Column("Categoria_profesor")]
    [StringLength(1)]
    public string? CategoriaProfesor { get; set; }

    [StringLength(50)]
    public string? Seguro { get; set; }

    public int SaldoD { get; set; }

    [Column("cod_tipo_estado")]
    public int? CodTipoEstado { get; set; }

    public string Partida { get; set; } = null!;

    [StringLength(50)]
    public string? Operador { get; set; }

    [Column("Estatus_Enviado")]
    public int EstatusEnviado { get; set; }

    [Column("Estatus_Imprimir")]
    public int? EstatusImprimir { get; set; }

    [Column("Estatus_Devuelto")]
    public int EstatusDevuelto { get; set; }

    [Column("Fecha_Enviado", TypeName = "datetime")]
    public DateTime? FechaEnviado { get; set; }

    [Column("Estatus_Firmado")]
    public int? EstatusFirmado { get; set; }
}
