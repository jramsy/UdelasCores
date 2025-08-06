using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdelasCore.Negocio.DTOs
{
   public class TernaRequestDto
    {
        public InsertarTernaDTO Terna { get; set; }
        public InsertarTernaDetalleDTO? Detalle { get; set; }
    }
}
