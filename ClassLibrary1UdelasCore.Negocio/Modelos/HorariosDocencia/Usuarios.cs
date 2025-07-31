using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class Usuarios
{
    [Column("id_usuario")]
    public int IdUsuario { get; set; }

    [Column("usuario")]
    [StringLength(15)]
    [Unicode(false)]
    public string Usuario { get; set; } = null!;

    [Column("password")]
    [StringLength(15)]
    [Unicode(false)]
    public string Password { get; set; } = null!;

    [Column("nombre")]
    [StringLength(25)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    [Column("apellido")]
    [StringLength(25)]
    [Unicode(false)]
    public string Apellido { get; set; } = null!;

    [Column("cedula")]
    [StringLength(13)]
    [Unicode(false)]
    public string Cedula { get; set; } = null!;

    [Column("entidad_labora")]
    public int EntidadLabora { get; set; }

    [Column("ubicacion_fisica")]
    [StringLength(100)]
    [Unicode(false)]
    public string UbicacionFisica { get; set; } = null!;

    [Column("maquina")]
    [StringLength(15)]
    [Unicode(false)]
    public string Maquina { get; set; } = null!;

    [Column("macadress")]
    [StringLength(25)]
    [Unicode(false)]
    public string Macadress { get; set; } = null!;

    [Column("ip")]
    [StringLength(25)]
    [Unicode(false)]
    public string Ip { get; set; } = null!;

    [Column("cargo")]
    [StringLength(25)]
    [Unicode(false)]
    public string Cargo { get; set; } = null!;

    [Column("funciones")]
    [StringLength(25)]
    [Unicode(false)]
    public string Funciones { get; set; } = null!;

    /// <summary>
    /// 0 no entra, 1 consulta, 5 operativo , 6 administrador
    /// </summary>
    [Column("nivel_acceso")]
    public int NivelAcceso { get; set; }

    [Column("fecha_creacion")]
    [StringLength(10)]
    [Unicode(false)]
    public string FechaCreacion { get; set; } = null!;

    [Column("observacion")]
    [StringLength(100)]
    [Unicode(false)]
    public string Observacion { get; set; } = null!;

    [Column("creador_cuenta")]
    [StringLength(15)]
    [Unicode(false)]
    public string CreadorCuenta { get; set; } = null!;

    [Column("facultad")]
    public int Facultad { get; set; }

    [Column("escuela")]
    public int Escuela { get; set; }

    [Column("carreras")]
    public int Carreras { get; set; }

    [Column("extension")]
    public int Extension { get; set; }

    [Column("guidusuario")]
    public Guid? Guidusuario { get; set; }

    [Column("codunidad")]
    public int? Codunidad { get; set; }
}
