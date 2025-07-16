using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class CursoOficialCruceMatriculadaPanama
{
    public int CodCurso { get; set; }

    public int CodMateria { get; set; }

    public string CedProfesor { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public int? Cantidad { get; set; }

    public string? CodGrupo { get; set; }

    public string MateriaCompleta { get; set; } = null!;
}
