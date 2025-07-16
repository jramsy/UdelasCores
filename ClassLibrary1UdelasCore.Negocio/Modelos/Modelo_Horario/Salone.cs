using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class Salone
{
    public string CodSalon { get; set; } = null!;

    public string CodEdificio { get; set; } = null!;

    public int CodExtension { get; set; }

    public string NombreSalon { get; set; } = null!;

    public string Ubicacion { get; set; } = null!;

    public int TipoSalon { get; set; }

    public int Condiciones { get; set; }

    public int Gg { get; set; }
}
