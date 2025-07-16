using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class ProfesoresEvaluacionCurso
{
    public string? CedProfesor { get; set; }

    public int? CodExtension { get; set; }

    public int? Ano { get; set; }

    public int? Periodo { get; set; }

    public int Facultad { get; set; }

    public string? ActualperiodoEvaluacion { get; set; }
}
