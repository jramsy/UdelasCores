using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class MateriasPorCarrera
{
    public int IdMateria { get; set; }

    public int CodMateria { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Abreviatura { get; set; } = null!;

    public int TipoPeriodo { get; set; }

    public int Periodo { get; set; }

    public int Creditos { get; set; }

    public int CodCarrera { get; set; }

    public int CodDepartamento { get; set; }

    public int HorasTeoria { get; set; }

    public int HorasLab { get; set; }

    public int HorasOtros { get; set; }

    public int HorasTotal { get; set; }

    public int FlagPrerequisitos { get; set; }

    public string? Observacion { get; set; }

    public int? IdPlan { get; set; }

    public int CodCarrera2 { get; set; }

    public int Tecnico { get; set; }

    /// <summary>
    /// 1 - materia activa / 0 - materia desactivada
    /// </summary>
    public int Estatus { get; set; }

    /// <summary>
    /// Estatus para las materias Prácticas Universitarias: 0 No tiene horas prácticas, 1 si tiene horas prácticas (Lic)
    /// </summary>
    public int HorasPracticas { get; set; }

    public DateTime Horaregistro { get; set; }

    public string Operador { get; set; } = null!;
}
