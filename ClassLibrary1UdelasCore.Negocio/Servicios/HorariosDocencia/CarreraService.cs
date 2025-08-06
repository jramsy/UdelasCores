using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdelasCore.Negocio.Data;
using UdelasCore.Negocio.Modelos.HorariosDocencia;

namespace UdelasCore.Negocio.Servicios.HorariosDocencia
{
    public class CarreraService
    {
        private readonly HorariosDocenciaContext _horariosDocenciaContext;
        public CarreraService(HorariosDocenciaContext context)
        {
            _horariosDocenciaContext = context;
        }
        public async Task<List<Carreras>> GetCarrerasAsync()
        {
            return await _horariosDocenciaContext.Carreras
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
