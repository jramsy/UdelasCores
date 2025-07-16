using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class TipoPago1
{
    public int IdTipoPago { get; set; }

    public string Descripcion { get; set; } = null!;

    public decimal MontoHoras { get; set; }

    public decimal MontoVacaciones { get; set; }

    public int TipoEstudio { get; set; }

    public int SubTipoGrado { get; set; }

    public int Nivel { get; set; }
}
