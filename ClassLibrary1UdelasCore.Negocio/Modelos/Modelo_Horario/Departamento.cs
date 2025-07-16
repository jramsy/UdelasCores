using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class Departamento
{
    public int CodDepartamento { get; set; }

    public int? CodFacultad { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }
}
