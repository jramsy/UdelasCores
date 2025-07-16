using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class GrupoCursoLibretum
{
    public string CedProfesor { get; set; } = null!;

    public int CodCurso { get; set; }

    public int CodMateria { get; set; }

    public string? CodGrupo { get; set; }

    public int? CodCarrera { get; set; }

    public int Ano { get; set; }

    public int Periodo { get; set; }
}
