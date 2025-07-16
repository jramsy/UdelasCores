using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class CarrerasTecnico
{
    public int CodTecnico { get; set; }

    public string? Tecnico { get; set; }

    public string? AbrevTecnico { get; set; }

    public int? Activo { get; set; }

    public string? Acuerdo { get; set; }

    public int? GradoId { get; set; }

    public int? Subgrado { get; set; }

    public int? CodCarrera { get; set; }
}
