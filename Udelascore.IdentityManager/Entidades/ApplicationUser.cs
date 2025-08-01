using Microsoft.AspNetCore.Identity;

namespace Udelascore.IdentityManager.Entidades
{
    public class ApplicationUser : IdentityUser
    {
        public bool IsApproved { get; set; } = true;
        public DateTime LastActivityDate { get; set; } = new DateTime(1754, 1, 1);
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime LastPasswordChangedDate { get; set; } = new DateTime(1754, 1, 1);
    }
}
