using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class NotasMaterium
{
    public string Nomenclatura { get; set; } = null!;

    public string Fecha { get; set; } = null!;

    public string FirmaDe { get; set; } = null!;

    public string ResumenContenido { get; set; } = null!;

    public string Asunto { get; set; } = null!;

    public int CodCarrera { get; set; }

    public string PlanCarrera { get; set; } = null!;
}
