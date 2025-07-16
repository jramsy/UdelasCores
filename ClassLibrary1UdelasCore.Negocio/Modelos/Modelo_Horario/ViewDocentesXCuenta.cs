using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class ViewDocentesXCuenta
{
    public string Id { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string CedProfesor { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? NombreExtension { get; set; }

    public string Clave { get; set; } = null!;

    public string? Email { get; set; }

    public string Version { get; set; } = null!;

    public string Activo { get; set; } = null!;
}
