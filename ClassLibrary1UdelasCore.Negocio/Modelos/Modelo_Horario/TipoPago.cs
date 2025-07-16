using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class TipoPago
{
    public int CodTipo { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Observacion { get; set; } = null!;
}
