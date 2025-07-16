using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class Turno
{
    public int CodTurno { get; set; }

    public string Nombre { get; set; } = null!;

    public string Abreviado { get; set; } = null!;

    public string Observacion { get; set; } = null!;
}
