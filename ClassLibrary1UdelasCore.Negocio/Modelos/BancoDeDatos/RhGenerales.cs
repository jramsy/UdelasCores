using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
[Table("RH_generales")]
public partial class RhGenerales
{
    [StringLength(13)]
    [Unicode(false)]
    public string Cedula { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string FechaEntrada { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string NumeroContrato { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string FechaConfeccion { get; set; } = null!;

    [Column(TypeName = "decimal(24, 2)")]
    public decimal Valor { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string Provincia { get; set; } = null!;

    [StringLength(70)]
    [Unicode(false)]
    public string Estatus { get; set; } = null!;

    [StringLength(25)]
    [Unicode(false)]
    public string Recorrido { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string Apellido { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Anulado { get; set; } = null!;

    public int Contador { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Usuario { get; set; }

    [Column("sexo")]
    [StringLength(2)]
    [Unicode(false)]
    public string Sexo { get; set; } = null!;
}
