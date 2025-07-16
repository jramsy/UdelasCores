using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class ViewHorariosCurso
{
    public int HInicial { get; set; }

    public int MInicial { get; set; }

    public string AmPmI { get; set; } = null!;

    public int HFinal { get; set; }

    public int MFinal { get; set; }

    public string AmPmF { get; set; } = null!;

    public int IdCurso { get; set; }

    public int? CodExtension { get; set; }

    public string? CedProfesor { get; set; }

    public string NombreDia { get; set; } = null!;

    public int IdHorario { get; set; }
}
