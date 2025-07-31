using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Table("Cambios_Horarios_Log")]
public partial class CambiosHorariosLog
{
    [Key]
    public int CambioHorarioId { get; set; }

    [StringLength(13)]
    public string CedulaAnterior { get; set; } = null!;

    [StringLength(13)]
    public string CedulaActual { get; set; } = null!;

    public int CodCarrera { get; set; }

    public int CodCurso { get; set; }

    public int CodMateria { get; set; }

    public int CodExtension { get; set; }

    public int CodFacultad { get; set; }

    public int Periodo { get; set; }

    public int Anio { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Fecha { get; set; }

    [StringLength(50)]
    public string Usuario { get; set; } = null!;
}
