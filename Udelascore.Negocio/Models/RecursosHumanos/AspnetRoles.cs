using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Table("aspnet_Roles")]
public partial class AspnetRoles
{
    public Guid ApplicationId { get; set; }

    [Key]
    public Guid RoleId { get; set; }

    [StringLength(256)]
    public string RoleName { get; set; } = null!;

    [StringLength(256)]
    public string LoweredRoleName { get; set; } = null!;

    [StringLength(256)]
    public string? Description { get; set; }

    [ForeignKey("ApplicationId")]
    [InverseProperty("AspnetRoles")]
    public virtual AspnetApplications Application { get; set; } = null!;

    [ForeignKey("RoleId")]
    [InverseProperty("Role")]
    public virtual ICollection<AspnetUsers> User { get; set; } = new List<AspnetUsers>();
}
