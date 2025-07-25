using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
[Table("Cursos_HORARIOS")]
public partial class CursosHorarios
{
    [Column("id_curso")]
    public int IdCurso { get; set; }

    [Column("cod_curso")]
    public int CodCurso { get; set; }

    [Column("cod_materia")]
    public int CodMateria { get; set; }

    [Column("materia_completa")]
    [StringLength(150)]
    [Unicode(false)]
    public string MateriaCompleta { get; set; } = null!;

    [Column("ano")]
    public int Ano { get; set; }

    [Column("periodo")]
    public int Periodo { get; set; }

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
}
