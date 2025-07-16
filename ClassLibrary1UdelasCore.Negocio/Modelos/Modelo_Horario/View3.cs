using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class View3
{
    public string CedProfesor { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Carrera { get; set; } = null!;

    public int? SemestreGrupo { get; set; }

    public string? LetraGrupo { get; set; }

    public int? Turno { get; set; }

    public string MateriaCompleta { get; set; } = null!;

    public string TipoPago { get; set; } = null!;

    public int? PeriodoMatricula { get; set; }

    public int TipoPeriodo { get; set; }

    public int? Expr1 { get; set; }
}
