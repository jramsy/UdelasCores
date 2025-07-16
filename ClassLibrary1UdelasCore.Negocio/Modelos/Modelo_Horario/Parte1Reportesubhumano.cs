using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class Parte1Reportesubhumano
{
    public string CedProfesor { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string? TipoPago { get; set; }

    public int? CodCurso { get; set; }
}
