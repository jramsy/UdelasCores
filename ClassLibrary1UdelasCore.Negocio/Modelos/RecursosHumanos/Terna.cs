using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdelasCore.Negocio.Modelos.RecursosHumanos;

namespace Udelascore.Negocio.Models.RecursosHumanos
{
    public class Terna
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTerna { get; set; }

        // Puedes usar un tipo int si el año se representa con números
        [Required]
        public int Anio { get; set; } = DateTime.Now.Year;

        [Required]
        public int CodMateria { get; set; } //Materias_por_carreras esta es la asignatura que trae la facultaf y la carrera de la terna en HORARIOS DOCENCIA
        [Required]
        public int CodCarrera { get; set; } //Materias_por_carreras esta es la carrera que trae la facultad y la carrera de la terna en HORARIOS DOCENCIA
        [Required]
        public DateOnly FechaInicio { get; set; }

        [Column("EstadoIdEstado")]
        public int EstadoIdEstado { get; set; } = 1; // Asignar un estado por defecto, "PENDIETE" (1)

        [Required]
        public DateOnly FechaFinal { get; set; }

        // Valores por defecto para los IDs de usuario
        public int IdUsuarioCreador { get; set; } = 0;
        public int IdUsuarioModificador { get; set; } = 0;
        public int IdUsuarioBorrador { get; set; } = 0;
        public bool? Borrado { get; set; } = false; // Indica si la terna está marcada como borrada
        // Fechas de creación y modificación
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime? FechaModificacion { get; set; } = null; // Puede ser null hasta que se modifique
        public DateTime? FechaBorrador { get; set; } = null; // Puede ser null hasta que se marque como borrador

        public virtual Estado? Estado { get; set; } // Relación con la entidad Estado (HORARIO DOCENCIA)
        public virtual ICollection<TernaDetalle>? TernaDetalles { get; set; }
    }
}
