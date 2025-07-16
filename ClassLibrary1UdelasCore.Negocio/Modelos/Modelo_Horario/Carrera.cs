using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class Carrera
{
    public int CodExtension { get; set; }

    public int CodFacultad { get; set; }

    public int CodEscuela { get; set; }

    public int CodCarrera { get; set; }

    public string Carrera1 { get; set; } = null!;

    public string AbrevCarrera { get; set; } = null!;

    public string PlanCarrera { get; set; } = null!;

    public int TipoPeriodo { get; set; }

    public int Activa { get; set; }

    public string Acuerdo { get; set; } = null!;

    public string? Observacion { get; set; }

    public int? CodFacultad2 { get; set; }

    public int? CodEscuela2 { get; set; }

    public int? GradoId { get; set; }

    public int? Subgrado { get; set; }

    public int? CodTecnico { get; set; }

    public int? Nivel { get; set; }

    /// <summary>
    /// 0: no promocionada 1: promocionada
    /// </summary>
    public int Estatus { get; set; }
}
