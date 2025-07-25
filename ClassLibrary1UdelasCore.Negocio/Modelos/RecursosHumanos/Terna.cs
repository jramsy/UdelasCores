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
        public int Year { get; set; } = DateTime.Now.Year;

        [Required]
        public int IdFacultad { get; set; }

        [Required]
        public int IdSemestre { get; set; }

        [Required]
        public int CodCarrera { get; set; }

        [Required]
        public DateOnly FechaInicio { get; set; }

        [Required]
        public DateOnly FechaFinal { get; set; }

        // Valores por defecto para los IDs de usuario
        public int IdUsuarioCreador { get; set; } = 0;
        public int IdUsuarioModificador { get; set; } = 0;
        public int IdUsuarioBorrador { get; set; } = 0;

        // Fechas de creación y modificación
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime? FechaModificacion { get; set; } = null; // Puede ser null hasta que se modifique
        public DateTime? FechaBorrador { get; set; } = null; // Puede ser null hasta que se marque como borrador

        public virtual Estado Estado { get; set; } // Relación con la entidad Estado (HORARIO DOCENCIA)
    }
}
