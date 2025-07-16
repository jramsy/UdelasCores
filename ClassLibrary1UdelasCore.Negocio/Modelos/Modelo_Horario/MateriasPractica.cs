using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class MateriasPractica
{
    public int Idmateria { get; set; }

    public int CodMateria { get; set; }

    public int CodCarrera { get; set; }

    public string CompetenciaNivelPractica { get; set; } = null!;
}
