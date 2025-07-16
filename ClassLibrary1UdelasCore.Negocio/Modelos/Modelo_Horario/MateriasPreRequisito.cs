using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class MateriasPreRequisito
{
    public int CodMateria { get; set; }

    public int CodCarrera { get; set; }

    public string PlanCarrera { get; set; } = null!;

    public int IdMateriaAsociada { get; set; }

    public string NombreMateria { get; set; } = null!;
}
