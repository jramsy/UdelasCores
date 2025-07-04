using System.ComponentModel.DataAnnotations;

namespace UdelasCore.Negocio.Modelos
{
    public class Materia
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string? Nombre { get; set; }

        [Required]
        [StringLength(10)]
        public required string Codigo { get; set; }

        [Required]
        public int Creditos { get; set; }

        public string? Descripcion { get; set; }

        // Relaciones
        public virtual ICollection<Terna> Ternas { get; set; } = new List<Terna>();
        public virtual ICollection<Profesor> Profesores { get; set; } = new List<Profesor>();
    }
}
