using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class GruposChoque
{
    public int IdGrupo { get; set; }

    public string? CodGrupo { get; set; }

    public int IdCurso { get; set; }

    public string AbrevMateria { get; set; } = null!;

    public int NumeroDia { get; set; }

    public int NumeroHora { get; set; }

    public string Salon { get; set; } = null!;

    public string Edificio { get; set; } = null!;
}
