using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class BitacoraPr
{
    public int IdTbl { get; set; }

    public int? IdMateria { get; set; }

    public int? CodMateriaPr { get; set; }

    public int? CodCarrera { get; set; }

    /// <summary>
    /// 1. borró PR, 2. agregró PR
    /// </summary>
    public int? Estatus { get; set; }

    public string? Operador { get; set; }

    public string? Motivo { get; set; }

    public DateTime? Fecha { get; set; }
}
