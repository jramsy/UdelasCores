using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class SubTiposGrado
{
    public int SubTipoGradoId { get; set; }

    public int TipoGrado { get; set; }

    public string Descripcion { get; set; } = null!;
}
