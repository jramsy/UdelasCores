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
    public class MateriasPorCarreraService
    {
        private readonly HorariosDocenciaContext _context;
        public MateriasPorCarreraService(HorariosDocenciaContext context)
        {
            _context = context;
        }
        public async Task<List<MateriasPorCarreras>> GetMateriasPorCarreraAsync()
        {
            return await _context.MateriasPorCarreras
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
