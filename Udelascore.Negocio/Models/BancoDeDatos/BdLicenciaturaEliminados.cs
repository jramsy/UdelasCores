using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Keyless]
[Table("Bd_Licenciatura_eliminados")]
public partial class BdLicenciaturaEliminados
{
    [Column("Cod_lic")]
    public int CodLic { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Licenciatura { get; set; } = null!;
}
