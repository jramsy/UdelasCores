using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdelasCore.Negocio.DTOs
{
    public class InsertarTernaDetalleDTO
    {
        public int? IdTernaDetalle { get; set; } = 0; // Esto es porque podemos crear un detalle nuevo o actualizar uno existente
        public int IdTerna { get; set; }
        public string CedDocente { get; set; }
        public int IdEstado { get; set; } = 1; // Asignar un valor por defecto (PENDIENTE)
        public int IdUsuarioCreador { get; set; } = 1; // Asignar un valor por defecto, si es necesario
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
