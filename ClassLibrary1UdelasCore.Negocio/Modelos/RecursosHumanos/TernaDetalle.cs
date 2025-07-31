using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Udelascore.Negocio.Models.RecursosHumanos;

namespace UdelasCore.Negocio.Modelos.RecursosHumanos
{
    public class TernaDetalle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTernaDetalle { get; set; }

        [Required]
        public int IdTerna { get; set; }

        [Required]
        public int IdEstado { get; set; }

        [Required]
        public string CedDocente { get; set; } = string.Empty; // Asumimos que el docente se identifica por su cédula

        // Valores por defecto para IDs de usuario si no se asignan aún
        public int IdUsuarioCreador { get; set; } = 0;
        public int IdUsuarioModificador { get; set; } = 0;
        public int IdUsuarioBorrador { get; set; } = 0;

        // Fecha de creación al momento de instanciar
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        // Modificación y borrado pueden ser nulos hasta que se actualicen
        public DateTime? FechaModificacion { get; set; } = new DateTime(1754, 1, 1);
        public DateTime? FechaBorrador { get; set; } = new DateTime(1754, 1, 1);

        [ForeignKey(nameof(IdTerna))]
        public virtual Terna? Terna { get; set; } // Relación con la entidad Terna
        [ForeignKey(nameof(IdEstado))]
        public virtual Estado? Estado { get; set; } // Relación con la entidad Estado
    }
}
