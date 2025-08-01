using System.ComponentModel.DataAnnotations;

namespace Udelascore.IdentityManager.Entidades
{
    public class AspNetApplication
    {
        [Key]
        public required string ApplicationId { get; set; }
        public required string ApplicationName { get; set; }
        public required string LoweredApplicationName { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
