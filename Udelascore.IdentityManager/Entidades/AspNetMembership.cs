using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Udelascore.IdentityManager.Entidades
{
    public class AspNetMembership
    {
        [Key]
        public int Id { get; set; }
        public required string UserId { get; set; }
        public required string PasswordHash { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string Observacion { get; set; } = string.Empty;
    }
}
