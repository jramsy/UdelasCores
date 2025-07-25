using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Keyless]
public partial class VwAspnetProfiles
{
    public Guid UserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDate { get; set; }

    public int? DataSize { get; set; }
}
