using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class HorariosPlantilla
{
    public int CodPlantilla { get; set; }

    public string Nombre { get; set; } = null!;

    public string Observacion { get; set; } = null!;
}
