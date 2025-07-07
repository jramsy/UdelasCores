// Archivo: UdelasCore.Negocio/Modelos/Terna.cs
using System.ComponentModel.DataAnnotations;

namespace UdelasCore.Negocio.Modelos
{
    public class Terna
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public required string Nombre { get; set; }

        public DateTime FechaCreacion { get; set; }

        [Required]
        public required string Estado { get; set; } // Activa, Inactiva, Finalizada

        public string? Descripcion { get; set; }

        // Relaciones
        public virtual ICollection<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();
        public virtual ICollection<Materia> Materias { get; set; } = new List<Materia>();
        public virtual ICollection<Profesor> Profesores { get; set; } = new List<Profesor>();
    }
}