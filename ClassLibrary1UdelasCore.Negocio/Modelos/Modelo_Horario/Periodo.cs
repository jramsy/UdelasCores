using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class Periodo
{
    public int PeriodoId { get; set; }

    public int Periodo1 { get; set; }

    public int CodPeriodo { get; set; }

    public string Descripcion { get; set; } = null!;

    public int GradoId { get; set; }
}
