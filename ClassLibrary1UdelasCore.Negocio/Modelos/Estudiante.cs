using System.ComponentModel.DataAnnotations;

namespace UdelasCore.Negocio.Modelos
{
    public class Estudiante
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string Apellido { get; set; }

        [Required]
        [StringLength(20)]
        public string Carnet { get; set; }

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