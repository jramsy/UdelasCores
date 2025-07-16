using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class MCostosFijosGruposTemp
{
    public int MCostosFijosGruposId { get; set; }

    public int CodCarrera { get; set; }

    public int CodContenedor { get; set; }

    public string CodGrupo { get; set; } = null!;

    public int CodExtension { get; set; }

    public int Ano { get; set; }

    public int CodPeriodoMatricula { get; set; }

    public int TipoPeriodoMatricula { get; set; }
}
