using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udelascore.Negocio.Data;
using Udelascore.Negocio.Models.BancoDeDatos;

namespace UdelasCore.Negocio.Servicios.BancoDeDatos
{
    public class ExtensionService
    {
        private readonly BancoDeDatosContext _context;

        public ExtensionService(BancoDeDatosContext context)
        {
            _context = context;
        }

        public async Task<List<Extensiones>> GetExtensionsAsync()
        {
            try
            {
                var extensiones = await _context.Extensiones.ToListAsync();

                return extensiones;
            }
            catch (Exception ex)
            {
                // Log the exception (not implemented here)
                throw new Exception("Error retrieving extensions", ex);
            }
        }
    }
}
