using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Table("Estudios_BD")]
public partial class EstudiosBd
{
    [Key]
    [Column("ID")]
    public long Id { get; set; }

    public int Tipo { get; set; }

    public int Codigo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Descripcion { get; set; } = null!;

    public int Puntaje { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Fecha { get; set; }
}
