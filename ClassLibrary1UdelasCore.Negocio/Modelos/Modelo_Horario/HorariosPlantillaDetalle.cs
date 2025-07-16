using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class HorariosPlantillaDetalle
{
    public int CodPlantilla { get; set; }

    public int HInicial { get; set; }

    public int MInicial { get; set; }

    public string AmpmI { get; set; } = null!;

    public int HFinal { get; set; }

    public int MFinal { get; set; }

    public string AmpmF { get; set; } = null!;

    public int NumeroHora { get; set; }

    public int MinutosIntermedio { get; set; }

    public int? CodExtension { get; set; }
}
