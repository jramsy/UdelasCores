using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int IdDocente { get; set; }

        // Valores por defecto para IDs de usuario si no se asignan aún
        public int IdUsuarioCreador { get; set; } = 0;
        public int IdUsuarioModificador { get; set; } = 0;
        public int IdUsuarioBorrador { get; set; } = 0;

        // Fecha de creación al momento de instanciar
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        // Modificación y borrado pueden ser nulos hasta que se actualicen
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaBorrador { get; set; }
    }
}
