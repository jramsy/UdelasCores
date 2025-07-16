using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class PeriodoPorDiplomado
{
    public int IdPeriodoPorDiplomado { get; set; }

    public int Periodo { get; set; }

    public int CodPeriodo { get; set; }

    public int CodCarrera { get; set; }

    public string DescripcionDiplomado { get; set; } = null!;
}
