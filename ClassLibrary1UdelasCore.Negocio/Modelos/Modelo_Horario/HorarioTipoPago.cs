using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class HorarioTipoPago
{
    public int IdCurso { get; set; }

    public string TipoPago { get; set; } = null!;

    public int? T { get; set; }
}
