using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class GruposEspeciale
{
    public int Idr { get; set; }

    public int? AnioActual { get; set; }

    public int? PeriodoActual { get; set; }

    public string? GrupoActual { get; set; }

    public int? CodExtension { get; set; }

    public int? CodFacultad { get; set; }

    public int? IdGrupoReferencia { get; set; }

    public string? GrupoAnterior { get; set; }

    public int? AnioAnterior { get; set; }

    public int? PeriodoAnterior { get; set; }
}
