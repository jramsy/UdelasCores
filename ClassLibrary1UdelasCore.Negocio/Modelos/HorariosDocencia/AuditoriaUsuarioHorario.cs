using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class AuditoriaUsuarioHorario
{
    [Column("guidusuario")]
    public Guid? Guidusuario { get; set; }

    [Column("nombre")]
    [StringLength(25)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    [Column("apellido")]
    [StringLength(25)]
    [Unicode(false)]
    public string Apellido { get; set; } = null!;

    [Column("facultad")]
    public int Facultad { get; set; }

    [Column("escuela")]
    public int Escuela { get; set; }

    public Guid? ApplicationId { get; set; }

    [StringLength(256)]
    public string? Email { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastLoginDate { get; set; }

    public bool? IsApproved { get; set; }

    public bool? IsLockedOut { get; set; }

    [Column("extension")]
    public int Extension { get; set; }

    [Column("nivel_acceso")]
    public int NivelAcceso { get; set; }

    [StringLength(256)]
    public string? RoleName { get; set; }
}
