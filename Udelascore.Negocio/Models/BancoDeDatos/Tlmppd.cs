using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Table("TLMPPD")]
public partial class Tlmppd
{
    [Key]
    [Column("ID_Estudio")]
    public int IdEstudio { get; set; }

    [Column("Cod_Estudio")]
    public int CodEstudio { get; set; }

    [Column("Nombre_Estudio")]
    [StringLength(100)]
    [Unicode(false)]
    public string NombreEstudio { get; set; } = null!;

    [Column("Cod_Tipo_Estudio")]
    public int CodTipoEstudio { get; set; }
}
