using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class HorariosCopium
{
    public int IdHorario { get; set; }

    public int IdGrupo { get; set; }

    public int IdCurso { get; set; }

    public int CodCurso { get; set; }

    public string AbrevMateria { get; set; } = null!;

    public int HInicial { get; set; }

    public int MInicial { get; set; }

    public string AmPmI { get; set; } = null!;

    public int HFinal { get; set; }

    public int MFinal { get; set; }

    public string AmPmF { get; set; } = null!;

    public int IntermedioMinutos { get; set; }

    public int NumeroDia { get; set; }

    public string NombreDia { get; set; } = null!;

    public int NumeroHora { get; set; }

    public string Salon { get; set; } = null!;

    public string Edificio { get; set; } = null!;

    public int TipoHoraClase { get; set; }

    public string NombreTipoClase { get; set; } = null!;

    public string TipoPago { get; set; } = null!;

    public string Estatus1 { get; set; } = null!;

    public string Estatus2 { get; set; } = null!;

    public int CodHorarioPlantilla { get; set; }

    public int Cod1 { get; set; }

    public string Cod2 { get; set; } = null!;

    public int Periodo { get; set; }

    public int Ano { get; set; }
}
