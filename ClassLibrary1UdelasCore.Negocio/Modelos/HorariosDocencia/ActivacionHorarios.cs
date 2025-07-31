using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

public partial class ActivacionHorarios
{
    [Key]
    public int Id { get; set; }

    public int Anio { get; set; }

    public int Periodo { get; set; }

    public int Extension { get; set; }

    public int Activado { get; set; }
}
