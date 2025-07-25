﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Table("aspnet_Users")]
[Index("ApplicationId", "LastActivityDate", Name = "aspnet_Users_Index2")]
public partial class AspnetUsers
{
    public Guid ApplicationId { get; set; }

    [Key]
    public Guid UserId { get; set; }

    [StringLength(256)]
    public string UserName { get; set; } = null!;

    [StringLength(256)]
    public string LoweredUserName { get; set; } = null!;

    [StringLength(16)]
    public string? MobileAlias { get; set; }

    public bool IsAnonymous { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastActivityDate { get; set; }

    [ForeignKey("ApplicationId")]
    [InverseProperty("AspnetUsers")]
    public virtual AspnetApplications Application { get; set; } = null!;

    [InverseProperty("User")]
    public virtual AspnetMembership? AspnetMembership { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<AspnetPersonalizationPerUser> AspnetPersonalizationPerUser { get; set; } = new List<AspnetPersonalizationPerUser>();

    [InverseProperty("User")]
    public virtual AspnetProfile? AspnetProfile { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("User")]
    public virtual ICollection<AspnetRoles> Role { get; set; } = new List<AspnetRoles>();
}
