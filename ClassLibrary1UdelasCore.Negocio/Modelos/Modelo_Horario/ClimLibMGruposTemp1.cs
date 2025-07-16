using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class ClimLibMGruposTemp1
{
    public int MGruposId { get; set; }

    public string CodGrupo { get; set; } = null!;

    public string Grupo { get; set; } = null!;

    public int CodTurno { get; set; }

    public string Bloqueado { get; set; } = null!;

    public string Cerrado { get; set; } = null!;

    public string VerEnInforme { get; set; } = null!;

    public int CodFacultad { get; set; }

    public int CodCarrera { get; set; }

    public int AnoMatricula { get; set; }

    public int MesMatricula { get; set; }

    public int CodPeriodoMatricula { get; set; }

    public int TipoPeriodoMatricula { get; set; }

    public int CodPeriodoCarrera { get; set; }

    public int TipoPeriodoCarrera { get; set; }

    public int CodExtensionRegional { get; set; }

    public string Primeringreso { get; set; } = null!;
}
