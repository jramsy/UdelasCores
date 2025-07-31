using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class MateriasParaVerificarTecnico
{
    [Column("creditos")]
    public int Creditos { get; set; }

    [Column("cod_materia")]
    public int CodMateria { get; set; }

    [Column("periodo")]
    public int Periodo { get; set; }
}
