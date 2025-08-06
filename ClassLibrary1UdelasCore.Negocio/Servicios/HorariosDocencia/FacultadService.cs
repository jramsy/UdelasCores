using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udelascore.Negocio.Data;
using UdelasCore.Negocio.Data;
using UdelasCore.Negocio.Modelos.HorariosDocencia;

namespace UdelasCore.Negocio.Servicios.HorariosDocencia
{
    public class FacultadService
    {
        private readonly HorariosDocenciaContext _context;
        public FacultadService(HorariosDocenciaContext context)
        {
            _context = context;
        }

        public async Task<List<Facultades>> GetFacultadesAsync()
        {
            return await _context.Facultades.ToListAsync();
        }
    }
}
