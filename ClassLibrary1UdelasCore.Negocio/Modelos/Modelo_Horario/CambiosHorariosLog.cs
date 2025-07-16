using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class CambiosHorariosLog
{
    public int CambioHorarioId { get; set; }

    public string CedulaAnterior { get; set; } = null!;

    public string CedulaActual { get; set; } = null!;

    public int CodCarrera { get; set; }

    public int CodCurso { get; set; }

    public int CodMateria { get; set; }

    public int CodExtension { get; set; }

    public int CodFacultad { get; set; }

    public int Periodo { get; set; }

    public int Anio { get; set; }

    public DateTime Fecha { get; set; }

    public string Usuario { get; set; } = null!;
}
