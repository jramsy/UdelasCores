using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class CodigosCursos
{
    public int IdCurso { get; set; }

    [Column("Codigo_Curso")]
    public int CodigoCurso { get; set; }

    [Column("Cod_Extension")]
    public int CodExtension { get; set; }

    public int Anio { get; set; }

    public int Periodo { get; set; }

    public int TipoPeriodo { get; set; }

    public int GradoId { get; set; }
}
