using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class ListadoAnioMayorDocente
{
    public string CedProfesor { get; set; } = null!;

    public int Ano { get; set; }

    public string Facultad { get; set; } = null!;

    public string NombreExtension { get; set; } = null!;
}
