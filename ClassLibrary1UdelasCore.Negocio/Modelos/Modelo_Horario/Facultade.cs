using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class Facultade
{
    public int CodFacultad { get; set; }

    public string Facultad { get; set; } = null!;

    public int CodExtension { get; set; }

    public int CodNivel { get; set; }
}
