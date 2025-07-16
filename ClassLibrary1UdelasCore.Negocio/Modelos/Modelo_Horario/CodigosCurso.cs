using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class CodigosCurso
{
    public int IdCurso { get; set; }

    public int CodigoCurso { get; set; }

    public int CodExtension { get; set; }

    public int Anio { get; set; }

    public int Periodo { get; set; }

    public int TipoPeriodo { get; set; }

    public int GradoId { get; set; }
}
