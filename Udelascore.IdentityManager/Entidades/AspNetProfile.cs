using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Udelascore.IdentityManager.Entidades
{
    public class AspNetProfile
    {
        [Key]
        [Column(TypeName = "nvarchar(450)")]
        public required string UserId { get; set; }
        [Required]
        public byte[] ProfileImage { get; set; }
        public DateTime LastUpdatedDate { get; set; } = new DateTime(1754, 1, 1);
    }
}
