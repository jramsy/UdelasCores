using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class ViewPorAutorizarConHorariosTurno
{
    public string? Expr1 { get; set; }

    public int? HInicial { get; set; }

    public int? MInicial { get; set; }

    public string? AmPmI { get; set; }

    public int? HFinal { get; set; }

    public int? MFinal { get; set; }

    public string? AmPmF { get; set; }

    public int? CodExtension { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? NombreDia { get; set; }

    public int? IdHorario { get; set; }
}
