using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class PeriodosAcademico
{
    public int CodTipoPeriodo { get; set; }

    public int Numero { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Abreviado { get; set; } = null!;
}
