using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

public partial class Escuelas
{
    [Column("cod_extension")]
    public int CodExtension { get; set; }

    [Column("cod_facultad")]
    public int CodFacultad { get; set; }

    [Column("cod_escuela")]
    public int CodEscuela { get; set; }

    [Column("nombre")]
    [StringLength(50)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    [Key]
    [Column("id_escuela")]
    public int IdEscuela { get; set; }
}
