using Microsoft.EntityFrameworkCore;
using Udelascore.Negocio.Data;
using Udelascore.Negocio.Models.BancoDeDatos;

namespace Udelascore.Negocio.Servicios.SistemaTernas
{
    public class ProfesorService
    {
        private readonly BancoDeDatosContext _context;
        public ProfesorService(BancoDeDatosContext context)
        {
            _context = context;
        }
        public async Task<List<BdProfesor>> GetAllProfesoresAsync()
        {
            return await _context.BdProfesor
                .Take(10)
                .ToListAsync();
        }
        public async Task<BdProfesor> GetProfesorByCedulaAsync(string cedula)
        {
            return await _context.BdProfesor.FirstOrDefaultAsync(p => p.Cedula == cedula);
        }
        public async Task AddProfesorAsync(BdProfesor profesor)
        {
            _context.BdProfesor.Add(profesor);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateProfesorAsync(BdProfesor profesor)
        {
            _context.BdProfesor.Update(profesor);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteProfesorAsync(string cedula)
        {
            var profesor = await GetProfesorByCedulaAsync(cedula);
            if (profesor != null)
            {
                _context.BdProfesor.Remove(profesor);
                await _context.SaveChangesAsync();
            }
        }
    }
}
