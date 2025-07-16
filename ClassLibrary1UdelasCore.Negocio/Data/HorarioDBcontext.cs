using Microsoft.EntityFrameworkCore;

namespace SIRCADWEB.Models.Horarios // Puedes usar el namespace que desees
{
    public class HorariosDbContext : DbContext
    {
        public HorariosDbContext(DbContextOptions<HorariosDbContext> options)
            : base(options)
        {
        }

        // Aquí vendrán los DbSet<T> generados automáticamente
        // o los agregas manualmente si sabes las tablas que usarás
        //public DbSet<Grupos> Grupos { get; set; }  // Ejemplo
        //public DbSet<Horarios> Horarios { get; set; }  // Ejemplo
        // ...
    }
}
