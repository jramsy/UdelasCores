using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class T3Horario
{
    public int IdCurso { get; set; }

    public string T { get; set; } = null!;

    public int? Ano { get; set; }

    public int? Periodo { get; set; }
}
