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
    public class SemMatService
    {
        private readonly HorariosDocenciaContext _context;

        public SemMatService(HorariosDocenciaContext context)
        {
            _context = context;
        }

        public async Task<List<SemMat>> GetSemMatAsync()
        {
            return await _context.SemMat
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
