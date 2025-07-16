using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class VerificarGruposCantEstPma
{
    public int CodCurso { get; set; }

    public int CodMateria { get; set; }

    public int Ano { get; set; }

    public int Periodo { get; set; }

    public string CodGrupo { get; set; } = null!;

    public string CedProfesor { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string? Carrera { get; set; }

    public int? CantidadEstudiantes { get; set; }

    public int? CodCarrera { get; set; }

    public int CodExtension { get; set; }

    public string MateriaCompleta { get; set; } = null!;
}
