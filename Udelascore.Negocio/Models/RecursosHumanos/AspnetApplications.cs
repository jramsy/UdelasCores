using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Table("aspnet_Applications")]
[Index("LoweredApplicationName", Name = "UQ__aspnet_A__17477DE45B78929E", IsUnique = true)]
[Index("ApplicationName", Name = "UQ__aspnet_A__309103315E54FF49", IsUnique = true)]
public partial class AspnetApplications
{
    [StringLength(256)]
    public string ApplicationName { get; set; } = null!;

    [StringLength(256)]
    public string LoweredApplicationName { get; set; } = null!;

    [Key]
    public Guid ApplicationId { get; set; }

    [StringLength(256)]
    public string? Description { get; set; }

    [InverseProperty("Application")]
    public virtual ICollection<AspnetMembership> AspnetMembership { get; set; } = new List<AspnetMembership>();

    [InverseProperty("Application")]
    public virtual ICollection<AspnetPaths> AspnetPaths { get; set; } = new List<AspnetPaths>();

    [InverseProperty("Application")]
    public virtual ICollection<AspnetRoles> AspnetRoles { get; set; } = new List<AspnetRoles>();

    [InverseProperty("Application")]
    public virtual ICollection<AspnetUsers> AspnetUsers { get; set; } = new List<AspnetUsers>();
}
