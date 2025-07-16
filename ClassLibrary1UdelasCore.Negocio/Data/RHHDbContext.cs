using Microsoft.EntityFrameworkCore;
using UdelasCore.Negocio.Modelos;
using UdelasCore.Negocio.Modelos.Modelo_Terna;

namespace UdelasCore.Negocio.Data
{
    public class RHHDbContext : DbContext
    {
        // Constructor para inyección de dependencias (runtime)
        public RHHDbContext(DbContextOptions<RHHDbContext> options) : base(options)
        {
        }

        // Constructor sin parámetros para Migrations (design-time)
        public RHHDbContext() : base()
        {
        }

        // DbSets para las entidades
        public DbSet<Terna> Ternas { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Profesor> Profesores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuraciones de las entidades
            ConfigurarTerna(modelBuilder);
            ConfigurarEstudiante(modelBuilder);
            ConfigurarMateria(modelBuilder);
            ConfigurarProfesor(modelBuilder);
        }

        private void ConfigurarTerna(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Terna>(entity =>
            {
                entity.HasKey(t => t.Id);
                entity.Property(t => t.Nombre).IsRequired().HasMaxLength(100);
                entity.Property(t => t.FechaCreacion).IsRequired();
                entity.Property(t => t.Estado).IsRequired();
            });
        }

        private void ConfigurarEstudiante(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estudiante>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nombre).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Apellido).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Carnet).IsRequired().HasMaxLength(20);
                entity.Property(e => e.Email).HasMaxLength(100);
            });
        }


        private void ConfigurarMateria(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Materia>(entity =>
            {
                entity.HasKey(m => m.Id);
                entity.Property(m => m.Nombre).IsRequired().HasMaxLength(150);
                entity.Property(m => m.Codigo).IsRequired().HasMaxLength(10);
                entity.Property(m => m.Creditos).IsRequired();
            });
        }

        private void ConfigurarProfesor(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profesor>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.Property(p => p.Nombre).IsRequired().HasMaxLength(100);
                entity.Property(p => p.Apellido).IsRequired().HasMaxLength(100);
                entity.Property(p => p.Email).HasMaxLength(100);
                entity.Property(p => p.Especialidad).HasMaxLength(100);
            });
        }
    }
}