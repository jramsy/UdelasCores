using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class Administrativos
{
    [Key]
    public int AdministrativosId { get; set; }

    public Guid Guid { get; set; }

    [StringLength(50)]
    public string CodEmpleado { get; set; } = null!;

    [StringLength(5)]
    public string CodigoEstructura { get; set; } = null!;

    [StringLength(50)]
    public string Cedula { get; set; } = null!;

    [StringLength(50)]
    public string PrimerNombre { get; set; } = null!;

    [StringLength(50)]
    public string SegundoNombre { get; set; } = null!;

    [StringLength(50)]
    public string ApellidoPaterno { get; set; } = null!;

    [StringLength(50)]
    public string ApellidoMaterno { get; set; } = null!;

    public DateOnly FechaRegistro { get; set; }

    [StringLength(50)]
    public string SeguroSocial { get; set; } = null!;

    [StringLength(1)]
    public string CodSexo { get; set; } = null!;

    [StringLength(50)]
    public string EstadoCivil { get; set; } = null!;

    [StringLength(50)]
    public string TipoSangre { get; set; } = null!;

    public DateOnly FechaNacimiento { get; set; }

    [StringLength(10)]
    public string FechaNacimientoS { get; set; } = null!;

    public int Edad { get; set; }

    [StringLength(200)]
    public string LugarNacimiento { get; set; } = null!;

    [StringLength(50)]
    public string Nacionalidad { get; set; } = null!;

    [StringLength(200)]
    public string DireccionResidencial { get; set; } = null!;

    [StringLength(50)]
    public string TelefonoRecidencia { get; set; } = null!;

    [StringLength(50)]
    public string Celular { get; set; } = null!;

    [StringLength(200)]
    public string Email { get; set; } = null!;

    [StringLength(1)]
    public string Alergico { get; set; } = null!;

    [StringLength(100)]
    public string DetalleAlergia { get; set; } = null!;

    public int CodExtension { get; set; }

    public int CodDepartamento { get; set; }

    public int Activo { get; set; }

    [StringLength(10)]
    public string FechaIngresoLabores { get; set; } = null!;
}
