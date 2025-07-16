using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class Escuela
{
    public int CodExtension { get; set; }

    public int CodFacultad { get; set; }

    public int CodEscuela { get; set; }

    public string Nombre { get; set; } = null!;

    public int IdEscuela { get; set; }
}
