using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class ViewNumCar
{
    [Column("ID")]
    public int? Id { get; set; }

    [Column("cod_carrera")]
    public int? CodCarrera { get; set; }

    public int? Numero { get; set; }
}
