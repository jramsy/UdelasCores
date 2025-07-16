using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class GruposCopium
{
    public int IdGrupo { get; set; }

    public int? AnoMatricula { get; set; }

    public int? PeriodoMatricula { get; set; }

    public string? FechaMatricula { get; set; }

    public int? CodExtension { get; set; }

    public int? CodFacultad { get; set; }

    public int? CodEscuela { get; set; }

    public int? CodCarrera { get; set; }

    public string? CodGrupo { get; set; }

    public string? LetraGrupo { get; set; }

    public int? SemestreGrupo { get; set; }

    public int? Turno { get; set; }

    public string? Salon { get; set; }

    public string? Edificio { get; set; }

    public string? Estatus1 { get; set; }

    public string? Estatus2 { get; set; }

    public int? CodHorPlantilla { get; set; }

    public string? Observacion { get; set; }

    public int? Cod1 { get; set; }

    public string? Cod2 { get; set; }
}
