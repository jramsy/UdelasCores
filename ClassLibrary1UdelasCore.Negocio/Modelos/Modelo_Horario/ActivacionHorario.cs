using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class ActivacionHorario
{
    public int Id { get; set; }

    public int Anio { get; set; }

    public int Periodo { get; set; }

    public int Extension { get; set; }

    public int Activado { get; set; }
}
