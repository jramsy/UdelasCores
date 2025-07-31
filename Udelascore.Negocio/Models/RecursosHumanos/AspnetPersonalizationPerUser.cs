﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Table("aspnet_PersonalizationPerUser")]
[Index("UserId", "PathId", Name = "aspnet_PersonalizationPerUser_ncindex2", IsUnique = true)]
public partial class AspnetPersonalizationPerUser
{
    [Key]
    public Guid Id { get; set; }

    public Guid? PathId { get; set; }

    public Guid? UserId { get; set; }

    [Column(TypeName = "image")]
    public byte[] PageSettings { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDate { get; set; }

    [ForeignKey("PathId")]
    [InverseProperty("AspnetPersonalizationPerUser")]
    public virtual AspnetPaths? Path { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("AspnetPersonalizationPerUser")]
    public virtual AspnetUsers? User { get; set; }
}
