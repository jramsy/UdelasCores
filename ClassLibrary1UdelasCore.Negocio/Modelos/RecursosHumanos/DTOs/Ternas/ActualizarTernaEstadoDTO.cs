using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdelasCore.Negocio.Modelos.RecursosHumanos.DTOs.Ternas
{
    public class ActualizarTernaEstadoDTO
    {
        public int IdTerna { get; set; }
        public int IdEstado { get; set; }
        public int? IdTernaDetalleSeleccionado { get; set; }
        public int IdUsuarioModificador { get; set; }
        public DateTime? FechaModificacion { get; set; } = DateTime.Now;
    }
}
