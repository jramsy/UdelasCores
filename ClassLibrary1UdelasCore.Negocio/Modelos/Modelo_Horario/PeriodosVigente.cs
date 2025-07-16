using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class PeriodosVigente
{
    public int AnoVigente { get; set; }

    public int PeriodoSemestre { get; set; }

    public int PeriodoCuatrimestre { get; set; }

    public int PeriodoModulo { get; set; }
}
