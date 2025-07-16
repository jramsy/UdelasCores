using System.ComponentModel.DataAnnotations;
using UdelasCore.Negocio.Modelos.Modelo_Terna;

namespace UdelasCore.Negocio.Modelos
{
    public class Profesor
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public required string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public required string Apellido { get; set; }

        [EmailAddress]
        [StringLength(100)]
        public string? Email { get; set; }

        [StringLength(100)]
        public string? Especialidad { get; set; }

        public string? Telefono { get; set; }

        // Relaciones
        public virtual ICollection<Terna> Ternas { get; set; } = new List<Terna>();
        public virtual ICollection<Materia> Materias { get; set; } = new List<Materia>();
    }
}