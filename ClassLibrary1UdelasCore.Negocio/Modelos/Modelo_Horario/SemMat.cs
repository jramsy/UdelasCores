using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class SemMat
{
    public int IdSemMat { get; set; }

    public string? NomSemMateria { get; set; }

    public int? Codigo { get; set; }

    public int? CodCarrera { get; set; }

    public int Periodo { get; set; }

    public int TipoPeriodo { get; set; }

    public int? GradoId { get; set; }
}
