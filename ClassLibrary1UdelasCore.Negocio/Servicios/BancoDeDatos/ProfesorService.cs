using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udelascore.Negocio.Data;
using Udelascore.Negocio.Models.BancoDeDatos;
using UdelasCore.Negocio.Helpers;

namespace UdelasCore.Negocio.Servicios.BancoDeDatos
{
    public class ProfesorService
    {
        private readonly BancoDeDatosContext _context;
        public ProfesorService(BancoDeDatosContext context)
        {
            _context = context;
        }

        public async Task<BdProfesor?> GetProfesorByCedulaAsync(string cedula)
        {
            if (string.IsNullOrWhiteSpace(cedula))
                return null;

            cedula = FormatearCedula.FormatearCedulaPanama(cedula);

            //Buscar la cedula mediante la cedula larga, anteriormente formateada
            return await _context.BdProfesor
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Cedula == cedula);
        }

    }
}
