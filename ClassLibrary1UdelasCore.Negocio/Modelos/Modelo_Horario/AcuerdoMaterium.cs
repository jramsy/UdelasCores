using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class AcuerdoMaterium
{
    /// <summary>
    /// identificacion del acuerdo
    /// </summary>
    public string Nomenclatura { get; set; } = null!;

    public string Fecha { get; set; } = null!;

    public string Observacion { get; set; } = null!;

    /// <summary>
    /// Hay veces que ademas de la nomenclatura o identif de plan, se adjunta un titulo que lo describe
    /// </summary>
    public string Titulo { get; set; } = null!;

    public int CodCarrera { get; set; }

    public string PlanCarrera { get; set; } = null!;
}
