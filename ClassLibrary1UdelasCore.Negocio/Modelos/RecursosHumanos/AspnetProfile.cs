﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Table("aspnet_Profile")]
public partial class AspnetProfile
{
    [Key]
    public Guid UserId { get; set; }

    [Column(TypeName = "ntext")]
    public string PropertyNames { get; set; } = null!;

    [Column(TypeName = "ntext")]
    public string PropertyValuesString { get; set; } = null!;

    [Column(TypeName = "image")]
    public byte[] PropertyValuesBinary { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDate { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("AspnetProfile")]
    public virtual AspnetUsers User { get; set; } = null!;
}
