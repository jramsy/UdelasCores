using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class Sesiones
{
    [Column("id_sesion")]
    [StringLength(50)]
    [Unicode(false)]
    public string IdSesion { get; set; } = null!;

    [Column("tablas_afectadas")]
    [StringLength(25)]
    [Unicode(false)]
    public string TablasAfectadas { get; set; } = null!;

    [Column("tipo_de_operaciones")]
    [StringLength(25)]
    [Unicode(false)]
    public string TipoDeOperaciones { get; set; } = null!;

    [Column("id_usuario")]
    public int IdUsuario { get; set; }

    [Column("maquina")]
    [StringLength(50)]
    [Unicode(false)]
    public string Maquina { get; set; } = null!;

    [Column("macadress")]
    [StringLength(50)]
    [Unicode(false)]
    public string Macadress { get; set; } = null!;

    [Column("ip")]
    [StringLength(50)]
    [Unicode(false)]
    public string Ip { get; set; } = null!;

    [Column("fecha")]
    [StringLength(10)]
    [Unicode(false)]
    public string Fecha { get; set; } = null!;

    [Column("hora")]
    [StringLength(10)]
    [Unicode(false)]
    public string Hora { get; set; } = null!;
}
