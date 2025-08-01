using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Udelascore.IdentityManager.Entidades
{
    public class ApplicationRole : IdentityRole
    {
        [Required]
        public string ApplicationId { get; set; }
    }
}
