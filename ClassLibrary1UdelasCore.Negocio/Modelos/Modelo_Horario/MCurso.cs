using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class MCurso
{
    public int MCursosId { get; set; }

    public string CodGrupo { get; set; } = null!;

    public string Grupo { get; set; } = null!;

    public int CodCurso { get; set; }

    public int CodAsignatura { get; set; }

    public string Asignatura { get; set; } = null!;

    public int CodFacultad { get; set; }

    public int CodCarrera { get; set; }

    public string CodProfesor { get; set; } = null!;

    public int CodTurno { get; set; }

    public int Creditos { get; set; }

    public int Tope { get; set; }

    public int Minimo { get; set; }

    public string Bloqueado { get; set; } = null!;

    public string Cerrado { get; set; } = null!;

    public string VerEnInforme { get; set; } = null!;

    public int IdAsignatura { get; set; }

    public int CodPeriodoMatricula { get; set; }

    public int TipoPeriodoMatricula { get; set; }

    public int AnoMatricula { get; set; }

    public int CodExtensionRegional { get; set; }

    public int IdGrupo { get; set; }

    public string CedProfesor { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public int CodEscuela { get; set; }
}
