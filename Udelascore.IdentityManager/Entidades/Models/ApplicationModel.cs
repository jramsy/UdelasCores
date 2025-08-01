namespace Udelascore.IdentityManager.Entidades.Models
{
    public class ApplicationModel
    {
        public string ApplicationId { get; set; } = string.Empty;
        public required string ApplicationName { get; set; }
    }
    public class CustomClaimTypes
    {
        public const string Permission = "Application.Permission";
    }
    public static class UserPermissions
    {
        public const string Add = "users.add";
        public const string Edit = "users.edit";
        public const string EditRole = "users.edit.role";
    }
    public class AsignarRolModel
    {
        public required string UserId { get; set; }
        public required List<string> RolId { get; set; }
    }
    public class ClaimModel
    {
        public required string ClaimTypes { get; set; }
        public required string ClaimValue { get; set; }
    }
    public class UserRolesViewModel
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public string? Description { get; set; }
        public bool IsSelected { get; set; }
    }
}
