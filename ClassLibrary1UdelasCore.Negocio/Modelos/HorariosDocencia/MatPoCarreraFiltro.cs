using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class MatPoCarreraFiltro
{
    [Column("cod_materia")]
    public int CodMateria { get; set; }

    [Column("cod_carrera")]
    public int CodCarrera { get; set; }
}
