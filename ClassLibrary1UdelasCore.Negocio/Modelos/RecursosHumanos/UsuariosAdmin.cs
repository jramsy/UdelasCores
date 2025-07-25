using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class UsuariosAdmin
{
    [Key]
    public int UsuariosId { get; set; }

    public Guid UserGuid { get; set; }

    public int CodExtension { get; set; }

    /// <summary>
    /// se utiliza -1 para los operadores
    /// </summary>
    public int CodFacultad { get; set; }
}
