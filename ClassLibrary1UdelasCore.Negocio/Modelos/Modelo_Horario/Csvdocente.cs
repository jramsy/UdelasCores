using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class Csvdocente
{
    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string CedProfesor { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Email { get; set; }

    public string? Sede { get; set; }
}
