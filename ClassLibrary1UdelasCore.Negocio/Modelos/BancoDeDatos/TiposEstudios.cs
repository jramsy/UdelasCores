using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
[Table("Tipos_Estudios")]
public partial class TiposEstudios
{
    public int Tipo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Estudio { get; set; } = null!;
}
