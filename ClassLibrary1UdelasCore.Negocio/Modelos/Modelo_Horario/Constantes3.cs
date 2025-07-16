using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class Constantes3
{
    public int IdTabla { get; set; }

    public int? Ano { get; set; }

    public int? Periodo { get; set; }

    public string? FechaInicialSem { get; set; }

    public string? FechaFinalSem { get; set; }

    public string? FechaInicialPost { get; set; }

    public string? FechaFinalPost { get; set; }

    public string? Version { get; set; }

    public int? PeriodoPost { get; set; }

    public string Actual { get; set; } = null!;

    public string? Cerrado { get; set; }

    public string? CerradoEvaluacion { get; set; }

    public string? ActualLibreta { get; set; }

    public string? ActualperiodoEvaluacion { get; set; }
}
