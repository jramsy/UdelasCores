using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using UdelasCore.Negocio.Data;

public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        optionsBuilder.UseSqlServer(
            "Server=JAIME\\MSSQLSERVER03;Database=RECURSOS_HUMANOS;Trusted_Connection=True;TrustServerCertificate=True;",
            options => options.EnableRetryOnFailure());

        return new ApplicationDbContext(optionsBuilder.Options);
    }
}