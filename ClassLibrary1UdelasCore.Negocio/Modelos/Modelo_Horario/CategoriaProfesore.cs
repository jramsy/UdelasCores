using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class CategoriaProfesore
{
    public int CodCategoriaProfesor { get; set; }

    public string NombreCategoriaProfesor { get; set; } = null!;

    public string Abreviatura { get; set; } = null!;

    public int IdTipoPago { get; set; }
}
