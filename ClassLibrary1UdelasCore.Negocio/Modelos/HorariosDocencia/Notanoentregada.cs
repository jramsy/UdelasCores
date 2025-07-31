using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class Notanoentregada
{
    [Column("cod_curso")]
    public int CodCurso { get; set; }
}
