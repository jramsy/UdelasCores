using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class TipoDocente
{
    public int CodTipoDocente { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Observacion { get; set; } = null!;
}
