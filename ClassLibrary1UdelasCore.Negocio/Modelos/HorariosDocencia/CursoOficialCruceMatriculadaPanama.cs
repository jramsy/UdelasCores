using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
public partial class CursoOficialCruceMatriculadaPanama
{
    [Column("cod_curso")]
    public int CodCurso { get; set; }

    [Column("cod_materia")]
    public int CodMateria { get; set; }

    [Column("ced_profesor")]
    [StringLength(13)]
    [Unicode(false)]
    public string CedProfesor { get; set; } = null!;

    [Column("nombre")]
    [StringLength(25)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    [Column("apellido")]
    [StringLength(25)]
    [Unicode(false)]
    public string Apellido { get; set; } = null!;

    [Column("cantidad")]
    public int? Cantidad { get; set; }

    [Column("cod_grupo")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CodGrupo { get; set; }

    [Column("materia_completa")]
    [StringLength(150)]
    [Unicode(false)]
    public string MateriaCompleta { get; set; } = null!;
}
