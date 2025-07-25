using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Table("aspnet_PersonalizationAllUsers")]
public partial class AspnetPersonalizationAllUsers
{
    [Key]
    public Guid PathId { get; set; }

    [Column(TypeName = "image")]
    public byte[] PageSettings { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDate { get; set; }

    [ForeignKey("PathId")]
    [InverseProperty("AspnetPersonalizationAllUsers")]
    public virtual AspnetPaths Path { get; set; } = null!;
}
