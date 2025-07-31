using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
[Table("Prueba1_Copia")]
public partial class Prueba1Copia
{
    [Column("id")]
    public int Id { get; set; }

    [Column("cedula")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Cedula { get; set; }

    [Column("estudios")]
    [StringLength(600)]
    [Unicode(false)]
    public string? Estudios { get; set; }

    [Column("codigo_estudio")]
    public int? CodigoEstudio { get; set; }

    [Column("codigo_tipo")]
    public int? CodigoTipo { get; set; }

    [Column("puntaje")]
    public float? Puntaje { get; set; }

    [Column("provincia")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Provincia { get; set; }

    [Column("habilitado")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Habilitado { get; set; }

    [Column("fecha", TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    [Column("direccion")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Direccion { get; set; }
}
