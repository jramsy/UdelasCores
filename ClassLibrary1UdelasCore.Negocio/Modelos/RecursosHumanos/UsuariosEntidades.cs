using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class UsuariosEntidades
{
    [Key]
    [Column("ID_usuarios")]
    public int IdUsuarios { get; set; }

    [Column("Guid_usuarios")]
    public Guid? GuidUsuarios { get; set; }

    [Column("ID_entidad")]
    public int? IdEntidad { get; set; }

    [Column("Cod_entidad")]
    public int? CodEntidad { get; set; }

    [Column("Cod_extension")]
    public int? CodExtension { get; set; }
}
