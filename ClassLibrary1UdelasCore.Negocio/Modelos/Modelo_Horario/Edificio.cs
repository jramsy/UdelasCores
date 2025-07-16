using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class Edificio
{
    public string CodigoEdificio { get; set; } = null!;

    public int CodExtension { get; set; }

    public string Nombre { get; set; } = null!;

    public string Ubicacion { get; set; } = null!;

    public int CodEntidad { get; set; }
}
