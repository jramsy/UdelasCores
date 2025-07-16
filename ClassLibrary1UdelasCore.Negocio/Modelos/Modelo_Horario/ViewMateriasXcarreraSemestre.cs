using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class ViewMateriasXcarreraSemestre
{
    public int CodMateria { get; set; }

    public int CodCarrera { get; set; }

    public int Periodo { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? NomSemMateria { get; set; }

    public int? IdPlan { get; set; }
}
