using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class SalonesChoque1
{
    public int NumeroDia { get; set; }

    public int NumeroHora { get; set; }

    public string Salon { get; set; } = null!;

    public string Edificio { get; set; } = null!;

    public int? Expr1 { get; set; }
}
