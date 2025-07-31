using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

public partial class Instancias
{
    [Key]
    [Column("Cod_Instancia")]
    public int CodInstancia { get; set; }

    [Column("Nombre_Instancia")]
    [StringLength(50)]
    public string NombreInstancia { get; set; } = null!;

    [StringLength(50)]
    public string Sede { get; set; } = null!;

    [Column("Cod_Facultad")]
    public int CodFacultad { get; set; }

    [Column("Cod_Sede")]
    public int CodSede { get; set; }
}
