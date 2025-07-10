using System.ComponentModel.DataAnnotations;

namespace UdelasCore.Negocio.Modelos.Modelo.Terna
{
    public class Estudiante
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public required string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public required string Apellido { get; set; }

        [Required]
        [StringLength(20)]
        public required string Carnet { get; set; }

        [EmailAddress]
        [StringLength(100)]
        public string? Email { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string? Telefono { get; set; }

        // Relaciones
        public int? TernaId { get; set; }
        public virtual Terna? Terna { get; set; }
    }
}