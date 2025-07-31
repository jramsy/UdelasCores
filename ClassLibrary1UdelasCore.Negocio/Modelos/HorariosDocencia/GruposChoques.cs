using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class GruposChoques
{
    [Column("id_grupo")]
    public int IdGrupo { get; set; }

    [Column("cod_grupo")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CodGrupo { get; set; }

    [Column("id_curso")]
    public int IdCurso { get; set; }

    [Column("abrev_materia")]
    [StringLength(25)]
    [Unicode(false)]
    public string AbrevMateria { get; set; } = null!;

    [Column("numero_dia")]
    public int NumeroDia { get; set; }

    [Column("numero_hora")]
    public int NumeroHora { get; set; }

    [Column("salon")]
    [StringLength(5)]
    [Unicode(false)]
    public string Salon { get; set; } = null!;

    [Column("edificio")]
    [StringLength(5)]
    [Unicode(false)]
    public string Edificio { get; set; } = null!;
}
