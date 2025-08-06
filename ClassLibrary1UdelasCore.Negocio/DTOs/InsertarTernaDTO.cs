using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdelasCore.Negocio.DTOs
{
    public class InsertarTernaDTO
    {
        public int? IdTerna { get; set; } = 0; // Esto es porque podemos crear una terna nueva o actualizar una existente
        public DateOnly fechaInicio {get; set;}
        public DateOnly fechaCulmina { get; set; }
        public int CodMateria { get; set; }
        public int Anio { get; set; }
        public int CodCarrera { get; set; }
        public int IdUsuarioCreador { get; set; } = 1; // Asignar un valor por defecto, si es necesario
        public int EstadoIdEstado { get; set; } = 1; // Asignar un valor por defecto (PENDIENTE)
    }
}
