using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class AcuerdosCarrera
{
    public int IdPlan { get; set; }

    public string NomPlan { get; set; } = null!;

    public string Acuerdo { get; set; } = null!;

    public int CodCarrera { get; set; }
}
