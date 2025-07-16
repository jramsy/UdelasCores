using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class AuditoriaUsuarioHorario
{
    public Guid? Guidusuario { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public int Facultad { get; set; }

    public int Escuela { get; set; }

    public Guid? ApplicationId { get; set; }

    public string? Email { get; set; }

    public DateTime? LastLoginDate { get; set; }

    public bool? IsApproved { get; set; }

    public bool? IsLockedOut { get; set; }

    public int Extension { get; set; }

    public int NivelAcceso { get; set; }

    public string? RoleName { get; set; }
}
