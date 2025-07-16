using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class Curso
{
    public int IdCurso { get; set; }

    public int IdGrupo { get; set; }

    public int CodCurso { get; set; }

    public int CodMateria { get; set; }

    public string MateriaAbreviada { get; set; } = null!;

    public string MateriaCompleta { get; set; } = null!;

    public int Ano { get; set; }

    public int Periodo { get; set; }

    public int CodProfesor { get; set; }

    public string CedProfesor { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public int CodTurno { get; set; }

    public string Salon { get; set; } = null!;

    public string Edificio { get; set; } = null!;

    public string Estatus1 { get; set; } = null!;

    public string Estatus2 { get; set; } = null!;

    public int CantidadEstudiantes { get; set; }

    public int Creditos { get; set; }

    public int PeriodoMateria { get; set; }

    public int CodFinanciero { get; set; }

    public string DirEspecial { get; set; } = null!;

    public string CodGrupo { get; set; } = null!;

    public string Grupo { get; set; } = null!;

    public int CodDeparatmento { get; set; }

    public int CodExtension { get; set; }

    public int CodFacultad { get; set; }

    public int? CodEscuela { get; set; }

    public int CodCarrera { get; set; }

    /// <summary>
    /// La cantidad de semanas que realmente se va impartir este curso,si es -1, entonces se usan las semanas del periodo y se obvia la cantidad de este campo.
    /// </summary>
    public int Cod1 { get; set; }

    public string Cod2 { get; set; } = null!;

    public DateTime? Fechaasigdoc { get; set; }

    public Guid? Guidusuarioasigdoc { get; set; }

    public DateTime? Fechaasigpos { get; set; }

    public Guid? Guidusuarioasigpos { get; set; }

    public int? IdPosicion { get; set; }

    public int AnioVigente { get; set; }
}
